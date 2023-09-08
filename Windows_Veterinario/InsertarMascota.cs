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
    public partial class InsertarMascota : Form
    {
        ProxyMascota.ServicioMascotaClient objServiceMascota = new ProxyMascota.ServicioMascotaClient();
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
       ProxyMascota.MascotaInsertar objInsertarDC = new ProxyMascota.MascotaInsertar();
       DataView dtv;

        public InsertarMascota()
        {
            InitializeComponent();
        }


        private void InsertarMascota_Load(object sender, EventArgs e)
        {
            CargarDatos();
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



        private void CargarDatos()
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceMascota.ListarEspecie()))
            {
                table.Load(reader);
            }


            cboEsp.DataSource = table;
            cboEsp.ValueMember = "cod_esp";
            cboEsp.DisplayMember = "des_esp";


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                objInsertarDC.cod_esp = Convert.ToInt16(cboEsp.SelectedValue);
                objInsertarDC.nom_mascota = txtNomMas.Text.Trim();
                objInsertarDC.cod_cliente = Convert.ToInt16(dtgClientes.CurrentRow.Cells[0].Value.ToString());
                objInsertarDC.nom_cliente = dtgClientes.CurrentRow.Cells[1].Value.ToString();
                objInsertarDC.ape_cliente = dtgClientes.CurrentRow.Cells[2].Value.ToString();
                if (cboSexo.Text.Equals("Macho"))
                {
                    objInsertarDC.sexo = "1";
                }
                else
                    objInsertarDC.sexo = "2";

                objInsertarDC.color = txtColor.Text.Trim();
                objInsertarDC.fec_nacimiento = Convert.ToDateTime(dtpFecNac.Text);
                objInsertarDC.foto = null;

                if (objServiceMascota.InsertarMascota(objInsertarDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro. Contacte con IT.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
