using Benchwarp.Benches;

namespace Benchwarp.Events;

public static class WorldEvents
{
    /// <summary>
    /// Event invoked on the first update frame after the player's respawn is changed by any means.
    /// </summary>
    public static event Action<RespawnInfo, BenchData?>? OnRespawnChanged;
    internal static void InvokeOnRespawnChanged(RespawnInfo info)
    {
        BenchList.UpdateRespawn(info);
        try { OnRespawnChanged?.Invoke(info, BenchList.CurrentBenchRespawn); }
        catch (Exception e) { LogError(e); }
    }

    /*
    /// <summary>
    /// Event invoked when a bench is unlocked, after its key is added to local settings.
    /// </summary>
    public static event Action<BenchKey>? OnBenchUnlock;
    internal static void InvokeOnBenchUnlock(BenchKey key)
    {
        try { OnBenchUnlock?.Invoke(key); }
        catch (Exception e) { LogError(e); }
    }
    */
}
