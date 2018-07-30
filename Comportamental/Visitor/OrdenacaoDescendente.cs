using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comportamental.Visitor
{
    class OrdenacaoDescendente : VisitorOrdenacao
    {
        public override void Visite(MinhaLista minhaLista)
        {
            minhaLista.ListaAlfabetica = minhaLista.ListaAlfabetica.OrderByDescending(m => m);
            minhaLista.ListaNumerica = minhaLista.ListaNumerica.OrderByDescending(m => m);
        }
    }
}