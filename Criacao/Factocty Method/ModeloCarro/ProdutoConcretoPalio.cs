using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factocty_Method
{
    public class ProdutoConcretoPalio : ProdutoCarro
    {
        public ProdutoConcretoPalio()
        {
            Nome = "Palio";
            tamanhoAroRoda = 13;
            Motor = FabricaMotorCarro.CrieMotoModelo("Fire");
        }
    }
}
