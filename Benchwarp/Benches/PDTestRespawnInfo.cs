namespace Benchwarp.Benches;

/// <summary>
/// Data carrier for a respawn marker which changes depending on various PlayerData variables.
/// Prefer <see cref="PDConditionalRespawnInfo"/> for the common case of depending on simple PlayerData bools.
/// </summary>
public sealed record PDTestRespawnInfo(PlayerDataTest.Test Test, IRespawnInfo SuccessRespawn, IRespawnInfo FailRespawn) : IRespawnInfo
{
    public RespawnInfo GetRespawnInfo()
    {
        return Test.IsFulfilled(PlayerData.instance) ? SuccessRespawn.GetRespawnInfo() : FailRespawn.GetRespawnInfo();
    }
}
