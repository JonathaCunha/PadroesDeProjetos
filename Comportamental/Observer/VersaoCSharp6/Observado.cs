using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer.VersaoCSharp6
{
    public class Observado
    {
        public event Action Update;

        public void Notify() => Update?.Invoke();
    }
}
