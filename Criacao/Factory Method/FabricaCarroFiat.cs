using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Definir uma interface para criar um objeto, mas deixar as subclasses decidirem que classe instanciar.
/// O Factory Method permite adiar a instanciação para subclasses.
/// </summary>
namespace Criacao.Factory_Method
{
    public class FabricaCarroFiat : FabricaAbstract
    {
        int carroPotente = 4;
        protected override ProdutoCarro CrieNovoCarro()
        {
            if(carroPotente == 0)
                return new ProdutoConcretoPalio();

            return new ProdutoConcretoStrada();
        }
        
    }
}
