using Comportamental.State.EstadosDeHumor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.State
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
            Humor = new BemHumorada(this);
        }
        public void ComoEstaSeuHumor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Estou de {Humor.Nome}");
        }
        public string Nome { get; set; }
        public Humor Humor { get; private set; }

        public void GanhaNaLoteria()
        {
            Humor = new BemHumorada(this);
        }
        public void PerdeNaLoteria()
        {
            Humor = new MalHumorada(this);
        }

        public void QualSeuNome()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual seu Nome?");
            Console.BackgroundColor = ConsoleColor.White;
            Humor.QualSeuNome();
        }
        public void QueCantaUmaMusicaFeliz()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Que canta uma música feliz?");
            Console.BackgroundColor = ConsoleColor.White;
            Humor.QueCantaUmaMusicaFeliz();
        }


    }
}
