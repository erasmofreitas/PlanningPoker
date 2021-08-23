﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PlanningPoker.Data.Contexts;

namespace PlanningPoker.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PlanningPoker.Domain.Entities.Cartas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ValorCarta")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cartas");
                });

            modelBuilder.Entity("PlanningPoker.Domain.Entities.Historias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("PlanningPoker.Domain.Entities.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PlanningPoker.Domain.Entities.Votos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CartaId")
                        .HasColumnType("integer");

                    b.Property<int?>("CartasId")
                        .HasColumnType("integer");

                    b.Property<int>("HistoriaId")
                        .HasColumnType("integer");

                    b.Property<int?>("HistoriasId")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CartasId");

                    b.HasIndex("HistoriasId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Votos");
                });

            modelBuilder.Entity("PlanningPoker.Domain.Entities.Votos", b =>
                {
                    b.HasOne("PlanningPoker.Domain.Entities.Cartas", "Cartas")
                        .WithMany()
                        .HasForeignKey("CartasId");

                    b.HasOne("PlanningPoker.Domain.Entities.Historias", "Historias")
                        .WithMany()
                        .HasForeignKey("HistoriasId");

                    b.HasOne("PlanningPoker.Domain.Entities.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuariosId");
                });
#pragma warning restore 612, 618
        }
    }
}
