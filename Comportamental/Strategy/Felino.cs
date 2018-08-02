using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Strategy
{
    public abstract class Felino
    {
        public abstract void Display();

        protected CorrerStrategy CorrerEstrategia { get; set; }
        protected PularStrategy PularEstrategia { get; set; }

        public void SetEstrategiaCorrer(CorrerStrategy correrEstrategia)
        {
            CorrerEstrategia = correrEstrategia;
        }

        public void SetEstrategiaPular(PularStrategy pularEstrategia)
        {
            PularEstrategia = pularEstrategia;
        }

        public void PerformaceCorrer()
        {
            CorrerEstrategia.Correr();
        }

        public void PerformacePular()
        {
            PularEstrategia.Pular();
        }


    }
}
