using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Interface to remove or negate obstacles that block transitions when entering from unexpected directions, such as due to Doorwarp.
/// </summary>
public interface IObstacleHandler
{
    /// <summary>
    /// Called immediately before GameManager.BeginSceneTransition.
    /// </summary>
    void BeforeTransition(RoomData room, DoorData gate);
    /// <summary>
    /// Called immediately after the new scene is activated.
    /// </summary>
    void OnSceneChange(Scene scene, RoomData room, DoorData gate);
}
