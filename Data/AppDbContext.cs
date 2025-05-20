using System;
using System.Collections.Generic;
using CRUD_PRUEBA.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_PRUEBA.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Nue).HasName("PRIMARY");

            entity.ToTable("Empleado");

            entity.Property(e => e.Nue).HasMaxLength(6);
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Puesto).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
