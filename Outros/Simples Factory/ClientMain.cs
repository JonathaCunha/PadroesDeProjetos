using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Simples_Factory
{
    /// <summary>
    /// Uma fábrica simples encapsula a criação do objeto e a oculta do cliente
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] agrs)
        {
            var fabricaSimples = new FabricaCarro();

            var carroB = fabricaSimples.Crie("B");
            Console.WriteLine(carroB.Nome);

            var carroK = fabricaSimples.Crie("K");
            Console.WriteLine(carroK.Nome);

            Console.ReadKey();
        }


        //SEM FABRICA
        //public /*static*/ void Main(string[] agrs)
        //{
        //    Console.WriteLine(SimplesFactory("B").Nome);
        //    Console.WriteLine(SimplesFactory("K").Nome);
        //    Console.ReadKey();
        //}

        //public /*static*/ Car SimplesFactory(string tipo)
        //{
        //    switch (tipo)
        //    {
        //        case "B":
        //            return new BMW();
        //        case "K":
        //            return new Kia();
        //        default:
        //            return null;
        //    }
        //}
    }
}
