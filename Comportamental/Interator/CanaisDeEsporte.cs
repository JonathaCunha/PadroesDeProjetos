using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Interator
{
    public class CanaisDeEsporte : AgregandoDeCanais
    {
        protected List<Canal> canais;
        public CanaisDeEsporte()
        {
            canais = new List<Canal>();
            canais.Add(new Canal("Esporte ao vivo"));
            canais.Add(new Canal("Basquete 2011"));
            canais.Add(new Canal("Campeonato Italiano"));
        }

        public Interator CrieInterator()
        {
            return new InteratorListaCanais(canais);
        }
    }
}
