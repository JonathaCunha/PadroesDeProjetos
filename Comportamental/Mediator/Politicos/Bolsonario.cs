using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    public class Bolsonario : Politico
    {
        public Bolsonario() 
            : base("Bolsonario")
        {
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"Bolsonario recebeu {mensagem}");
        }
    }
}
