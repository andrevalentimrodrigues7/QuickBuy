using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.IdItemPedido);

            builder.Property(i => i.IdProduto)
                   .IsRequired();

            builder.Property(i => i.Quantidade)
                   .IsRequired()
                   .HasMaxLength(14);
        }
    }
}
