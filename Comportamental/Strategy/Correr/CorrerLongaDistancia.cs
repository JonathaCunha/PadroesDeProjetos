using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class CorrerLongaDistancia : CorrerStrategy
    {
        public void Correr()
        {
            Console.WriteLine("Correr longa distância, caso necessário.");
        }
    }
}
