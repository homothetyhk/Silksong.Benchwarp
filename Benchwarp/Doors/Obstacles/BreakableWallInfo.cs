namespace Benchwarp.Doors.Obstacles;

public record BreakableWallInfo(string ObjPath, string FsmName, ObstacleSeverity Severity, string? PlayerDataBoolName = null) : FsmObstacleInfo(ObjPath, FsmName, ObstacleType.BreakableWall, Severity), ISaveableObstacle
{
    public void Save(RoomData room, DoorData gate)
    {
        if (PlayerDataBoolName is not null) PlayerData.instance.SetBool(PlayerDataBoolName, true);
        SavePersistentBool(room);
    }
}
