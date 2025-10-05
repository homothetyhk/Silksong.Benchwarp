using System.Collections.ObjectModel;

namespace Benchwarp.Data;

public class Room
{
    public required string Name { get; init; }
    public required string MapArea { get; init; }
    public required string TitledArea { get; init; }
    public required ReadOnlyCollection<Gate> Gates { get; init; }
    public bool ManuallyVerified { get; init; } = false;
}
