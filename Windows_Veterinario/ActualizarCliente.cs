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
    public partial class ActualizarCliente : Form
    {

        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        ProxyCliente.ClienteInsertar objClienteInsertar = new ProxyCliente.ClienteInsertar();
        ProxyCliente.ClienteActualizar objClienteActualizar = new ProxyCliente.ClienteActualizar();
        DataView dtv;

        public ActualizarCliente()
        {
            InitializeComponent();
        }


        private Int16 _Codigo;

        public Int16 Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique...

                objClienteDC = objServiceCliente.ConsultarCliente(this.Codigo); 

                lblCodigo.Text = objClienteDC.cod_cliente.ToString(); //Que voy a pintar en lblCod.Text? pues estos codigo
                mskdni.Text = objClienteDC.dni_cli.ToString();
                txtnom.Text = objClienteDC.nom_cliente;
                txtape.Text = objClienteDC.ape_cliente;
                if(objClienteDC.sexo.Trim().Equals("2"))
                {
                    cbosexo.SelectedIndex = 1;
                }
                if (objClienteDC.sexo.Trim().Equals("1"))
                {
                    cbosexo.SelectedIndex = 0;
                }


                txtdireccion.Text = objClienteDC.direccion;
                dtpfecreg.Value = objClienteDC.fec_registro;
                msktel.Text = objClienteDC.tel_cliente;


                chkEstado.Checked = Convert.ToBoolean(objClienteDC.est_cli);


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



                objClienteActualizar.cod_cliente = Convert.ToInt16(lblCodigo.Text);
                objClienteActualizar.nom_cliente = txtnom.Text.Trim();
                objClienteActualizar.ape_cliente = txtape.Text.Trim();
                if (cbosexo.Text.Equals("Masculino"))
                {
                    objClienteActualizar.sexo = "1";
                }
                else
                    objClienteActualizar.sexo = "2";

                objClienteActualizar.dni_cli = Convert.ToInt32(mskdni.Text);
                objClienteActualizar.direccion = txtdireccion.Text.Trim();
                objClienteActualizar.tel_cliente = msktel.Text.Trim();
                objClienteActualizar.est_cli = Convert.ToInt16(chkEstado.Checked);
                objClienteActualizar.email = "";
              
                objClienteActualizar.num_reg = lblCodigo.Text;
                objClienteActualizar.Usu_Ult_Mod = "Leo";







                if (objServiceCliente.ActualizarCliente(objClienteActualizar) == true)
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
