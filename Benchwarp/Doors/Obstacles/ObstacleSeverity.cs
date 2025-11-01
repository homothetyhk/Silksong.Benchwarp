namespace Benchwarp.Doors.Obstacles;

public enum ObstacleSeverity
{
    /// <summary>
    /// An obstacle which pushes Hornet back into the transition.
    /// </summary>
    InterruptsEntry,
    /// <summary>
    /// An obstacle which causes Hornet to enter from the wrong transition.
    /// </summary>
    WrongEntry,
    /// <summary>
    /// An obstacle which does not interupt entry, but does prevent Hornet from reaching a visible position in the room.
    /// </summary>
    VisualAndLimitsRoomAccess,
    /// <summary>
    /// An obstacle which does not interupt entry or prevent access to a visible position in the room, but prevents the exit of the scene via some door.
    /// </summary>
    LimitsDoorExit,
    /// <summary>
    /// A purely visual obstacle which prevents seeing Hornet, such as a mask. Does not include foreground layers which exist ordinarily.
    /// </summary>
    Visual,
}
