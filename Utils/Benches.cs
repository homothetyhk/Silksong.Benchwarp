using GlobalEnums;
using UnityEngine;

namespace BenchwarpSS.Utils
{
    public class Bench : MonoBehaviour
    {
        public string benchName;
        public string objName;
        public string sceneName;
        public int respawnType;
        public MapZone mapZone;

        public class BenchData(string name, string objName, string sceneName, int respawnType, MapZone mapZone)
        {
            public string benchName = name;
            public string objName = objName;
            public string sceneName = sceneName;
            public int respawnType = respawnType;
            public MapZone mapZone = mapZone;
        }

        public void Init(BenchData benchData)
        {
            benchName = benchData.benchName;
            objName = benchData.objName;
            sceneName = benchData.sceneName;
            respawnType = benchData.respawnType;
            mapZone = benchData.mapZone;
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
