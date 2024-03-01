using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipa.Data.Configurations;

public class ConfigurationEleicao : IEntityTypeConfiguration<Eleicao>
{
    public void Configure(EntityTypeBuilder<Eleicao> builder)
    {
        builder
            .HasKey(eleicao => eleicao.Id);

        builder
            .Property(eleicao => eleicao.DataInicio)
            .HasColumnType("datetime")
            .IsRequired();

        builder
            .Property(eleicao => eleicao.DataFim)
            .HasColumnType("datetime")
            .IsRequired();

        builder
            .Property(eleicao => eleicao.Status)
            .HasColumnType("tinyint")
            .IsRequired();

        builder
            .HasMany(eleicao => eleicao.Candidatos)
            .WithOne(candidato => candidato.Eleicao)
            .HasForeignKey(eleicao => eleicao.EleicaoId);
    }
}
