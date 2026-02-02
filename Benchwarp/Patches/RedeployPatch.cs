using Benchwarp.Deploy;

namespace Benchwarp.Patches
{
    internal static class RedeployPatch
    {
        internal static void Hook()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnActiveSceneChanged;
        }

        internal static void Unhook()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= OnActiveSceneChanged;
        }

        private static void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene from, UnityEngine.SceneManagement.Scene to)
        {
            DeployManager.Redeploy();
        }
    }
}
