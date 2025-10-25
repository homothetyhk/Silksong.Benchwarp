using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

internal class FontManager : MonoBehaviour
{
    private static Font? Trajan;

    private static Font Mono
    {
        get
        {
            if (!field)
            {
                string[] systemFonts = Font.GetOSInstalledFontNames();
                if (systemFonts.Contains("Consolas")) return field = Font.CreateDynamicFontFromOSFont("Consolas", 16);
                else if (systemFonts.Contains("Courier")) return field = Font.CreateDynamicFontFromOSFont("Courier", 16);
                else if (systemFonts.Contains("Arial")) return field = Font.CreateDynamicFontFromOSFont("Arial", 16);
                else return field = Font.CreateDynamicFontFromOSFont(systemFonts[0], 16);
            }
            else return field;
        }
    }

    internal static void SetMonoFont(Text requester)
    {
        requester.font = Mono;
    }

    private static event Action? OnTrajanLoaded;
    internal static void SetTrajanFont(Text requester)
    {
        if (Trajan) requester.font = Trajan;
        else
        {
            requester.font = Mono;
            OnTrajanLoaded += () => requester.font = Trajan;
        }
    }

    private void Start()
    {
        StartCoroutine(FindTrajan());
    }

    private System.Collections.IEnumerator FindTrajan()
    {
        while (true)
        {
            yield return null; // takes about 1 second to exist
            Trajan = Resources.FindObjectsOfTypeAll<Font>().FirstOrDefault(f => f.name == "TrajanPro-Bold");
            if (Trajan) break;
        }
        
        OnTrajanLoaded?.Invoke();
        OnTrajanLoaded = null;
    }

}
