using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Chain_of_Responsibility
{
    public class DescontoPorQuantidade : Desconto
    {
        public override decimal Calcular(Pedido pedido)
        {
            if (pedido.QuatidadesItens >= 100)
                return 5;

            return (proximo ?? new SemDesconto()).Calcular(pedido);
        }
    }
}
