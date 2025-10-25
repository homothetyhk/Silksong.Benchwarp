namespace Benchwarp.Benches;

public static class IRespawnInfoExtensions
{
    /// <summary>
    /// Sets respawn using the info returned by <see cref="IRespawnInfo.GetRespawnInfo"/>.
    /// </summary>
    public static void SetRespawn(this IRespawnInfo info) => info.GetRespawnInfo().SetRespawn();
    /// <summary>
    /// Checks respawn using the info returned by <see cref="IRespawnInfo.GetRespawnInfo"/>.
    /// </summary>
    public static bool IsCurrentRespawn(this IRespawnInfo info) => info.GetRespawnInfo().IsCurrentRespawn();
}
