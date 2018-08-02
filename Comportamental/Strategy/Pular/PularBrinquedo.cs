using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class PularBrinquedo : PularStrategy
    {
        public void Pular()
        {
            Console.WriteLine("Sou um brinquedo não consigo pular");
        }
    }
}
