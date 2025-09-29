using Benchwarp.Components;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Benchwarp
{
    [BepInAutoPlugin(id: "io.github.benchwarp")]
    public partial class BenchwarpPlugin : BaseUnityPlugin
    {
        new public ManualLogSource Logger => base.Logger;
        public static BenchwarpPlugin Instance => _instance ?? throw new NullReferenceException("Benchwarp has not loaded yet!");
        private static BenchwarpPlugin? _instance;

        public static Settings.GlobalSettings GS = new();
        public static Settings.LocalSettings LS = new();

        private void Awake()
        {
            
            // TODO: fix patches
            try
            {
                _instance = this;
                Log($"Plugin {Name} ({Id}) has loaded!");
                Log($"BenchList has loaded with {Data.BenchList.BaseBenches.Count} benches.");

                Harmony harmony = new($"{Name} ({Id})");
                harmony.PatchAll(GetType().Assembly);

                GUIController.Setup();
                GUIController.Instance.BuildMenus();
                GUIController.Instance.canvas.SetActive(false);
            }
            catch (Exception e)
            {
                LogError(e);
                throw;
            }
        }

        private void Update()
        {
            GUIController.Instance.GUIUpdate();
        }
    }
}