using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class Leopardo : Felino
    {
        public Leopardo()
        {
            CorrerEstrategia = new CorrerLongaDistancia();
            PularEstrategia = new PularAlto();
        }

        public override void Display()
        {
            Console.WriteLine("Sou um Leopardo Veloz");
        }
    }
}
