using EleicaoCipa.Data.Configurations;
using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipa.Data;

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
}
