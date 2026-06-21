using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="IObstacleHandler"/> which avoids permanently modifying save data to remove obstacles.
/// </summary>
public class NoSaveObstacleHandler : ObstacleHandler
{
    protected override bool HandleObstacleOnActiveSceneChange(Scene scene, RoomData room, DoorData gate, ObstacleInfo o, bool handledBeforeTransition)
    {
        return HandleObstacle(scene, room, gate, o);
    }

    public static bool HandleObstacle(Scene scene, RoomData room, DoorData gate, ObstacleInfo o)
    {
        o.Open(scene);
        return true;
    }
}
