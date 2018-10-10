using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.State
{
    /// <summary>
    /// Permite a um objeto alterar seu comportamento quando seu estado interno muda.
    /// O objeto parecerá ter mudado de classe.
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            var pessoa = new Pessoa("Jonatha");
            pessoa.ComoEstaSeuHumor();
            pessoa.QualSeuNome();
            pessoa.QueCantaUmaMusicaFeliz();

            pessoa.PerdeNaLoteria();
            pessoa.ComoEstaSeuHumor();
            pessoa.QualSeuNome();
            pessoa.QueCantaUmaMusicaFeliz();

            pessoa.GanhaNaLoteria();
            pessoa.ComoEstaSeuHumor();
            pessoa.QualSeuNome();
            pessoa.QueCantaUmaMusicaFeliz();
            Console.ReadKey();
        }
    }
}
