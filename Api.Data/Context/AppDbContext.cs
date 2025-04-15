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
    }
}
