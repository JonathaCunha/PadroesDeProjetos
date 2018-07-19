using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Adpater
{
    interface IEnvioSMS
    {
        void EnviaSMS(string msg, int ddd, int fone);
    }
}
