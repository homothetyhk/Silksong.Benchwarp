using System.Runtime.CompilerServices;

namespace Benchwarp.Settings;

public class ConfigSettings
{
    private readonly ConfigSettingsData data;

    public ConfigSettings(ConfigSettingsData data)
    {
        this.data = data;
        data.MenuMode.SettingChanged += (_, _) => Invoke(OnMenuModeChanged);
        data.ShowScene.SettingChanged += (_, _) => Invoke(OnShowSceneChanged);
        data.AlwaysToggleAll.SettingChanged += (_, _) => Invoke(OnAlwaysToggleAllChanged);
        data.EnableHotkeys.SettingChanged += (_, _) => Invoke(OnEnableHotkeysChanged);
        data.EnableDeploy.SettingChanged += (_, _) => Invoke(OnEnableDeployChanged);
        data.RecoveryMode.SettingChanged += (_, _) => Invoke(OnRecoveryModeChanged);
    }

    public MenuMode MenuMode
    {
        get => data.MenuMode.Value;
        set => data.MenuMode.Value = value;
    }
    internal static event Action? OnMenuModeChanged;

    public bool ShowScene
    {
        get => data.ShowScene.Value;
        set => data.ShowScene.Value = value;
    }
    internal static event Action? OnShowSceneChanged;

    public bool AlwaysToggleAll
    {
        get => data.AlwaysToggleAll.Value;
        set => data.AlwaysToggleAll.Value = value;
    }
    internal static event Action? OnAlwaysToggleAllChanged;
    
    public bool EnableDeploy
    {
        get => data.EnableDeploy.Value;
        set => data.EnableDeploy.Value = value;
    }
    internal static event Action? OnEnableDeployChanged;

    public bool EnableHotkeys
    {
        get => data.EnableHotkeys.Value;
        set => data.EnableHotkeys.Value = value;
    }
    internal static event Action? OnEnableHotkeysChanged;

    public bool RecoveryMode
    {
        get => data.RecoveryMode.Value;
        set => data.RecoveryMode.Value = value;
    }
    internal static event Action? OnRecoveryModeChanged;
    


    internal static void Invoke(Action? a, [CallerMemberName] string? caller = "")
    {
        try
        {
            a?.Invoke();
        }
        catch (Exception e)
        {
            LogError($"Error in update event for {caller}:\n{e}");
        }
    }

    internal static void Invoke<T>(Action<T>? a, T arg, [CallerMemberName] string? caller = "")
    {
        try
        {
            a?.Invoke(arg);
        }
        catch (Exception e)
        {
            LogError($"Error in update event for {caller}:\n{e}");
        }
    }
}
