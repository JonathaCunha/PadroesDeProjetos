using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Separar a construção de um objeto complexo de sua representação
///de modo que o mesmo processo de construção possa criar diferentes representações.
/// </summary>
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
