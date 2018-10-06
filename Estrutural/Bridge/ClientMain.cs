using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Desacoplar uma abstração da sua implementação, 
/// de modo que as duas possam variar independentemente.
/// </summary>
namespace Estrutural.Bridge
{
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            JanelaAbstrata janela = new JanelaDialogo(new SOLinux());
            janela.Desenhe();
            janela = new JanelaDialogo(new SOWindows());
            janela.Desenhe();

            janela = new JanelaAviso(new SOLinux());
            janela.Desenhe();

           

            Console.ReadKey();
        }
    }
}
