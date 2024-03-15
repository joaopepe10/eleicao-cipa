using EleicaoCipa.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipa.Infraestrutura.Data.Mappings;

public class VotoMapping : IEntityTypeConfiguration<Voto>
{
    public void Configure(EntityTypeBuilder<Voto> builder)
    {
        builder
            .HasKey(voto => voto.Id);

        builder
            .Property(voto => voto.DataVoto)
            .HasColumnName("data_voto")
            .HasColumnType("datetime")
            .HasDefaultValueSql("now()")
            .IsRequired();

        builder
            .HasOne(voto => voto.Usuario)
            .WithMany(usuario => usuario.Votos)
            .HasForeignKey(voto => voto.UsuarioId);

        builder
            .HasOne(voto => voto.Eleicao)
            .WithMany(eleicao => eleicao.Votos)
            .HasForeignKey(voto => voto.EleicaoId);

    }
}
