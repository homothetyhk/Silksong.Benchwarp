using HutongGames.PlayMaker;
using Silksong.FsmUtil;

namespace Benchwarp.Doors.Obstacles;

public record FsmEventObstacleInfo(string ObjPath, string FsmName, string FsmEventName, ObstacleType Type, ObstacleSeverity Severity, ObstacleSaveInfo? SaveInfo = null)
    : FsmObstacleInfo(ObjPath, FsmName, Type, Severity, SaveInfo)
{
    public override void Open(PlayMakerFSM fsm)
    {
        fsm.SendEvent(FsmEventName);
    }
}

