using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.FactoctyMethod
{
    class ProdutoConcretoGol : ProdutoCarro 
    {
        public string Nome => "Gol";

        public string Potencia()
        {
            return " 140 Nm / 2000 rpm";
        }

        public string Freia()
        {
            return "Bom";
        }
    }
}
