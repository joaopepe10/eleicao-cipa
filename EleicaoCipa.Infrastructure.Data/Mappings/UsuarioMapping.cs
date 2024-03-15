using EleicaoCipa.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleicaoCipa.Infraestrutura.Data.Mappings;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder
            .HasKey(usuario => usuario.Id);

        builder
            .Property(usuario => usuario.Nome)
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}