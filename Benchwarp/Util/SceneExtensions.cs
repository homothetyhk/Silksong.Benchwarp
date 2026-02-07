using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace Benchwarp.Util
{
    internal static class SceneExtensions
    {
        private static readonly List<GameObject> rootObjects = new(500);

        public static GameObject? FindGameObject(this Scene s, string path, bool warnIfNotFound)
        {
            s.GetRootGameObjects(rootObjects);
            int index = path.IndexOf('/');
            GameObject? result = null;
            if (index >= 0)
            {
                string rootName = path.Substring(0, index);
                foreach (GameObject root in rootObjects)
                {
                    if (root.name != rootName) continue;
                    result = root.transform.Find(path.Substring(index + 1))?.gameObject;
                    if (result != null) break;
                }
            }
            else
            {
                result = rootObjects.FirstOrDefault(g => g.name == path);
            }
            if (!result && warnIfNotFound)
            {
                LogWarn($"Failed to find object {path} in scene {s.name}. Existing objects are {s.Dump()}.");
            }
            rootObjects.Clear();

            return result;
        }

        private static string Dump(this Scene s) => string.Join("\n", s.Traverse().Select(p => p.path));

        private static List<(string path, GameObject go)> Traverse(this Scene s)
        {
            s.GetRootGameObjects(rootObjects);
            List<(string, GameObject)> results = new();
            foreach (GameObject g in rootObjects)
            {
                TraverseInternal(string.Empty, g.transform, results);
            }
            return results;
        }

        private static void TraverseInternal(string path, Transform t, List<(string, GameObject)> results)
        {
            path = $"{path}/{t.name}";
            results.Add((path, t.gameObject));
            foreach (Transform u in t)
            {
                TraverseInternal(path, u, results);
            }
        }
    }
}
