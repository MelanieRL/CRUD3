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
    
    public partial class SGR_TIPOS_SIST_TRAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGR_TIPOS_SIST_TRAT()
        {
            this.SGR_CLIENTES = new HashSet<SGR_CLIENTES>();
        }
    
        public decimal ID_TIPO_SIST_TRATAMI { get; set; }
        public string DESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_CLIENTES> SGR_CLIENTES { get; set; }
    }
}
