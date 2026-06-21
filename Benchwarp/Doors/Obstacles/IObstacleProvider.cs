namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Interface to provide obstacles to an obstacle handler.
/// </summary>
public interface IObstacleProvider
{
    IEnumerable<ObstacleInfo> GetGateObstacles(RoomData room, DoorData gate);
}
