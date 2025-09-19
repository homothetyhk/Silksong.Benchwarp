using System;
using GlobalEnums;
using UnityEngine;

namespace BenchwarpSS.Utils
{
    public class Bench : MonoBehaviour
    {
        public BenchData data;
        public BenchData act3Data;

        public string benchName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.benchName;
                }
                else
                {
                    return data.benchName;
                }
            }
        }
        public string objName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.objName;
                }
                else
                {
                    return data.objName;
                }
            }
        }
        public string sceneName
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.sceneName;
                }
                else
                {
                    return data.sceneName;
                }
            }
        }
        public int respawnType
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.respawnType;
                } else
                {
                    return data.respawnType;
                }
            }
        }
        public MapZone mapZone
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.mapZone;
                } else
                {
                    return data.mapZone;
                }
            }
        }
        
        public bool isUnlocked
        {
            get
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    return act3Data.isUnlocked;
                }
                else
                {
                    return data.isUnlocked;
                }
            }
            set
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    act3Data.isUnlocked = value;
                }
                else
                {
                    data.isUnlocked = value;
                }
            }
        }
        public BenchSaveData saveData
        {
            get
            {
                BenchSaveData data = new()
                {
                    objName = objName,
                    sceneName = sceneName,
                    isUnlocked = isUnlocked,
                };
                return data;
            }
        }

        public class BenchData
        {
            public string benchName;
            public string objName;
            public string sceneName;
            public int respawnType;
            public MapZone mapZone;
            public bool isUnlocked = false;
            public BenchData act3Data;

            public BenchData(string name, string objName, string sceneName, int respawnType, MapZone mapZone, BenchData act3Data = null)
            {
                benchName = name;
                this.objName = objName;
                this.sceneName = sceneName;
                this.respawnType = respawnType;
                this.mapZone = mapZone;

                if (act3Data != null)
                {
                    this.act3Data = act3Data;
                }
                else
                {
                    this.act3Data = this;
                }

                GUIController.buttons++;
            }
        }
        [Serializable]
        public struct BenchSaveData
        {
            public string objName;
            public string sceneName;
            public bool isUnlocked;
        }

        public void Init(BenchData benchData)
        {
            data = new(benchData.benchName, benchData.objName, benchData.sceneName, benchData.respawnType, benchData.mapZone);
            act3Data = benchData.act3Data;
        }

        public void SetBench()
        {
            if (isUnlocked || GUIController.Instance.ForceUnlock)
            {
                if (PlayerData.instance.act3_wokeUp)
                {
                    PlayerData.instance.respawnMarkerName = act3Data.objName;
                    PlayerData.instance.respawnScene = act3Data.sceneName;
                    PlayerData.instance.respawnType = act3Data.respawnType;
                    PlayerData.instance.mapZone = act3Data.mapZone;
                }
                else
                {
                    PlayerData.instance.respawnMarkerName = data.objName;
                    PlayerData.instance.respawnScene = data.sceneName;
                    PlayerData.instance.respawnType = data.respawnType;
                    PlayerData.instance.mapZone = data.mapZone;
                }
            }
        }

        public void SetUnlockStatus()
        {
            if (GUIController.saveFile.Length != 0)
            {
                foreach (var item in GUIController.saveFile)
                {
                    if (item.objName == objName && item.sceneName == sceneName)
                    {
                        isUnlocked = item.isUnlocked;
                    }
                }
            }
        }
    }
}
