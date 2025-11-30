using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which activating/deactivating a GameObject affects the obstacle.
/// </summary>
public record GameObjectActiveObstacleInfo(string ObjPath, bool Active, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity)
{
    public override void Open(Scene scene)
    {
        FindObj(scene)?.SetActive(Active);
    }
}
