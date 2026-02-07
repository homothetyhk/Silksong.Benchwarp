using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which enabling/disabling a Behaviour affects the obstacle.
/// </summary>
public record BehaviourObstacleInfo<T>(string ObjPath, bool Enable, ObstacleType Type, ObstacleSeverity Severity, ObstacleSaveInfo? SaveInfo = null, int Index = 0)
    : ObstacleInfo(ObjPath, Type, Severity, SaveInfo) where T : Behaviour
{
    public Behaviour? FindBehaviour(Scene scene, bool warnIfNotFound = false)
    {
        GameObject? go = FindObj(scene, warnIfNotFound);
        if (!go) return null;

        Behaviour? b = go.GetComponents<T>().ElementAtOrDefault(Index);

        if (!b && warnIfNotFound)
        {
            LogWarn($"GameObject at {ObjPath} did not have {Index + 1} components of type {typeof(T).Name}.");
        }

        return b;
    }

    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is Behaviour b && b)
        {
            b.enabled = Enable;
        }
    }
}