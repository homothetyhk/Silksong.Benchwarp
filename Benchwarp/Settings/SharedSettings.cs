using Benchwarp.Deploy;
using System.Runtime.CompilerServices;

namespace Benchwarp.Settings;

public class SharedSettings(SharedSettingsData data)
{
    private SharedSettingsData data = data;

    public DeployStyles DeployStyle
    {
        get => data.DeployStyle;
        set
        {
            data.DeployStyle = value;
            Invoke(OnDeployStyleChanged);
        }
    }
    internal static event Action? OnDeployStyleChanged;

    internal string GetHotkey(string code) => data.HotkeyOverrides.TryGetValue(code, out string? altcode) ? altcode : code;

    internal static event Action? OnNewSettingsLoaded;

    internal SharedSettingsData GetSerializationData() => data;
    internal void Load(SharedSettingsData data)
    {
        this.data = data;
        try
        {
            OnNewSettingsLoaded?.Invoke();
        }
        catch (Exception e)
        {
            LogError($"Error invoking OnNewSettingsLoaded:\n{e}");
        }
    }

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
}
