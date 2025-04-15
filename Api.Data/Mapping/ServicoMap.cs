using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class ServicoMap : IEntityTypeConfiguration<ServicoEntity>
{
    public void Configure(EntityTypeBuilder<ServicoEntity> builder)
    {
        builder.ToTable("servico");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Descricao)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Tipo)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(s => s.EmpresaId)
            .IsRequired();

        builder.HasOne(s => s.Empresa)
            .WithMany()
            .HasForeignKey(s => s.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
