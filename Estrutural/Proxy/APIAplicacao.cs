using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Proxy
{
    class APIAplicacao
    {
        public virtual IEnumerable<string> ObtenhaNomesDeClientes()
        {
            return new string[] { "Jonatha", "Jordana", "Ana Clara", "Beatriz" };
        }
    }
}
