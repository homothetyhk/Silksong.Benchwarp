using Benchwarp.Util;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// <see cref="ObstacleInfo"/> with a TestGameObjectActivator that controls its state.
/// </summary>
public record TestObjObstacleInfo(string ObjPath, ObstacleType Type, ObstacleSeverity Severity) : ObstacleInfo(ObjPath, Type, Severity)
{
    public TestGameObjectActivator? GetTestGameObjectActivator(Scene scene) => scene.FindGameObject(ObjPath)?.GetComponent<TestGameObjectActivator>();

    public override void Open(Scene scene)
    {
        if (GetTestGameObjectActivator(scene) is TestGameObjectActivator tgoa)
        {
            tgoa.enabled = false;
            tgoa.activateGameObject?.SetActive(true);
            tgoa.deactivateGameObject?.SetActive(false);
        }
    }
}
