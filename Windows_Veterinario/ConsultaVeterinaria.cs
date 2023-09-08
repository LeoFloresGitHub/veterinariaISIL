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
    public partial class ConsultaVeterinaria : Form
    {
        public ConsultaVeterinaria()
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
            ConsultasClienteFechas obj00 = new ConsultasClienteFechas();
            obj00.ShowDialog();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            ConsultasMascotaFechas obj01 = new ConsultasMascotaFechas();
            obj01.ShowDialog();
        }

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            ConsultasVeterinarioFechas obj02 = new ConsultasVeterinarioFechas();
            obj02.ShowDialog();
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            MascotasPorEspecie obj03 = new MascotasPorEspecie();
            obj03.ShowDialog();
        }

        private void ConsultaVeterinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu obj10 = new Menu();
            obj10.Show();
        }
    }
}
