using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Bridge
{
    class JanelaWindows : IJanelaImpletacao
    {
        public void DesenheBotao(string titulo)
        {
            Console.WriteLine($"Janela Linux - {titulo} ");
        }

        public void DesenheJanela(string titulo)
        {
            Console.WriteLine($"Botão Linux - {titulo} ");
        }
    }
}
