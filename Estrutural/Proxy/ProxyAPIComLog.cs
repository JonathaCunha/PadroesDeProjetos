using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Proxy
{
    class ProxyAPIComLog : APIAplicacao
    {
        public override IEnumerable<string> ObtenhaNomesDeClientes()
        {
            var nomes = base.ObtenhaNomesDeClientes();
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            foreach (var item in nomes)
            {
                Console.Write(" - " + item.ToUpper());
            }
            return nomes;
        }
    }
}
