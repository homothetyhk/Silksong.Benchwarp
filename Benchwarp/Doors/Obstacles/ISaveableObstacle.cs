namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Interface for obstacles which can be disabled by saving PlayerData or SceneData prior to transition.
/// </summary>
public interface ISaveableObstacle
{
    /// <summary>
    /// To be called by an <see cref="IObstacleHandler"/> before transition.
    /// </summary>
    void Save(RoomData room, DoorData gate);
}
