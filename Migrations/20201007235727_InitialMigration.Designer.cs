﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using maximo_P1_A2.Data;

namespace maximo_P1_A2.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201007235727_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("maximo_P1_A2.Models.Productos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("costo")
                        .HasColumnType("REAL");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("existencia")
                        .HasColumnType("INTEGER");

                    b.Property<double>("valorInventario")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
