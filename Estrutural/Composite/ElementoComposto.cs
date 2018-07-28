using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Composite
{
    public class ElementoComposto : Elemento
    {
        public ElementoComposto(string nome) : base(nome)
        {
        }

        protected List<Elemento> ListaElementos => new List<Elemento>();

        public void AdicionarElemento(Elemento elemento)
        {
            ListaElementos.Add(elemento);
        }

        public void RemoveElemento(Elemento elemento)
        {
            ListaElementos.Remove(elemento);
        }
    }
}
