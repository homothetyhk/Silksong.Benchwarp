using TeamCherry.Localization;

namespace Benchwarp.Util;

internal static class Localization
{
    private const string Sheet = $"Mods.{BenchwarpPlugin.Id}";

    public static string GetLanguageString(this string key)
    {
        return Language.Get(key, Sheet);
    }
}
