using Benchwarp.Data;
using GlobalEnums;
using UnityEngine;

namespace Benchwarp.Components
{
    public class BenchComponent : MonoBehaviour
    {
        public BenchData data;
        public BenchData act3Data;

        public string benchName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.BenchName;
                }
                else
                {
                    return data.BenchName;
                }
            }
        }
        public string objName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.RespawnMarker;
                }
                else
                {
                    return data.RespawnMarker;
                }
            }
        }
        public string sceneName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.SceneName;
                }
                else
                {
                    return data.SceneName;
                }
            }
        }
        public int respawnType
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.RespawnType;
                } else
                {
                    return data.RespawnType;
                }
            }
        }
        public MapZone mapZone
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.MapZone;
                } else
                {
                    return data.MapZone;
                }
            }
        }


        

        public void Init(BenchData benchData)
        {
            data = new(benchData.BenchName, benchData.RespawnMarker, benchData.SceneName, benchData.RespawnType, benchData.MapZone);
            act3Data = benchData.Act3Data;
        }

        public void SetBench()
        {
            if (PlayerData.instance.act3_wokeUp)
            {
                PlayerData.instance.respawnMarkerName = act3Data.RespawnMarker;
                PlayerData.instance.respawnScene = act3Data.SceneName;
                PlayerData.instance.respawnType = act3Data.RespawnType;
                PlayerData.instance.mapZone = act3Data.MapZone;
            } else
            {
                PlayerData.instance.respawnMarkerName = data.RespawnMarker;
                PlayerData.instance.respawnScene = data.SceneName;
                PlayerData.instance.respawnType = data.RespawnType;
                PlayerData.instance.mapZone = data.MapZone;
            }
        }
    }
}
