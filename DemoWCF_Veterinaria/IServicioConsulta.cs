using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF_Veterinaria
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConsulta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConsulta
    {
        [OperationContract]
        List<ConsultaDC> ListarConsultasMascotaFechas(Int32 strCodigo, DateTime fecini, DateTime fecfin);
        [OperationContract]
        List<ConsultaDCVet> ListarConsultasVeterinarioFechas(Int32 strCodigo, String estado, DateTime fecini, DateTime fecfin);
        [OperationContract]
        List<ConsultaDCEsp> ListarMascotasPorEspecie(Int32 strCodigo);
        [OperationContract]
        List<ConsultaDC> ListarConsultasClientesFechas(Int32 strCodigo, String estado, DateTime fecini, DateTime fecfin);



    }

    public class ConsultaDC
    {
        [DataMember]
        public Int32 id_consulta { get; set; }
        [DataMember]
        public String nom_mascota { get; set; }
        [DataMember]
        public String nom_cliente { get; set; }
        [DataMember]
        public String ape_cliente { get; set; }
        [DataMember]
        public DateTime fec_consulta { get; set; }
        [DataMember]
        public Int32 cod_veterinario { get; set; }
        [DataMember]

        public String Estado { get; set; }
        [DataMember]
        public Double Total { get; set; }
     





    }

    public class ConsultaDCVet
    {
        [DataMember]
        public Int32 id_consulta { get; set; }
        [DataMember]
        public String nom_veterinario{ get; set; }
        [DataMember]
        public String ape_veterinario { get; set; }
        [DataMember]
        public String nom_mascota { get; set; }
        [DataMember]
        public DateTime fec_consulta { get; set; }
        [DataMember]
        public Int32 cod_veterinario { get; set; }
        [DataMember]
        public String Estado { get; set; }
     




    }

    public class ConsultaDCEsp
    {

        [DataMember]
        public String nom_mascota { get; set; }

        [DataMember]
        public Int32 cod_mascota { get; set; }
        [DataMember]
        public Int16 cod_esp{ get; set; }
        [DataMember]
        public String Especie { get; set; }





    }

}
