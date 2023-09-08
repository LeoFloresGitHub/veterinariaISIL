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
    public partial class ClienteVeterinaria : Form

        
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        ProxyCliente.ClienteInsertar objClienteInsertar = new ProxyCliente.ClienteInsertar();
        ProxyCliente.ClienteActualizar objClienteActualizar = new ProxyCliente.ClienteActualizar();
        DataView dtv;

        public ClienteVeterinaria()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "nom_cliente like '%" + strFiltro + "%'";
            dtgClientes.DataSource = dtv;

            lblRegistros.Text = dtgClientes.Rows.Count.ToString();
        }


        private void ClienteVeterinaria_Load(object sender, EventArgs e)
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
               
                //dtv = objServiceCliente.ListarCliente().;
                CargarDatos(String.Empty);
                lblRegistros.Text = dtgClientes.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarCliente objInsertarCliente = new InsertarCliente();
            objInsertarCliente.ShowDialog();

            // Refrescar...
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceCliente.ListarCliente()))
            {
                table.Load(reader);
            }

            dtgClientes.DataSource = table.DefaultView;
            dtv = table.DefaultView;
            CargarDatos(txtFiltro.Text.Trim());
            lblRegistros.Text = dtgClientes.Rows.Count.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Int16 strCod = Convert.ToInt16(dtgClientes.CurrentRow.Cells[0].Value.ToString());
            ActualizarCliente objActualizarCliente = new ActualizarCliente();
            objActualizarCliente.Codigo= strCod;
            objActualizarCliente.ShowDialog();

            // Refrescar...
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceCliente.ListarCliente()))
            {
                table.Load(reader);
            }

            dtgClientes.DataSource = table.DefaultView;
            dtv = table.DefaultView;
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
//

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu obj02 = new Menu();
            obj02.Show();
        }

        private void ClienteVeterinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu obj10 = new Menu();
            obj10.Show();

        }
    }
}
