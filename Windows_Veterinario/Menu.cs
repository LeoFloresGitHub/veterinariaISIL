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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           MascotaVeterinaria objMDI = new MascotaVeterinaria();
            objMDI.Show();

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteVeterinaria ptn = new ClienteVeterinaria();
            ptn.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaVeterinaria ptn = new ConsultaVeterinaria();
            ptn.Show();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaVeterinaria ptn = new ConsultaVeterinaria();
            ptn.Show();
            
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Salimos de la aplicación...
            Application.Exit();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticaVeterinaria ptn = new EstadisticaVeterinaria();
            ptn.Show();
        }
    }
}
