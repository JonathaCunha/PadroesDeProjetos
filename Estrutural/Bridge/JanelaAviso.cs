using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Bridge
{
    public class JanelaAviso : JanelaAbstrata
    {
        public JanelaAviso(JanelaImpletacao impletacao)
            : base(impletacao)
        {
        }

        public override void Desenhe()
        {
            DesenheJanela("Janela de Aviso");
            DesenheBotao("Ok");
        }
    }
}
