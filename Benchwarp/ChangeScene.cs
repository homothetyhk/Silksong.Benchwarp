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

            GameManager.instance.PauseGameToggle(false);
            GameManager.instance.ChangeToScene(sceneName, gateName, pauseBeforeEnter: 0.0f);
        }
    }
}
