using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    public class FabricaCarroFiat : FabricaAbstract
    {
        int carroPotente = 2;
        protected override ProdutoCarro CrieNovoCarro()
        {
            if(carroPotente++ < 2)
                return new ProdutoConcretoStrada();

            return new ProdutoConcretoPalio();
        }
        
    }
}
