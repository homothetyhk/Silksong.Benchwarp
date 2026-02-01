using Benchwarp.Data;

namespace Benchwarp.Patches
{
    internal static class DataManagerFix
    {
        internal static void Hook()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnMenu;
        }

        internal static void Unhook()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= OnMenu;
        }

        private static void OnMenu(UnityEngine.SceneManagement.Scene from, UnityEngine.SceneManagement.Scene to)
        {
            if (to.name == SceneNames.Menu_Title)
            {
                BenchwarpPlugin.SaveSettings.Load(new());
            } 
        }
    }
}
