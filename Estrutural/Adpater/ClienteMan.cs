using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// O padrão Adapter converte uma interface de uma classe para outra interface que o cliente espera encontrar.
/// O Adaptador permite que classes com interfaces incompatíveis trabalhem juntas.
/// </summary>
namespace Estrutural.Adpater
{
    class ClienteMan
    {
        public /*static*/ void Main(string[] args)
        {
            var listaOperadoras = new IEnvioSMS[] 
            {
                new AdpterSMSVivo(),
                new AdpaterSMSClaro()
            };

            foreach (var operadora in listaOperadoras)
            {
                operadora.EnviaSMS("Teste", 62, 91893476);
            }
            Console.ReadKey();
        }
    }
}
