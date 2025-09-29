using System.Collections.ObjectModel;

namespace Benchwarp
{
    public static class Hotkeys
    {
        /// <summary>
        /// The current list of letter hotkey codes, accounting for hotkey overrides.
        /// </summary>
        public static ReadOnlyDictionary<string, int> CurrentHotkeys { get; } = new(_hotkeys = new());
        private static readonly Dictionary<string, int> _hotkeys;
        private static readonly Dictionary<int, Action> _customHotkeyActions = new();

        public const int LastBenchID = -1;
        public const int StartBenchID = -2;
        public const int WarpDeployID = -3;
        public const int ToggleMenuID = -4;
        public const int DoorWarpID = -5;
        public const int DeployBenchID = -6;
        public const int NextPageID = -7;
        /// <summary>
        /// The first id reserved for custom hotkey actions.
        /// </summary>
        public static int CustomActionID { get => NextPageID - 1; }

        public static void RefreshHotkeys()
        {
            _hotkeys.Clear();
            _customHotkeyActions.Clear();

            _hotkeys.AddHotkey("LB", LastBenchID);
            _hotkeys.AddHotkey("SB", StartBenchID);
            _hotkeys.AddHotkey("WD", WarpDeployID);
            _hotkeys.AddHotkey("TM", ToggleMenuID);
            _hotkeys.AddHotkey("DW", DoorWarpID);
            _hotkeys.AddHotkey("DB", DeployBenchID);
            _hotkeys.AddHotkey("PP", NextPageID);

            foreach ((string code, Action a) in Events.GetHotkeyRequests())
            {
                if (code != null)
                {
                    int id = CustomActionID - _customHotkeyActions.Count;
                    _hotkeys.AddHotkey(code, id);
                    _customHotkeyActions.Add(id, a);
                }
            }
        }

        internal static void AddHotkey(this Dictionary<string, int> dict, string code, int id)
        {
            if (BenchwarpPlugin.GS.HotkeyOverrides.TryGetValue(code, out string altCode))
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
            try
            {
                dict.Add(code, id);
            }
            catch (ArgumentException)
            {
                LogError($"Duplicate binding for hotkey '{code}'");
            }
        }
    }
}
