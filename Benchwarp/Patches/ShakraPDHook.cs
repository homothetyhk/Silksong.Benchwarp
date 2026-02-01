using System;
using System.Collections.Generic;
using System.Text;
using Benchwarp.Data;
using PrepatcherPlugin;

namespace Benchwarp.Patches
{
    internal static class ShakraPDHook
    {
        internal static void Hook()
        {
            PlayerDataVariableEvents.OnSetBool += UpdateShakraBenches;
        }

        internal static void Unhook()
        {
            PlayerDataVariableEvents.OnSetBool -= UpdateShakraBenches;
        }

        private static bool UpdateShakraBenches(PlayerData pd, string fieldName, bool current)
        {
            switch (fieldName)
            {
                case nameof(PlayerData.MapperLeftGreymoor) when current:
                    BenchwarpPlugin.SaveSettings.SetVisited(BaseBenchList.ShakraGreymoor, true);
                    break;
                case nameof(PlayerData.MapperLeftPeak) when current:
                    BenchwarpPlugin.SaveSettings.SetVisited(BaseBenchList.ShakraMountFay, true);
                    break;
            }
            return current;
        }
    }
}
