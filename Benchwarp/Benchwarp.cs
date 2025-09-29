using BenchwarpSS.Utils;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BenchwarpSS
{
    [BepInAutoPlugin(id: "io.github.benchwarp")]
    public partial class Benchwarp : BaseUnityPlugin
    {
        new public ManualLogSource Logger => base.Logger;
        public static Benchwarp Instance => _instance ?? throw new NullReferenceException("Benchwarp has not loaded yet!");
        private static Benchwarp? _instance;

        private void Awake()
        {
            _instance = this;
            base.Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
            Harmony harmony = new($"{Name} ({Id})");
            harmony.PatchAll(GetType().Assembly);

            GUIController.Setup();
            GUIController.Instance.BuildMenus();

            GUIController.Instance.canvas.SetActive(false);
        }

        private void Update()
        {
            GUIController.Instance.GUIUpdate();
        }
    }
}