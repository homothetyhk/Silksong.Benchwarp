using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which controlling an Unmasker affects the obstacle.
/// </summary>
public record UnmaskerInfo(string ObjPath) : BehaviourObstacleInfo(ObjPath, nameof(Unmasker), false, ObstacleType.Mask, ObstacleSeverity.LimitsVisibility)
{
    public override void Open(Scene scene)
    {
        if (FindBehaviour(scene) is Unmasker unmasker && unmasker)
        {
            unmasker.Uncover();
        }
    }
}
