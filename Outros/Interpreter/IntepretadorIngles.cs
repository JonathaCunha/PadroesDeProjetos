using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Outros.Interpreter
{
    public class InterpretadorIngles : Interpretador
    {
        public InterpretadorIngles()
            : base("Inglês")
        {
            traducoes.Add("love", "amor");
            traducoes.Add("I", "eu");
            traducoes.Add("you", "você");
        }
        
    }
}
