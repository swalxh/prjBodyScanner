﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBodyScanner.Data.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestionBodyscannerEntities : DbContext
    {
        public GestionBodyscannerEntities()
            : base("name=GestionBodyscannerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BitacoraBD> BitacoraBD { get; set; }
        public virtual DbSet<DoctorBD> DoctorBD { get; set; }
        public virtual DbSet<EnfermedadesBD> EnfermedadesBD { get; set; }
        public virtual DbSet<OcupacionesBD> OcupacionesBD { get; set; }
        public virtual DbSet<PacientesBD> PacientesBD { get; set; }
        public virtual DbSet<SexoBD> SexoBD { get; set; }
        public virtual DbSet<TipoSangreBD> TipoSangreBD { get; set; }
        public virtual DbSet<ResultadosBD> ResultadosBD { get; set; }
    }
}
