using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Facade
{
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            var fachada = new FachadaParaSubSistema();
            fachada.ExecutarTarefasDiarias();

            Console.ReadKey();
        }
    }
}
