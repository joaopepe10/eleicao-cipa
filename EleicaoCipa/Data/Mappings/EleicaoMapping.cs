using EleicaoCipa.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipaVotacao.Data.Mappings;

public class EleicaoMapping : IEntityTypeConfiguration<Eleicao>
{
    public void Configure(EntityTypeBuilder<Eleicao> builder)
    {
        builder
            .HasKey(eleicao => eleicao.Id);

        builder
            .Property(eleicao => eleicao.DataInicio)
            .HasColumnName("data_inicio")
            .HasColumnType("datetime")
            .IsRequired();

        builder
            .Property(eleicao => eleicao.DataFim)
            .HasColumnName("data_fim")
            .HasColumnType("datetime")
            .IsRequired();

        builder
            .Property(eleicao => eleicao.Status)
            .HasColumnName("status")
            .HasColumnType("tinyint")
            .IsRequired();

        builder
            .HasMany(eleicao => eleicao.Candidatos)
            .WithOne(candidato => candidato.Eleicao)
            .HasForeignKey(candidato => candidato.EleicaoId);

    }
}
