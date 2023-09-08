using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;
namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        ClienteDC ConsultarCliente(Int32 strCodigo);
        [OperationContract]
        Boolean InsertarCliente(ClienteInsertar objClienteDC);
        [OperationContract]
        Boolean ActualizarCliente(ClienteActualizar objClienteDC);
        [OperationContract]
        Boolean EliminarCliente(Int32 strCodigo);
        [OperationContract]
        List<ClienteDC> ListarCliente();
    }

    [DataContract]
    [Serializable]
    public class ClienteDC
    {
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Int32 dni_cli { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String tel_cliente { get; set; }
        [DataMember]
        public Int16 est_cli { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String sexo_lit { get; set; }
        [DataMember]
        public String email { get; set; }
        [DataMember]
        public String num_reg { get; set; }
        [DataMember]
        public String id_Ubigeo { get; set; }
        [DataMember]
        public DateTime fec_registro { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
       

    }

    public class ClienteDCInsertar
    {
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Int32 dni_cli { get; set; }
        [DataMember]
        public String id_Ubigeo { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String tel_cliente { get; set; }
        [DataMember]
        public Int16 est_cli { get; set; }
    
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String email { get; set; }
        
        
     
        [DataMember]
        public String Usu_Registro { get; set; }
      

    }

    public class ClienteInsertar
    {
        
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Int32 dni_cli { get; set; }
        [DataMember]
        public String id_Ubigeo { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String tel_cliente { get; set; }
        [DataMember]
        public Int16 est_cli { get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String email { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
    }

    public class ClienteActualizar
    {
        [DataMember]
        public Int32 cod_cliente { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public Int32 dni_cli { get; set; }
        [DataMember]
        public String id_Ubigeo { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String tel_cliente { get; set; }
        [DataMember]
        public Int16 est_cli { get; set; }
        [DataMember]
        public String sexo { get; set; }
        [DataMember]
        public String email { get; set; }
        [DataMember]
        public String num_reg { get; set; }
        [DataMember]
        public String Usu_Ult_Mod{ get; set; }
    }


}
