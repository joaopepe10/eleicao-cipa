﻿using EleicaoCipa.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipa.Infraestrutura.Data.Mappings;

public class CandidatoMapping : IEntityTypeConfiguration<Candidato>
{
    public void Configure(EntityTypeBuilder<Candidato> builder)
    {
        builder
            .HasKey(candidato => candidato.Id);

        builder.
            Property(candidato => candidato.DataInscricao)
            .HasColumnName("data_inscricao")
            .HasColumnType("datetime")
            .IsRequired();

        builder
            .Property(candidato => candidato.Discurso)
            .HasColumnType("text")
            .IsRequired();

        builder
            .HasOne(candidato => candidato.Usuario)
            .WithMany(usuario => usuario.Candidatos)
            .HasForeignKey(candidato => candidato.UsuarioId);
    }
}
