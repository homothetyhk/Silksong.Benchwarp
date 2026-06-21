namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// <see cref="IObstacleProvider"/> which identically yields <see cref="DoorData.Obstacles"/>.
/// </summary>
public class BaseObstacleProvider : IObstacleProvider
{
    public IEnumerable<ObstacleInfo> GetGateObstacles(RoomData room, DoorData gate) => gate.Obstacles;
}
