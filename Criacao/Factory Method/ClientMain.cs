using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    /// <summary>
    /// Definir uma interface para criar um objeto, mas deixar as subclasses decidirem que classe instanciar.
    /// O Factory Method permite adiar a instanciação para subclasses.
    /// </summary>
    public class ClientMain
    {
       public/* static*/ void Main(string[] args)
        {
            var fabricaFiat = new FabricaCarroFiat();
            for (int i = 0; i < 6; i++)
            {
                var carro = fabricaFiat.NovoCarro();
                fabricaFiat.ColocaRodaAro(13 + i);
                Console.WriteLine($"{carro.Nome} roda {carro.tamanhoAroRoda}");
            }

            Console.ReadKey();
        }
    }
}
