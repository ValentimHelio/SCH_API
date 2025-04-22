using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class EnderecoMap : IEntityTypeConfiguration<EnderecoEntity>
{
    public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
    {
        builder.ToTable("endereco");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Logradouro)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Cep)
               .IsRequired()
               .HasMaxLength(20);

        builder.HasOne(e => e.Estado)
               .WithMany()
               .HasForeignKey(e => e.EstadoId);

        builder.HasOne(e => e.Municipio)
               .WithMany()
               .HasForeignKey(e => e.MunicipioId);
    }
}
