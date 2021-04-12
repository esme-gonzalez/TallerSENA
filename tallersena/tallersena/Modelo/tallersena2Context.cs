using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tallersena.Modelo
{
    public partial class tallersena2Context : DbContext
    {
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost; userid=root; password=; Database=tallersena2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiantes>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("estudiantes");

                entity.Property(e => e.Codigo).HasColumnType("int(11)");

                entity.Property(e => e.Correo).HasMaxLength(30);

                entity.Property(e => e.Nombre).HasMaxLength(20);
            });
        }
    }
}
