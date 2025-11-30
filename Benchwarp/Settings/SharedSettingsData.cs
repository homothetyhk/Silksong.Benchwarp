using Benchwarp.Hotkeys;

namespace Benchwarp.Settings;

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
                [HotkeyActions.DoorWarpGo] = HotkeyActions.DoorWarpGo,
                [HotkeyActions.DoorWarpFlip] = HotkeyActions.DoorWarpFlip,
                [HotkeyActions.DoorWarpLast] = HotkeyActions.DoorWarpLast,
                [HotkeyActions.DoorAreaDropdown] = HotkeyActions.DoorAreaDropdown,
                [HotkeyActions.DoorRoomDropdown] = HotkeyActions.DoorRoomDropdown,
                [HotkeyActions.DoorDoorDropdown] = HotkeyActions.DoorDoorDropdown,
                [HotkeyActions.NextPage] = HotkeyActions.NextPage,
            }
        };
    }

    private Dictionary<string, string> hotkeyOverrides = [];
    public Dictionary<string, string> HotkeyOverrides
    {
        get => hotkeyOverrides;
        set => hotkeyOverrides = value ?? [];
    }
}
