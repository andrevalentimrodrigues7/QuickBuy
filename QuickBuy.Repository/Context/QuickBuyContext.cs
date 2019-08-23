using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ValueObject;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    IdFormaPagamento = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de Pagamento Boleto"
                },
                new FormaPagamento()
                {
                    IdFormaPagamento = 2,
                    Nome = "Cartão de Crédito",
                    Descricao = "Forma de Pagamento Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    IdFormaPagamento = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de Pagamento Depósito"
                }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
