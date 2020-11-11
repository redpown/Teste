﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteDev.Repository.Contexto;

namespace TesteDev.Repository.Migrations
{
    [DbContext(typeof(TesteDevContexto))]
    [Migration("20201109162736_v002")]
    partial class v002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteDev.Entidades.Ingredientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ingrediente")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Ingredientes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ingrediente = "Alface",
                            quantidade = 0,
                            tipo = "1",
                            valor = 0.40m
                        },
                        new
                        {
                            id = 2,
                            ingrediente = "Bacon",
                            quantidade = 0,
                            tipo = "2",
                            valor = 2.00m
                        },
                        new
                        {
                            id = 3,
                            ingrediente = "Hambúrguer de carne",
                            quantidade = 0,
                            tipo = "3",
                            valor = 3.00m
                        },
                        new
                        {
                            id = 4,
                            ingrediente = "Ovo",
                            quantidade = 0,
                            tipo = "4",
                            valor = 0.80m
                        },
                        new
                        {
                            id = 5,
                            ingrediente = "Queijo",
                            quantidade = 0,
                            tipo = "5",
                            valor = 1.50m
                        });
                });

            modelBuilder.Entity("TesteDev.Entidades.Lanches", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ingrediente")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("lanche")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Lanches");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ingrediente = "Hambúrguer de carne e queijo",
                            lanche = "X-Burger",
                            quantidade = 0,
                            valor = 4.50m
                        },
                        new
                        {
                            id = 2,
                            ingrediente = "Hambúrguer de carne , queijo e Ovo",
                            lanche = "X-Egg",
                            quantidade = 0,
                            valor = 5.30m
                        },
                        new
                        {
                            id = 3,
                            ingrediente = "Hambúrguer de carne , queijo ,Ovo e bacon",
                            lanche = "X-Egg Bacon",
                            quantidade = 0,
                            valor = 7.30m
                        },
                        new
                        {
                            id = 4,
                            ingrediente = "Hambúrguer de carne , queijo , bacon",
                            lanche = "X-Bacon",
                            quantidade = 0,
                            valor = 6.50m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
