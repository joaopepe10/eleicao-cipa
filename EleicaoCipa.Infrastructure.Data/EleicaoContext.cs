using EleicaoCipa.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EleicaoCipa.Infraestrutura.Data;

public class EleicaoContext : DbContext
{
    public EleicaoContext(DbContextOptions<EleicaoContext> opts) : base(opts) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString("EleicaoConnection");


        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<Eleicao> Eleicoes { get; set; }
    public DbSet<Voto> Votos { get; set; }
}
