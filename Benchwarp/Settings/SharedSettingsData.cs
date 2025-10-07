using Benchwarp.Data;

namespace Benchwarp.Settings
{
    public class SharedSettingsData
    {
        internal static SharedSettingsData CreateDefault()
        {
            return new()
            {
                HotkeyOverrides = new()
                {
                    [HotkeyActions.LastBench] = HotkeyActions.LastBench,
                    [HotkeyActions.StartBench] = HotkeyActions.StartBench,
                    [HotkeyActions.DoorWarp] = HotkeyActions.DoorWarp,
                    [HotkeyActions.NextPage] = HotkeyActions.NextPage,
                }
            };
        }

        public Dictionary<string, string> HotkeyOverrides = [];
    }
}
