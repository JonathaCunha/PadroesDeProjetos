using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    public class CafeDecorator : Bebida
    {
        public Bebida Bebida { get; set; }
        public CafeDecorator(Bebida bebida)
        {
            Bebida = bebida;
        }

        public override string Nome => Bebida.Nome;
        public override decimal Preco => Bebida.Preco;
    }
}
