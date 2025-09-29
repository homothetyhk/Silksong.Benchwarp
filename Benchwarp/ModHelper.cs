using System.IO;
using System.Reflection;
using UnityEngine;

namespace BenchwarpSS
{
    internal class ModHelper
    {
        public static void Log(string msg)
        {
            Benchwarp.Instance.Logger.LogInfo(msg);
        }

        public static void LogError(string msg)
        {
            Benchwarp.Instance.Logger.LogError(msg);
        }

        public static Texture2D LoadTexFromAssembly(string resourceName)
        {
            var asm = Assembly.GetExecutingAssembly();


            using (Stream stream = asm.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    LogError("Couldnt load resoruce lol");
                    return null;
                }

                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);

                Texture2D tex = new(2,2, TextureFormat.RG32, false);
                tex.LoadImage(data);
                return tex;
            }
        }
    }
}