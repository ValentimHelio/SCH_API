using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteEntity>
    {
        public void Configure(EntityTypeBuilder<ClienteEntity> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeCliente)
                .HasColumnName("nomecliente")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnName("endereco")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Uf)
                .HasColumnName("uf")
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(x => x.Cep)
                .HasColumnName("cep")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Fone)
                .HasColumnName("fone")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Cpf)
                .HasColumnName("cpf")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.CreateAt)
                .HasColumnName("create_at")
                .IsRequired();

            builder.Property(x => x.UpdateAt)
                .HasColumnName("update_at")
                .IsRequired(false);
        }
    }
}
