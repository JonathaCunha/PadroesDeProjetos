using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Interpreter
{
    public class PalavraTraduzida
    {
        public PalavraTraduzida(string idioma,string traducao)
        {
            Idioma = idioma;
            Traducao = traducao;
        }
        public string Idioma { get; private set; }
        public string Traducao { get; private set; }
    }
}
