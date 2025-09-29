using UnityEngine;

namespace Benchwarp.Util
{
    internal static class SpriteManager
    {
        public static Texture2D LoadTexFromAssembly(string resourceName)
        {
            using Stream stream = typeof(SpriteManager).Assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
            {
                LogError($"Failed to load {resourceName}. The embedded resources are " +
                    string.Join(", ", typeof(SpriteManager).Assembly.GetManifestResourceNames()));
                throw new KeyNotFoundException(resourceName);
            }

            byte[] data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);

            Texture2D tex = new(2, 2, TextureFormat.RG32, false);
            tex.LoadImage(data);
            return tex;
        }
    }
}