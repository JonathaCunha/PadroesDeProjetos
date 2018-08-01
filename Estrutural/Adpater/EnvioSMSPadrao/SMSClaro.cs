using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Adpater
{
    class SMSClaro
    {
        public void EnviaMsg(string msg, string ddd, string fone)
        {
            Console.WriteLine($"Claro: ({ddd}) {fone}");
            Console.WriteLine($"MSG: {msg}");
        }
    }
}
