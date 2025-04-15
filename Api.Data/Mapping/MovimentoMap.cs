using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class MovimentoMap : IEntityTypeConfiguration<MovimentoEntity>
    {
        public void Configure(EntityTypeBuilder<MovimentoEntity> builder)
        {
            builder.ToTable("movimento");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.ClienteId)
                .IsRequired();

            builder.Property(m => m.ServicoId)
                .IsRequired();

            builder.Property(m => m.Data)
                .IsRequired();

            builder.Property(m => m.Valor_Hora)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.HasOne(m => m.Cliente)
                .WithMany()
                .HasForeignKey(m => m.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Servico)
                .WithMany()
                .HasForeignKey(m => m.ServicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
