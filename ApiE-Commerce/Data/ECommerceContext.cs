using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace ApiProyectoDeCursoE_Commerce.Data
{
    public class ECommerceContext : DbContext
    {
        // ==================================
        // ADO.NET
        // ==================================

        private readonly string _connectionString;

        public ECommerceContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // ==================================
        // ENTITY FRAMEWORK
        // ==================================

        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Vendedor> Vendedores { get; set; }
        //public DbSet<Comprador> Compradores { get; set; }
        //public DbSet<Administrador> Administradores { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<EstadoProducto> EstadosProducto { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        //public DbSet<ImagenProducto> ImagenesProducto { get; set; }
        //public DbSet<MetodoDePago> MetodosDePago { get; set; }
        //public DbSet<EstadoTransaccion> EstadosTransaccion { get; set; }
        //public DbSet<Transaccion> Transacciones { get; set; }
        //public DbSet<TipoIngreso> TiposIngreso { get; set; }
        //public DbSet<Ingreso> IngresosECommerce { get; set; }
        //public DbSet<Chat> Chats { get; set; }
        //public DbSet<Mensaje> Mensajes { get; set; }
        //public DbSet<ParticipanEnChat> ParticipantesEnChat { get; set; }
        //public DbSet<Direccion> Direcciones { get; set; }
        //public DbSet<ReseñaVendedor> ReseñasVendedor { get; set; }
        //public DbSet<ReseñaProducto> ReseñasProducto { get; set; }
        //public DbSet<PasswordReset> PasswordResets { get; set; }
        //public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuario>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(u => u.IdUsuario).HasName("PK_Usuarios");

        //        // Constraint único en Correo con nombre específico
        //        entity.HasIndex(u => u.Correo)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_Usuarios_Correo");
        //    });
        //    modelBuilder.Entity<Vendedor>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(v => v.IdVendedor).HasName("PK_Vendedores");
        //        // Constraint único en IdUsuario
        //        entity.HasIndex(v => v.IdUsuario)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_Vendedores_IdUsuario");
        //        // FK hacia Usuarios con nombre específico
        //        entity.HasOne(v => v.Usuario)
        //              .WithOne() // Uno a uno
        //              .HasForeignKey<Vendedor>(v => v.IdUsuario)
        //              .HasConstraintName("FK_Vendedores_Usuarios");

        //    });
        //    modelBuilder.Entity<Comprador>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(c => c.IdComprador).HasName("PK_Compradores");

        //        // Constraint único en IdUsuario
        //        entity.HasIndex(c => c.IdUsuario)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_Compradores_IdUsuario");

        //        // FK hacia Usuarios con nombre específico
        //        entity.HasOne(c => c.Usuario)
        //              .WithOne() // Uno a uno
        //              .HasForeignKey<Comprador>(c => c.IdUsuario)
        //              .HasConstraintName("FK_Compradores_Usuarios");
        //    });
        //    modelBuilder.Entity<Administrador>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(a => a.IdAdministrador).HasName("PK_Administradores");

        //        // Constraint único en IdUsuario
        //        entity.HasIndex(a => a.IdUsuario)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_Administradores_IdUsuario");

        //        // FK hacia Usuarios con nombre específico
        //        entity.HasOne(a => a.Usuario)
        //              .WithOne() // Uno a uno
        //              .HasForeignKey<Administrador>(a => a.IdUsuario)
        //              .HasConstraintName("FK_Administradores_Usuarios");
        //    });
        //    modelBuilder.Entity<Categoria>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(c => c.IdCategoria).HasName("PK_Categoria");

        //        // Constraint único en NombreCategoria
        //        entity.HasIndex(c => c.NombreCategoria)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_Categorias_NombreCategoria");
        //    });
        //    modelBuilder.Entity<EstadoProducto>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(e => e.IdEstadoProducto).HasName("PK_EstadosProducto");

        //        // Constraint único en NombreEstado
        //        entity.HasIndex(e => e.NombreEstado)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_EstadosProducto_NombreEstado");
        //    });
        //    modelBuilder.Entity<Producto>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(p => p.IdProducto).HasName("PK_Productos");

        //        // CHECK constraints con nombre específico
        //        entity.HasCheckConstraint("CK_Productos_Precio", "Precio > 0.01");
        //        entity.HasCheckConstraint("CK_Productos_StockDisponible", "StockDisponible >= 0");

        //        // Relaciones
        //        entity.HasOne(p => p.Vendedor)
        //              .WithMany(v => v.Productos)
        //              .HasForeignKey(p => p.IdVendedor)
        //              .HasConstraintName("FK_Productos_Vendedores");

        //        entity.HasOne(p => p.Categoria)
        //              .WithMany(c => c.Productos)
        //              .HasForeignKey(p => p.IdCategoria)
        //              .HasConstraintName("FK_Productos_Categorias");

        //        entity.HasOne(p => p.EstadoProducto)
        //              .WithMany(e => e.Productos)
        //              .HasForeignKey(p => p.IdEstadoProducto)
        //              .HasConstraintName("FK_Productos_EstadosProducto");
        //    });
        //    modelBuilder.Entity<ImagenProducto>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(i => i.IdImagenProducto)
        //              .HasName("PK_ImagenProductos");

        //        // Relación con Productos
        //        entity.HasOne(i => i.Producto)
        //              .WithMany(p => p.Imagenes)
        //              .HasForeignKey(i => i.IdProducto)
        //              .HasConstraintName("FK_ImagenProductos_Productos");
        //    });
        //    modelBuilder.Entity<MetodoDePago>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(m => m.IdMetodoDePago)
        //              .HasName("PK_MetodosDePago");

        //        // Constraint único con nombre específico
        //        entity.HasIndex(m => m.NombreMetodoDePago)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_MetodosDePago_NombreMetodoDePago");
        //    });
        //    modelBuilder.Entity<EstadoTransaccion>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(e => e.IdEstadoTransaccion)
        //              .HasName("PK_EstadosTransacciones");

        //        // Constraint único con nombre personalizado
        //        entity.HasIndex(e => e.NombreEstadoTransaccion)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_EstadosTransaccion_NombreEstadoTransaccion");
        //    });
        //    modelBuilder.Entity<Transaccion>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(t => t.IdTransaccion)
        //              .HasName("PK_Transaciones");

        //        // Check constraint personalizado
        //        entity.HasCheckConstraint("CK_Transacciones_unidadesCompradas", "UnidadesCompradas >= 1");

        //        // Relación con Productos
        //        entity.HasOne(t => t.Producto)
        //              .WithMany(p => p.Transacciones)
        //              .HasForeignKey(t => t.IdProducto)
        //              .HasConstraintName("FK_Transacciones_Productos");

        //        // Relación con Compradores
        //        entity.HasOne(t => t.Comprador)
        //              .WithMany(c => c.Transacciones)
        //              .HasForeignKey(t => t.IdComprador)
        //              .HasConstraintName("FK_Transacciones_Compradores");

        //        // Relación con EstadosTransaccion
        //        entity.HasOne(t => t.EstadoTransaccion)
        //              .WithMany(e => e.Transacciones)
        //              .HasForeignKey(t => t.IdEstadoTransaccion)
        //              .HasConstraintName("FK_Transacciones_EstadosTransaccion");

        //        // Relación con MetodosDePago
        //        entity.HasOne(t => t.MetodoDePago)
        //              .WithMany(m => m.Transacciones)
        //              .HasForeignKey(t => t.IdMetodoDePago)
        //              .HasConstraintName("FK_Transacciones_MetodosDePago");
        //    });
        //    modelBuilder.Entity<TipoIngreso>(entity =>
        //    {
        //        entity.HasKey(t => t.IdTipoIngreso)
        //              .HasName("PK_TiposIngreso");

        //        entity.HasIndex(t => t.Detalle)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_TiposIngreso_Detalle");
        //    });
        //    modelBuilder.Entity<Ingreso>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(i => i.IdIngresoEcommerce)
        //              .HasName("PK_IngresosEcommerce");

        //        // Cantidad con CHECK constraint
        //        entity.HasCheckConstraint("CK_IngresosEcommerce_Cantidad", "Cantidad > 0.01");

        //        // Relaciones
        //        entity.HasOne(i => i.Transaccion)
        //              .WithMany(t => t.Ingresos)
        //              .HasForeignKey(i => i.IdTransaccion)
        //              .HasConstraintName("FK_IngresosEcommerce_Transacciones");

        //        entity.HasOne(i => i.TipoIngreso)
        //              .WithMany(ti => ti.Ingresos)
        //              .HasForeignKey(i => i.IdTipoIngreso)
        //              .HasConstraintName("FK_IngresosEcommerce_TiposIngreso");
        //    });
        //    modelBuilder.Entity<Chat>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(c => c.IdChat)
        //              .HasName("PK_Chats");
        //    });
        //    modelBuilder.Entity<Mensaje>(entity =>
        //    {
        //        // Clave primaria con nombre específico
        //        entity.HasKey(m => m.IdMensaje)
        //              .HasName("PK_Mensajes");

        //        // Relaciones
        //        entity.HasOne(m => m.Chat)
        //              .WithMany(c => c.Mensajes)
        //              .HasForeignKey(m => m.IdChat)
        //              .HasConstraintName("FK_Mensajes_Chats");

        //        entity.HasOne(m => m.Usuario)
        //              .WithMany()
        //              .HasForeignKey(m => m.IdUsuario)
        //              .HasConstraintName("FK_Mensajes_Usuarios");
        //    });
        //    modelBuilder.Entity<ParticipanEnChat>(entity =>
        //    {
        //        // Clave primaria compuesta con nombre específico
        //        entity.HasKey(pc => new { pc.IdUsuario, pc.IdChat })
        //              .HasName("PK_ParticipanEnChat");

        //        // Relaciones
        //        entity.HasOne(pc => pc.Usuario)
        //              .WithMany(u => u.Participaciones) // agregar ICollection<ParticipanEnChat> Participaciones en Usuario
        //              .HasForeignKey(pc => pc.IdUsuario)
        //              .HasConstraintName("FK_ParticipanEnChat_Usuarios");

        //        entity.HasOne(pc => pc.Chat)
        //              .WithMany(c => c.Participantes) // ya lo definimos en Chat
        //              .HasForeignKey(pc => pc.IdChat)
        //              .HasConstraintName("FK_ParticipanEnChat_Chats");
        //    });
        //    modelBuilder.Entity<Direccion>(entity =>
        //    {
        //        // Clave primaria
        //        entity.HasKey(d => d.IdDireccion).HasName("PK_Direcciones");

        //        // Relaciones
        //        entity.HasOne(d => d.Vendedor)
        //              .WithMany(v => v.Direcciones) // agregar ICollection<Direccion> Direcciones en Vendedor
        //              .HasForeignKey(d => d.IdVendedor)
        //              .HasConstraintName("FK_Direcciones_Vendedores");

        //        entity.HasOne(d => d.Comprador)
        //              .WithMany(c => c.Direcciones) // agregar ICollection<Direccion> Direcciones en Comprador
        //              .HasForeignKey(d => d.IdComprador)
        //              .HasConstraintName("FK_Direcciones_Compradores");

        //        // Check constraint para que al menos una FK sea no nula
        //        entity.HasCheckConstraint("CK_Direccion_Asociada", "IdVendedor IS NOT NULL OR IdComprador IS NOT NULL");
        //    });
        //    modelBuilder.Entity<ReseñaVendedor>(entity =>
        //    {
        //        entity.HasKey(r => r.IdReseñaVendedor)
        //              .HasName("PK_ReseñasVendedor");

        //        entity.HasOne(r => r.Vendedor)
        //              .WithMany(v => v.Reseñas)
        //              .HasForeignKey(r => r.IdVendedor)
        //              .HasConstraintName("FK_ReseñasVendedor_Vendedores");

        //        entity.HasOne(r => r.Comprador)
        //              .WithMany(c => c.Reseñas)
        //              .HasForeignKey(r => r.IdComprador)
        //              .HasConstraintName("FK_ReseñasVendedor_Compradores");

        //        entity.HasCheckConstraint("CK_ReseñasVendedor_Calificacion", "Calificacion >= 1 AND Calificacion <= 5");
        //    });
        //    modelBuilder.Entity<ReseñaProducto>(entity =>
        //    {
        //        entity.HasKey(r => r.IdReseñaProducto)
        //              .HasName("PK_ReseñasProducto");

        //        entity.HasOne(r => r.Producto)
        //              .WithMany(p => p.Reseñas)
        //              .HasForeignKey(r => r.IdProducto)
        //              .HasConstraintName("FK_ReseñasProducto_Productos");

        //        entity.HasOne(r => r.Comprador)
        //              .WithMany(c => c.ReseñasP)
        //              .HasForeignKey(r => r.IdComprador)
        //              .HasConstraintName("FK_ReseñasProducto_Compradores");

        //        entity.HasCheckConstraint("CK_ReseñasProducto_Calificacion", "Calificacion >= 1 AND Calificacion <= 5");
        //    });
        //    modelBuilder.Entity<PasswordReset>(entity =>
        //    {
        //        entity.HasKey(p => p.IdReset)
        //              .HasName("PK_PasswordResets");

        //        entity.HasIndex(p => p.Token)
        //              .IsUnique()
        //              .HasDatabaseName("UQ_PasswordResets_Token");

        //        entity.Property(p => p.Token)
        //              .HasDefaultValueSql("NEWID()")
        //              .IsRequired();

        //        entity.HasOne(p => p.Usuario)
        //              .WithMany()
        //              .HasForeignKey(p => p.IdUsuario)
        //              .HasConstraintName("FK_PasswordResets_Usuarios");
        //    });

        //    base.OnModelCreating(modelBuilder);
    }
}