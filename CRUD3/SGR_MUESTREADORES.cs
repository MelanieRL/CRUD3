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
    
    public partial class SGR_MUESTREADORES
    {
        public decimal ID_MUESTREADOR { get; set; }
        public string NOMBRE { get; set; }
        public string APE_PATERNO { get; set; }
        public string APE_MATERNO { get; set; }
        public string RUT { get; set; }
        public string EMAIL { get; set; }
        public Nullable<decimal> ID_LABORATORIO { get; set; }
        public decimal ACTIVO { get; set; }
    
        public virtual SGR_LABORATORIOS SGR_LABORATORIOS { get; set; }
    }
}