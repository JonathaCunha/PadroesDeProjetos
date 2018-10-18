using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Chain_of_Responsibility
{
    public abstract class Desconto
    {
        protected Desconto proximo;

        public void SetDesconto(Desconto proximoDesconto)
        {
            proximo = proximoDesconto;
        }

       public abstract decimal Calcular(Pedido pedido);
    }
}
