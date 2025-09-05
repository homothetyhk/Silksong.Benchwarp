using BenchwarpSS.Utils;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace BenchwarpSS
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource logSource;

        private void Awake()
        {
            logSource = Logger;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Harmony harmony = new("com.example.patch");
            harmony.PatchAll();

            GUIController.Setup();
            GUIController.Instance.BuildMenus();

            GUIController.Instance.canvas.SetActive(false);
        }
    }
}