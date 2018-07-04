using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Sigleton
{
    class SigletonFactory
    {
        public SigletonFactory sigletonFactory { get; set; }
        private SigletonFactory()
        {
        }

        public SigletonFactory Crie()
        {
            return sigletonFactory ?? new SigletonFactory();
        }
    }
}
