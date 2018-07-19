using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class BuilderGuerreiroMedievalFluent : BuilderGuerreiroFluent
    {
        public BuilderGuerreiroMedievalFluent()
        {
            Guerreiro.Tipo = "Medieval";
        }
        public override BuilderGuerreiroFluent AdicionarEscudo()
        {
            Guerreiro.AdicionarEscudo("Escudo Medieval");
            return this;
        }

        public BuilderGuerreiroFluent AdicionarEscudoMagico()
        {
            Guerreiro.AdicionarEscudo("Escudo Magíco");
            return this;
        }

        public override BuilderGuerreiroFluent AdicionarEspada()
        {
            Guerreiro.AdicionarEspada("Espada Medieval");
            return this;
        }

        public override BuilderGuerreiroFluent AdicionarFlecha()
        {
            Guerreiro.AdicionarFlecha("Flecha Medieval");
            return this;
        }
    }
}
