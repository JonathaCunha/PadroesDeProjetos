using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer.VersaoCSharp6
{
    public class Observador4
    {
        public string Nome { get; set; }

        public Observador4(string nome)
        {
            Nome = nome;
        }
        public void Update()
        {
            Console.WriteLine($"Observador 2 notificado. Nome observador {Nome}");
        }
    }
}
