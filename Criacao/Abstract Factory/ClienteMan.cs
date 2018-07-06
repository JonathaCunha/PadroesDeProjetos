using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Abstract_Factory
{
    public class ClienteMan
    {
        public static void Main(string[] args)
        {
            var cliente = new Cliente(new FabricaWindows());
            cliente.Desenhe();

            var clienteLinux = new Cliente(new FabricaLinux());
            clienteLinux.Desenhe();
            Console.Read();
        }
    }
}
