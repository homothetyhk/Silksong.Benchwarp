using Benchwarp.Data.RawData;
using System.Collections.ObjectModel;

namespace Benchwarp.Data
{
    public static class BenchList
    {
        private static readonly List<BenchData> _benchList;
        public static ReadOnlyCollection<BenchData> Benches { get; }
        private static readonly List<AreaBenchGroup> _groupList;
        public static ReadOnlyCollection<AreaBenchGroup> BenchGroups { get; }

        /// <summary>
        /// The bench which is the current respawn.
        /// Null if none of the benches in <see cref="Benches"/> match the current respawn.
        /// </summary>
        public static BenchData? CurrentBenchRespawn { get; private set; }

        public static void RefreshBenchList()
        {
            _benchList.Clear();
            _benchList.AddRange(BaseBenchList.BaseBenches);
            _benchList.AddRange(Events.BenchListModifiers.GetInjectedBenches());
            _benchList.RemoveAll(Events.BenchListModifiers.ShouldSuppressBench);
            Events.BenchListModifiers.SortBenchList(_benchList);
            _groupList.Clear();
            _groupList.AddRange(_benchList.GroupBy(b => b.MenuArea).Select(g => new AreaBenchGroup { MenuArea = g.Key, Benches = new([.. g]) }));
            
            //TopMenu.RebuildMenu(); // TODO
        }   

        internal static void UpdateRespawn(RespawnInfo info)
        {
            CurrentBenchRespawn = null;
            foreach (BenchData b in Benches)
            {
                if (RespawnInfo.ReferToSameMarker(b.RespawnInfo.GetRespawnInfo(), info))
                {
                    CurrentBenchRespawn = b;
                    BenchwarpPlugin.LS.SetVisited(b, true);
                    break;
                }
            }
        }

        static BenchList()
        {
            _benchList = [];
            Benches = new(_benchList);
            _groupList = [];
            BenchGroups = new(_groupList);
            RefreshBenchList();
        }
    }
}
