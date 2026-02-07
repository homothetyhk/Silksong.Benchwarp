using BepInEx.Configuration;

namespace Benchwarp.Settings;

public class ConfigSettingsData
{
    public required ConfigEntry<MenuMode> MenuMode { get; init; }
    public required ConfigEntry<bool> ShowScene { get; init; }
    public required ConfigEntry<bool> AlwaysToggleAll { get; init; }
    public required ConfigEntry<bool> EnableDeploy { get; init; }
    public required ConfigEntry<bool> EnableHotkeys { get; init; }
    public required ConfigEntry<bool> RecoveryMode { get; init; }
}
