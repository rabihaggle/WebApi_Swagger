using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi1.Models
{
    public partial class PRE_ALTIUS_00_INTERMEDIAContext : DbContext
    {
        public PRE_ALTIUS_00_INTERMEDIAContext()
        {
        }

        public PRE_ALTIUS_00_INTERMEDIAContext(DbContextOptions<PRE_ALTIUS_00_INTERMEDIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<_00Operacione> _00Operaciones { get; set; } = null!;
        public virtual DbSet<_00OperacionesMovimientosAut> _00OperacionesMovimientosAuts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PORTNABIHAGGLE\\SQLEXPRESS;Database=PRE_ALTIUS_00_INTERMEDIA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_00Operacione>(entity =>
            {
                entity.ToTable("00_Operaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Matricula_Contenedor");

                entity.Property(e => e.Flujo).HasMaxLength(50);

                entity.Property(e => e.Navieras).HasMaxLength(50);

                entity.Property(e => e.NumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("Numero_Operacion");
            });

            modelBuilder.Entity<_00OperacionesMovimientosAut>(entity =>
            {
                entity.ToTable("00_Operaciones_Movimientos_Aut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DidCodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Cod_Matricula_Contenedor");

                entity.Property(e => e.DidNumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Numero_Operacion");

                entity.Property(e => e.FechaActualTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_actual_time");

                entity.Property(e => e.FechaActualizaciónRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualización_Registro");

                entity.Property(e => e.FechaExpectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_expected_time");

                entity.Property(e => e.TipoEvento)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Evento");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
