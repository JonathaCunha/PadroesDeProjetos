using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class Leao : Felino
    {
        public Leao()
        {
            CorrerEstrategia = new CorrerCurtaDistancia();
            PularEstrategia = new PularAlto();
        }
        public override void Display()
        {
            Console.WriteLine("Sou um Leão Feroiz");
        }
    }
}
