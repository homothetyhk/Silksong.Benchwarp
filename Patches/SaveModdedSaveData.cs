using System.Linq;
using System.Reflection;
using BenchwarpSS.Utils;
using HarmonyLib;

namespace BenchwarpSS.Patches
{
    [HarmonyPatch]
    internal class SaveModdedSaveData
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
        public static void Postfix()
        {
            GUIController.Instance.SaveData();
        }
    }
}
