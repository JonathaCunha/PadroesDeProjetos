using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer
{
    public abstract class ObservadorAbstrato
    {
        protected Observada Observada;
        public ObservadorAbstrato(Observada observada)
        {
            Observada = observada;
        }

        public abstract void Notifique();
    }
}
