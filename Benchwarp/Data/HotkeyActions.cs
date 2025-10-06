using Benchwarp.Components;
using System.Collections.ObjectModel;

namespace Benchwarp.Data
{
    public static class HotkeyActions
    {
        /// <summary>
        /// The current list of letter hotkey codes, accounting for hotkey overrides.
        /// </summary>
        public static ReadOnlyDictionary<string, Action> CurrentHotkeys { get; } = new(_hotkeys = []);
        private static readonly Dictionary<string, Action> _hotkeys;

        public static ReadOnlyDictionary<string, Action> BaseHotkeys { get; } = new(new Dictionary<string, Action>
        {
            ["LB"] = ChangeScene.WarpToRespawn,
            ["SB"] = (Action)Events.BenchListModifiers.SetToStart + ChangeScene.WarpToRespawn,
            //["WD"], // warp deploy
            //["TM"], // toggle menu
            ["DW"] = () =>
            {
                if (BenchwarpPlugin.GS.MenuMode != Settings.MenuMode.DoorWarp) BenchwarpPlugin.GS.MenuMode = Settings.MenuMode.DoorWarp;
                else BenchwarpPlugin.GS.MenuMode = Settings.MenuMode.StandardBenchwarp;
            },
            //["DB"], // deploy bench
            ["NP"] = () => GUIController.Instance.NextPage(),
        });

        static HotkeyActions()
        {
            RefreshHotkeys();
        }

        public static void RefreshHotkeys()
        {
            _hotkeys.Clear();
            foreach ((string code, Action a) in BaseHotkeys) AddHotkey(_hotkeys, code, a);

            foreach ((string code, Action? a) in Events.ModEvents.GetHotkeyRequests())
            {
                if (a is null) _hotkeys.Remove(code);
                else AddHotkey(_hotkeys, code, a);
            }
        }

        internal static void AddHotkey(Dictionary<string, Action> dict, string code, Action a)
        {
            code = BenchwarpPlugin.GS.GetHotkey(code);
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
                BenchList.BenchGroups[groupIndex].Benches[benchIndex].RespawnInfo.SetRespawn();
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
}
