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

        builder.Property(c => c.Nome)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("nome");

        builder.Property(c => c.CpfCnpj)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("cpf_cnpj");

        builder.Property(c => c.Telefone)
               .HasMaxLength(20)
               .HasColumnName("telefone");

        builder.Property(c => c.Email)
               .HasMaxLength(100)
               .HasColumnName("email");

        builder.Property(c => c.EnderecoId)
               .HasColumnName("endereco_id");

        builder.HasOne(c => c.Endereco)
               .WithMany()
               .HasForeignKey(c => c.EnderecoId);
    }
}
