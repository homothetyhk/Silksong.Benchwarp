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

        public static void WarpToDoor(string sceneName, string gateName)
        {
            GameManager gm = GameManager.instance;
            if (gm == null)
            {
                LogError($"{nameof(WarpToRespawn)} called while GameManager is null, aborting...");
                return;
            }
            ModEvents.InvokeOnDoorwarp(sceneName, gateName);
            BenchwarpPlugin.Instance.StartCoroutine(DoWarpToDoor(sceneName, gateName));
        }

        private static System.Collections.IEnumerator DoWarpToDoor(string sceneName, string gateName)
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

            void Warp() => GameManager.instance.BeginSceneTransition(new DoorwarpSceneLoadInfo
            {
                SceneName = sceneName,
                EntryGateName = gateName,
                PreventCameraFadeOut = false,
                WaitForSceneTransitionCameraFade = true,
                Visualization = GameManager.SceneLoadVisualizations.Default,
                AlwaysUnloadUnusedAssets = true,
                IsFirstLevelForPlayer = false,
            });
        }

        // using a custom subclass allows other mods to detect and distinguish doorwarps from ordinary transitions
        private class DoorwarpSceneLoadInfo : GameManager.SceneLoadInfo;
    }
}
