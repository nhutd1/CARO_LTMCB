using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO_LTMCB
{
    class EffectManager
    {
        private static bool effectEnabled = true; 

        public static void EnableEffect()
        {
            effectEnabled = true;
        }

        public static void DisableEffect()
        {
            effectEnabled = false;
        }

        public static bool IsEffectEnabled()
        {
            return effectEnabled;
        }
    }
}
