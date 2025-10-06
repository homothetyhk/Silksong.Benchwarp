using UnityEngine;

namespace Benchwarp
{
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
            Events.ModEvents.InvokeOnBenchwarp();
            
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

        public static void WarpToDoor(string sceneName, string gateName)
        {
            GameManager gm = GameManager.instance;
            if (gm == null)
            {
                LogError($"{nameof(WarpToRespawn)} called while GameManager is null, aborting...");
                return;
            }
            Events.ModEvents.InvokeOnDoorwarp(sceneName, gateName);
            try
            {
                // HK code for resetting state
                UIManager.instance.UIClosePauseMenu();
                Time.timeScale = 1.0f;
                GameManager.instance.FadeSceneIn();
                GameManager.instance.isPaused = false;
                GameCameras.instance.ResumeCameraShake();
                if (HeroController.SilentInstance != null) HeroController.instance.UnPause();
                MenuButtonList.ClearAllLastSelected();
                TimeManager.TimeScale = 1.0f;
                GameManager.instance.actorSnapshotUnpaused.TransitionTo(0f);
                GameManager.instance.ui.AudioGoToGameplay(.2f);
                if (HeroController.SilentInstance != null) HeroController.instance.UnPause();
                MenuButtonList.ClearAllLastSelected();
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
                    load.Finish += () => GameManager.instance.ChangeToScene(sceneName, gateName, 0.0f);
                }
                else
                {
                    GameManager.instance.ChangeToScene(sceneName, gateName, 0.0f);
                }

            }
            catch (Exception e)
            {
                LogError($"Error during {nameof(WarpToDoor)}:\n{e}");
            }
        }
    }
}
