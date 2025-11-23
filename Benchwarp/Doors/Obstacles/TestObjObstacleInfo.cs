using Benchwarp.Util;
using UnityEngine.SceneManagement;

namespace Benchwarp.Doors.Obstacles;

/// <summary>
/// An <see cref="ObstacleInfo"/> of which toggling a TestGameObjectActivator's GameObjects affects the obstacle.
/// </summary>
public record TestObjObstacleInfo(string ObjPath, bool Activate, ObstacleType Type, ObstacleSeverity Severity) : BehaviourObstacleInfo(ObjPath, nameof(TestGameObjectActivator), Activate, Type, Severity)
{
    public TestGameObjectActivator? GetTestGameObjectActivator(Scene scene) => scene.FindGameObject(ObjPath)?.GetComponent<TestGameObjectActivator>();

    public override void Open(Scene scene)
    {
        if (GetTestGameObjectActivator(scene) is TestGameObjectActivator tgoa)
        {
            tgoa.enabled = false;

            tgoa.activateGameObject?.SetActive(Activate);
            tgoa.deactivateGameObject?.SetActive(!Activate);
        }
    }
}
