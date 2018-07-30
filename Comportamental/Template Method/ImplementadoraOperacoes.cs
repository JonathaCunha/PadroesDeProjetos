using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Definir o esqueleto de um algoritmo em uma operação, postergando alguns passos para as subclasses. 
/// Template Method permite que subclasses redefinam certos passo de um algoritmo sem mudar a estrutura do mesmo
/// </summary>
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
