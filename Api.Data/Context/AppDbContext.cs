using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<UserEntitiy> Users { get; set; }
    public DbSet<ClienteEntity> Clientes { get; set; }
    public DbSet<EmpresaEntity> Empresas { get; set; }
    public DbSet<MovimentoEntity> Movimentos { get; set; }
    public DbSet<ServicoEntity> Servicos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserEntitiy>(new UserMap().Configure);
        modelBuilder.Entity<ClienteEntity>(new ClienteMap().Configure);
        modelBuilder.Entity<EmpresaEntity>(new EmpresaMap().Configure);
        modelBuilder.Entity<MovimentoEntity>(new MovimentoMap().Configure);
        modelBuilder.Entity<ServicoEntity>(new ServicoMap().Configure);
        modelBuilder.Entity<EstadoEntity>(new EstadoMap().Configure);
        modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
        modelBuilder.Entity<EnderecoEntity>(new EnderecoMap().Configure);
    }
}
