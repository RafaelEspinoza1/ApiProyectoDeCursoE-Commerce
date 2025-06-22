using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProyectoDeCursoE_Commerce.Data
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ImagenProducto> ImagenesProducto { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<IngresosECommerce> IngresosECommerce { get; set; }
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compras>()
                .HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Compras>()
                .HasOne(c => c.Vendedor)
                .WithMany()
                .HasForeignKey(c => c.VendedorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Compras>()
                .HasOne(c => c.Producto)
                .WithMany()
                .HasForeignKey(c => c.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
