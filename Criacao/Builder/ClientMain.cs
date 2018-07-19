using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class ClientMain
    {
        public static void Main(string[] args)
        {
            CriarGuerreiro(new ConcreteBuilderMedieval());
            CriarGuerreiro(new ConcreteBuilderDoFuturo());

            Console.WriteLine("Usando Fluent");
            var perfilMedievalFluent = new ConcreteBuilderMedievalFluent();

            var distribuidoDeArmasFluent = new DirectorGuerreiroFluent();
            distribuidoDeArmasFluent.CarregarItensBasico(perfilMedievalFluent);
            perfilMedievalFluent.ObtenhaGuerreiro();

            perfilMedievalFluent.AdicionarEscudoMagico();
            perfilMedievalFluent.ObtenhaGuerreiro();

            distribuidoDeArmasFluent.CarregarItensProtecaoContraAtaque(perfilMedievalFluent);
            perfilMedievalFluent.ObtenhaGuerreiro();

            Console.Read();
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
