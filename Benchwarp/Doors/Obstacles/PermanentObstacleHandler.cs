using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="IObstacleHandler"/> which prefers to permanently remove obstacles where possible.
/// </summary>
public class PermanentObstacleHandler : ObstacleHandler
{
    protected override bool HandleObstacleBeforeTransition(RoomData room, DoorData gate, ObstacleInfo o)
    {
        return HandleObstacle(room, gate, o);
    }

    protected override bool HandleObstacleOnActiveSceneChange(Scene scene, RoomData room, DoorData gate, ObstacleInfo o, bool handledBeforeTransition)
    {
        if (handledBeforeTransition) return false;
        return NoSaveObstacleHandler.HandleObstacle(scene, room, gate, o);
    }

    public static bool HandleObstacle(RoomData room, DoorData gate, ObstacleInfo o)
    {
        return o.TrySave(room, gate);
    }
}
