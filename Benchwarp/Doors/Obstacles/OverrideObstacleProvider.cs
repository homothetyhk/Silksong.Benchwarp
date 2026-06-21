namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// <see cref="IObstacleProvider"/> for on-the-fly usage, which identically yields a fixed sequence of obstacles regardless of room or gate.
/// </summary>
public class OverrideObstacleProvider : IObstacleProvider
{
    public required IEnumerable<ObstacleInfo> Obstacles { get; init; }
    public IEnumerable<ObstacleInfo> GetGateObstacles(RoomData room, DoorData gate) => gate.Obstacles;
}