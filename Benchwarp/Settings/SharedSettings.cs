namespace Benchwarp.Settings;

public class SharedSettings(SharedSettingsData data)
{
    private SharedSettingsData data = data;

    internal string GetHotkey(string code) => data.HotkeyOverrides.TryGetValue(code, out string? altcode) ? altcode : code;

    internal static event Action? OnNewSettingsLoaded;
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

}
