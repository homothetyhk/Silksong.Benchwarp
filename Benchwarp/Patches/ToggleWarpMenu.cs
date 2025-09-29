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
                GUIController.Instance.canvas.SetActive(true);
            }
            else
            {
                GUIController.Instance.canvas.SetActive(false);
            }
        }
    }

    [HarmonyPatch(typeof(GameManager), nameof(GameManager.ReturnToMainMenu))]
    internal class HideWarpMenu
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            GUIController.Instance.canvas.SetActive(false);
        }
    }
}