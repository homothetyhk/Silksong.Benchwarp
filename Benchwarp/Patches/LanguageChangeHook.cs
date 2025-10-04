using Benchwarp.Util;
using TeamCherry.Localization;

namespace Benchwarp.Patches;

internal static class LanguageChangeHook
{
    internal static void Hook()
    {
        On.TeamCherry.Localization.Language.SwitchLanguage_LanguageCode += Language_SwitchLanguage_LanguageCode;
    }

    internal static void Unhook()
    {
        On.TeamCherry.Localization.Language.SwitchLanguage_LanguageCode -= Language_SwitchLanguage_LanguageCode;
        Localization.Clear();
    }

    private static bool Language_SwitchLanguage_LanguageCode(On.TeamCherry.Localization.Language.orig_SwitchLanguage_LanguageCode orig, LanguageCode code)
    {
        if (_langs.Contains(code)) Localization.SetLanguage(code.ToString().ToLowerInvariant());
        return orig(code);
    }

    static LanguageChangeHook()
    {
        /*
        _langs = [];
        foreach (string s in typeof(LanguageChangeHook).Assembly.GetManifestResourceNames())
        {
            string[] components = s.Split('.'); // Benchwarp.Resources.Langs.{code}.json
            if (components.Length != 5
                || components[2] != "Langs"
                ) continue;
            _langs.Add((LanguageCode)Enum.Parse(typeof(LanguageCode), components[3], ignoreCase: true));
        }
        */
    }

    private static readonly HashSet<LanguageCode> _langs;
}
