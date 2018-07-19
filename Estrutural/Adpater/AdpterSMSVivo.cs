using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Adpater
{
    class AdpterSMSVivo : SMSVivo, IEnvioSMS
    {
        public void EnviaSMS(string msg, int ddd, int fone)
        {
            EnviarSMSVIVO(msg, $"({ddd}) {fone}");
        }
    }
}
