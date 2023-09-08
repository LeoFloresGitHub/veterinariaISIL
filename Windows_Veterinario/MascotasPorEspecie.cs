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
    public partial class MascotasPorEspecie : Form
    {

        ProxyMascota.ServicioMascotaClient objServiceMascota = new ProxyMascota.ServicioMascotaClient();
        ProxyConsulta.ServicioConsultaClient objServiceConsulta = new ProxyConsulta.ServicioConsultaClient();

        DataView dtv;

        public MascotasPorEspecie()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceMascota.ListarEspecie()))
            {
                table.Load(reader);
            }


            cboEspecies.DataSource = table;
            cboEspecies.ValueMember = "cod_esp";
            cboEspecies.DisplayMember = "des_esp";


        }

        private void MascotasPorEspecie_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 codigo = cboEspecies.SelectedIndex+1;

            /*DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(objServiceConsulta.ListarMascotasPorEspecie(codigo)))
            {
                table.Load(reader);
            }*/

            dtgMascotas.DataSource = objServiceConsulta.ListarMascotasPorEspecie(codigo);
            //dtv = table.DefaultView;

            lblRegistros.Text = dtgMascotas.Rows.Count.ToString();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}
