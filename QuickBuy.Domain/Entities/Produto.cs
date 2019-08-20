using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Produto : Entidade
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagemValidacao("Alerta - O Nome do Produto não pode ficar em branco");
            }
            if (this.Valor <= 0)
            {
                AdicionarMensagemValidacao("Alerta - O valor deve ser maior que R$ 0,00");
            }
        }
    }
}
