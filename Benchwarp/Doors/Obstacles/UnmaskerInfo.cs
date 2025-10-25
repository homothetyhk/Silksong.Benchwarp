using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

public record UnmaskerInfo(string ObjPath) : ObstacleInfo(ObjPath, ObstacleType.Mask, ObstacleSeverity.Visual)
{
    public Unmasker? GetUnmasker(Scene scene) => FindObj(scene)?.GetComponent<Unmasker>();
    public void Uncover(Scene scene) => GetUnmasker(scene)?.Uncover();
}
