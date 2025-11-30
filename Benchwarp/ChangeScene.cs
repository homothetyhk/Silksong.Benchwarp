using Benchwarp.Doors;
using Benchwarp.Doors.Obstacles;
using Benchwarp.Events;
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

        gm.StartCoroutine(gm.PauseGameToggle(false));
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

    private class DoorwarpSceneLoadInfo(IObstacleHandler handler, RoomData room, Doors.DoorData gate) : GameManager.SceneLoadInfo
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
            handler.OnSceneChange(newScene, room, gate);
        }
    }
}
