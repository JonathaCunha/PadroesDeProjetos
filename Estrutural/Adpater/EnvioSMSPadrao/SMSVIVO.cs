using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Adpater
{
    class SMSVivo 
    {
        public void EnviarSMSVIVO(string msg, string numero)
        {
            Console.WriteLine($"VIVO: {numero}");
            Console.WriteLine($"MSG: {msg}");
        }
    }
}
