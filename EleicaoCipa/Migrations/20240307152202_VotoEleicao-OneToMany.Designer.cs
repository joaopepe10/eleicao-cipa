﻿// <auto-generated />
using System;
using EleicaoCipaVotacao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EleicaoCipa.Migrations
{
    [DbContext(typeof(EleicaoContext))]
    [Migration("20240307152202_VotoEleicao-OneToMany")]
    partial class VotoEleicaoOneToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EleicaoCipa.Model.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInscricao")
                        .HasColumnType("datetime")
                        .HasColumnName("data_inscricao");

                    b.Property<string>("Discurso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EleicaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EleicaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Eleicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime")
                        .HasColumnName("data_fim");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime")
                        .HasColumnName("data_inicio");

                    b.Property<sbyte>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("Eleicoes");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Voto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVoto")
                        .HasColumnType("datetime")
                        .HasColumnName("data_voto");

                    b.Property<int>("EleicaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EleicaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Votos");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Candidato", b =>
                {
                    b.HasOne("EleicaoCipa.Model.Eleicao", "Eleicao")
                        .WithMany("Candidatos")
                        .HasForeignKey("EleicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleicaoCipa.Model.Usuario", "Usuario")
                        .WithMany("Candidatos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eleicao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Voto", b =>
                {
                    b.HasOne("EleicaoCipa.Model.Eleicao", "Eleicao")
                        .WithMany("Votos")
                        .HasForeignKey("EleicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleicaoCipa.Model.Usuario", "Usuario")
                        .WithMany("Votos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eleicao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Eleicao", b =>
                {
                    b.Navigation("Candidatos");

                    b.Navigation("Votos");
                });

            modelBuilder.Entity("EleicaoCipa.Model.Usuario", b =>
                {
                    b.Navigation("Candidatos");

                    b.Navigation("Votos");
                });
#pragma warning restore 612, 618
        }
    }
}
