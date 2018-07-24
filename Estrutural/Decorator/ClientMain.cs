using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Decorator
{
    class ClientMain
    {
        public static void Main(string[] args)
        {
            Bebida bebida = new CafeExpresso();
            bebida = new Leite(bebida);
            bebida = new Chocolate(bebida);

            Console.WriteLine(bebida.Nome);
            Console.WriteLine(bebida.Preco);

            Bebida bebidaTradicional = new CafeTradicional();
            bebidaTradicional = new Leite(bebidaTradicional);
            Console.WriteLine(bebidaTradicional.Nome);
            Console.WriteLine(bebidaTradicional.Preco);
            bebidaTradicional = new Chocolate(bebidaTradicional);

            Console.WriteLine(bebidaTradicional.Nome);
            Console.WriteLine(bebidaTradicional.Preco);

            Console.ReadKey();



        }
    }
}
