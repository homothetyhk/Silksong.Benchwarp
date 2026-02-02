using Benchwarp.Deploy;
using Silksong.AssetHelper.ManagedAssets;
using UnityEngine;

namespace Benchwarp
{
    public partial class BenchwarpPlugin
    {
        private void LoadAssets()
        {
            DeployAssets.Bench = ManagedAsset<GameObject>.FromSceneAsset("Bone_04", "RestBench");
        }
    }
}
