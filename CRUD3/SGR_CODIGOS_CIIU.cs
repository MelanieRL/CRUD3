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
    
    public partial class SGR_CODIGOS_CIIU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGR_CODIGOS_CIIU()
        {
            this.SGR_UNIDADES_DESCARGA = new HashSet<SGR_UNIDADES_DESCARGA>();
            this.SGR_LABS_CIIU_TARIFA = new HashSet<SGR_LABS_CIIU_TARIFA>();
        }
    
        public decimal COD_CIIU { get; set; }
        public string DESCRIPCION { get; set; }
        public string PARAMETROS { get; set; }
        public decimal ACTIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_UNIDADES_DESCARGA> SGR_UNIDADES_DESCARGA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_LABS_CIIU_TARIFA> SGR_LABS_CIIU_TARIFA { get; set; }
    }
}
