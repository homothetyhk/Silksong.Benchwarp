using Silksong.AssetHelper.ManagedAssets;
using Silksong.FsmUtil;
using UnityEngine;

namespace Benchwarp.Deploy
{
    internal static class DeployAssets
    {
        public static ManagedAsset<GameObject>? Bench { get; set; }
        public const string DeployedRespawnMarkerName = "Benchwarp Deployed Respawn";

        public static GameObject CreateMarker()
        {
            GameObject go = new(DeployedRespawnMarkerName);
            RespawnMarker rm = go.AddComponent<RespawnMarker>();
            rm.customFadeDuration = new();
            rm.overrideMapZone = new();
            go.AddComponent<DeployComponent>();
            return go;
        }

        public static void PlaceMarkerRelativeToHero(GameObject go, Vector3 heroPos)
        {
            go.transform.position = heroPos;
        }

        public static GameObject CreateBench()
        {
            Bench!.Load().WaitForCompletion();
            GameObject go = Bench!.InstantiateAsset();
            go.name = DeployedRespawnMarkerName;
            ModifyBench(go);
            go.AddComponent<DeployComponent>();
            return go;
        }

        public static void PlaceBenchRelativeToHero(GameObject go, Vector3 heroPos)
        {
            heroPos.y -= 0.6677f; // offsets from Mosshome Gate bench
            heroPos.z += 0.0087f;
            go.transform.position = heroPos;
        }

        private static void ModifyBench(GameObject bench)
        {
            // removing this just in case
            PlayMakerFSM fsm = bench.LocateMyFSM("Bench Control");
            fsm.GetState("Craw Summons?")!.ChangeTransition("FINISHED", "Start Locked?").ThrowIfFalse();
            fsm.GetState("Craw Summons?")!.ReplaceAllActions();
            fsm.GetState("Craw summons check")!.ChangeTransition("FINISHED", "Resting").ThrowIfFalse();
            fsm.GetState("Craw summons check")!.ReplaceAllActions();
            fsm.GetState("Craw Summons Instant?")!.ReplaceAllActions();
        }

        private static void ThrowIfFalse(this bool b)
        {
            if (!b) throw new InvalidOperationException();
        }
    }
}
