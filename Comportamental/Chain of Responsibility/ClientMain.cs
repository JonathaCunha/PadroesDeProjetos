using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamental.Chain_of_Responsibility
{
    /// <summary>
    /// Evitar o acoplamento do remetente de uma solicitação ao seu receptor,
    /// ao dar a mais de um objeto a oportunidade de tratar a solicitação.
    /// Encadear os objetos receptores, 
    /// passando a solicitação ao longo da cadeia até que um objeto a trate.
    /// </summary>
    public class ClientMain
    {
        public /*static*/ void Main(string[] agrs)
        {
            var pedido = new Pedido(valor:10,quantidadesItens:5);

            var descontoValor = new DescontoPorValor();
            var descontoQuantidade = new DescontoPorQuantidade();
            var descontoZero = new SemDesconto();

            descontoValor.SetDesconto(descontoQuantidade);
            descontoQuantidade.SetDesconto(descontoZero);

            Console.WriteLine(descontoValor.Calcular(pedido) + "%");
            pedido.QuatidadesItens = 100;
            Console.WriteLine(descontoValor.Calcular(pedido) + "%");
            pedido.Valor = 1000;
            Console.WriteLine(descontoValor.Calcular(pedido) + "%");
            pedido.Valor = 0;
            pedido.QuatidadesItens = 0;
            Console.WriteLine(descontoValor.Calcular(pedido) + "%");

            Console.ReadKey();
        }
    }
}
