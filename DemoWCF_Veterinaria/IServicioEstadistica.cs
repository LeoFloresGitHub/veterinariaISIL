using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEstadistica" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEstadistica
    {
        [OperationContract]
        List<ClienteEstadistica> TopAtencionesClientesMascotasXAño(Int16 año, Int16 top);
        [OperationContract]
        List<MascotasEstadistica> TopAtencionesMascotasXAño(Int16 año, Int16 top);
        [OperationContract]
        List<MedicinaEstadistica> TopMedicinasXAño(Int16 año, Int16 top);
        [OperationContract]
        List<ConsultasEstadistica> ConsultasXAño(Int16 año);
    }

    [DataContract]
    [Serializable]
    public class ClienteEstadistica
    {
        [DataMember]
        public Int32 cod_cli { get; set; }
        [DataMember]
        public String nom_cli { get; set; }
        [DataMember]
        public String ape_cli { get; set; }

        [DataMember]
        public Int32 ConsultasTotales { get; set; }

    }
    [DataContract]
    [Serializable]
    public class MascotasEstadistica
    {
        [DataMember]
        public Int32 cod_mascota { get; set; }
        [DataMember]
        public String nom_mascota { get; set; }
       

        [DataMember]
        public Int32 ConsultasTotales { get; set; }

    }
    [DataContract]
    [Serializable]
    public class MedicinaEstadistica
    {
        [DataMember]
        public Int32 cod_medicamento { get; set; }
        [DataMember]
        public String des_medicamento { get; set; }

        [DataMember]
        public Int32 CantidadRecetadas { get; set; }

    }
    [DataContract]
    [Serializable]
    public class ConsultasEstadistica
    {
        [DataMember]
        public Int16 Consultas { get; set; }
        

        [DataMember]
        public Int32 Montos { get; set; }

        [DataMember]
        public String Estado { get; set; }


    }
}
