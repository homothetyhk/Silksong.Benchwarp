namespace Benchwarp.Benches;

/// <summary>
/// Data carrier for a respawn marker which changes according to a PlayerData bool.
/// </summary>
public sealed record PDConditionalRespawnInfo(string PlayerDataBoolName, IRespawnInfo TrueRespawn, IRespawnInfo FalseRespawn) : IRespawnInfo
{
    public RespawnInfo GetRespawnInfo() 
        => PlayerData.instance.GetBool(PlayerDataBoolName) ? TrueRespawn.GetRespawnInfo() : FalseRespawn.GetRespawnInfo();

    public bool IsCurrentRespawn() 
        => PlayerData.instance.GetBool(PlayerDataBoolName) ? TrueRespawn.IsCurrentRespawn() : FalseRespawn.IsCurrentRespawn();

    public void SetRespawn()
    {
        if (PlayerData.instance.GetBool(PlayerDataBoolName))
        {
            TrueRespawn.SetRespawn();
        }
        else
        {
            FalseRespawn.SetRespawn();
        }
    }
}
