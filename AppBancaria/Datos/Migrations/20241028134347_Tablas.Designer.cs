﻿// <auto-generated />
using Datos.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241028134347_Tablas")]
    partial class Tablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("en_US.UTF-8")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Entidades.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .HasName("PK_ID_CLIENTE");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Entidades.Entidades.CuentaBancaria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("FK_ID_CLIENTE")
                        .HasColumnType("int");

                    b.Property<int>("NumeroCuenta")
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.Property<string>("TipoCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .HasName("PK_ID_CUENTABANCARIA");

                    b.HasIndex("FK_ID_CLIENTE");

                    b.ToTable("CuentaBancarias");
                });

            modelBuilder.Entity("Entidades.Entidades.TarjetaCredito", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_ID_CLIENTE")
                        .HasColumnType("int");

                    b.Property<double>("LimiteCredito")
                        .HasColumnType("float");

                    b.Property<int>("NumeroTarjeta")
                        .HasColumnType("int");

                    b.Property<double>("SaldoDisponible")
                        .HasColumnType("float");

                    b.HasKey("ID")
                        .HasName("PK_ID_TARJETACREDITO");

                    b.HasIndex("FK_ID_CLIENTE");

                    b.ToTable("TarjetaCredito");
                });

            modelBuilder.Entity("Entidades.Entidades.CuentaBancaria", b =>
                {
                    b.HasOne("Entidades.Entidades.Cliente", "Cliente")
                        .WithMany("Cuentas")
                        .HasForeignKey("FK_ID_CLIENTE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Entidades.Entidades.TarjetaCredito", b =>
                {
                    b.HasOne("Entidades.Entidades.Cliente", "Cliente")
                        .WithMany("TarjetasCredito")
                        .HasForeignKey("FK_ID_CLIENTE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Entidades.Entidades.Cliente", b =>
                {
                    b.Navigation("Cuentas");

                    b.Navigation("TarjetasCredito");
                });
#pragma warning restore 612, 618
        }
    }
}