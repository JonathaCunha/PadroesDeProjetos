using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class BuilderGuerreiroFuturoFluent : BuilderGuerreiroFluent
    {
        public BuilderGuerreiroFuturoFluent()
        {
            Guerreiro.Tipo = "Futuro";
        }
        public override BuilderGuerreiroFluent AdicionarEscudo()
        {
            Guerreiro.AdicionarEscudo("Escudo Futuro");
            return this;
        }

        public BuilderGuerreiroFluent AdicionarEscudoMagico()
        {
            Guerreiro.AdicionarEscudo("Escudo Espelho Futuro");
            return this;
        }

        public override BuilderGuerreiroFluent AdicionarEspada()
        {
            Guerreiro.AdicionarEspada("Espada lazer Futuro");
            return this;
        }

        public override BuilderGuerreiroFluent AdicionarFlecha()
        {
            Guerreiro.AdicionarFlecha("Flecha Futuro");
            return this;
        }
    }
}
