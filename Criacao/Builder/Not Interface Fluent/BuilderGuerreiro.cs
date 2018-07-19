using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public abstract class BuilderGuerreiro
    {
        protected ProdutoGuerreiro Guerreiro { get; set; }
        public BuilderGuerreiro()
        {
            this.Guerreiro = new ProdutoGuerreiro();
        }

        public abstract void AdicionarEspada();
        public abstract void AdicionarEscudo();
        public abstract void AdicionarFlecha();

        public ProdutoGuerreiro ObtenhaGuerreiro()
        {
            Console.WriteLine($"Tipo: {Guerreiro.Tipo} | Espada: {Guerreiro.Espada} | Escudo: {Guerreiro.Escudo} | Flecha: {Guerreiro.Flecha}");
            return Guerreiro;
        }
    }
}
