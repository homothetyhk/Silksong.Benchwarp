using Benchwarp.Doors;
using Benchwarp.Doors.Obstacles;
using Benchwarp.Events;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp;

public static class ChangeScene
{
    public static void WarpToRespawn()
    {
        GameManager gm = GameManager.instance;
        if (gm == null)
        {
            LogError($"{nameof(WarpToRespawn)} called while GameManager is null, aborting...");
            return;
        }
        ModEvents.InvokeOnBenchwarp();
        
        PlayerData.instance.atBench = false;

        gm.SaveGame((worked) =>
        {
            if (worked)
            {
                gm.LoadGameFromUI(gm.profileID);
            }
        });

        gm.PauseGameToggle(false);
    }

    public static void WarpToDoor(RoomData room, Doors.DoorData gate)
    {
        GameManager gm = GameManager.instance;
        if (gm == null)
        {
            LogError($"{nameof(WarpToRespawn)} called while GameManager is null, aborting...");
            return;
        }
        ModEvents.InvokeOnDoorwarp(room, gate);
        BenchwarpPlugin.Instance.StartCoroutine(DoWarpToDoor(room, gate));
    }

    private static System.Collections.IEnumerator DoWarpToDoor(RoomData room, Doors.DoorData gate)
    {
        if (GameManager.instance.IsGamePaused())
        {
            yield return GameManager.instance.PauseGameToggleByMenu();
        }

        PlayerData.instance.atBench = false;
        if (HeroController.SilentInstance != null)
        {
            if (HeroController.instance.cState.onConveyor || HeroController.instance.cState.onConveyorV || HeroController.instance.cState.inConveyorZone)
            {
                HeroController.instance.GetComponent<ConveyorMovementHero>()?.StopConveyorMove();
                HeroController.instance.cState.inConveyorZone = false;
                HeroController.instance.cState.onConveyor = false;
                HeroController.instance.cState.onConveyorV = false;
            }
            HeroController.instance.cState.nearBench = false;
        }

        SceneLoad load = GameManager.instance.sceneLoad;
        if (load != null)
        {
            load.Finish += Warp;
        }
        else
        {
            Warp();
        }

        void Warp()
        {
            if (!CanLoadScene(gate.Self.SceneName))
            {
                LogWarn($"Doorwarp aborted: scene {gate.Self.SceneName} is not available. Warping to respawn to avoid a softlock.");
                ChangeScene.WarpToRespawn();
                return;
            }

            IObstacleHandler handler = ModEvents.DoorwarpObstacleHandler;
            handler.BeforeTransition(room, gate);
            
            GameManager.instance.BeginSceneTransition(new DoorwarpSceneLoadInfo(handler, room, gate)
            {
                SceneName = gate.Self.SceneName,
                EntryGateName = gate.Self.GateName,
                PreventCameraFadeOut = false,
                WaitForSceneTransitionCameraFade = true,
                Visualization = GameManager.SceneLoadVisualizations.Default,
                AlwaysUnloadUnusedAssets = true,
                IsFirstLevelForPlayer = false,
            });
        }
    }

    private sealed class DoorwarpSceneLoadInfo(IObstacleHandler handler, RoomData room, Doors.DoorData gate) : GameManager.SceneLoadInfo
    {
        public override void NotifyFetchComplete()
        {
            base.NotifyFetchComplete();
            GameManager.instance.sceneLoad.ActivationComplete += ActivationComplete;
        }

        private void ActivationComplete()
        {
            GameManager.instance.sceneLoad.ActivationComplete -= ActivationComplete;
            Scene newScene = SceneManager.GetActiveScene();
            if (!GateExistsInScene(newScene, gate))
            {
                LogWarn($"Doorwarp aborted: gate {gate.Self} was not found in scene {newScene.name}. Warping to respawn to avoid a softlock.");
                ChangeScene.WarpToRespawn();
                return;
            }
            handler.OnSceneChange(newScene, room, gate);
        }

        private static readonly List<GameObject> gateSearchRoots = new(64);
        private static bool GateExistsInScene(Scene scene, Doors.DoorData gate)
        {
            try
            {
                gateSearchRoots.Clear();
                scene.GetRootGameObjects(gateSearchRoots);
                foreach (GameObject root in gateSearchRoots)
                {
                    foreach (TransitionPoint tp in root.GetComponentsInChildren<TransitionPoint>(includeInactive: true))
                    {
                        if (tp.gameObject.name == gate.Self.GateName) return true;
                    }
                }
            }
            catch (Exception e)
            {
                LogError($"Error while checking for gate {gate.Self} in scene {scene.name}:\n{e}");
                return true; // If unsure, allow the warp rather than blocking it outright.
            }
            finally
            {
                gateSearchRoots.Clear();
            }
            return false;
        }
    }

    private static bool CanLoadScene(string sceneName)
    {
        static bool IsLoadable(string name)
        {
            return Application.CanStreamedLevelBeLoaded(name) || SceneUtility.GetBuildIndexByScenePath(name) >= 0;
        }

        if (IsLoadable(sceneName)) return true;

        // Many scene addressables are prefixed with "Scenes/".
        string prefixed = $"Scenes/{sceneName}";
        return IsLoadable(prefixed);
    }
}
