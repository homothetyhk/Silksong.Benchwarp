namespace Benchwarp.Doors.Obstacles;

[Flags]
public enum ObstacleSeverity
{
    /// <summary>
    /// An obstacle that modifies save data on entry.
    /// </summary>
    ModifiesSaveData,
    /// <summary>
    /// An obstacle which prevents Hornet from entering the entire room in a normal fashion.
    /// </summary>
    InterruptsEntry,
    /// <summary>
    /// An obstacle which prevents Hornet from reaching a visible position in the room.
    /// </summary>
    LimitsRoomAccess,
    /// <summary>
    /// An obstacle which prevents Hornet from leaving the scene via some transition that should normally be accessible.
    /// </summary>
    LimitsExitAccess,
    /// <summary>
    /// An obstacle which prevents seeing Hornet normally, such as a mask. Does not include foreground layers which exist ordinarily.
    /// </summary>
    LimitsVisibility,
    /// <summary>
    /// An obstacle which has visually abnormal features that don't prevent seeing Hornet.
    /// </summary>
    AbnormalVisual,
}
