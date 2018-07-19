using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Template_Method
{
    class ImplementadoraOperacoes : Template
    {
        protected override void opercacao1()
        {
            Console.Write("Operação 1");
        }

        protected override void opercacao2()
        {
            Console.Write("Operação 2");
        }
    }
}
