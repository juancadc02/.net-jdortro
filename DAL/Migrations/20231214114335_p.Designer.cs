﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(gestorDbContext))]
    [Migration("20231214114335_p")]
    partial class p
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Modelos.Elemento", b =>
                {
                    b.Property<long>("idElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("idElemento"));

                    b.Property<int>("cantidadElemento")
                        .HasColumnType("integer");

                    b.Property<string>("codigoElemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descripcionElemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombreElemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idElemento");

                    b.ToTable("Elementos");
                });

            modelBuilder.Entity("DAL.Modelos.Reserva", b =>
                {
                    b.Property<long>("idReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("idReserva"));

                    b.Property<DateTime>("fchReserva")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("idReserva");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ElementoReserva", b =>
                {
                    b.Property<long>("ElementoidElemento")
                        .HasColumnType("bigint");

                    b.Property<long>("ReservasidReserva")
                        .HasColumnType("bigint");

                    b.HasKey("ElementoidElemento", "ReservasidReserva");

                    b.HasIndex("ReservasidReserva");

                    b.ToTable("Rel_Elemento_Reservas", (string)null);
                });

            modelBuilder.Entity("ElementoReserva", b =>
                {
                    b.HasOne("DAL.Modelos.Elemento", null)
                        .WithMany()
                        .HasForeignKey("ElementoidElemento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Modelos.Reserva", null)
                        .WithMany()
                        .HasForeignKey("ReservasidReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
