using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Command
{
    public class GerenciadoMensagem
    {
        protected List<Command> commads;
        public GerenciadoMensagem()
        {
            commads = new List<Command>();
        }

        public void AdicionarComando(Command comandoEnvioMensagem)
        {
            commads.Add(comandoEnvioMensagem);
        }

        public void EnviarMensageParaTodos(string mensagem)
        {
            foreach (var command in commads)
            {
                command.Executar(mensagem);
            }
        }
    }
}
