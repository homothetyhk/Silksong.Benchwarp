using GlobalEnums;

namespace Benchwarp.Data
{
    /// <summary>
    /// The basic data required to check or set a respawn.
    /// </summary>
    public sealed record RespawnInfo(string SceneName, string RespawnMarkerName, int RespawnType, MapZone MapZone) : IRespawnInfo
    {
        public static RespawnInfo FromPlayerData()
        {
            return new(PlayerData.instance.respawnScene, PlayerData.instance.respawnMarkerName, PlayerData.instance.respawnType, PlayerData.instance.mapZone);
        }

        public static bool ReferToSameMarker(RespawnInfo r1, RespawnInfo r2)
        {
            return r1.SceneName == r2.SceneName && r1.RespawnMarkerName == r2.RespawnMarkerName;
        }

        RespawnInfo IRespawnInfo.GetRespawnInfo() => this;
        public void SetRespawn()
        {
            PlayerData.instance.respawnScene = SceneName;
            PlayerData.instance.respawnMarkerName = RespawnMarkerName;
            PlayerData.instance.respawnType = RespawnType;
            PlayerData.instance.mapZone = MapZone;
        }

        public bool IsCurrentRespawn() 
            => PlayerData.instance.respawnScene == SceneName && PlayerData.instance.respawnMarkerName == RespawnMarkerName;
    }
}
