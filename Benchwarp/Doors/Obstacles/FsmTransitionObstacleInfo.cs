using HutongGames.PlayMaker;
using Silksong.FsmUtil;

namespace Benchwarp.Doors.Obstacles;

public record FsmTransitionObstacleInfo(string ObjPath, string FsmName, string FsmStateName, string FsmEventName, string ToState, ObstacleType Type, ObstacleSeverity Severity, ObstacleSaveInfo? SaveInfo = null)
    : FsmObstacleInfo(ObjPath, FsmName, Type, Severity, SaveInfo)
{
    public override void Open(PlayMakerFSM fsm)
    {
        FsmState state = fsm.MustGetState(FsmStateName);
        state.ChangeTransition(FsmEventName, ToState);
    }
}

