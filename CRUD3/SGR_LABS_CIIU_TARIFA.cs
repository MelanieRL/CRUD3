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
    
    public partial class SGR_LABS_CIIU_TARIFA
    {
        public decimal ID_LABORATORIO { get; set; }
        public decimal COD_CIIU { get; set; }
        public Nullable<decimal> COSTO { get; set; }
    
        public virtual SGR_CODIGOS_CIIU SGR_CODIGOS_CIIU { get; set; }
        public virtual SGR_LABORATORIOS SGR_LABORATORIOS { get; set; }
    }
}
