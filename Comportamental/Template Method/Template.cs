using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Template_Method
{
    /// <summary>
    /// Definir o esqueleto de um algoritmo em uma operação, postergando alguns passos para as subclasses.
    /// Template Method permite que subclasses redefinam certos passo de um algoritmo sem mudar a estrutura do mesmo.
    /// </summary>
    abstract class Template
    {
        public void TemplateMethod()
        {
            opercacao1();
            opercacao2();
        }

        protected abstract void opercacao1();
        protected abstract void opercacao2();
    }
}
