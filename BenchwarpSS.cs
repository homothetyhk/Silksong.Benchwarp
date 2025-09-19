using BenchwarpSS.Patches;
using BenchwarpSS.Utils;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BenchwarpSS
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class BenchwarpSS : BaseUnityPlugin
    {
        public static ManualLogSource logSource;

        private void Awake()
        {
            logSource = Logger;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Harmony harmony = new("com.example.patch");

            GUIController.Setup();
            GUIController.Instance.BuildMenus();

            GUIController.Instance.canvas.SetActive(false);

            harmony.PatchAll(typeof(ToggleWarpMenu));
            harmony.PatchAll(typeof(SetBenchUnlocksForProfile));
            harmony.PatchAll(typeof(HideWarpMenu));
            SaveModdedSaveData.Apply(harmony);
        }

        private void Update()
        {
            GUIController.Instance.GUIUpdate();
        }
    }
}