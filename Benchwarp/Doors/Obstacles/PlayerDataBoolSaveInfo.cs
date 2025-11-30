namespace Benchwarp.Doors.Obstacles;

public record PlayerDataBoolSaveInfo(string PlayerDataBoolName) : ObstacleSaveInfo
{
    public override void Save(RoomData room, DoorData gate, string objName)
    {
        PlayerData.instance.SetBool(PlayerDataBoolName, true);
    }
}
