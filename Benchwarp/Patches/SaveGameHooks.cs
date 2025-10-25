namespace Benchwarp.Patches;

internal static class SaveGameHooks
{
    internal static void Hook()
    {
        On.GameManager.SaveGame_Action1 += OnSaveGame;
        On.GameManager.ContinueGame += OnContinueGame;
        UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnMainMenu;
    }

    internal static void Unhook()
    {
        On.GameManager.SaveGame_Action1 -= OnSaveGame;
        On.GameManager.ContinueGame -= OnContinueGame;
        UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= OnMainMenu;
    }

    private static void OnMainMenu(UnityEngine.SceneManagement.Scene from, UnityEngine.SceneManagement.Scene to)
    {
        if (to.name == "Menu_Title")
        {
            BenchwarpPlugin.SaveSettings.Load(new());
        }
    }

    private static void OnSaveGame(On.GameManager.orig_SaveGame_Action1 orig, GameManager self, Action<bool> callback)
    {
        try
        {
            int profileID = self.profileID;
            BepInEx.ThreadingHelper.Instance.StartAsyncInvoke(() =>
            {
                BenchwarpPlugin.SaveSettings.Save(profileID);
                return null;
            });
        }
        catch (Exception e)
        {
            LogError($"Error in save game hook:\n{e}");
        }
        orig(self, callback);
    }

    private static void OnContinueGame(On.GameManager.orig_ContinueGame orig, GameManager self)
    {
        try
        {
            int profileID = self.profileID;
            BepInEx.ThreadingHelper.Instance.StartAsyncInvoke(() =>
            {
                Settings.SaveSettingsData data = Settings.IO.LoadSaveSettingsData(profileID);
                return () => BenchwarpPlugin.SaveSettings.Load(data);
            });
        }
        catch (Exception e)
        {
            LogError($"Error in continue game hook:\n{e}");
        }
        orig(self);
    }
}
