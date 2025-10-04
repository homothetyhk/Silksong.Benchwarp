    using Benchwarp.Components;
using HarmonyLib;

namespace Benchwarp.Patches
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.PauseGameToggle))]
    internal class ToggleWarpMenu
    {
        [HarmonyPostfix]
        public static void Postfix(GameManager __instance)
        {
            if (!__instance.isPaused)
            {
                // runs after coroutine is created, but before isPaused is set.
                GUIController.Instance.ToggleDisplay(true);
            }
            else
            {
                GUIController.Instance.ToggleDisplay(false);
            }
        }
    }
}