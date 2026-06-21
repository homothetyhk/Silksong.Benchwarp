using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

public abstract record FsmObstacleInfo(string ObjPath, string FsmName, ObstacleType Type, ObstacleSeverity Severity, ObstacleSaveInfo? SaveInfo = null) 
    : ObstacleInfo(ObjPath, Type, Severity, SaveInfo)
{
    public abstract void Open(PlayMakerFSM fsm);

    public sealed override void Open(Scene scene)
    {
        GameObject? obj = FindObj(scene);
        if (obj == null) return;
        PlayMakerFSM? fsm = obj.LocateMyFSM(FsmName);
        if (fsm == null) return;
        Open(fsm);
    }
}

