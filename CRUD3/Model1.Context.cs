﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD : DbContext
    {
        public BD()
            : base("name=BD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BIN_R1DzHbCu6sngUGQKCMVXuQ___0> BIN_R1DzHbCu6sngUGQKCMVXuQ___0 { get; set; }
        public virtual DbSet<SGR_CLIENTES> SGR_CLIENTES { get; set; }
        public virtual DbSet<SGR_CODIGOS_CIIU> SGR_CODIGOS_CIIU { get; set; }
        public virtual DbSet<SGR_COMUNAS> SGR_COMUNAS { get; set; }
        public virtual DbSet<SGR_EMPRESAS> SGR_EMPRESAS { get; set; }
        public virtual DbSet<SGR_ESTADOS_CLIENTE> SGR_ESTADOS_CLIENTE { get; set; }
        public virtual DbSet<SGR_FISCALIZADORES> SGR_FISCALIZADORES { get; set; }
        public virtual DbSet<SGR_FRECUENCIAS_MUES> SGR_FRECUENCIAS_MUES { get; set; }
        public virtual DbSet<SGR_LABORATORIOS> SGR_LABORATORIOS { get; set; }
        public virtual DbSet<SGR_LABS_CIIU_TARIFA> SGR_LABS_CIIU_TARIFA { get; set; }
        public virtual DbSet<SGR_LABS_LOC_MUEST> SGR_LABS_LOC_MUEST { get; set; }
        public virtual DbSet<SGR_LOCALIDADES> SGR_LOCALIDADES { get; set; }
        public virtual DbSet<SGR_MODULOS> SGR_MODULOS { get; set; }
        public virtual DbSet<SGR_MUESTREADORES> SGR_MUESTREADORES { get; set; }
        public virtual DbSet<SGR_PARAMETROS_RILES> SGR_PARAMETROS_RILES { get; set; }
        public virtual DbSet<SGR_PERFILES> SGR_PERFILES { get; set; }
        public virtual DbSet<SGR_PLANTAS> SGR_PLANTAS { get; set; }
        public virtual DbSet<SGR_PROVINCIAS> SGR_PROVINCIAS { get; set; }
        public virtual DbSet<SGR_REGIONES> SGR_REGIONES { get; set; }
        public virtual DbSet<SGR_SERVICIOS> SGR_SERVICIOS { get; set; }
        public virtual DbSet<SGR_SERVICIOS_UDS> SGR_SERVICIOS_UDS { get; set; }
        public virtual DbSet<SGR_TIPOS_CALC_EXC> SGR_TIPOS_CALC_EXC { get; set; }
        public virtual DbSet<SGR_TIPOS_CLIENTE> SGR_TIPOS_CLIENTE { get; set; }
        public virtual DbSet<SGR_TIPOS_CONTROL> SGR_TIPOS_CONTROL { get; set; }
        public virtual DbSet<SGR_TIPOS_MUESTRA> SGR_TIPOS_MUESTRA { get; set; }
        public virtual DbSet<SGR_TIPOS_SIST_TRAT> SGR_TIPOS_SIST_TRAT { get; set; }
        public virtual DbSet<SGR_UNIDADES_DESCARGA> SGR_UNIDADES_DESCARGA { get; set; }
        public virtual DbSet<SGR_USUARIOS> SGR_USUARIOS { get; set; }
    }
}
