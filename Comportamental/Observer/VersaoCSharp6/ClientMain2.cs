using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Observer.VersaoCSharp6
{
    public class ClientMain2
    {
        public /*static*/ void Main(string[] args)
        {
            var observador1 = new Observador3();
            var observador2 = new Observador4("Raimundo");
            var observador3 = new Observador4("Carla");

            var observado = new Observada2();
            observado.Update += observador1.Update;
            observado.Update += observador2.Update;
            observado.Update += observador3.Update;

            observado.Notify();

            Console.ReadKey();
        }
    }
}
