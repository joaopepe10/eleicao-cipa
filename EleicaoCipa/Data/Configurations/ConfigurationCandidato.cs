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
            .HasOne(candidato => candidato.Usuario)
            .WithOne(usuario => usuario.Candidato)
            .HasForeignKey<Candidato>(candidato => candidato.UsuarioId);
    }
}
