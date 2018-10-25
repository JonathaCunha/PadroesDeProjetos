using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Interpreter
{
    public class InterpretadorAlemao : Interpretador
    {
        public InterpretadorAlemao() 
            : base("Alemão")
        {
            traducoes.Add("Ich", "amor");
            traducoes.Add("liebe", "eu");
            traducoes.Add("dich", "você");
        }
    }
}
