using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Separar a construção de um objeto complexo de sua representação
/// de modo que o mesmo processo de construção possa criar diferentes representações.
/// </summary>
namespace Criacao.Builder
{
    public class ClientMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sem Fluent");
            CriarGuerreiro(new BuilderGuerreiroMedieval());
            CriarGuerreiro(new BuilderGuerreiroFuturo());

            Console.WriteLine("Usando Fluent");
            CriarGuerreiro(new BuilderGuerreiroFuturoFluent());
            var guerreiroMedieval = new BuilderGuerreiroMedievalFluent();
            CriarGuerreiro(guerreiroMedieval);

            guerreiroMedieval
                .AdicionarEscudoMagico()
                .ObtenhaGuerreiro();

            Console.Read();
        }

        private static void CriarGuerreiro(BuilderGuerreiroFluent perfil)
        {
            var distribuidoDeArmasFluent = new DirectorGuerreiroFluent();

            distribuidoDeArmasFluent.CarregarItensBasico(perfil);
            perfil.ObtenhaGuerreiro();

            distribuidoDeArmasFluent.CarregarItensProtecaoContraAtaque(perfil);
            perfil.ObtenhaGuerreiro();
        }

        public static void CriarGuerreiro(BuilderGuerreiro perfil)
        {
            var distribuidoDeArmas = new DirectorGuerreiro();

            distribuidoDeArmas.CarregarItensBasico(perfil);
            perfil.ObtenhaGuerreiro();

            distribuidoDeArmas.CarregarItensProtecaoContraAtaque(perfil);
            perfil.ObtenhaGuerreiro();
        }
    }
}
