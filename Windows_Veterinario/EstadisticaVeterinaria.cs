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
    public partial class EstadisticaVeterinaria : Form
    {
        public EstadisticaVeterinaria()
        {
            InitializeComponent();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu obj02 = new Menu();
            obj02.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TopAtencionesClientes obj00 = new TopAtencionesClientes();
            obj00.ShowDialog();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            TopAtencionesMascotas obj01 = new TopAtencionesMascotas();
            obj01.ShowDialog();
        }

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            TopMedicinas obj03 = new TopMedicinas();
            obj03.ShowDialog();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            ConsultasTotalesXAño obj04 = new ConsultasTotalesXAño();
            obj04.ShowDialog();
        }

        private void EstadisticaVeterinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu obj10 = new Menu();
            obj10.Show();
        }
    }
}
