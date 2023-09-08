using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConsulta" en el código y en el archivo de configuración a la vez.
    public class ServicioConsulta : IServicioConsulta
    {

        //Instancia del modelo

        DBVeterinariaEntities MisAtenciones = new DBVeterinariaEntities();

        public List<ConsultaDC> ListarConsultasMascotaFechas(Int32 strCodigo, DateTime fecini, DateTime fecfin)
        {
            try
            {
                //Creamos una lista de facturas...
                List<ConsultaDC> objListaConsultaMascotaDC = new List<ConsultaDC>();

                //Hacemos la consulta con LINQ

                var query = MisAtenciones.usp_ListarConsultasMascotaFecha(strCodigo, fecini, fecfin);

                //Recorremos el resultado...
                foreach (var resultado in query)
                {
                    ConsultaDC objConsultaDC = new ConsultaDC();
                    objConsultaDC.cod_veterinario = Convert.ToInt32(resultado.cod_veterinario);
                    objConsultaDC.nom_cliente = resultado.nom_cliente;
                    objConsultaDC.ape_cliente = resultado.ape_Cliente;
                    objConsultaDC.nom_mascota = resultado.nom_mascota;
                    objConsultaDC.id_consulta = resultado.id_consulta;
                    objConsultaDC.Estado= resultado.Estado;
                    objConsultaDC.fec_consulta = Convert.ToDateTime(resultado.fec_consulta);
                    objConsultaDC.cod_veterinario = Convert.ToInt32(resultado.cod_veterinario);
                    objConsultaDC.Total = Convert.ToDouble(resultado.Total);
                    objConsultaDC.fec_consulta = Convert.ToDateTime(resultado.fec_consulta);
                    

                    //Agregamos la instancia a la lista...
                    objListaConsultaMascotaDC.Add(objConsultaDC);

                }
                return objListaConsultaMascotaDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }


        
        public List<ConsultaDCVet> ListarConsultasVeterinarioFechas(Int32 strCodigo,String estado, DateTime fecini, DateTime fecfin)
        {
            try
            {
                //Creamos una lista de facturas...
                List<ConsultaDCVet> objListaConsultaVeterinarioDC = new List<ConsultaDCVet>();

                //Hacemos la consulta con LINQ

                var query = MisAtenciones.usp_ListarConsultasVeterinarioFechas2(strCodigo,estado, fecini, fecfin);

                //Recorremos el resultado...
                foreach (var resultado in query)
                {
                    ConsultaDCVet objConsultaDC = new ConsultaDCVet();
                    objConsultaDC.cod_veterinario = Convert.ToInt32(resultado.cod_veterinario);
                    objConsultaDC.nom_veterinario = resultado.nom_veterinario;
                    objConsultaDC.ape_veterinario = resultado.ape_veterinario;
                    objConsultaDC.id_consulta = resultado.id_consulta;
                    objConsultaDC.nom_mascota=resultado.nom_mascota;
                   
                    objConsultaDC.Estado = resultado.Estado;
                    objConsultaDC.fec_consulta = Convert.ToDateTime(resultado.fec_consulta);

                    //Agregamos la instancia a la lista...
                    objListaConsultaVeterinarioDC.Add(objConsultaDC);

                }
                return objListaConsultaVeterinarioDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<ConsultaDCEsp> ListarMascotasPorEspecie(Int32 strCodigo)
        {
            try
            {
                //Creamos una lista de facturas...
                List<ConsultaDCEsp> objListaConsultaVeterinarioDC = new List<ConsultaDCEsp>();

                //Hacemos la consulta con LINQ

                var query = MisAtenciones.usp_ListarMascotasPorEspecie2(strCodigo);

                //Recorremos el resultado...
                foreach (var resultado in query)
                {
                    ConsultaDCEsp objConsultaDC = new ConsultaDCEsp();
                    objConsultaDC.cod_mascota = Convert.ToInt32(resultado.cod_mascota);
                    objConsultaDC.nom_mascota = resultado.nom_mascota;
                    objConsultaDC.Especie = resultado.des_esp;
                    objConsultaDC.cod_esp = Convert.ToInt16(resultado.cod_esp);

                    //Agregamos la instancia a la lista...
                    objListaConsultaVeterinarioDC.Add(objConsultaDC);

                }
                return objListaConsultaVeterinarioDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<ConsultaDC> ListarConsultasClientesFechas(Int32 strCodigo, String estado, DateTime fecini, DateTime fecfin)
        {
            try
            {
                //Creamos una lista de facturas...
                List<ConsultaDC> objListaConsultaVeterinarioDC = new List<ConsultaDC>();

                //Hacemos la consulta con LINQ

                var query = MisAtenciones.usp_ListarMascotasdeClientesFechas2(strCodigo, estado, fecini, fecfin);

                //Recorremos el resultado...
                foreach (var resultado in query)
                {
                    ConsultaDC objConsultaDC = new ConsultaDC();
                    
                    objConsultaDC.nom_cliente = resultado.nom_cliente;
                    
                    objConsultaDC.ape_cliente = resultado.ape_cliente;
                    objConsultaDC.nom_mascota = resultado.nom_mascota;
                    objConsultaDC.id_consulta = resultado.id_consulta;
                    objConsultaDC.Estado = resultado.Estado;
                    objConsultaDC.fec_consulta = Convert.ToDateTime(resultado.fec_consulta);
                    objConsultaDC.cod_veterinario = Convert.ToInt32(resultado.cod_veterinario);
                    objConsultaDC.Total = Convert.ToDouble(resultado.Total);
                  

                    //Agregamos la instancia a la lista...
                    objListaConsultaVeterinarioDC.Add(objConsultaDC);

                }
                return objListaConsultaVeterinarioDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

            
    }
}
