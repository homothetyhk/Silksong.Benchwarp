using Benchwarp.Doors.Obstacles;
using System.Collections.ObjectModel;

namespace Benchwarp.Doors;

public class DoorData
{
    public DoorData(TransitionKey self, TransitionKey sourcetarget)
    {
        Self = self;
        Target = sourcetarget;
        Source = sourcetarget;
    }

    public DoorData(TransitionKey self, TransitionKey? source, TransitionKey? target)
    {
        Self = self;
        Target = target;
        Source = source;
    }

    public TransitionKey Self { get; }
    public TransitionKey? Target { get; }
    public TransitionKey? Source { get; }
    public ReadOnlyCollection<ObstacleInfo> Obstacles { get; init; } = empty;

    private static readonly ReadOnlyCollection<ObstacleInfo> empty = new([]);

}
