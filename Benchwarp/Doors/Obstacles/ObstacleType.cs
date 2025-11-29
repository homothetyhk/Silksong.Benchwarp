namespace Benchwarp.Doors.Obstacles;

public enum ObstacleType
{
    /// <summary>
    /// A purely visual obstacle that affects visibility of Hornet (no collision or interaction).
    /// </summary>
    Mask,

    /// <summary>
    /// A breakable wall that opens only from this side.
    /// </summary>
    OneWayBreakableEntry,

    /// <summary>
    /// A breakable wall that opens only from the other side.
    /// </summary>
    OneWayBreakableExit,

    /// <summary>
    /// A wall that opens by switch/lever mechanism, controlled only from this side.
    /// </summary>
    OneWayMechanismEntry,

    /// <summary>
    /// A wall that opens by switch/lever mechanism, controlled only from the other side.
    /// </summary>
    OneWayMechanismExit,

    /// <summary>
    /// A wall/transition that opens after progressing further into the game in some abstract way.
    /// </summary>
    OpenAfterProgression,

    /// <summary>
    /// A wall/transition that closes after progressing further into the game in some abstract way.
    /// </summary>
    ClosedAfterProgression,

    /// <summary>
    /// An obstacle involving taking control of Hornet and/or a cutscene.
    /// </summary>
    Cutscene,

    /// <summary>
    /// Anything else that does not fit into the other categories.
    /// </summary>
    Other

    // /// <summary>
    // /// A breakable wall that opens from both sides.
    // /// </summary>
    // TwoWayBreakable,

    // /// <summary>
    // /// A wall that opens by switch/lever mechanism, controlled from both sides.
    // /// </summary>
    // TwoWayMechanism,
}
