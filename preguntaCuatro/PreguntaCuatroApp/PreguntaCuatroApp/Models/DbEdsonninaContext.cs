using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PreguntaCuatroApp.Models;

public partial class DbEdsonninaContext : DbContext
{
    public DbEdsonninaContext()
    {
    }

    public DbEdsonninaContext(DbContextOptions<DbEdsonninaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inscripcion> Inscripcions { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DBEdsonNinaContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inscripcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("inscripcion");

            entity.Property(e => e.Ciestudiante).HasColumnName("CIestudiante");
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CiestudianteNavigation).WithMany()
                .HasForeignKey(d => d.Ciestudiante)
                .HasConstraintName("FK__inscripci__CIest__2D27B809");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Ci).HasName("PK__persona__32149A7BAEAF0583");

            entity.ToTable("persona");

            entity.Property(e => e.Ci)
                .ValueGeneratedNever()
                .HasColumnName("CI");
            entity.Property(e => e.Departamento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
