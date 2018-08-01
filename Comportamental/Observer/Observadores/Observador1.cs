using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer
{
    public class Observador1 : ObservadorAbstrato
    {
        public Observador1(Observada observada) : base(observada)
        {
        }
        public override void Notifique()
        {
            Console.WriteLine($"Observador 1 Notificado - alteração {Observada.Numero}");
        }
    }
}
