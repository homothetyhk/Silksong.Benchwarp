using Benchwarp.Components;
using BepInEx;
using BepInEx.Logging;

namespace Benchwarp
{
    [BepInAutoPlugin(id: "io.github.benchwarp")]
    public partial class BenchwarpPlugin : BaseUnityPlugin
    {
        new public ManualLogSource Logger => base.Logger;
        public static BenchwarpPlugin Instance => _instance ?? throw new NullReferenceException("Benchwarp has not loaded yet!");
        private static BenchwarpPlugin? _instance;
        
        public static Settings.GlobalSettings GS = new(new());
        public static Settings.LocalSettings LS = new(new());

        
        private void Awake()
        {
            try
            {
                _instance = this;
                Log($"Plugin {Name} ({Id}) has loaded!");
                Log($"BenchList has loaded with {Data.BenchList.Benches.Count} benches in {Data.BenchList.BenchGroups.Count} groups.");
                gameObject.AddComponent<RespawnChangeListener>();
            }
            catch (Exception e)
            {
                LogError(e);
                throw;
            }
        }

        private void OnEnable()
        {
            if (!StartCalled) return;
            try
            {
                HarmonyLib.Harmony harmony = new(HarmonyID);
                harmony.PatchAll(GetType().Assembly);
                Patches.LanguageChangeHook.Hook();


                GUIController.Setup();
                GUIController.Instance.BuildMenus();
                GUIController.Instance.ToggleDisplay(false);
            }
            catch (Exception e)
            {
                LogError(e);
                throw;
            }
        }

        private void Start()
        {
            StartCalled = true;
            OnEnable();
        }

        private void OnDisable()
        {
            HarmonyLib.Harmony.UnpatchID(HarmonyID);
            Patches.LanguageChangeHook.Unhook();

            GUIController.Unload();
        }

        private void Update()
        {
            GUIController.Instance.GUIUpdate();
        }

        private bool StartCalled { get; set; } = false;
        private string HarmonyID { get; } = $"{Name} ({Id})";
    }
}