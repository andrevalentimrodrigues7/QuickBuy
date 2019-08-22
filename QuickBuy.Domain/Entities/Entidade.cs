using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void AdicionarMensagemValidacao(string message)
        {
            mensagemValidacao.Add(message);
        }

        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        public abstract void Validate();

        public bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

    }
}
