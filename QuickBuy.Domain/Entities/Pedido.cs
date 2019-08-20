using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Um pedido deve ter pelo menos um item de pedido 
        /// ou muitos Itens de Pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
            {
                AdicionarMensagemValidacao("Alerta - O pedido deve conter pelo menos um item");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagemValidacao("Alerta - O CEP deve estar preenchido");
            }
            if (FormaPagamentoId == 0)
            {
                AdicionarMensagemValidacao("Alerta - Forma de Pagamento não informada");
            }

        }
    }
}
