using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Veterinario
{
    public partial class ConsultasClienteFechas : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyConsulta.ServicioConsultaClient objServiceConsulta = new ProxyConsulta.ServicioConsultaClient();
        ProxyConsulta.ConsultaDC objConsultaDC = new ProxyConsulta.ConsultaDC();

        DataView dtv;

        public ConsultasClienteFechas()
        {
            InitializeComponent();
        }
        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "nom_cliente like '%" + strFiltro + "%'";
            dtgClientes.DataSource = dtv;

            //lblRegistros.Text = dtgClientes.Rows.Count.ToString();
        }


        private void ConsultasClienteFechas_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                dtgClientes.AutoGenerateColumns = false;
                // El autogenerate columns debe especificar en falso despues de haber formateado la grilla

                // Definimos el dataview...
                //Convertimos el list a DataTable para poder usar el DefaultView propio del mismo
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(objServiceCliente.ListarCliente()))
                {
                    table.Load(reader);
                }

                dtgClientes.DataSource = table.DefaultView;
                dtv = table.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                Int16 strCod = Convert.ToInt16(dtgClientes.CurrentRow.Cells[0].Value.ToString());

                String Est = "";
                if (rbtnAtendida.Checked)
                {
                    Est = "Atendida";
                }
                if (rbtnCancelada.Checked)
                {
                    Est = "Cancelada";
                }
                if (rbtnPendiente.Checked)
                {
                    Est = "Pendiente";
                }


                dtgConsultas.AutoGenerateColumns = false;

                dtgConsultas.DataSource = objServiceConsulta.ListarConsultasClientesFechas(strCod, Est, dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
