using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
   public abstract class BuilderGuerreiroFluent
    {
        protected ProdutoGuerreiro Guerreiro { get; set; }
        public BuilderGuerreiroFluent()
        {
            this.Guerreiro = new ProdutoGuerreiro();
        }

        public abstract BuilderGuerreiroFluent AdicionarEspada();
        public abstract BuilderGuerreiroFluent AdicionarEscudo();
        public abstract BuilderGuerreiroFluent AdicionarFlecha();

        public ProdutoGuerreiro ObtenhaGuerreiro()
        {
            Console.WriteLine($"Tipo: {Guerreiro.Tipo} | Espada: {Guerreiro.Espada} | Escudo: {Guerreiro.Escudo} | Flecha: {Guerreiro.Flecha}");
            return Guerreiro;
        }
    }
}
