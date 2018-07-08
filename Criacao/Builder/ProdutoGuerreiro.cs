using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public abstract class ProdutoGuerreiro
    {
        public ProdutoGuerreiro(int forcaEspada, int forcaArmadura, int forcaEscudo)
        {
            this.ForcaArmadura = forcaArmadura;
            this.ForcaEspada = forcaEspada;
            this.ForcaEscudo = forcaEscudo;
        }
        public int ForcaEspada { get; private set; }
        public int ForcaEscudo { get; private set; }
        public int ForcaArmadura { get; private set; }
        public int Nivel { get; private set; }

        public void SubiNivel()
        {
            Nivel++;
        }

        public void AdicionarPontosForcaEspada(int quantidade)
        {
            ForcaEspada =+ (quantidade * Nivel);
        }

        public void AdicionarPontosForcaArmadura(int quantidade)
        {
            ForcaArmadura = +(quantidade * Nivel);
        }

        public void AdicionarPontosForcaEscudo(int quantidade)
        {
            ForcaEscudo = +(quantidade * Nivel);
        }
    }
}
