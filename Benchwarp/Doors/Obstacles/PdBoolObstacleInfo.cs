namespace Benchwarp.Doors.Obstacles;

public record PdBoolObstacleInfo(string ObjPath, string PlayerDataBoolName, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity), ISaveableObstacle
{
    public void Save(RoomData room, DoorData gate)
    {
        PlayerData.instance.SetBool(PlayerDataBoolName, true);
    }
}
