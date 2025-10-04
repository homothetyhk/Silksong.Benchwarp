using System.Collections.ObjectModel;

namespace Benchwarp.Data
{
    public class AreaBenchGroup
    {
        public required string MenuArea { get; init; }
        public required ReadOnlyCollection<BenchData> Benches { get; init; }

        public void Deconstruct(out string menuArea, out ReadOnlyCollection<BenchData> benches)
        {
            menuArea = MenuArea;
            benches = Benches;
        }
    }
}
