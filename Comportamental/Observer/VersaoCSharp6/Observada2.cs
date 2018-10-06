using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer.VersaoCSharp6
{
    public class Observada2
    {
        public event Action Update;

        public void Notify() => Update?.Invoke();
    }
}
