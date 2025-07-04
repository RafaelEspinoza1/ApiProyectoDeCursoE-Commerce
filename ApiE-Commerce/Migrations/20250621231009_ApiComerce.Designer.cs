﻿// <auto-generated />
using System;
using ApiProyectoDeCursoE_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiProyectoDeCursoE_Commerce.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20250621231009_ApiComerce")]
    partial class ApiComerce
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Administrador", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministradorId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministradorId");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompraId"));

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CuentaUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Envio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("LatitudDestino")
                        .HasColumnType("float");

                    b.Property<double>("LatitudOrigen")
                        .HasColumnType("float");

                    b.Property<double>("LongitudDestino")
                        .HasColumnType("float");

                    b.Property<double>("LongitudOrigen")
                        .HasColumnType("float");

                    b.Property<string>("NombreDireccionDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDireccionOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.ImagenProducto", b =>
                {
                    b.Property<int>("ImagenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImagenId"));

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("ImagenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ImagenesProducto");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.IngresosECommerce", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoId"));

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("IngresoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("IngresosECommerce");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Vendedores", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendedorId"));

                    b.Property<string>("DireccionOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ingresos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("LatitudOrigen")
                        .HasColumnType("float");

                    b.Property<double>("LongitudOrigen")
                        .HasColumnType("float");

                    b.Property<string>("NumeroDeCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("VendedorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Compras", b =>
                {
                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Vendedores", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.ImagenProducto", b =>
                {
                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Productos", "Producto")
                        .WithMany("Imagenes")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.IngresosECommerce", b =>
                {
                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Productos", b =>
                {
                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Vendedores", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Vendedores", b =>
                {
                    b.HasOne("ApiProyectoDeCursoE_Commerce.Models.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiProyectoDeCursoE_Commerce.Models.Productos", b =>
                {
                    b.Navigation("Imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}
