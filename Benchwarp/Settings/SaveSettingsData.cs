using Benchwarp.Benches;

namespace Benchwarp.Settings;

public class SaveSettingsData
{
    public Deploy.DeployInfo? DeployInfo;
    public HashSet<BenchKey> VisitedBenches = [];
    public HashSet<BenchKey> LockedBenches = [];
}
