using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Visitor
{
    public class MinhaLista
    {
        public IEnumerable<int> ListaNumerica { get; set; }
        public IEnumerable<string> ListaAlfabetica { get; set; }

        public MinhaLista()
        {
            ListaNumerica = new int[] { 3, 1, 4, 6, 2, 5 };
            ListaAlfabetica = new string[] { "Beatriz", "Ana", "Suele", "Carla", "Jonatha", "João" };
        }

        public void AceiteVisita(VisitorOrdenacao visitor)
        {
            visitor.Visite(this);
        }
    }
}
