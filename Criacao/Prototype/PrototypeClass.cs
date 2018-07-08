using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Prototype
{
    public class PrototypeClass : ICloneable
    {
        public int Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public object Clone()
        {
            return new PrototypeClass()
            {
                Valor = this.Valor,
                Quantidade = this.Quantidade,
            };
        }
    }
}
