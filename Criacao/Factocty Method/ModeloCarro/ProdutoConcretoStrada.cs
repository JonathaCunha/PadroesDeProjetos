using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factocty_Method
{
    class ProdutoConcretoStrada : ProdutoCarro
    {
        public ProdutoConcretoStrada()
        {
            Nome = "Strada";
            tamanhoAroRoda = 14;
            Motor = FabricaMotorCarro.CrieMotoModelo("Work");
        }
    }
}
