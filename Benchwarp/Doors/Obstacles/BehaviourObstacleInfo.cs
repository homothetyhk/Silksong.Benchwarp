using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which enabling/disabling a Behaviour affects the obstacle.
/// </summary>
public record BehaviourObstacleInfo(string ObjPath, string BehaviourType, bool Enable, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity)
{
    public Behaviour? FindBehaviour(Scene scene) => FindObj(scene)?.GetComponents<Behaviour>().FirstOrDefault(c => c?.GetType().Name == BehaviourType);

    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is Behaviour b && b)
        {
            b.enabled = Enable;
        }
    }
}