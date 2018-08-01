using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Prototype
{
    public class PrototypeSimples : ICloneable
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public object Clone()
        {
            return new PrototypeSimples()
            {
                Nome = this.Nome,
                Quantidade = this.Quantidade,
            };
        }
    }
}
