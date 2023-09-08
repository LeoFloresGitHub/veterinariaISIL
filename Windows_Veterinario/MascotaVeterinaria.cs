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
    public partial class MascotaVeterinaria : Form
    {

        ProxyMascota.ServicioMascotaClient objServiceMascota = new ProxyMascota.ServicioMascotaClient();
        ProxyMascota.MascotaDC objMascotaDC = new ProxyMascota.MascotaDC();
        ProxyMascota.MascotaInsertar objInsertarDC = new ProxyMascota.MascotaInsertar();
        ProxyMascota.MascotaActualizar objActualizarDC = new ProxyMascota.MascotaActualizar();
        DataView dtv;


        public MascotaVeterinaria()
        {
            InitializeComponent();

        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "nom_mascota like '%" + strFiltro + "%'";
            dtgMascotas.DataSource = dtv;

            lblRegistros.Text = dtgMascotas.Rows.Count.ToString();
        }



        private void MascotaVeterinaria_Load(object sender, EventArgs e)
        {

            try
            {
                // Codifique

                dtgMascotas.AutoGenerateColumns = false;
                // El autogenerate columns debe especificar en falso despues de haber formateado la grilla

                // Definimos el dataview...
                //Convertimos el list a DataTable para poder usar el DefaultView propio del mismo
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(objServiceMascota.ListarMascota()))
                {
                    table.Load(reader);
                }

                dtgMascotas.DataSource = table.DefaultView;
                dtv = table.DefaultView;

                lblRegistros.Text = dtgMascotas.Rows.Count.ToString();


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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Codifique
            InsertarMascota obj02 = new InsertarMascota();
            obj02.ShowDialog();

            // Refrescar...
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceMascota.ListarMascota()))
            {
                table.Load(reader);
            }

            dtgMascotas.DataSource = table.DefaultView;
            dtv = table.DefaultView;
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Int16 strCod = Convert.ToInt16(dtgMascotas.CurrentRow.Cells[0].Value.ToString());
            ActualizarMascota objActualizarMascota = new ActualizarMascota();
            objActualizarMascota.Codigo = strCod;
            objActualizarMascota.ShowDialog();

            // Refrescar...
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceMascota.ListarMascota()))
            {
                table.Load(reader);
            }

            dtgMascotas.DataSource = table.DefaultView;
            dtv = table.DefaultView;
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Menu obj02 = new Menu();
            obj02.Show();
        }

        private void dtgMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MascotaVeterinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu obj10 = new Menu();
            obj10.Show();
        }
    }
}
