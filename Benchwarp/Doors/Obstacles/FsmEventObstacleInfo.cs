using Benchwarp.Util;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which sending an FsmEvent on a PlayMakerFSM affects the obstacle.
/// </summary>
public record FsmEventObstacleInfo(string ObjPath, string FsmEventName, ObstacleType Type, ObstacleSeverity Severity) : BehaviourObstacleInfo<PlayMakerFSM>(ObjPath, true, Type, Severity)
{
    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is PlayMakerFSM fsm && fsm)
        {
            fsm.SendEvent(FsmEventName);
        }
    }
}
