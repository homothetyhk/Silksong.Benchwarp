namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which setting a PlayerDataBool true/false affects the obstacle.
/// </summary>
public record PdBoolObstacleInfo(string ObjPath, string PlayerDataBoolName, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity), ISaveableObstacle
{
    public void Save(RoomData room, DoorData gate)
    {
        PlayerData.instance.SetBool(PlayerDataBoolName, true);
    }
}
