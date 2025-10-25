    using Benchwarp.Components;
using HarmonyLib;

namespace Benchwarp.Patches;

/*
[HarmonyPatch(typeof(GameManager), nameof(GameManager.ReturnToMainMenu))]
internal class HideWarpMenu
{
    [HarmonyPostfix]
    public static void Postfix()
    {
        GUIController.Instance.ToggleDisplay(false);
    }
}
*/