using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Chain_of_Responsibility
{
    public class DescontoPorValor : Desconto
    {
        public override decimal Calcular(Pedido pedido)
        {
           if(pedido.Valor >= 1000)
                return 10;

            return (proximo ?? new SemDesconto()).Calcular(pedido);
        }
    }
}
