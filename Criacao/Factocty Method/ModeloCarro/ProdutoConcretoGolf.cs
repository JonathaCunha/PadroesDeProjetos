using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.FactoctyMethod
{
    class ProdutoConcretoGolf : ProdutoCarro
    {
        public string Nome => "Golf";

        public string Potencia()
        {
            return " 151 Nm / 2500 rpm";
        }

        public string Freia()
        {
            return "Muito Bom";
        }
    }
}
