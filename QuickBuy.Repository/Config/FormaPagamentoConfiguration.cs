using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.IdFormaPagamento);

            builder.Property(f => f.Nome)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(f => f.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
