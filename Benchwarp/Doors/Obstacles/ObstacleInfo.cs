using Benchwarp.Util;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

public record ObstacleInfo(string ObjPath, ObstacleType Type, ObstacleSeverity Severity)
{
    public string GetObjName() => ObjPath.Split('/').Last();
    public GameObject? FindObj(Scene scene) => scene.FindGameObject(ObjPath)!;
    public void DestroyObj(Scene scene) => UnityEngine.Object.Destroy(FindObj(scene));
    public void DeactivateObj(Scene scene) => FindObj(scene)?.SetActive(false);
    public void SavePersistentBool(RoomData room) => SceneData.instance.persistentBools.SetValue(new() { SceneName = room.Name, ID = GetObjName(), IsSemiPersistent = false, Mutator = SceneData.PersistentMutatorTypes.None, Value = true });

    public virtual void Open(Scene scene)
    {
        DestroyObj(scene);
    }
}
