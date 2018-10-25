using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Interpreter
{
    public class ClientMain
    {
        /// <summary>
        /// Rever Exemplo, para ver estar certo
        /// </summary>
        /// <param name="agrs"></param>
        public /*static*/ void Main(string[] agrs)
        {
            var tradutor = new Tradutor();
            tradutor.AdicioneIntepretador(new InterpretadorIngles());
            tradutor.AdicioneIntepretador(new InterpretadorAlemao());

            var frase = "I love you , Ich dich liebe";
            Console.WriteLine(frase);
            tradutor.Traduzar(frase);
            Console.Read();
        }
    }
}
