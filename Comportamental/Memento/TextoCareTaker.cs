using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Memento
{
    public class TextoCareTaker
    {
        protected List<TextoMemento> estados;

        public TextoCareTaker()
        {
            estados = new List<TextoMemento>();
        }

        public void AdicionarMomento(TextoMemento textMemento)
        {
            estados.Add(textMemento);
        }

        public TextoMemento ObtenhaUltimoEstado()
        {
            if (estados.Count <= 0)
                return new TextoMemento("");

            TextoMemento estadoSalvo = estados[estados.Count - 1];
            estados.RemoveAt(estados.Count - 1);
            return estadoSalvo;
        }
    }
}
