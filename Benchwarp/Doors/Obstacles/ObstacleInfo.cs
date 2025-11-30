using Benchwarp.Util;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Base class for handling individual GameObjects that control an obstacle.
/// </summary>
public record ObstacleInfo(string ObjPath, ObstacleType Type, ObstacleSeverity Severity, ObstacleSaveInfo? SaveInfo = null)
{
    public string GetObjName() => ObjPath.Split('/').Last();
    public GameObject? FindObj(Scene scene) => scene.FindGameObject(ObjPath)!;
    public void DestroyObj(Scene scene) => UnityEngine.Object.Destroy(FindObj(scene));

    /// <summary>
    /// To be called by an <see cref="IObstacleHandler"/> on active scene change.
    /// </summary>
    public virtual void Open(Scene scene)
    {
        DestroyObj(scene);
    }

    /// <summary>
    /// To be called by an <see cref="IObstacleHandler"/> before transition.
    /// </summary>
    public bool TrySave(RoomData room, DoorData gate)
    {
        if (SaveInfo is not null)
        {
            SaveInfo.Save(room, gate, GetObjName());
            return true;
        }
        return false;
    }
}
