using Benchwarp.Benches;
using Benchwarp.Data;
using HarmonyLib;

namespace Benchwarp.Patches
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.ContinueGame))]
    internal static class RecoveryModePatch
    {
        [HarmonyPrefix]
        private static void ModifyRespawn()
        {
            if (BenchwarpPlugin.ConfigSettings.RecoveryMode)
            {
                LogWarn($"Recovery mode is enabled. Setting respawn location to Tut_01...");
                new RespawnInfo(SceneNames.Tut_01, RespawnMarkerNames.Death_Respawn_Marker_Init, 
                    RespawnTypes.Floor, GlobalEnums.MapZone.MOSS_CAVE)
                    .SetRespawn();
            }
        }
    }
}
