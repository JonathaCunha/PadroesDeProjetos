using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    class DirectorGuerreiro
    {
        public void CarregarItensBasico(BuilderGuerreiro builderGuerreiro)
        {
            builderGuerreiro.AdicionarEspada();
        }

        public void CarregarItensProtecaoContraAtaque(BuilderGuerreiro builderGuerreiro)
        {
            builderGuerreiro.AdicionarEscudo();
            builderGuerreiro.AdicionarFlecha();
        }
    }
}
