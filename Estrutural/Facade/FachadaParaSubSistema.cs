using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Facade
{
    public class FachadaParaSubSistema
    {
        public void ExecutarTarefasDiarias()
        {
            var sub1 = new SubSistema1();
            sub1.Configuracao();
            sub1.Executar();

            var sub2 = new SubSistema2();
            sub2.Configuracao();
            sub2.ExecucaoModelo1();
            sub2.ExecucaoModelo2();
            sub2.ExecucaoModelo3();
        }
    }
}
