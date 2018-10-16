using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Command
{
    public class CommandEnviarMensagem : Command
    {
        private CaixaDeMensagem contatoAlvo;
        private DateTime dataEHoraEnvio;
        private string idMensagem;

        public CommandEnviarMensagem(CaixaDeMensagem contato)
        {
            contatoAlvo = contato;
        }

        public void Executar(string mensagem)
        {
            dataEHoraEnvio = DateTime.Now;
            idMensagem = contatoAlvo.ReceberMensagem(mensagem);
        }

        public void Desfazer()
        {
            if(DateTime.Now > dataEHoraEnvio.AddSeconds(20))
            {
                Console.WriteLine($"Tempo de exclusão esgotado 20 segundos: {idMensagem} contato:{contatoAlvo.Nome}");
                return;
            }

            contatoAlvo.ExcluarMensagem(idMensagem);
        }
        
    }
}
