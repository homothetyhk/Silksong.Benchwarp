using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// Scaffolding to help implement <see cref="IObstacleHandler"/>. Produces a warning for unhandled obstacles at runtime.
/// </summary>
public abstract class ObstacleHandler : IObstacleHandler
{
    /// <summary>
    /// The collection of obstacles for the current transition which have been handled. Additions are managed by the base class.
    /// All HandleObstacle events are called regardless of whether the obstacle has already been handled by a previous call.
    /// </summary>
    protected readonly HashSet<ObstacleInfo> handledObstacles = [];

    public void BeforeTransition(RoomData room, DoorData gate)
    {
        handledObstacles.Clear();
        foreach (ObstacleInfo o in gate.Obstacles)
        {
            try
            {
                if (HandleObstacleBeforeTransition(room, gate, o)) handledObstacles.Add(o);
            }
            catch (Exception e)
            {
                LogError($"Error handling obstacle {o} before transition for gate {gate.Self}:\n{e}");
            }
        }
    }

    public void OnSceneChange(Scene scene, RoomData room, DoorData gate)
    {
        foreach (ObstacleInfo o in gate.Obstacles)
        {

            try
            {
                if (HandleObstacleOnActiveSceneChange(scene, room, gate, o)) handledObstacles.Add(o);
            }
            catch (Exception e)
            {
                LogError($"Error handling obstacle {o} on scene change for gate {gate.Self}:\n{e}");
            }
        }
        IEnumerable<ObstacleInfo> unhandledObstacles = gate.Obstacles.Where(o => !handledObstacles.Contains(o));
        if (unhandledObstacles.Any())
        {
            LogWarn($"ObstacleHandler {GetType().Name} for gate {gate.Self.Name} did not handle the following obstacles: {string.Join("; ", unhandledObstacles)}");
        }
        handledObstacles.Clear();
    }

    public virtual bool HandleObstacleBeforeTransition(RoomData room, DoorData gate, ObstacleInfo o) => false;
    public virtual bool HandleObstacleOnActiveSceneChange(Scene scene, RoomData room, DoorData gate, ObstacleInfo o) => false;
}
