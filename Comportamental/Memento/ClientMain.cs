using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Memento
{
    /// <summary>
    /// Sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, 
    /// de maneira que o objeto possa ser restaurado para esse estado mais tarde.
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] agrs)
        {
            var editor = new EditorDeTexto();
            editor.Escreve("Jonatha da cunha ");
            editor.Escreve("é muito ");
            editor.Escreve("Bonito");

            Console.WriteLine(editor.ObtenhaTexto());
            editor.Desfazer();
            Console.WriteLine(editor.ObtenhaTexto());
            editor.Desfazer();
            Console.WriteLine(editor.ObtenhaTexto());

            Console.ReadKey();
        }
    }
}
