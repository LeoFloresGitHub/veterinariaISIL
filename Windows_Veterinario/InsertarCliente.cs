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
    public partial class InsertarCliente : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteInsertar objClienteInsertar = new ProxyCliente.ClienteInsertar();
        ProxyCliente.ClienteActualizar objClienteActualizar = new ProxyCliente.ClienteActualizar();
        DataView dtv;

        public InsertarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique

                //objClienteInsertar.cod_cliente = Convert.ToInt16(mskcod.Text);
                objClienteInsertar.nom_cliente = txtnom.Text.Trim();
                objClienteInsertar.ape_cliente = txtape.Text.Trim();
                if (cbosexo.Text.Equals("Masculino"))
                {
                    objClienteInsertar.sexo = "1";
                }
                else
                    objClienteInsertar.sexo = "2";

                objClienteInsertar.dni_cli = Convert.ToInt32(mskdni.Text);
                objClienteInsertar.direccion = txtdireccion.Text.Trim();
                objClienteInsertar.tel_cliente = msktel.Text.Trim();
                objClienteInsertar.est_cli = Convert.ToInt16(chkEstado.Checked);
                objClienteInsertar.id_Ubigeo = "140101";

                objClienteInsertar.email = txtemail.Text.Trim();
                
                
                objClienteInsertar.Usu_Registro = "Leo";




                if (objServiceCliente.InsertarCliente(objClienteInsertar) == true)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
