using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.Descricao)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(p => p.Valor)
                   .IsRequired();
        }
    }
}
