using Benchwarp.Benches;
using Benchwarp.Data;
using Benchwarp.Util;
using HarmonyLib;
using PrepatcherPlugin;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Patches;

[HarmonyPatch(typeof(SceneAdditiveLoadConditional), nameof(SceneAdditiveLoadConditional.OnWasLoaded))]
internal static class FleaGamesStartBenchFix
{
    [HarmonyPostfix]
    public static void OnWasLoaded(SceneAdditiveLoadConditional __instance)
    {
        if (__instance.SceneNameToLoad == SceneNames.Aqueduct_05_festival && PlayerDataAccess.FleaGamesCanStart && !PlayerDataAccess.FleaGamesStarted)
        {
            RespawnInfo info = RespawnInfo.FromPlayerData();
            if (info.SceneName == SceneNames.Aqueduct_05
                && (info.RespawnMarkerName == RespawnMarkerNames.RestBench || info.RespawnMarkerName == RespawnMarkerNames.RestBench_Festival))
            {
                Scene festival = Enumerable.Range(0, SceneManager.sceneCount)
                    .Select(SceneManager.GetSceneAt)
                    .First(s => s.name == SceneNames.Aqueduct_05_festival);

                string[] paths = 
                [
                    "Caravan_States/Flea Festival/Festival_Feast/RestBench Festival",
                    "Caravan_States/Flea Festival/Festival_Feast/Bench (1)"
                ];
                foreach (string path in paths)
                {
                    GameObject? go = festival.FindGameObject(path, warnIfNotFound: true);
                    if (go == null) continue;
                    go.transform.SetParent(null, worldPositionStays: true);
                    go.SetActive(true);
                }

                if (info.RespawnMarkerName != RespawnMarkerNames.RestBench_Festival)
                {
                    PlayerDataAccess.respawnMarkerName = RespawnMarkerNames.RestBench_Festival;
                }
            }
        }
    }
}
