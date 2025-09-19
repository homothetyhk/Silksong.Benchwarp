using System.Linq;
using System.Reflection;
using BenchwarpSS.Utils;
using HarmonyLib;
using UnityEngine;

namespace BenchwarpSS.Patches
{
    [HarmonyPatch]
    internal class UnlockBench
    {
        public static void Apply(Harmony harmony)
        {
            var targetType = typeof(GameManager);
            var saveGameMethods = targetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).Where(m => m.Name == "SaveGame");

            foreach (var method in saveGameMethods)
            {
                harmony.Patch(method,
                    postfix: new HarmonyMethod(typeof(SaveModdedSaveData).GetMethod(nameof(Postfix))));
            }
        }

        [HarmonyPostfix]
        public static void Postfix(PlayerData __instance)
        {
            foreach (GameObject benchButton in GUIController.Instance.benchButtons)
            {
                Bench bench = benchButton.GetComponent<Bench>();
                if (bench.objName == __instance.respawnMarkerName && bench.sceneName == __instance.respawnScene)
                {
                    bench.isUnlocked = true;
                }
            }
        }
    }
}
