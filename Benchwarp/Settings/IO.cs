using UnityEngine;
using Benchwarp.Util;

namespace Benchwarp.Settings;

internal static class IO
{
    private static string BenchwarpSaveDirectory => Path.Combine(Application.persistentDataPath, "Benchwarp");

    public static SharedSettingsData LoadSharedSettingsData()
    {
        try
        {
            string dir = BenchwarpSaveDirectory;
            string path = Path.Combine(dir, "shared.json");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            if (!File.Exists(path))
            {
                SharedSettingsData data = SharedSettingsData.CreateDefault();
                JsonUtil.SerializeFile(data, path);
                return data;
            }
            else
            {
                SharedSettingsData? data = null;
                try
                {
                    data = JsonUtil.DeserializeFile<SharedSettingsData>(path);
                }
                catch (Exception e)
                {
                    data = new();
                    LogError($"Error deserializing shared settings data:\n{e}");
                }
                return data;
            }
        }
        catch (Exception e)
        {
            LogError($"Error reading shared settings data from file:\n{e}");
            return new();
        }
    }

    public static SaveSettingsData LoadSaveSettingsData(int profileID)
    {
        try
        {
            string dir = BenchwarpSaveDirectory;
            string path = Path.Combine(dir, $"user{profileID}.json");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            if (!File.Exists(path))
            {
                SaveSettingsData data = new();
                JsonUtil.SerializeFile(data, path);
                return data;
            }
            else
            {
                SaveSettingsData? data = null;
                try
                {
                    data = JsonUtil.DeserializeFile<SaveSettingsData>(path);
                }
                catch (Exception e)
                {
                    data = new();
                    LogError($"Error deserializing save settings data from profile {profileID}:\n{e}");
                }
                return data;
            }
        }
        catch (Exception e)
        {
            LogError($"Error reading save settings data from profile {profileID}:\n{e}");
            return new();
        }
    }

    public static void SaveSaveSettingsData(SaveSettingsData data, int profileID)
    {
        try
        {
            string dir = BenchwarpSaveDirectory;
            string path = Path.Combine(dir, $"user{profileID}.json");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            JsonUtil.SerializeFile(data, path);
        }
        catch (Exception e)
        {
            LogError($"Error writing save settings to file:\n{e}");
        }
    }

}
