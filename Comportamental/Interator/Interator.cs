using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Interator
{
    public interface Interator
    {
        void Next();
        bool HasValue();
        Canal CurrentItem();
    }
}
