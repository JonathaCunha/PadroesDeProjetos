using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public abstract class BuilderGuerreiroAbstract
    {
        protected ProdutoGuerreiro guerreiro { get; set; }
        protected BuilderGuerreiroAbstract(ProdutoGuerreiro guerreiro)
        {
            this.guerreiro = guerreiro;
        }

        public abstract void SubirNivel();
        public abstract void SubirForcaEscudo();
        public abstract void SubirFocaEspada();
        public abstract void SubirForcaArmadura();

        public ProdutoGuerreiro Pontuacao()
        {
            Console.WriteLine($"Espada: {guerreiro.ForcaEspada} Escudo: {guerreiro.ForcaEscudo} Armadura: {guerreiro.ForcaArmadura}");
            return guerreiro;
        }
    }
}
