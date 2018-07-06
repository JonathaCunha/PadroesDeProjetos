using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    public class ClientMain
    {
       public/* static*/ void Main(string[] args)
        {
            var fabricaFiat = new FabricaCarroFiat();
            for (int i = 0; i < 6; i++)
            {
                var carro = fabricaFiat.NovoCarro();
                fabricaFiat.ColocaRodaAro(13 + i);
                Console.WriteLine($"{carro.Nome} {carro.NomeMotorEPotencia} roda {carro.tamanhoAroRoda}");
            }

            Console.ReadKey();
        }
    }
}
