//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SGR_PROVINCIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGR_PROVINCIAS()
        {
            this.SGR_COMUNAS = new HashSet<SGR_COMUNAS>();
        }
        [Required]
        public decimal ID_PROVINCIA { get; set; }
        [Required]
        public Nullable<decimal> ID_REGION { get; set; }
        [Required]
        public string DESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_COMUNAS> SGR_COMUNAS { get; set; }
        public virtual SGR_REGIONES SGR_REGIONES { get; set; }
    }
}
