using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Prototype
{
    public class PrototypeDemo2
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public object Clone()
        {
            return new PrototypeDemo2()
            {
                Nome = this.Nome,
                Quantidade = this.Quantidade,
            };
        }
    }
}
