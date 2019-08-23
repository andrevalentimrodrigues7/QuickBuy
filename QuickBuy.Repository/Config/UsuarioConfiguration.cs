using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.IdUsuario);

            builder.Property(u => u.Nome)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(u => u.Sobrenome)
                   .IsRequired()
                   .HasMaxLength(70);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(u => u.Senha)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasMany(u => u.Pedidos)
                   .WithOne(p => p.Usuario);
        }
    }
}
