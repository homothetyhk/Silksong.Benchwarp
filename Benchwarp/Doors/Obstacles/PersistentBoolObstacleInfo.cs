namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which setting PersistentBoolData affects the obstacle.
/// The PersistentBoolData's scene name and ID may not match the current scene or owner object.
/// </summary>
public record PersistentBoolObstacleInfo(string ObjPath, ObstacleType Type, ObstacleSeverity Severity, string? SceneName = null, string? ID = null)
    : ObstacleInfo(ObjPath, Type, Severity), ISaveableObstacle
{
    public void SavePersistentBool(RoomData room) => SceneData.instance.PersistentBools.SetValue(new() { SceneName = SceneName ?? room.Name, ID = ID ?? ObjPath, Value = true });

    public void Save(RoomData room, DoorData gate)
    {
        SavePersistentBool(room);
    }
}
