using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class ConcreteBuilderDoFuturo : BuilderGuerreiroAbstract
    {
        public ConcreteBuilderDoFuturo() : base(new GuerreiroDoFuturo())
        {
        }

        public override void SubirFocaEspada()
        {
            guerreiro.AdicionarPontosForcaEspada(2);
        }

        public override void SubirForcaArmadura()
        {
            guerreiro.AdicionarPontosForcaArmadura(4);
        }

        public override void SubirForcaEscudo()
        {
            guerreiro.AdicionarPontosForcaEscudo(3);
        }

        public override void SubirNivel()
        {
            guerreiro.SubiNivel();
        }
    }
}
