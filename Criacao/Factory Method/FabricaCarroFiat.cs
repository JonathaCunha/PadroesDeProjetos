using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    public class FabricaCarroFiat : FabricaAbstract
    {
        int carroPotente = 4;
        protected override ProdutoCarro CrieNovoCarro()
        {
            if (carroPotente-- > 0)
            {
                var carro = new ProdutoConcretoStrada();
                if (carroPotente == 0)
                    carro.Motor = FabricaMotorCarro.CrieMotoModelo("Fire");
                return carro;
            }
            return new ProdutoConcretoPalio();
        }
        
    }
}
