using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioVeterinario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioVeterinario
    {
        [OperationContract]
        VeterinarioDC ConsultarVeterinario(Int32 strCodigo);

        [OperationContract]
        List<VeterinarioDC> ListarVeterinario();
    }
    [DataContract]
    [Serializable]
    public class VeterinarioDC
    {

        [DataMember]
        public Int32 cod_veterinario { get; set; }
        [DataMember]
        public String nom_veterinario { get; set; }
        [DataMember]
        public String ape_veterinario { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public Int32 sueldo { get; set; }
        [DataMember]
        public Int32 dni_vet { get; set; }
        [DataMember]
        public String foto { get; set; }
        [DataMember]
        public Int16 est_vet { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String tel_veterinario { get; set; }
        [DataMember]
        public Int16 cod_especialidad { get; set; }
        [DataMember]
        public String des_especialidad { get; set; }
        [DataMember]
        public DateTime fec_Ult_Mod { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }

    }


    

}
