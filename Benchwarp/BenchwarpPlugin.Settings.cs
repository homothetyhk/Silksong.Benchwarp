using Benchwarp.Settings;
using BepInEx.Configuration;
using Silksong.DataManager;

namespace Benchwarp
{
    public partial class BenchwarpPlugin : ISaveDataMod<SaveSettingsData>, IGlobalDataMod<SharedSettingsData>
    {
        public static ConfigSettings ConfigSettings { get; } = new(new());
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

        private void DefineConfig()
        {
            // TODO: add event subscriber to update config when settings are changed in-game
            // TODO: figure out how this should be setup for hot-reloading
            ConfigEntry<MenuMode> cfgMenuMode = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "MenuMode"),
                    defaultValue: MenuMode.StandardBenchwarp,
                    configDescription: new ConfigDescription(description:
                    ("StandardBenchwarp: only warp to visited benches.\n" +
                    "WarpOnly: only warp to current respawn.\n" +
                    "UnlockAll: warp to any bench.\n" +
                    "DoorWarp: warp to room transitions.")));
            cfgMenuMode.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                ConfigSettings.MenuMode = (MenuMode)args.ChangedSetting.BoxedValue;
            };
            ConfigSettings.MenuMode = cfgMenuMode.Value;

            ConfigEntry<bool> cfgAlwaysToggleAll = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "AlwaysToggleAll"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Auto-expand all dropdown panels."));
            cfgAlwaysToggleAll.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                ConfigSettings.AlwaysToggleAll = (bool)args.ChangedSetting.BoxedValue;
            };
            ConfigSettings.AlwaysToggleAll = cfgAlwaysToggleAll.Value;

            ConfigEntry<bool> cfgShowScene = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "ShowScene"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "Displays a panel in the bottom-left with the active scene name."));
            cfgShowScene.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                ConfigSettings.ShowScene = (bool)args.ChangedSetting.BoxedValue;
            };
            ConfigSettings.ShowScene = cfgShowScene.Value;

            ConfigEntry<bool> cfgEnableHotkeys = Config.Bind(
                    configDefinition: new ConfigDefinition(section: "Menu", key: "EnableHotkeys"),
                    defaultValue: false,
                    configDescription: new ConfigDescription(description: "See README.md for information on supported commands."));
            cfgEnableHotkeys.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                ConfigSettings.EnableHotkeys = (bool)args.ChangedSetting.BoxedValue;
            };
            ConfigSettings.EnableHotkeys = cfgEnableHotkeys.Value;

            ConfigEntry<bool> cfgRecoveryMode = Config.Bind(
                configDefinition: new ConfigDefinition(section: "Menu", key: "RecoveryMode"),
                defaultValue: false,
                configDescription: new ConfigDescription(description: "Use if you get stuck. While active, any file loaded will spawn into the starting area in Moss Grotto."));
            cfgRecoveryMode.SettingChanged += (o, e) =>
            {
                SettingChangedEventArgs args = (SettingChangedEventArgs)e;
                ConfigSettings.RecoveryMode = (bool)args.ChangedSetting.BoxedValue;
            };
            ConfigSettings.RecoveryMode = cfgRecoveryMode.Value;
        }
    }
}
