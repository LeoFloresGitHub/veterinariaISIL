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
    public partial class ConsultasTotalesXAño : Form
    {
        ProxyEstadistica.ServicioEstadisticaClient objServiceEstadistica = new ProxyEstadistica.ServicioEstadisticaClient();

        public ConsultasTotalesXAño()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            Int16 año = Convert.ToInt16(cboAño.Text);
            if (cboAño.SelectedIndex == 0)
            {
                lblTop.Text = "Consultas totales 2020 :";

            }
            if (cboAño.SelectedIndex == 1)
            {
                lblTop.Text = "Consultas totales 2021 :";

            }
            if (cboAño.SelectedIndex == 2)
            {
                lblTop.Text = "Consultas totales 2022 :";

            }


            dtgTop.AutoGenerateColumns = false;
            dtgTop.DataSource = objServiceEstadistica.ConsultasXAño(año);



        }

        private void ConsultasTotalesXAño_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
