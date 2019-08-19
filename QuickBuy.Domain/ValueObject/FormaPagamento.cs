using QuickBuy.Domain.Enumerables;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ValueObject
{
    public class FormaPagamento
    {
        public int IdFormaPagamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoFoiDefinido
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
