using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Interator
{

    /// <summary>
    /// Fornecer um meio de acessar, sequencialmente, 
    /// os elementos de um objeto agregado sem expor sua representação subjacente
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] agrs)
        {
            Console.WriteLine("---- Canais de Filmes ----");
            var canaisFilmes = new CanaisDeFilme();
            Interator iterator = canaisFilmes.CrieInterator();
            for (; iterator.HasValue(); iterator.Next())
            {
                Console.WriteLine(iterator.CurrentItem().Nome);
            }

            Console.WriteLine("---- Canais de Esporte ----");
            var canaisEsportes = new CanaisDeEsporte();
            Interator iteratorEsporte = canaisEsportes.CrieInterator();
            for (; iteratorEsporte.HasValue(); iteratorEsporte.Next())
            {
                Console.WriteLine(iteratorEsporte.CurrentItem().Nome);
            }

            Console.ReadKey();
        }
    }
}
