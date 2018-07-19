using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    class DirectorGuerreiroFluent
    {
        public void CarregarItensBasico(BuilderGuerreiroFluent builderGuerreiro)
        {
            builderGuerreiro.AdicionarEspada();
        }

        public void CarregarItensProtecaoContraAtaque(BuilderGuerreiroFluent builderGuerreiro)
        {
            builderGuerreiro.AdicionarEscudo().AdicionarFlecha();
        }
    }
}
