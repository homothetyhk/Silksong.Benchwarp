using Benchwarp.Data;

namespace Benchwarp.Settings
{
    public class SaveSettingsData
    {
        //public bool benchDeployed;
        //public bool atDeployedBench;
        //public float benchX;
        //public float benchY;
        //public string benchScene;
        public HashSet<BenchKey> visitedBenches = [];
        public HashSet<BenchKey> lockedBenches = [];
    }
}
