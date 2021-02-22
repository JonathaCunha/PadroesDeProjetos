using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Memento
{
    public class TextoCareTaker
    {
        protected List<string> estados;

        public TextoCareTaker()
        {
            estados = new List<string>();
        }

        public void AdicionarMomento(string textMemento)
        {
            estados.Add(textMemento);
        }

        public string ObtenhaUltimoEstado()
        {
            if (estados.Count <= 0)
                return string.Empty;

            string estadoSalvo = estados[estados.Count - 1];
            estados.RemoveAt(estados.Count - 1);
            return estadoSalvo;
        }
    }
}
