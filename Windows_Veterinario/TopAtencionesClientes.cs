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
    public partial class TopAtencionesClientes : Form
    {
        ProxyEstadistica.ServicioEstadisticaClient objServiceEstadistica = new ProxyEstadistica.ServicioEstadisticaClient();
        public TopAtencionesClientes()
        {
            InitializeComponent();
        }

        private void TopAtencionesClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int16 top = Convert.ToInt16(cboTop.SelectedIndex+1);
            Int16 año = Convert.ToInt16(cboAño.Text);
            if(cboTop.SelectedIndex == 0)
            {
                lblTop.Text = "Top 1 Clientes :";

            }
            if (cboTop.SelectedIndex == 1)
            {
                lblTop.Text = "Top 2 Clientes :";

            }
            if (cboTop.SelectedIndex == 2)
            {
                lblTop.Text = "Top 3 Clientes :";

            }


            dtgTop.AutoGenerateColumns = false;
            dtgTop.DataSource = objServiceEstadistica.TopAtencionesClientesMascotasXAño(año,top);

            


        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void dtgTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
