//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWCF_Veterinaria
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consulta()
        {
            this.Det_Consulta = new HashSet<Det_Consulta>();
        }
    
        public int id_consulta { get; set; }
        public Nullable<System.DateTime> fec_consulta { get; set; }
        public Nullable<int> cod_veterinario { get; set; }
        public Nullable<int> cod_mascota { get; set; }
        public Nullable<int> est_consulta { get; set; }
        public decimal prec_consulta { get; set; }
        public decimal igv { get; set; }
        public string diagnostico { get; set; }
        public Nullable<System.DateTime> fec_proxconsulta { get; set; }
        public Nullable<System.DateTime> fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        public virtual Veterinario Veterinario { get; set; }
        public virtual Mascota Mascota { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Consulta> Det_Consulta { get; set; }
    }
}