namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Base class for handling obstacles by saving PlayerData or SceneData prior to transition.
/// </summary>
public abstract record ObstacleSaveInfo
{
    public abstract void Save(RoomData room, DoorData gate, string objName);
}
