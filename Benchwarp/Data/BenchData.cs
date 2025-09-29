using GlobalEnums;

namespace Benchwarp.Data
{
    public record BenchData(string BenchName, string SceneName, string RespawnMarker, 
        int RespawnType, MapZone MapZone, string MenuArea = null!, BenchData? Act3Data = null)
    {
        public BenchKey ToBenchKey()
        {
            return new(SceneName, RespawnMarker);
        }
    }
}
