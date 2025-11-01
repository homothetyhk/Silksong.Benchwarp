using Benchwarp.Util;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// <see cref="FsmObstacleInfo"/> where an FSM may close a door on entry.
/// The effects can also happen regardless of which transition the scene is entered by.
/// </summary>
public record ClosingDoorInfo(string ObjPath, string FsmName, string TransitionObjPath) : FsmObstacleInfo(ObjPath, FsmName, ObstacleType.Other, ObstacleSeverity.LimitsDoorExit)
{
    public TransitionPoint? GetTransitionPoint(Scene scene) => scene.FindGameObject(TransitionObjPath)?.GetComponent<TransitionPoint>();

    public override void Open(Scene scene)
    {
        if (FindFsm(scene) is PlayMakerFSM fsm)
        {
            fsm.enabled = false;
        }
        GetTransitionPoint(scene)?.SetIsInactive(false);
    }
}
