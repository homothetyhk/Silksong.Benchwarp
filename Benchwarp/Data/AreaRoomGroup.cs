using System.Collections.ObjectModel;

namespace Benchwarp.Data;

public class AreaRoomGroup
{
    public required string MenuArea { get; init; }
    public required ReadOnlyCollection<Room> Rooms { get; init; }
}
