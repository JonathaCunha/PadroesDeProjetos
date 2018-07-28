using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Composite
{
    public abstract class Elemento
    {
        public Elemento(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj)
        {
            var elemento2 = obj as Elemento;
            return Nome.Equals(elemento2.Nome) && Date.Equals(elemento2.Date);
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }
}
