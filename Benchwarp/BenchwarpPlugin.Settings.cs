using Benchwarp.Settings;
using BepInEx.Configuration;
using Silksong.DataManager;

namespace Benchwarp
{
    public partial class BenchwarpPlugin : ISaveDataMod<SaveSettingsData>, IGlobalDataMod<SharedSettingsData>
    {
        public static ConfigSettings ConfigSettings { get; private set; } = null!; // initialized in plugin constructor
        public static SaveSettings SaveSettings { get; } = new(new());
        public static SharedSettings SharedSettings { get; } = new(new());

        SaveSettingsData? ISaveDataMod<SaveSettingsData>.SaveData
        {
            get => SaveSettings.GetSerializationData(); 
            set => SaveSettings.Load(value ?? new());
        }

        SharedSettingsData? IGlobalDataMod<SharedSettingsData>.GlobalData 
        { 
            get => SharedSettings.GetSerializationData(); 
            set => SharedSettings.Load(value ?? new()); 
        }

        private ConfigSettings DefineConfig()
        {
            ConfigEntry<MenuMode> cfgMenuMode = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "MenuMode"),
                    defaultValue: MenuMode.StandardBenchwarp,
                    configDescription: new ConfigDescription(description: "See README.md for details on modes."));

            ConfigEntry<bool> cfgShowScene = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "ShowScene"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Displays a panel in the bottom-left with the active scene name."));

            ConfigEntry<bool> cfgAlwaysToggleAll = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "AlwaysToggleAll"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Auto-expand all dropdown panels."));

            ConfigEntry<bool> cfgEnableDeploy = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "EnableDeploy"),
                    defaultValue: true,
                    configDescription: new ConfigDescription(description: "Enables placing a bench at the current location through the menu."));

            ConfigEntry<bool> cfgEnableHotkeys = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "EnableHotkeys"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "See README.md for information on supported commands."));

            ConfigEntry<bool> cfgRecoveryMode = Config.Bind(
                configDefinition: new ConfigDefinition(section: "Menu", key: "RecoveryMode"),
                defaultValue: false,
                configDescription: new ConfigDescription(description: "Use if you get stuck. While active, any file loaded will spawn into the starting area in Moss Grotto."));

            return new(new()
            {
                MenuMode = cfgMenuMode,
                ShowScene = cfgShowScene,
                AlwaysToggleAll = cfgAlwaysToggleAll,
                EnableDeploy = cfgEnableDeploy,
                EnableHotkeys = cfgEnableHotkeys,
                RecoveryMode = cfgRecoveryMode,
            });
        }
    }
}
