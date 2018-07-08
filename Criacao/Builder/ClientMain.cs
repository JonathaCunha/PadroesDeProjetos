using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class ClientMain
    {
        public static void Main(string[] args)
        {
            var guerreiroMedieval = new ConcreteBuilderMedieval();
            var guerreiroFuturo = new ConcreteBuilderDoFuturo();

            var fase = new DirectorFortalecerGuerreiroFluent();
            fase.ComeMaca(guerreiroMedieval);
            fase.ComeBanana(guerreiroMedieval);

            fase.ComeMaca(guerreiroFuturo);
            fase.ComeBanana(guerreiroFuturo);

            guerreiroMedieval.Pontuacao();
            guerreiroFuturo.Pontuacao();

            fase.ComeMaca(guerreiroFuturo);
            fase.ComeBanana(guerreiroFuturo);
            fase.ComeMaca(guerreiroMedieval);
            fase.ComeBanana(guerreiroMedieval);

            guerreiroMedieval.Pontuacao();
            guerreiroFuturo.Pontuacao();

            Console.Read();
        }
    }
}
