using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Garantir que uma classe tenha somente uma instância e fornece um ponto global de acesso para a mesma.
/// </summary>
namespace Criacao.Sigleton
{
    class SigletonFactory
    {
        public SigletonFactory sigletonFactory { get; set; }
        private SigletonFactory()
        {
        }

        public SigletonFactory Crie()
        {
            return sigletonFactory ?? new SigletonFactory();
        }
    }
}
