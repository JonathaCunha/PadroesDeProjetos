using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Interator
{
    public class CanaisDeFilme : AgregandoDeCanais
    {
        protected Canal[] canais;
        public CanaisDeFilme()
        {
            canais = new Canal[2];
            canais[0] = new Canal("Cine Filme");
            canais[1] = new Canal("BBC Filmes");
        }
        public Interator CrieInterator()
        {
            return new InteratorArrayCanais(canais);
        }
    }
}
