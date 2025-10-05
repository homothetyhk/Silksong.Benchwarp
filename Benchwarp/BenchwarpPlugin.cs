using Benchwarp.Components;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using System.Runtime.CompilerServices;

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
                Log($"DoorList has loaded with {Data.DoorList.RoomGroups.Count} groups.");
                gameObject.AddComponent<RespawnChangeListener>();

            }
            catch (Exception e)
            {
                LogError(GetErrorMsg(e));
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
            }
            catch (Exception e)
            {
                LogError(GetErrorMsg(e));
            }
        }

        private void Start()
        {
            StartCalled = true;
            try
            {
                OnEnable();
                DefineConfig();
                GUIController.LateSetup();
            }
            catch (Exception e)
            {
                LogError(GetErrorMsg(e));
            }
        }

        private void OnDisable()
        {
            try
            {
                HarmonyLib.Harmony.UnpatchID(HarmonyID);
                Patches.LanguageChangeHook.Unhook();

                GUIController.Unload();
            }
            catch (Exception e)
            {
                LogError(GetErrorMsg(e));
            }
        }

        private void DefineConfig()
        {
            ConfigEntry<Settings.MenuMode> cfgMenuMode = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "MenuMode"),
                    defaultValue: Settings.MenuMode.StandardBenchwarp,
                    configDescription: new ConfigDescription(description:
                    ("StandardBenchwarp: only warp to visited benches.\n" +
                    "WarpOnly: only warp to current respawn.\n" +
                    "UnlockAll: warp to any bench.\n" +
                    "DoorWarp: warp to room transitions.").Localize()));
            cfgMenuMode.SettingChanged += (o, e) =>
                {
                    SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                    GS.MenuMode = (Settings.MenuMode)args.ChangedSetting.BoxedValue;
                };
            GS.MenuMode = cfgMenuMode.Value;

            ConfigEntry<bool> cfgAlwaysToggleAll = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "AlwaysToggleAll"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Auto-expand all dropdown panels.".Localize()));
            cfgAlwaysToggleAll.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                GS.AlwaysToggleAll = (bool)args.ChangedSetting.BoxedValue;
            };
            GS.AlwaysToggleAll = cfgAlwaysToggleAll.Value;

            ConfigEntry<bool> cfgShowScene = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "ShowScene"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Displays a panel in the bottom-left with the active scene name.".Localize()));
            cfgShowScene.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                GS.ShowScene = (bool)args.ChangedSetting.BoxedValue;
            };
            GS.ShowScene = cfgShowScene.Value;

            ConfigEntry<bool> cfgEnableHotkeys = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "EnableHotkeys"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "See README.md for information on supported commands.".Localize()));
            cfgEnableHotkeys.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                GS.EnableHotkeys = (bool)args.ChangedSetting.BoxedValue;
            };
            GS.EnableHotkeys = cfgEnableHotkeys.Value;

            ConfigEntry<bool> cfgOverrideLocalization = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "OverrideLocalization"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Use English labels regardless of game language.".Localize()));
            cfgOverrideLocalization.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                GS.OverrideLocalization = (bool)args.ChangedSetting.BoxedValue;
            };
            GS.OverrideLocalization = cfgOverrideLocalization.Value;
        }

        private bool StartCalled { get; set; } = false;
        private string HarmonyID { get; } = $"{Name} ({Id})";
        private string GetErrorMsg(Exception e, [CallerMemberName] string? caller = "") => $"Error during {GetType().Name}.{caller}:\n{e}";
    }
}