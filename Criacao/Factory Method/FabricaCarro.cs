using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    public abstract class FabricaAbstract
    {

        private ProdutoCarro carro { get; set; }
        protected abstract ProdutoCarro CrieNovoCarro();

       public ProdutoCarro NovoCarro()
        {
            carro = this.CrieNovoCarro();
            return carro;
        }

        public void ColocaRodaAro(int tamanho)
        {
            carro.tamanhoAroRoda = tamanho;
        }

    }
}
