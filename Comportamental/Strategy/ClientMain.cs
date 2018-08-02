using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiáveis.
/// Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam
/// </summary>
namespace Comportamental.Strategy
{
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            var leao = new Leao();
            leao.Display();
            leao.PerformaceCorrer();
            leao.PerformacePular();

            var leopardo = new Leopardo();
            leopardo.Display();
            leopardo.PerformaceCorrer();
            leopardo.PerformacePular();

            var tigre = new TigreDeBriquedo();
            tigre.Display();
            tigre.PerformaceCorrer();
            tigre.PerformacePular();


            Console.ReadKey();
        }
    }
}
