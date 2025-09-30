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
                if (PlayerData.instance.act3_wokeUp && act3Data != null)
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
                if (PlayerData.instance.act3_wokeUp && act3Data != null)
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
                if (PlayerData.instance.act3_wokeUp && act3Data != null)
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
                if (PlayerData.instance.act3_wokeUp && act3Data != null)
                {
                    return act3Data.RespawnType;
                }
                else
                {
                    return data.RespawnType;
                }
            }
        }
        public MapZone mapZone
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp && act3Data != null)
                {
                    return act3Data.MapZone;
                }
                else
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
            PlayerData.instance.respawnMarkerName = objName;
            PlayerData.instance.respawnScene = sceneName;
            PlayerData.instance.respawnType = respawnType;
            PlayerData.instance.mapZone = mapZone;
        }
    }
}
