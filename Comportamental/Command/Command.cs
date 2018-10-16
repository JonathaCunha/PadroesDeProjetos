using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Command
{
    public interface Command
    {
        void Executar(string mensagem);
        void Desfazer();
    }
}
