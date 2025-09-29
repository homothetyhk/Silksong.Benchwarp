using Benchwarp.Data;

namespace Benchwarp.Settings
{
    public class LocalSettings
    {
        //public bool benchDeployed;
        //public bool atDeployedBench;
        //public float benchX;
        //public float benchY;
        //public string benchScene;
        public HashSet<BenchKey> visitedBenchScenes = [];
        public HashSet<BenchKey> lockedBenches = [];
    }
}
