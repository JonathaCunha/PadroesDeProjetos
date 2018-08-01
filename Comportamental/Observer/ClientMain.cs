using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Definir uma dependência um para muitos entre objetos, 
/// de maneira que quando um objeto muda de estado todos os seus dependentes são notificados e atualizados automaticamente
/// </summary>
namespace Comportamental.Observer
{
    public class ClientMain
    {
        public static void Main(string[] args)
        {
            var observada = new Observada();
            observada.AdicioneObservador(new Observador1(observada));
            observada.AdicioneObservador(new Observador2(observada));
            observada.AlterarNumero(820);


            observada.RemovaObservador(1);
            observada.AlterarNumero(3209);

            Console.ReadKey();
        }
    }
}
