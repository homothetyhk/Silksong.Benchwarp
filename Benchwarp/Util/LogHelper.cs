namespace Benchwarp.Util;

internal static class LogHelper
{
    public static void Log(object? o)
    {
        BenchwarpPlugin.Instance.Logger.LogInfo(o);
    }

    public static void LogError(object? o)
    {
        BenchwarpPlugin.Instance.Logger.LogError(o);
    }

    public static void LogWarn(object? o)
    {
        BenchwarpPlugin.Instance.Logger.LogWarning(o);
    }
}
