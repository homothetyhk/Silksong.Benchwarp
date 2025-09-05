using System;
using System.Collections.Generic;
using System.Text;

namespace BenchwarpSS
{
    internal class ModHelper
    {
        public static void Msg(string msg)
        {
            Plugin.logSource.LogInfo(msg);
        }
    }
}
