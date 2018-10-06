using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Facade
{
    /// <summary>
    /// O Padrão de Projeto Facade oculta toda a complexidade de uma ou mais classes 
    /// através de uma Facade (Fachada)
    /// 
    /// O Padrão Facade fornece uma interface unificada
    /// para um conjunto de interfaces em um subsistema
    /// </summary>
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
