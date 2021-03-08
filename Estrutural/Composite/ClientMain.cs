using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Compor objetos em estruturas de árvore para representar hierarquia partes-todo.
/// Composite permite aos clientes tratarem de maneira uniforme objetos individuais e composições de objetos
/// </summary>
namespace Estrutural.Composite
{
    class ClientMain
    {
        public static void Main(string[] args)
        {
            var elementoRaiz = new ElementoComposto("Raiz");
            elementoRaiz.AdicionarElemento(new Folha("Folha 1"));

            var elementoComposto = new ElementoComposto("Elemento Composto");
            elementoComposto.AdicionarElemento(new Folha("Folha 2"));
            elementoRaiz.AdicionarElemento(elementoComposto);
        }

    }
}
