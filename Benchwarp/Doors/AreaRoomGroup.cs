using System.Collections.ObjectModel;

namespace Benchwarp.Doors;

public class AreaRoomGroup
{
    public required string MenuArea { get; init; }
    public required ReadOnlyCollection<RoomData> Rooms { get; init; }
}
