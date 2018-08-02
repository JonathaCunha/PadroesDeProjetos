using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public class TigreDeBriquedo : Felino
    {
        public TigreDeBriquedo()
        {
            CorrerEstrategia = new CorrerBrinquendo();
            PularEstrategia = new PularBrinquedo();
        }

        public override void Display()
        {
            Console.WriteLine("Sou um Briquedo bonitinho");
        }
    }
}
