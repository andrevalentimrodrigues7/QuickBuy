using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.IdPedido);

            builder.Property(p => p.DataPedido)
                   .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                   .IsRequired();

            builder.Property(p => p.CEP)
                   .IsRequired()
                   .HasMaxLength(12);

            builder.Property(p => p.Estado)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.Cidade)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.EnderecoCompleto)
                   .IsRequired()
                   .HasMaxLength(120);

            builder.Property(p => p.NumeroEndereco)
                   .IsRequired()
                   .HasMaxLength(10);
        }
    }
}
