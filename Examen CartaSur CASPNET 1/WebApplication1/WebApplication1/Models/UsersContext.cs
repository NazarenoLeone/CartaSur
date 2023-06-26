using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class UsersContext : DbContext
{
    public UsersContext()
    {
    }

    public UsersContext(DbContextOptions<UsersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-6009PIV;Initial Catalog=ventas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__ventas__F3B6C1B4C35C74D6");

            entity.ToTable("ventas");

            entity.Property(e => e.IdVenta)
                .ValueGeneratedNever()
                .HasColumnName("ID_VENTA");
            entity.Property(e => e.DireccionEnvioCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Direccion_envio_cliente");
            entity.Property(e => e.DireccionSucursalVenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Direccion_sucursal_venta");
            entity.Property(e => e.DniCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Dni_cliente");
            entity.Property(e => e.FechaVenta)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_venta");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Importe_total");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_cliente");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_empleado");
            entity.Property(e => e.NombreSucursalVenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_sucursal_venta");
            entity.Property(e => e.Producto)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
