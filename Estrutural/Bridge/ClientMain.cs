using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Desacoplar uma abstração da sua implementação, de modo que as duas possam variar independentemente.
/// </summary>
namespace Estrutural.Bridge
{
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            JanelaAbstrata janela = new JanelaDialogo(new JanelaLinux());
            janela.Desenhe();
            janela = new JanelaDialogo(new JanelaWindows());
            janela.Desenhe();

            janela = new JanelaAviso(new JanelaLinux());
            janela.Desenhe();

           

            Console.ReadKey();
        }
    }
}
