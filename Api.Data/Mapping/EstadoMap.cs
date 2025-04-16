using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EstadoMap : IEntityTypeConfiguration<EstadoEntity>
    {
        public void Configure(EntityTypeBuilder<EstadoEntity> builder)
        {
            builder.ToTable("estado");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Uf)
                .IsRequired()
                .HasMaxLength(2);

            builder.HasMany(e => e.Municipios)
                .WithOne(m => m.Estado)
                .HasForeignKey(m => m.EstadoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
