using Benchwarp.Util;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Base class for handling individual GameObjects that control an obstacle.
/// </summary>
public record ObstacleInfo(string ObjPath, ObstacleType Type, ObstacleSeverity Severity)
{
    public string GetObjName() => ObjPath.Split('/').Last();
    public GameObject? FindObj(Scene scene) => scene.FindGameObject(ObjPath)!;
    public void DestroyObj(Scene scene) => UnityEngine.Object.Destroy(FindObj(scene));
    public virtual void Open(Scene scene)
    {
        DestroyObj(scene);
    }
}
