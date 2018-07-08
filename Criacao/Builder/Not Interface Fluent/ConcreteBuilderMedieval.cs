using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class ConcreteBuilderMedieval : BuilderGuerreiroAbstract
    {
        public ConcreteBuilderMedieval() : base(new GuerreiroMedieval())
        {
        }

        public override void SubirFocaEspada()
        {
            guerreiro.AdicionarPontosForcaEspada(1);
        }

        public override void SubirForcaArmadura()
        {
            guerreiro.AdicionarPontosForcaArmadura(3);
        }

        public override void SubirForcaEscudo()
        {
            guerreiro.AdicionarPontosForcaEscudo(4);
        }

        public override void SubirNivel()
        {
            guerreiro.SubiNivel();
        }
    }
}
