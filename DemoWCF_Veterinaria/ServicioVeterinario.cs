using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioVeterinario" en el código y en el archivo de configuración a la vez.
    public class ServicioVeterinario : IServicioVeterinario
    {
        DBVeterinariaEntities MisAtenciones = new DBVeterinariaEntities();

        public VeterinarioDC ConsultarVeterinario(Int32 strCodigo)
        {
            try
            {
                //Obtenemos con LINQ los datos del cliente consultado
                Veterinario objConsulta =
                (
                from miVeterinario in MisAtenciones.Veterinario
                where miVeterinario.cod_veterinario == strCodigo
                select miVeterinario
                 ).FirstOrDefault();

                //Creamos una instancia de la DataContractual ClienteDC
                VeterinarioDC objVeterinarioDC = new VeterinarioDC();
                objVeterinarioDC.cod_veterinario = Convert.ToInt32(objConsulta.cod_veterinario);
                objVeterinarioDC.nom_veterinario = objConsulta.nom_veterinario;
                objVeterinarioDC.ape_veterinario = objConsulta.ape_veterinario;
                objVeterinarioDC.Usu_Registro = objConsulta.Usu_Registro;
                objVeterinarioDC.sueldo = Convert.ToInt32(objConsulta.sueldo);
                objVeterinarioDC.dni_vet = Convert.ToInt32(objConsulta.dni_vet);
                objVeterinarioDC.foto = objConsulta.foto_vet;
                objVeterinarioDC.direccion = objConsulta.direccion;
                objVeterinarioDC.tel_veterinario = objConsulta.tel_veterinario;
                 objVeterinarioDC.est_vet = Convert.ToInt16(objConsulta.est_vet);
                if (objVeterinarioDC.est_vet == 2)
                {
                    objVeterinarioDC.Estado = "Inactivo";
                }
                else
                {
                    objVeterinarioDC.Estado = "Activo";
                }

                objVeterinarioDC.cod_especialidad = Convert.ToInt16(objConsulta.cod_especialidad);
                objVeterinarioDC.des_especialidad = objConsulta.Especialidad.descripcion;
                objVeterinarioDC.fec_Ult_Mod = Convert.ToDateTime(objConsulta.fec_Ult_Mod);
                objVeterinarioDC.Usu_Ult_Mod= objConsulta.Usu_Ult_Mod;

               
                return objVeterinarioDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public List<VeterinarioDC> ListarVeterinario()
        {
            try
            {
                List<VeterinarioDC> objListarVeterinario = new List<VeterinarioDC>();

                var query = (from miVeterinario in MisAtenciones.Veterinario
                             orderby miVeterinario.cod_veterinario
                             select miVeterinario).ToList();
                foreach (var objConsulta in query)
                {
                    //Creamos instancia 
                    //Creamos una instancia de la DataContractual ClienteDC
                    VeterinarioDC objVeterinarioDC = new VeterinarioDC();
                    objVeterinarioDC.cod_veterinario = Convert.ToInt32(objConsulta.cod_veterinario);
                    objVeterinarioDC.nom_veterinario = objConsulta.nom_veterinario;
    
                    objVeterinarioDC.ape_veterinario = objConsulta.ape_veterinario;
                    objVeterinarioDC.Usu_Registro = objConsulta.Usu_Registro;
                    objVeterinarioDC.sueldo = Convert.ToInt32(objConsulta.sueldo);
                    objVeterinarioDC.dni_vet = Convert.ToInt32(objConsulta.dni_vet);
                    objVeterinarioDC.foto = objConsulta.foto_vet;
                    objVeterinarioDC.direccion = objConsulta.direccion;
                    objVeterinarioDC.tel_veterinario = objConsulta.tel_veterinario;
                    objVeterinarioDC.est_vet = Convert.ToInt16(objConsulta.est_vet);
                    if (objVeterinarioDC.est_vet == 2)
                    {
                        objVeterinarioDC.Estado = "Inactivo";
                    }
                    else
                    {
                        objVeterinarioDC.Estado = "Activo";
                    }

                    objVeterinarioDC.cod_especialidad = Convert.ToInt16(objConsulta.cod_especialidad);
                    objVeterinarioDC.des_especialidad = objConsulta.Especialidad.descripcion;
                    objVeterinarioDC.fec_Ult_Mod = Convert.ToDateTime(objConsulta.fec_Ult_Mod);
                    objVeterinarioDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;

                    objListarVeterinario.Add(objVeterinarioDC);


                }
                return objListarVeterinario;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
