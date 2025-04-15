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

        builder.Property(e => e.Endereco)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Cidade)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Uf)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(e => e.Cep)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(e => e.Fone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(e => e.Cpf)
            .IsRequired()
            .HasMaxLength(14);
    }
}
