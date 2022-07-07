using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mercado.core.Models;

namespace Mercado.UI.Data
{
    public class MercadoContext : DbContext
    {
        public MercadoContext(DbContextOptions<MercadoContext> options)
            : base(options)
        {
        }

        public DbSet<Producto>? Producto => Set<Producto>();

        public DbSet<Proveedor>? Proveedor => Set<Proveedor>();

        public DbSet<Marca>? Marca => Set<Marca>();
        public DbSet<ProveedoresxMarcas>? ProveedoresxMarcas => Set<ProveedoresxMarcas>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");
            modelBuilder.Entity<Marca>().ToTable("Marcas");
            //modelBuilder.Ignore<ProveedoresxMarcas>();
            modelBuilder.Entity<ProveedoresxMarcas>().ToTable("ProveedoresxMarcas")
            //Declaro la clave principal compuesta.
            .HasKey(t => new { t.ProveedorId, t.MarcaId });
        }
    }
}
