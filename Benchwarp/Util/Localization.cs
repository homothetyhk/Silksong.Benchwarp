namespace Benchwarp.Util;

public static class Localization
{
    private static Dictionary<string, string>? _map;

    internal static void Clear() => _map = null;

    internal static void SetLanguage(string? code)
    {
        if (code is null)
        {
            _map = null;
            return;
        }

        try
        {
            _map = JsonUtil.Deserialize<Dictionary<string, string>>($"Benchwarp.Resources.Langs.{code}.json");
        }
        catch (Exception e)
        {
            LogError($"Error changing language to {code}: {e}");
        }
    }

    public static string Localize(this string text)
    {
        if (BenchwarpPlugin.GS.OverrideLocalization) return text;

        return _map is not null && _map.TryGetValue(text, out string newText) ? newText : text;
    }
}
