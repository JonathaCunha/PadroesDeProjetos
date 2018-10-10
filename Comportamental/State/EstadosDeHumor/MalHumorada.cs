using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.State.EstadosDeHumor
{
    public class MalHumorada : Humor
    {
        public MalHumorada(Pessoa pessoa) 
            : base(pessoa)
        {
            Nome = "Mal Humor";
        }

        public override void QualSeuNome()
        {
            Console.WriteLine($"Para que te interessa");
        }
        public override void QueCantaUmaMusicaFeliz()
        {
            Console.WriteLine("Claro que não");
        }
    }
}
