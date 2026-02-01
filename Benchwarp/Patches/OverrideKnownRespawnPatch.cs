using Benchwarp.Benches;
using Benchwarp.Data;
using HarmonyLib;
using PrepatcherPlugin;

namespace Benchwarp.Patches
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.GetRespawnInfo))]
    internal static class OverrideKnownRespawnPatch
    {
        internal static bool OverrideFleatopiaBenchWhenCaravanAway = true;

        [HarmonyPrefix]
        private static bool OverrideGetRespawnInfo(ref string scene, ref string marker)
        {
            if (OverrideFleatopiaBenchWhenCaravanAway && ReferenceEquals(BenchList.CurrentBenchRespawn, BaseBenchList.Fleatopia)
                && PlayerDataAccess.CaravanTroupeLocation != GlobalEnums.CaravanTroupeLocations.Aqueduct)
            {
                LogWarn("Unable to safely enter Aqueduct_05: the bench will not be loaded since the caravan is away. Redirecting to Tut_01...");
                scene = SceneNames.Tut_01;
                marker = RespawnMarkerNames.Death_Respawn_Marker_Init;
                return false;
            }

            if (BenchList.CurrentBenchRespawn is BenchData bd)
            {
                RespawnInfo benchRespawn = bd.RespawnInfo.GetRespawnInfo();
                scene = benchRespawn.SceneName;
                marker = benchRespawn.RespawnMarkerName;
                return false;
            }

            RespawnInfo startRespawn = Events.BenchListModifiers.GetStartDef();
            if (startRespawn.IsCurrentRespawn())
            {
                scene = startRespawn.SceneName;
                marker = startRespawn.RespawnMarkerName;
                return false;
            }

            return true;
        }

        [HarmonyPostfix]
        private static void RecordGetRespawnInfoFallthrough(GameManager __instance, ref string scene, ref string marker)
        {
            if (scene == SceneNames.Tut_01 && __instance.playerData.respawnScene != SceneNames.Tut_01)
            {
                BenchwarpPlugin.Instance.Logger.LogWarning($"Unrecognized respawn at " +
                    $"{__instance.playerData.respawnMarkerName} in {__instance.playerData.respawnScene}, " +
                    $"GameManager.GetRespawnInfo will fall through to Tut_01.");
            }
        }
    }
}
