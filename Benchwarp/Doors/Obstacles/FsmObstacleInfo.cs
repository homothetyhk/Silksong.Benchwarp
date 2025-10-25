using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

public record FsmObstacleInfo(string ObjPath, string FsmName, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity)
{
    public PlayMakerFSM FindFsm(Scene scene) => FindObj(scene).LocateMyFSM(FsmName);
}
