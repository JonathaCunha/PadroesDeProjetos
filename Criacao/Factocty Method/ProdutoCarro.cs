using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factocty_Method
{
     public abstract class ProdutoCarro
    {
        public string Nome { get; protected set; }
        public int tamanhoAroRoda { get; set; }
        public MotorCarro Motor { get; set; }
        public string NomeMotorEPotencia => $"{Motor.Nome} {Motor.Potencia}";

    }
}
