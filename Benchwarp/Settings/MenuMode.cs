using System.ComponentModel;

namespace Benchwarp.Settings;

public enum MenuMode
{
    [Description("StandardBenchwarp: warp to visited benches only.")]
    StandardBenchwarp,
    [Description("WarpOnly: warp to current respawn only.")]
    WarpOnly,
    [Description("UnlockAll: warp to any bench.")]
    UnlockAll,
    [Description("DoorWarp: warp to room transitions.")]
    DoorWarp,
}
