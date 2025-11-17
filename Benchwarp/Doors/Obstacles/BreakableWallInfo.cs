namespace Benchwarp.Doors.Obstacles;

public record BreakableWallInfo(string ObjPath, BreakableWallType BreakableWallType, ObstacleSeverity Severity, string? PlayerDataBoolName = null) : ObstacleInfo(ObjPath, ObstacleType.BreakableWall, Severity), ISaveableObstacle
{
    public void Save(RoomData room, DoorData gate)
    {
        if (PlayerDataBoolName is not null) PlayerData.instance.SetBool(PlayerDataBoolName, true);
        SavePersistentBool(room);
    }
}
