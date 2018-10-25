using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Outros.Interpreter
{
    public abstract class Interpretador
    {
        protected IDictionary<string, string> traducoes;
        public string Idioma { get; private set; }

        public Interpretador(string idioma)
        {
            Idioma = idioma;
            traducoes = new Dictionary<string, string>();
            traducoes.Add(",", ",");
        }

        public virtual string Iterprete(string palavra)
        {
            var traducao = traducoes
                .FirstOrDefault(m => m.Key.Equals(palavra, StringComparison.OrdinalIgnoreCase));
            return string.IsNullOrWhiteSpace(traducao.Value) ? "#" : traducao.Value;

        }
    }
}
