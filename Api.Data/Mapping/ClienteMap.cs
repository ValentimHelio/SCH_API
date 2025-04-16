using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class ClienteMap : IEntityTypeConfiguration<ClienteEntity>
{
    public void Configure(EntityTypeBuilder<ClienteEntity> builder)
    {
        builder.ToTable("cliente");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.NomeCliente).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Fone).IsRequired().HasMaxLength(20);
        builder.Property(c => c.Cpf).IsRequired().HasMaxLength(14);

        builder.OwnsOne(c => c.Endereco, endereco =>
        {
            endereco.Property(e => e.Logradouro).IsRequired().HasMaxLength(100).HasColumnName("logradouro");
            endereco.Property(e => e.Cep).IsRequired().HasMaxLength(20).HasColumnName("cep");

            endereco.Property(e => e.EstadoId).HasColumnName("estado_id");
            endereco.HasOne(e => e.Estado)
                .WithMany()
                .HasForeignKey("estado_id");

            endereco.Property(e => e.MunicipioId).HasColumnName("municipio_id");
            endereco.HasOne(e => e.Municipio)
                .WithMany()
                .HasForeignKey("municipio_id");
        });
    }
}
