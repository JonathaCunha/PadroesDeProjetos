using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Comportamental.Command
{
    public class ClientMain
    {
        /// <summary>
        /// Encapsular uma solicitação como objeto,
        /// desta forma permitindo parametrizar cliente com diferentes solicitações,
        /// enfileirar ou fazer o registro de solicitações e suportar operações que podem ser desfeitas.
        /// </summary>
        /// <param name="agrs"></param>
        public static void Main(string[] agrs)
        {
            var caixaMsgAna = new CaixaDeMensagem("Ana");
            var caixaMsgJose = new CaixaDeMensagem("Jose");

            Command commadAna = new CommandEnviarMensagem(caixaMsgAna);
            Command commadJose = new CommandEnviarMensagem(caixaMsgJose);

            var gerenciadoMensagem = new GerenciadoMensagem();
            gerenciadoMensagem.AdicionarComando(commadAna);
            gerenciadoMensagem.AdicionarComando(commadJose);
            gerenciadoMensagem.EnviarMensageParaTodos(" Teste envio mensagem");
            //exemplo podeira ter um outro metodo 
            //no gerenciado enviar para todos contatos que começa com ana etc..

            commadJose.Desfazer();
            Thread.Sleep(21000);
            commadAna.Desfazer();

            Console.ReadKey();
        }
    }
}
