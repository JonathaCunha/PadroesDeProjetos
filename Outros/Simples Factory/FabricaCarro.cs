using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Simples_Factory
{
    public class FabricaCarro
    {
        public Car Crie(string tipo)
        {
            switch (tipo)
            {
                case "B":
                    return new BMW();
                case "K":
                    return new Kia();
                default:
                    return null;
            }
        }
    }
}
