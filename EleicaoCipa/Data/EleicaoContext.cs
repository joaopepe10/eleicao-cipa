using EleicaoCipa.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipaVotacao.Data;

public class EleicaoContext : DbContext
{
    public EleicaoContext(DbContextOptions<EleicaoContext> opts) : base(opts) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<Eleicao> Eleicoes { get; set; }
    public DbSet<Voto> Votos { get; set; }
}
