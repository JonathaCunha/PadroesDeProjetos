using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Bridge
{
    public class JanelaDialogo : JanelaAbstrata
    {
        public JanelaDialogo(IJanelaImpletacao impletacao) 
            : base(impletacao)
        {
        }

        public override void Desenhe()
        {
            DesenheJanela("Janela de Diálogo");
            DesenheBotao("Botão Sim");
            DesenheBotao("Botão Não");
            DesenheBotao("Botão Cancelar");
        }
    }
}
