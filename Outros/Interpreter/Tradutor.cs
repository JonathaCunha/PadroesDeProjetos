using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Outros.Interpreter
{
    public class Tradutor
    {
        protected List<Interpretador> intepretadores;
        public Tradutor()
        {
            intepretadores = new List<Interpretador>();
        }
       
        public void AdicioneIntepretador(Interpretador intepretador)
        {
            intepretadores.Add(intepretador);
        }
        public void Traduzar(string textoTraduzir)
        {
            var Palavras = textoTraduzir
                 .Split(' ');

            foreach (var intepretador in intepretadores)
            {
                Console.WriteLine("Idioma: "+ intepretador.Idioma);

                foreach (var palavra in Palavras)
                {
                    var traducao = intepretador.Iterprete(palavra);
                    Console.WriteLine(traducao);
                }
            }

        }

    }
}
