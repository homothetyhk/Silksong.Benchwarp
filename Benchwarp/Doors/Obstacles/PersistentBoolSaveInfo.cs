namespace Benchwarp.Doors.Obstacles;

public record PersistentBoolSaveInfo(string? SceneName = null, string? ID = null) : ObstacleSaveInfo
{
    public override void Save(RoomData room, DoorData gate, string objName)
    {
        SceneData.instance.PersistentBools.SetValue(new() { SceneName = SceneName ?? room.Name, ID = ID ?? objName, Value = true });
    }
}
