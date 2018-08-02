using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class PularAlto : PularStrategy
    {
        public void Pular()
        {
            Console.WriteLine("Pulo alto e objetivo.");
        }
    }
}
