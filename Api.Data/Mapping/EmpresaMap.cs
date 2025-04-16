using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class EmpresaMap : IEntityTypeConfiguration<EmpresaEntity>
{
    public void Configure(EntityTypeBuilder<EmpresaEntity> builder)
    {
        builder.ToTable("empresa");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.NomeEmpresa)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Fone)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(e => e.Cpf)
               .IsRequired()
               .HasMaxLength(14);

        builder.OwnsOne(e => e.Endereco, endereco =>
        {
            endereco.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("logradouro");

            endereco.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("cep");

            endereco.Property(e => e.EstadoId)
                    .HasColumnName("estado_id");

            endereco.HasOne(e => e.Estado)
                    .WithMany()
                    .HasForeignKey("estado_id");

            endereco.Property(e => e.MunicipioId)
                    .HasColumnName("municipio_id");

            endereco.HasOne(e => e.Municipio)
                    .WithMany()
                    .HasForeignKey("municipio_id");
        });
    }
}
