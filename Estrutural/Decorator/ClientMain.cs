using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Dinamicamente(em tempo de execução), agregar responsabilidades adicionais a objetos.
/// Os Decorators fornecem uma alternativa flexível ao uso de subclasses para extensão de funcionalidades.
/// </summary>
namespace Estrutural.Decorator
{
    class ClientMain
    {
        public /*static*/ void Main(string[] args)
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
