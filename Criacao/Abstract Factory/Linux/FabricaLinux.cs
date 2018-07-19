using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Abstract_Factory
{
    public class FabricaLinux : FabricaAbstrata
    {
        public override BotaoAbstrato CrieBotao()
        {
            return new BotaoLinux();
        }

        public override JanelaAbstrata CrieJanela()
        {
            return new JanelaLinux();
        }
    }
}
