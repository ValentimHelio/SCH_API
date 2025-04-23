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
               .HasMaxLength(100)
               .HasColumnName("logradouro");

        builder.Property(e => e.Numero)
               .IsRequired()
               .HasMaxLength(10)
               .HasColumnName("numero");

        builder.Property(e => e.Complemento)
               .HasMaxLength(50)
               .HasColumnName("complemento");

        builder.Property(e => e.Cep)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("cep");

        builder.Property(e => e.EstadoId)
               .HasColumnName("estado_id");

        builder.HasOne(e => e.Estado)
               .WithMany()
               .HasForeignKey(e => e.EstadoId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.MunicipioId)
               .HasColumnName("municipio_id");

        builder.HasOne(e => e.Municipio)
               .WithMany()
               .HasForeignKey(e => e.MunicipioId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
