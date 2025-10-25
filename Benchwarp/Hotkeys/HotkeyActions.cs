using Benchwarp.Benches;
using Benchwarp.Components;
using Benchwarp.Events;
using System.Collections.ObjectModel;

namespace Benchwarp.Hotkeys;

public static class HotkeyActions
{
    public const string LastBench = "LB";
    public const string StartBench = "SB";
    public const string DoorWarp = "DW";
    public const string NextPage = "NP";


    /// <summary>
    /// The current list of letter hotkey codes, accounting for hotkey overrides.
    /// </summary>
    public static ReadOnlyDictionary<string, Action> CurrentHotkeys { get; } = new(_hotkeys = []);
    private static readonly Dictionary<string, Action> _hotkeys;

    public static ReadOnlyDictionary<string, Action> BaseHotkeys { get; } = new(new Dictionary<string, Action>
    {
        [LastBench] = ChangeScene.WarpToRespawn,
        [StartBench] = (Action)BenchListModifiers.MenuSetToStart + ChangeScene.WarpToRespawn,
        //["WD"], // warp deploy
        //["TM"], // toggle menu
        [DoorWarp] = () =>
        {
            if (BenchwarpPlugin.ConfigSettings.MenuMode != Settings.MenuMode.DoorWarp) BenchwarpPlugin.ConfigSettings.MenuMode = Settings.MenuMode.DoorWarp;
            else BenchwarpPlugin.ConfigSettings.MenuMode = Settings.MenuMode.StandardBenchwarp;
        },
        //["DB"], // deploy bench
        [NextPage] = () => GUIController.Instance.NextPage(),
    });

    static HotkeyActions()
    {
        RefreshHotkeys();
    }

    public static void RefreshHotkeys()
    {
        _hotkeys.Clear();
        foreach ((string code, Action a) in BaseHotkeys) AddHotkey(_hotkeys, code, a);

        foreach ((string code, Action? a) in ModEvents.GetHotkeyRequests())
        {
            if (a is null) _hotkeys.Remove(code);
            else AddHotkey(_hotkeys, code, a);
        }
    }

    internal static void AddHotkey(Dictionary<string, Action> dict, string code, Action a)
    {
        code = BenchwarpPlugin.SharedSettings.GetHotkey(code);
        if (code.Length != 2 || !char.IsLetter(code[0]) || !char.IsLetter(code[1]))
        {
            LogError($"Invalid hotkey {code}: hotkeys must consist of exactly two letters.");
            return;
        }
        dict[code] = a;
    }

    public static bool TryDoHotkeyAction(int groupIndex, int benchIndex)
    {
        if (BenchList.BenchGroups.Count > groupIndex && BenchList.BenchGroups[groupIndex].Benches.Count > benchIndex)
        {
            BenchList.BenchGroups[groupIndex].Benches[benchIndex].MenuSetBench();
            ChangeScene.WarpToRespawn();
            return true;
        }
        return false;
    }

    public static bool TryDoHotkeyAction(string code)
    {
        if (CurrentHotkeys.TryGetValue(code, out Action a))
        {
            try
            {
                a?.Invoke();
            }
            catch (Exception e)
            {
                LogError($"Error invoking hotkey bound to {code}:\n{e}");
            }
            return true;
        }
        return false;
    }
}
