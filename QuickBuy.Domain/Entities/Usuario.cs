using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Usuario : Entidade
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMensagemValidacao("Alerta - Informe um endereço de e-mail");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagemValidacao("Alerta - Informe uma senha");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagemValidacao("Alerta - Por favor, informe o seu nome");
            }
        }
    }
}
