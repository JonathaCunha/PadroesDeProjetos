using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Memento
{
    public class TextoMemento
    {
        protected string momentoTexto;
        public TextoMemento(string texto)
        {
            momentoTexto = texto;
        }

        public string ObtenhaMomento()
        {
            return momentoTexto;
        }
    }
}
