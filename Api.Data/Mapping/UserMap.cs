using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntitiy>
    {
        public void Configure(EntityTypeBuilder<UserEntitiy> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(60);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Email).HasMaxLength(100);
        }
    }
}
