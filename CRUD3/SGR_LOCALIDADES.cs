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
    
    public partial class SGR_LOCALIDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGR_LOCALIDADES()
        {
            this.SGR_LABS_LOC_MUEST = new HashSet<SGR_LABS_LOC_MUEST>();
            this.SGR_PLANTAS = new HashSet<SGR_PLANTAS>();
        }
    
        public decimal ID_LOCALIDAD { get; set; }
        public string NOMBRE { get; set; }
        public decimal ID_COMUNA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_LABS_LOC_MUEST> SGR_LABS_LOC_MUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_PLANTAS> SGR_PLANTAS { get; set; }
    }
}
