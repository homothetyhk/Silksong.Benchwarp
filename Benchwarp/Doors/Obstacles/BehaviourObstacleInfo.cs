using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which enabling/disabling a Behaviour affects the obstacle.
/// </summary>
public record BehaviourObstacleInfo<T>(string ObjPath, bool Enable, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity) where T : Behaviour
{
    public Behaviour? FindBehaviour(Scene scene) => FindObj(scene)?.GetComponent<T>();

    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is Behaviour b && b)
        {
            b.enabled = Enable;
        }
    }
}