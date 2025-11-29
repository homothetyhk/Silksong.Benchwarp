using Benchwarp.Doors.Obstacles;
using System.Collections.ObjectModel;

namespace Benchwarp.Doors;

public class DoorData
{
    public DoorData (TransitionKey self)
    {
        Self = self;
        Target = self;
    }

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
    // Currently unused, just extra data
    public ReadOnlyCollection<TransitionKey> DynamicTargets { get; init; } = emptyDynamicTargets;
    public ReadOnlyCollection<ObstacleInfo> Obstacles { get; init; } = emptyObstacles;

    private static readonly ReadOnlyCollection<TransitionKey> emptyDynamicTargets = new([]);
    private static readonly ReadOnlyCollection<ObstacleInfo> emptyObstacles = new([]);

}
