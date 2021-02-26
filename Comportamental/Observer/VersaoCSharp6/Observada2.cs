using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer.VersaoCSharp6
{
    public class Observada2
    {
        public event Action Update;
        //public event Func<int, string> Update2;

        public void Notify() => Update?.Invoke();
    }
}
