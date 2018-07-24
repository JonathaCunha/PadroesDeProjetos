using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    public class CafeTradicional : Bebida
    {
        public override string Nome => "Café Tradicional";
        public override decimal Preco => 2;
    }
}
