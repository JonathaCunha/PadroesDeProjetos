using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Bridge
{
    public class JanelaLinux : JanelaImpletacao
    {
        public void DesenheBotao(string titulo)
        {
            Console.WriteLine($"Janela Windows - {titulo} ");
        }

        public void DesenheJanela(string titulo)
        {
            Console.WriteLine($"Botão Windows - {titulo} ");
        }
    }
}
