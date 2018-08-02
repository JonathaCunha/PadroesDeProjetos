using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class CorrerCurtaDistancia : CorrerStrategy
    {
        public void Correr()
        {
            Console.WriteLine("Correr curta distância, porém com o objetivo bem próximo.");
        }
    }
}
