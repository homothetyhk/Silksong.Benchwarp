using System.Collections.ObjectModel;
using GlobalEnums;

namespace Benchwarp.Doors;

public class RoomData
{
    public required string Name { get; init; }
    public required MapZone MapZone { get; init; }
    public required string MapArea { get; init; }
    public required string TitledArea { get; init; }
    public required ReadOnlyCollection<DoorData> Gates { get; init; }
    public bool ManuallyVerified { get; init; } = true;
}
