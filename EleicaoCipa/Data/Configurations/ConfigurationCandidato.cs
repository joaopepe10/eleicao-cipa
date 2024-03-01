using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipa.Data.Configurations;

public class ConfigurationCandidato : IEntityTypeConfiguration<Candidato>
{
    public void Configure(EntityTypeBuilder<Candidato> builder)
    {
        builder
            .HasKey(candidato => candidato.Id);

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
