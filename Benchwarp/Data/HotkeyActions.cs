using Benchwarp.Components;
using PlayMaker.ConditionalExpression.Ast;
using System.Collections.ObjectModel;
using System.Threading;
using UnityEngine;

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
            //["DW"], // toggle door warp
            //["DB"], // deploy bench
            ["PP"] = () => GUIController.Instance.NextPage(),
        });


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
            if (BenchwarpPlugin.GS.HotkeyOverrides.TryGetValue(code, out string? altCode))
            {
                if (altCode.Length != 2 || !char.IsLetter(altCode[0]) || !char.IsLetter(altCode[1]))
                {
                    LogError($"Invalid hotkey override {altCode} for {code}: hotkeys must consist of exactly two letters.");
                }
                else
                {
                    code = altCode;
                }
            }
            else if (code.Length != 2 || !char.IsLetter(code[0]) || !char.IsLetter(code[1]))
            {
                LogError($"Invalid custom hotkey {code}: hotkeys must consist of exactly two letters.");
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
