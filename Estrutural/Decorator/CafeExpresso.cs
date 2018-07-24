using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    public class CafeExpresso : Bebida
    {
        public override string Nome => "Café Expresso";
        public override decimal Preco => 3;
    }
}
