using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutural.Adpater
{
    class AdpaterSMSClaro : SMSClaro,  IEnvioSMS
    {
        public void EnviaSMS(string msg, int ddd, int fone)
        {
            EnviaMsg(msg, ddd.ToString(), fone.ToString());
        }
    }
}
