using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    public class Haddad : Politico
    {
        public Haddad()
            : base("Haddad")
        {
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"Haddad recebeu {mensagem}");
        }
    }
}
