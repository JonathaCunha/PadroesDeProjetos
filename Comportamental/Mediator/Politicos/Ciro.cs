using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    public class Ciro : Politico
    {
        public Ciro()
            : base("Ciro")
        {
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"Ciro recebeu {mensagem}");
        }
    }
}
