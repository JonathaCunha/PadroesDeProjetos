using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer
{
    public class Observador2 : ObservadorAbstrato
    {
        public Observador2(Observada observada) 
            : base(observada)
        {
        }
        public override void Notifique()
        {
            Console.WriteLine($"Observador 2 Notificado - alteração {Observada.Numero}");
        }
    }
}
