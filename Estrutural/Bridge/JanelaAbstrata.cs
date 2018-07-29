using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaImpletacao Impletacao;
        public JanelaAbstrata(IJanelaImpletacao impletacao)
        {
            Impletacao = impletacao;
        }

        public void DesenheJanela(string titulo)
        {
            Impletacao.DesenheJanela(titulo);
        }

        public void DesenheBotao(string titulo)
        {
            Impletacao.DesenheBotao(titulo);
        }

        public abstract void Desenhe();

    }
}
