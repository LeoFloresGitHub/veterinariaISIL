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
    public partial class TopAtencionesMascotas : Form
    {
        ProxyEstadistica.ServicioEstadisticaClient objServiceEstadistica = new ProxyEstadistica.ServicioEstadisticaClient();

        public TopAtencionesMascotas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int16 top = Convert.ToInt16(cboTop.SelectedIndex + 1);
            Int16 año = Convert.ToInt16(cboAño.Text);
            if (cboTop.SelectedIndex == 0)
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
            dtgTop.DataSource = objServiceEstadistica.TopAtencionesMascotasXAño(año, top);





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
