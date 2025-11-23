namespace Benchwarp.Doors.Obstacles;

[Flags]
public enum ObstacleSeverity
{
    /// <summary>
    /// An obstacle that modifies save data on entry.
    /// </summary>
    ModifiesSaveData = 1 << 0,
    /// <summary>
    /// An obstacle which prevents Hornet from entering the entire room in a normal fashion.
    /// </summary>
    InterruptsEntry = 1 << 1,
    /// <summary>
    /// An obstacle which prevents Hornet from reaching a visible position in the room.
    /// </summary>
    LimitsRoomAccess = 1 << 2,
    /// <summary>
    /// An obstacle which prevents Hornet from leaving the scene via some transition that should normally be accessible.
    /// </summary>
    LimitsExitAccess = 1 << 3,
    /// <summary>
    /// An obstacle which prevents seeing Hornet normally, such as a mask. Does not include foreground layers which exist ordinarily.
    /// </summary>
    LimitsVisibility = 1 << 4,
    /// <summary>
    /// An obstacle which has visually abnormal features that don't prevent seeing Hornet.
    /// </summary>
    AbnormalVisual = 1 << 5
}
