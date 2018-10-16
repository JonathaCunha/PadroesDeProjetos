using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Mediator
{
    /// <summary>
    /// Definir um objeto que encapsula a forma como um conjunto de objetos interage.
    /// O Mediator promove o acoplamento fraco ao evitar que os objetos se refiram uns aos outros explicitamente
    /// e permitir variar suas interações independentemente.
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            Politico haddad = new Haddad();
            Politico ciro = new Ciro();
            Politico bolsonario = new Bolsonario();

            var debate = new R7Debate();
            debate.AdicionarUsuario(haddad);
            debate.AdicionarUsuario(ciro);
            debate.AdicionarUsuario(bolsonario);

            haddad.EnviarMensagem("Meus projetos e na area dos Empregos");
            ciro.EnviarMensagem("Meus projetos e na area da Educação");
            bolsonario.EnviarMensagem("Meus projetos e na area de Segurança");

            Console.ReadKey();
        }
    }
}
