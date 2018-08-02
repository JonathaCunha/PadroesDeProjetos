using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class CorrerBrinquendo : CorrerStrategy
    {
        public void Correr()
        {
            Console.WriteLine("Sou um Brinquedo não consido correr.");
        }
    }
}
