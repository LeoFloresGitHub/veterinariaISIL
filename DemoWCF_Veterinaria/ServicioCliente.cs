using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {

        //Instancia del modelo

        DBVeterinariaEntities MisAtenciones = new DBVeterinariaEntities();

        public ClienteDC ConsultarCliente(Int32 strCodigo)
        {
            try
            {
                    //Obtenemos con LINQ los datos del cliente consultado
                    Cliente objConsulta =
                    (
                    from miCliente in MisAtenciones.Cliente
                    where miCliente.cod_cliente == strCodigo
                    select miCliente
                     ).FirstOrDefault();

                //Creamos una instancia de la DataContractual ClienteDC
                ClienteDC objClienteDC = new ClienteDC();
                objClienteDC.cod_cliente = Convert.ToInt32(objConsulta.cod_cliente);
                objClienteDC.nom_cliente = objConsulta.nom_cliente;
                objClienteDC.ape_cliente = objConsulta.ape_cliente;
                objClienteDC.email = objConsulta.email;
                objClienteDC.direccion = objConsulta.dirección;
                objClienteDC.dni_cli = Convert.ToInt32(objConsulta.dni_cli);
                objClienteDC.id_Ubigeo = objConsulta.id_Ubigeo;
                objClienteDC.tel_cliente = objConsulta.tel_cliente;
                objClienteDC.sexo = objConsulta.sexo;
                objClienteDC.Usu_Registro = objConsulta.Usu_Registro;
                objClienteDC.est_cli = Convert.ToInt16(objConsulta.est_cli);
                if (objClienteDC.est_cli == 2)
                {
                    objClienteDC.Estado = "Inactivo";
                }
                else
                {
                    objClienteDC.Estado = "Activo";
                }
                objClienteDC.fec_registro = Convert.ToDateTime(objConsulta.fec_registro);
                objClienteDC.num_reg= objConsulta.num_registro;
                
                return objClienteDC;
                
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
            
           
        }

        public Boolean InsertarCliente(ClienteInsertar objClienteDC)
        {
            try
            {
                MisAtenciones.usp_InsertarCliente
                    (
                    objClienteDC.nom_cliente, objClienteDC.ape_cliente, Convert.ToInt32(objClienteDC.dni_cli), objClienteDC.id_Ubigeo
                    , objClienteDC.direccion, objClienteDC.tel_cliente, objClienteDC.Usu_Registro,Convert.ToInt16(objClienteDC.est_cli),
                    objClienteDC.sexo, objClienteDC.email);
                    

                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean ActualizarCliente(ClienteActualizar objClienteDC)
        {
            try
            {
                MisAtenciones.usp_ActualizarCliente
                     (
                   Convert.ToInt32( objClienteDC.cod_cliente),objClienteDC.nom_cliente, objClienteDC.ape_cliente, Convert.ToInt32(objClienteDC.dni_cli), objClienteDC.id_Ubigeo
                    , objClienteDC.direccion, objClienteDC.tel_cliente,  Convert.ToInt16(objClienteDC.est_cli),
                    objClienteDC.sexo, objClienteDC.email, objClienteDC.num_reg, objClienteDC.Usu_Ult_Mod);

                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarCliente(Int32 strCodigo)
        {
            try
            {
                MisAtenciones.usp_EliminarCliente(strCodigo);

                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteDC> ListarCliente()
        {

           
            try
            {
                List<ClienteDC> objListarCliente = new List<ClienteDC>();

                var query = (from miCliente in MisAtenciones.Cliente
                             orderby miCliente.cod_cliente
                             select miCliente).ToList();
                foreach (var objListCli in query)
                {
                    //Creamos instancia 
                    ClienteDC objClienteDC = new ClienteDC();
                    objClienteDC.cod_cliente = Convert.ToInt32(objListCli.cod_cliente);
                    objClienteDC.nom_cliente = objListCli.nom_cliente;
                    objClienteDC.ape_cliente = objListCli.ape_cliente;
                    objClienteDC.dni_cli = Convert.ToInt32(objListCli.dni_cli);
                    objClienteDC.id_Ubigeo = objListCli.id_Ubigeo;
                    objClienteDC.direccion = objListCli.dirección;
                    objClienteDC.tel_cliente = objListCli.tel_cliente;
                    objClienteDC.email = objListCli.email;
                    objClienteDC.sexo = objListCli.sexo;
                    if (objListCli.sexo.Trim().Equals("1"))
                    {
                        objClienteDC.sexo_lit = "Masculino";
                    }
                    if (objListCli.sexo.Trim().Equals("2"))
                    {
                        objClienteDC.sexo_lit = "Femenino";
                    }
                    objClienteDC.est_cli = Convert.ToInt16(objListCli.est_cli);
                    if (objListCli.est_cli == 1)
                    {
                        objClienteDC.Estado = "Activo";
                    }
                    else { objClienteDC.Estado = "Inactivo"; }

                    objClienteDC.num_reg = objListCli.num_registro;
                    objClienteDC.fec_registro = Convert.ToDateTime(objListCli.fec_registro);
                    objClienteDC.Usu_Registro = objListCli.Usu_Registro;
                    objClienteDC.Usu_Ult_Mod = objListCli.Usu_Ult_Mod;

                    objListarCliente.Add(objClienteDC);


                }
                return objListarCliente;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }







    }
}
