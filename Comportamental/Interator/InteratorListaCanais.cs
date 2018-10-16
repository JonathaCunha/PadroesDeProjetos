using System.Collections.Generic;

namespace Comportamental.Interator
{
    internal class InteratorListaCanais : Interator
    {
        private List<Canal> canais;
        protected int contador;

        public InteratorListaCanais(List<Canal> canais)
        {
            this.canais = canais;
        }

        public Canal CurrentItem()
        {
            return canais[contador];
        }

        public bool HasValue()
        {
            return contador < canais.Count;
        }

        public void Next()
        {
            contador++;
        }
    }
}