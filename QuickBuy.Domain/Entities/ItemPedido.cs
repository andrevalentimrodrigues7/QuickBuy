using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class ItemPedido : Entidade
    {
        public int IdItemPedido { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (IdProduto <= 0)
            {
                AdicionarMensagemValidacao("Alerta - Não foi encontrado a referência do produto");
            }
            if (Quantidade <= 0)
            {
                AdicionarMensagemValidacao("Alerta - Deve conter pelo menos 1 item");
            }
        }
    }
}
