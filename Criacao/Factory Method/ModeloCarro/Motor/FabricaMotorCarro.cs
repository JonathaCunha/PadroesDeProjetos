using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    public class FabricaMotorCarro
    {
        public static MotorCarro CrieMotoModelo(string modelo)
        {
            if (modelo.Equals("Fire"))
                return new MotorFire();
            else if (modelo.Equals("Work"))
                return new MotorWork();
            throw new ArgumentException("Motor não localizado.");
        }
    }
}
