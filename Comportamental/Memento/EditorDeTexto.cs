using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Memento
{
    public class EditorDeTexto
    {
        protected string textoAtual;
        protected TextoCareTaker careTake;

        public EditorDeTexto()
        {
            textoAtual = string.Empty;
            careTake = new TextoCareTaker();
        }

        public void Escreve(string texto)
        {
            careTake.AdicionarMomento(textoAtual);
            textoAtual += texto;
        }

        public void Desfazer()
        {
            textoAtual = careTake.ObtenhaUltimoEstado();
        }

        public string ObtenhaTexto()
        {
            return textoAtual;
        }

    }
}
