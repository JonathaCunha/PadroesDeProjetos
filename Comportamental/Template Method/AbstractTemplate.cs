using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Template_Method
{
    abstract class AbstractTemplate
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
