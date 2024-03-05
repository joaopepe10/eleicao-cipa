using EleicaoCipa.Data.Configurations;
using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipa.Data;

public class EleicaoContext : DbContext
{
    public EleicaoContext(DbContextOptions<EleicaoContext> opts) : base(opts) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<Eleicao> Eleicoes { get; set; }
}
