using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    class DirectorFortalecerGuerreiroFluent
    {
        public void ComeMaca(BuilderGuerreiroAbstract builderGuerreiro)
        {
            builderGuerreiro.SubirNivel();
            builderGuerreiro.SubirForcaEscudo();
            builderGuerreiro.SubirForcaArmadura();
        }

        public void ComeBanana(BuilderGuerreiroAbstract builderGuerreiro)
        {
            builderGuerreiro.SubirNivel();
            builderGuerreiro.SubirNivel();
            builderGuerreiro.SubirFocaEspada();
            builderGuerreiro.SubirForcaArmadura();
        }
    }
}
