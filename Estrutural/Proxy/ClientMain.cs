using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Fornecer um substituto ou marcador da localização de outro objeto
/// para controlar o acesso a esse objeto
/// </summary>
namespace Estrutural.Proxy
{
    class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            APIAplicacao api = new ProxyAPIComLog();
            api.ObtenhaNomesDeClientes();
            Console.ReadKey();
        }
    }
}
