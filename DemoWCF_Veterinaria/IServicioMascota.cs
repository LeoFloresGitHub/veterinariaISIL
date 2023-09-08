using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioMascota" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioMascota
    {
        [OperationContract]
        MascotaDC ConsultarMascota(Int32 strCodigo);
        [OperationContract]
        Boolean InsertarMascota(MascotaInsertar objMascotaDC);
        [OperationContract]
        Boolean ActualizarMascota(MascotaActualizar objMascotaDC);
        [OperationContract]
        Boolean EliminarMascota(Int32 strCodigo);
        [OperationContract]
        List<MascotaDC> ListarMascota();
        [OperationContract]
        List<EspecieDC> ListarEspecie();
        
    }

    [DataContract]
    [Serializable]
    public class MascotaDC
    {
        [DataMember]
        public Int32 cod_mascota { get; set; }
        [DataMember]
        public Int16 cod_esp{ get; set; }
        [DataMember]
        public String des_esp { get; set; }
        [DataMember]
        public String nom_mascota { get; set; }
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Byte[] foto{ get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String sexoLit { get; set; }
        [DataMember]
        public String color { get; set; }
        [DataMember]
        public DateTime fec_nacimiento { get; set; }
        [DataMember]
        public Int16 est_mascota { get; set; }
        [DataMember]
        public DateTime fec_Ult_Mod { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public String Estado { get; set; }
    }
    

    public class MascotaInsertar
    {
      
        
        [DataMember]
        public String nom_mascota { get; set; }
        
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public Int16 cod_esp { get; set; }
        [DataMember]
        public Byte[] foto { get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String color { get; set; }
        [DataMember]
        public DateTime fec_nacimiento { get; set; }
        [DataMember]
        public Int16 est_mascota { get; set; }
      
    }

    public class MascotaActualizar
    {
        [DataMember]
        public Int32 cod_mascota { get; set; }
        [DataMember]
        public Int16 cod_esp { get; set; }
        [DataMember]
        public String nom_mascota { get; set; }
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Byte[] foto { get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String color { get; set; }
        [DataMember]
        public DateTime fec_nacimiento { get; set; }
        [DataMember]
        public Int16 est_mascota { get; set; }
        
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        

    }

    public class EspecieDC
    {
        [DataMember]
        public Int32 cod_esp { get; set; }
        [DataMember]
        public String des_esp { get; set; }

    }
}
