using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioMascota" en el código y en el archivo de configuración a la vez.
    public class ServicioMascota : IServicioMascota
    {

        //Instancia del modelo

        DBVeterinariaEntities MisAtenciones = new DBVeterinariaEntities();

        public MascotaDC ConsultarMascota(Int32 strCodigo)
        {
            try
            {
                //Obtenemos con LINQ los datos del Mascota consultado
                Mascota objConsulta =
                (
                from miMascota in MisAtenciones.Mascota
                join miEspecialidad in MisAtenciones.Esp on miMascota.cod_esp equals miEspecialidad.cod_esp
                 where miMascota.cod_mascota == strCodigo
                select miMascota
                 ).FirstOrDefault();
                

                //Creamos una instancia de la DataContractual MascotaDC
                MascotaDC objMascotaDC = new MascotaDC();
                objMascotaDC.cod_mascota = Convert.ToInt32(objConsulta.cod_mascota);
                objMascotaDC.nom_mascota = objConsulta.nom_mascota;
                objMascotaDC.cod_esp = Convert.ToInt16(objConsulta.cod_esp);
                objMascotaDC.des_esp = objConsulta.Esp.des_esp;
                objMascotaDC.nom_cliente = objConsulta.nom_cliente;
                objMascotaDC.ape_cliente = objConsulta.ape_cliente;
                objMascotaDC.cod_cliente = Convert.ToInt32(objConsulta.cod_cliente);
                objMascotaDC.foto = objConsulta.foto;
                objMascotaDC.sexo = objConsulta.sexo;
                if(objMascotaDC.sexo.Trim().Equals("1"))
                {
                    objMascotaDC.sexoLit = "Macho";
                }
                else
                {
                    objMascotaDC.sexoLit = "Hembra";
                }
                objMascotaDC.color = objConsulta.color;
                objMascotaDC.fec_nacimiento = Convert.ToDateTime(objConsulta.fec_nacimiento);
                objMascotaDC.sexo = objConsulta.sexo;
                objMascotaDC.est_mascota = Convert.ToInt16(objConsulta.est_mascota);
                if (objMascotaDC.est_mascota == 2)
                {
                    objMascotaDC.Estado = "Inactivo";
                }
                else
                {
                    objMascotaDC.Estado = "Activo";
                }
            

                return objMascotaDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public Boolean InsertarMascota(MascotaInsertar objMascotaDC)
        {
            try
            {
                MisAtenciones.usp_InsertarMascota
                    (
                    objMascotaDC.nom_mascota, objMascotaDC.nom_cliente, objMascotaDC.ape_cliente, Convert.ToInt32(objMascotaDC.cod_cliente),
                     Convert.ToInt16(objMascotaDC.cod_esp), objMascotaDC.foto,objMascotaDC.sexo
                    , objMascotaDC.color, Convert.ToDateTime(objMascotaDC.fec_nacimiento), Convert.ToInt16(objMascotaDC.est_mascota));


                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean ActualizarMascota(MascotaActualizar objMascotaDC)
        {
            try
            {
                MisAtenciones.usp_ActualizarMascota
                     (
                   Convert.ToInt32(objMascotaDC.cod_mascota), Convert.ToInt16(objMascotaDC.cod_esp),objMascotaDC.nom_mascota, objMascotaDC.nom_cliente,
                   objMascotaDC.ape_cliente, Convert.ToInt32(objMascotaDC.cod_cliente), objMascotaDC.foto, objMascotaDC.sexo
                    , objMascotaDC.color, Convert.ToDateTime(objMascotaDC.fec_nacimiento), Convert.ToInt16(objMascotaDC.est_mascota)
                    ,objMascotaDC.Usu_Ult_Mod);

                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarMascota(Int32 strCodigo)
        {
            try
            {
                MisAtenciones.usp_EliminarMascota(strCodigo);

                //Grabamos el modelo...
                MisAtenciones.SaveChanges();
                return true;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MascotaDC> ListarMascota()
        {
            try
            {
                List<MascotaDC> objListarMascota = new List<MascotaDC>();

                var query = (from miMascota2 in MisAtenciones.Mascota
                             orderby miMascota2.cod_mascota
                             select miMascota2).ToList();
                foreach (var objListMasc in query)
                {
 
                    //Creamos instancia 
                    MascotaDC objMascotaDC = new MascotaDC();
                    objMascotaDC.cod_mascota = objListMasc.cod_mascota;
                    objMascotaDC.cod_esp = Convert.ToInt16(objListMasc.cod_esp);
                    objMascotaDC.nom_mascota = objListMasc.nom_mascota;
                    objMascotaDC.cod_cliente = Convert.ToInt32(objListMasc.cod_cliente);
                    objMascotaDC.des_esp = objListMasc.Esp.des_esp;
                    objMascotaDC.nom_cliente = objListMasc.nom_cliente;
                    objMascotaDC.ape_cliente = objListMasc.ape_cliente;
                    objMascotaDC.foto = objListMasc.foto;
                    objMascotaDC.sexo = objListMasc.sexo;
                    if (objMascotaDC.sexo.Trim().Equals("1"))
                    {
                        objMascotaDC.sexoLit = "Macho";
                    }
                    else
                    {
                        objMascotaDC.sexoLit = "Hembra";
                    }
                    objMascotaDC.color = objListMasc.color;
                    objMascotaDC.fec_nacimiento = Convert.ToDateTime(objListMasc.fec_nacimiento);
                    objMascotaDC.est_mascota = Convert.ToInt16(objListMasc.est_mascota);
                    if (objListMasc.est_mascota == 1)
                    {
                        objMascotaDC.Estado = "Activo";
                    }
                    else { objMascotaDC.Estado = "Inactivo"; }
                   objMascotaDC.fec_Ult_Mod = Convert.ToDateTime(objListMasc.fec_Ult_Mod);
                    objMascotaDC.Usu_Ult_Mod = objListMasc.Usu_Ult_Mod;

                    objListarMascota.Add(objMascotaDC);

                    

                }
                return objListarMascota;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EspecieDC> ListarEspecie()
        {
            try
            {
                List<EspecieDC> objListarEspecie = new List<EspecieDC>();

                var query = (from miMascota2 in MisAtenciones.Esp
                             orderby miMascota2.cod_esp
                             select miMascota2).ToList();
                foreach (var objListMasc in query)
                {

                    //Creamos instancia 
                    EspecieDC objMascotaDC = new EspecieDC();

                    objMascotaDC.cod_esp = Convert.ToInt16(objListMasc.cod_esp);
                    objMascotaDC.des_esp = objListMasc.des_esp;
                    

                    objListarEspecie.Add(objMascotaDC);



                }
                return objListarEspecie;

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
