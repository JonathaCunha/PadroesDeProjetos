using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comportamental.Visitor
{
    public class OrdenacaoCrescente : VisitorOrdenacao
    {
        public override void Visite(MinhaLista minhaLista)
        {
            minhaLista.ListaAlfabetica = minhaLista.ListaAlfabetica.OrderBy(m => m);
            minhaLista.ListaNumerica = minhaLista.ListaNumerica.OrderBy(m => m);
        }
    }
}
