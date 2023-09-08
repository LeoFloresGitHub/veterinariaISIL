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
    public partial class ActualizarMascota : Form
    {
        ProxyMascota.ServicioMascotaClient objServiceMascota = new ProxyMascota.ServicioMascotaClient();
        ProxyMascota.MascotaDC objMascotaDC = new ProxyMascota.MascotaDC();
        ProxyMascota.MascotaActualizar objActualizarDC = new ProxyMascota.MascotaActualizar();
        
        public ActualizarMascota()
        {
            InitializeComponent();
        }

        private Int16 _Codigo;

        public Int16 Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

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

        private void ActualizarMascota_Load(object sender, EventArgs e)
        {
            try
            {

                // Codifique...
                //Mostramos los datos del proveedor que se desea actualizar...
                objMascotaDC = objServiceMascota.ConsultarMascota(this.Codigo);


                lblCodigo.Text = objMascotaDC.cod_mascota.ToString(); //Que voy a pintar en lblCod.Text? pues estos codigo
                txtNomMas.Text = objMascotaDC.nom_mascota;
                CargarDatos();
                cboEsp.SelectedIndex = (objMascotaDC.cod_esp)-1;
                
                //txtEsp.Text = objActualizarDC.des_esp;
                txtColor.Text = objMascotaDC.color;
                cboSexo.Text = objMascotaDC.sexoLit;
                txtNomCli.Text = objMascotaDC.nom_cliente;
                txtApeCli.Text = objMascotaDC.ape_cliente;
                dtpFecNac.Value = objMascotaDC.fec_nacimiento;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                objActualizarDC.cod_mascota = Convert.ToInt16(lblCodigo.Text.Trim());
                objActualizarDC.cod_esp = Convert.ToInt16(cboEsp.SelectedValue);
                objActualizarDC.nom_mascota = txtNomMas.Text.Trim();
                objActualizarDC.nom_cliente = txtNomCli.Text.Trim();
                objActualizarDC.cod_cliente = objMascotaDC.cod_cliente;
                objActualizarDC.ape_cliente = txtApeCli.Text.Trim();
                if (cboSexo.Text.Equals("Macho"))
                {
                    objActualizarDC.sexo = "1";
                }
                else
                    objActualizarDC.sexo = "2";

                objActualizarDC.color = txtColor.Text.Trim();
                objActualizarDC.fec_nacimiento = Convert.ToDateTime(dtpFecNac.Value);
                objActualizarDC.foto = null;
                objActualizarDC.est_mascota = 1;
               
                objActualizarDC.Usu_Ult_Mod = "Leo";






                if (objServiceMascota.ActualizarMascota(objActualizarDC) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
