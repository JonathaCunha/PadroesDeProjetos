using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    public class Leite : CafeDecorator
    {
        public Leite(Bebida bebida) : base(bebida)
        {
        }

        public override string Nome => base.Nome + " Com Leite";
        public override decimal Preco => base.Preco + 0.6M;
    }
}
