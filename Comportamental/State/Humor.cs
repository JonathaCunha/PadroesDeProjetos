using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.State
{
    public abstract class Humor
    {
        public Humor(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }

        protected Pessoa Pessoa { get; set; }
        public string Nome { get; set; }
        public abstract void QualSeuNome();
        public abstract void QueCantaUmaMusicaFeliz();
    }
}
