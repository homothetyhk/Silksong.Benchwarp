using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which enabling/disabling a TransitionPoint affects the obstacle.
/// </summary>
public record TransitionObstacleInfo(string ObjPath, bool Enabled, ObstacleType Type, ObstacleSeverity Severity) : BehaviourObstacleInfo<TransitionPoint>(ObjPath, Enabled, Type, Severity)
{
    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is TransitionPoint tp && tp)
        {
            tp.enabled = Enabled;
            tp.isInactive = !Enabled;
            tp.IsDisabled = !Enabled;
        }
    }
}