﻿// <auto-generated />
using System;
using Final_LACOA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalLACOA.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221217192603_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_LACOA.Models.CajaAhorro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cbu")
                        .HasColumnType("int");

                    b.Property<double>("saldo")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Caja", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.Movimiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("detalle")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("idCaja")
                        .HasColumnType("int");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("idCaja");

                    b.ToTable("Movimiento", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.Pago", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("detalle")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("idUsuario");

                    b.ToTable("Pago", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.PlazoFijo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<int>("cbu")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaIni")
                        .HasColumnType("datetime");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.Property<int>("tasa")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idUsuario");

                    b.ToTable("Plazo", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.TarjetaCredito", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("codigoSeguridad")
                        .HasColumnType("int");

                    b.Property<double>("consumos")
                        .HasColumnType("float");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<int>("limite")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idUsuario");

                    b.ToTable("Tarjeta", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("bloqueado")
                        .HasColumnType("bit");

                    b.Property<string>("contra")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<bool>("esADM")
                        .HasColumnType("bit");

                    b.Property<int>("intentosFallidos")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Final_LACOA.Models.UsuarioCaja", b =>
                {
                    b.Property<int>("num_usr")
                        .HasColumnType("int");

                    b.Property<int>("idCaja")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("num_usr", "idCaja");

                    b.HasIndex("idCaja");

                    b.ToTable("UsuarioCaja");
                });

            modelBuilder.Entity("Final_LACOA.Models.Movimiento", b =>
                {
                    b.HasOne("Final_LACOA.Models.CajaAhorro", "caja")
                        .WithMany("movimientos")
                        .HasForeignKey("idCaja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("caja");
                });

            modelBuilder.Entity("Final_LACOA.Models.Pago", b =>
                {
                    b.HasOne("Final_LACOA.Models.Usuario", "usuario")
                        .WithMany("pagos")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Final_LACOA.Models.PlazoFijo", b =>
                {
                    b.HasOne("Final_LACOA.Models.Usuario", "titular")
                        .WithMany("plazoFijo")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("titular");
                });

            modelBuilder.Entity("Final_LACOA.Models.TarjetaCredito", b =>
                {
                    b.HasOne("Final_LACOA.Models.Usuario", "titular")
                        .WithMany("tarjetas")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("titular");
                });

            modelBuilder.Entity("Final_LACOA.Models.UsuarioCaja", b =>
                {
                    b.HasOne("Final_LACOA.Models.CajaAhorro", "caja")
                        .WithMany("UserCaja")
                        .HasForeignKey("idCaja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_LACOA.Models.Usuario", "usuario")
                        .WithMany("UserCaja")
                        .HasForeignKey("num_usr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("caja");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Final_LACOA.Models.CajaAhorro", b =>
                {
                    b.Navigation("UserCaja");

                    b.Navigation("movimientos");
                });

            modelBuilder.Entity("Final_LACOA.Models.Usuario", b =>
                {
                    b.Navigation("UserCaja");

                    b.Navigation("pagos");

                    b.Navigation("plazoFijo");

                    b.Navigation("tarjetas");
                });
#pragma warning restore 612, 618
        }
    }
}
