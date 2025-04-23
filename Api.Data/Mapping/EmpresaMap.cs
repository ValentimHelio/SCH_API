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
               .HasMaxLength(100)
               .HasColumnName("nome_empresa");

        builder.Property(e => e.Fone)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("fone");

        builder.Property(e => e.Cpf)
               .IsRequired()
               .HasMaxLength(14)
               .HasColumnName("cpf");

        builder.Property(e => e.EnderecoId)
               .HasColumnName("endereco_id");

        builder.HasOne(e => e.Endereco)
               .WithMany()
               .HasForeignKey(e => e.EnderecoId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
