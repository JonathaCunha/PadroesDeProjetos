using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    public class Chocolate : CafeDecorator
    {
        public Chocolate(Bebida bebida) : base(bebida)
        {
        }

        public override string Nome => base.Nome + " Com Chocolate";
        public override decimal Preco => base.Preco + 0.3M;
    }
}
