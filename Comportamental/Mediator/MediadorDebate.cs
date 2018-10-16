using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    public abstract class MediadorDebate
    {
        public abstract void EnviarMensagem(string mensagem, Politico usuario);
    }
}
