using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;



namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstadistica" en el código y en el archivo de configuración a la vez.
    public class ServicioEstadistica : IServicioEstadistica
    {
        DBVeterinariaEntities MisAtenciones = new DBVeterinariaEntities();
        public List<ClienteEstadistica> TopAtencionesClientesMascotasXAño(Int16 año, Int16 top)
        {

            try
            {
                List<ClienteEstadistica> objLista = new List<ClienteEstadistica>();

                var query = MisAtenciones.usp_TopAtencionesClientesMascotasAño2(año).Take(top);

                foreach (var item in query)
                {
                    ClienteEstadistica objProductoEstadistica = new ClienteEstadistica();
                    objProductoEstadistica.cod_cli = Convert.ToInt32(item.cod_cliente);
                    objProductoEstadistica.ConsultasTotales = Convert.ToInt32(item.Consultas_Totales);
                    objProductoEstadistica.nom_cli = item.nom_cliente;
                    objProductoEstadistica.ape_cli = item.ape_Cliente;

                    objLista.Add(objProductoEstadistica);
                }

                return objLista;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<MascotasEstadistica> TopAtencionesMascotasXAño(Int16 año, Int16 top)
        {

            try
            {
                List<MascotasEstadistica> objLista = new List<MascotasEstadistica>();

                var query = MisAtenciones.usp_TopAtencionesMascotasAño2(año).Take(top);

                foreach (var item in query)
                {
                    MascotasEstadistica objMascotaEstadistica = new MascotasEstadistica();
                    objMascotaEstadistica.cod_mascota= Convert.ToInt32(item.cod_mascota);
                    objMascotaEstadistica.nom_mascota = item.nom_mascota;
                    objMascotaEstadistica.ConsultasTotales = Convert.ToInt32(item.Consultas_Totales);

                    objLista.Add(objMascotaEstadistica);
                }

                return objLista;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<MedicinaEstadistica> TopMedicinasXAño(Int16 año, Int16 top)
        {

            try
            {
                List<MedicinaEstadistica> objLista = new List<MedicinaEstadistica>();

                var query = MisAtenciones.usp_TopMedicinasXAño(año).Take(top);

                foreach (var item in query)
                {
                    MedicinaEstadistica objMedicinaEstadistica = new MedicinaEstadistica();
                    objMedicinaEstadistica.cod_medicamento = Convert.ToInt32(item.cod_medicamento);
                    objMedicinaEstadistica.des_medicamento = item.des_medicamento;
                    objMedicinaEstadistica.CantidadRecetadas = Convert.ToInt32(item.Cantidad_recetadas);

                    objLista.Add(objMedicinaEstadistica);
                }

                return objLista;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ConsultasEstadistica> ConsultasXAño(Int16 año)
        {

            try
            {
                List<ConsultasEstadistica> objLista = new List<ConsultasEstadistica>();

                var query = MisAtenciones.usp_ResumenConsultasXAño(año);

                foreach (var item in query)
                {
                    ConsultasEstadistica objConsultasEstadistica = new ConsultasEstadistica();

                    objConsultasEstadistica.Consultas = Convert.ToInt16(item.Consultas_Totales);
                    objConsultasEstadistica.Montos = Convert.ToInt32(item.Ingresos_Generados);
                    
                    objConsultasEstadistica.Estado = item.Estado;

                    objLista.Add(objConsultasEstadistica);
                }

                return objLista;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
