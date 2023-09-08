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
    public partial class ConsultasMascotaFechas : Form
    {
        ProxyMascota.ServicioMascotaClient objServiceMascota = new ProxyMascota.ServicioMascotaClient();
        ProxyConsulta.ServicioConsultaClient objServiceConsulta = new ProxyConsulta.ServicioConsultaClient();
        ProxyConsulta.ConsultaDC objConsultaDC = new ProxyConsulta.ConsultaDC();
        DataView dtv;

        public ConsultasMascotaFechas()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "nom_mascota like '%" + strFiltro + "%'";
            dtgClientes.DataSource = dtv;

            
        }

        private void ConsultasMascotaFechas_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                dtgClientes.AutoGenerateColumns = false;
                // El autogenerate columns debe especificar en falso despues de haber formateado la grilla

                // Definimos el dataview...
                //Convertimos el list a DataTable para poder usar el DefaultView propio del mismo
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(objServiceMascota.ListarMascota()))
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


                dtgConsultas.AutoGenerateColumns = false;
                dtgConsultas.DataSource = objServiceConsulta.ListarConsultasMascotaFechas(strCod, dtpFecIni.Value.Date, dtpFecFin.Value.Date);
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
