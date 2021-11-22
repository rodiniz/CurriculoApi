﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace curriculoapi.Migrations
{
    [DbContext(typeof(LiteDbContext))]
    partial class LiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("curriculoapi.Model.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFinal")
                        .HasColumnType("integer");

                    b.Property<int>("AnoInicio")
                        .HasColumnType("integer");

                    b.Property<string>("Atividades")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Atual")
                        .HasColumnType("boolean");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CurriculoId")
                        .HasColumnType("integer");

                    b.Property<int>("MesFinal")
                        .HasColumnType("integer");

                    b.Property<int>("MesInicio")
                        .HasColumnType("integer");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("curriculoapi.Model.Formacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFinal")
                        .HasColumnType("integer");

                    b.Property<int>("AnoInicio")
                        .HasColumnType("integer");

                    b.Property<int>("CurriculoId")
                        .HasColumnType("integer");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeFormacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Formacaos");
                });

            modelBuilder.Entity("curriculoapi.Model.Tecnologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AutoAvaliacao")
                        .HasColumnType("integer");

                    b.Property<int>("CurriculoId")
                        .HasColumnType("integer");

                    b.Property<string>("NomeTecnologia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Tecnologias");
                });

            modelBuilder.Entity("TesteSharepointNovo.Models.Curriculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CargoPretendido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Curriculos");
                });

            modelBuilder.Entity("TesteSharepointNovo.Models.Lingua", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CurriculoId")
                        .HasColumnType("integer");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Fluencia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Linguas");
                });

            modelBuilder.Entity("curriculoapi.Model.Experiencia", b =>
                {
                    b.HasOne("TesteSharepointNovo.Models.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curriculo");
                });

            modelBuilder.Entity("curriculoapi.Model.Formacao", b =>
                {
                    b.HasOne("TesteSharepointNovo.Models.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curriculo");
                });

            modelBuilder.Entity("curriculoapi.Model.Tecnologia", b =>
                {
                    b.HasOne("TesteSharepointNovo.Models.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curriculo");
                });

            modelBuilder.Entity("TesteSharepointNovo.Models.Lingua", b =>
                {
                    b.HasOne("TesteSharepointNovo.Models.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curriculo");
                });
#pragma warning restore 612, 618
        }
    }
}
