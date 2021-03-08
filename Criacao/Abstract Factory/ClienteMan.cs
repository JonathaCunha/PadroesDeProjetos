using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Fornecer uma interface para criação de famílias de objetos relacionados ou dependentes 
/// sem especificar suas classes concretas.
/// </summary>
namespace Criacao.Abstract_Factory
{
    public class ClienteMan
    {
        public static void Main(string[] args)
        {
            var cliente = new FabricaXamarim(new FabricaWindows());
            cliente.Desenhe();

            var clienteLinux = new FabricaXamarim(new FabricaLinux());
            clienteLinux.Desenhe();
            Console.Read();
        }
    }
}
