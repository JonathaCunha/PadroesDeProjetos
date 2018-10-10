using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.State.EstadosDeHumor
{
    public class BemHumorada : Humor
    {
        public BemHumorada(Pessoa pessoa)
            : base(pessoa)
        {
            Nome = "Bom Humor";
        }

        public override void QualSeuNome()
        {
            Console.WriteLine($"Meu nome é {Pessoa.Nome}");
        }
        public override void QueCantaUmaMusicaFeliz()
        {
            Console.WriteLine("Qual Música?");
        }
    }
}