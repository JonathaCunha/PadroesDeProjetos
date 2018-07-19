using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Especificar tipos de objetos a serem criados usando uma instância protótipo e criar novos objetos pela cópia desse protótipo.
/// </summary>
namespace Criacao.Prototype
{
    public class PrototypeDemo : ICloneable
    {
        public int Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public PrototypeSimples ParteObjetoClona { get; set; }
        public PrototypeSimples ParteObjetoManterRef { get; set; }

        public object Clone()
        {
            var clone = (PrototypeDemo)this.MemberwiseClone();

            clone.ParteObjetoClona = (PrototypeSimples)this.ParteObjetoClona.Clone();
            clone.ParteObjetoManterRef = this.ParteObjetoManterRef;

            return clone;
        }
    }
}
