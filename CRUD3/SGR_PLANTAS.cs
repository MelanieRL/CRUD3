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
    
    public partial class SGR_PLANTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGR_PLANTAS()
        {
            this.SGR_CLIENTES = new HashSet<SGR_CLIENTES>();
        }
    
        public decimal ID_PLANTA { get; set; }
        public Nullable<decimal> ID_EMPRESA { get; set; }
        public string COD_SISS { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> ID_LOCALIDAD { get; set; }
        public Nullable<System.DateTime> FECHA_OPERACION { get; set; }
        public decimal ACTIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGR_CLIENTES> SGR_CLIENTES { get; set; }
        public virtual SGR_EMPRESAS SGR_EMPRESAS { get; set; }
        public virtual SGR_LOCALIDADES SGR_LOCALIDADES { get; set; }
    }
}
