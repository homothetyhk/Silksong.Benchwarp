using Benchwarp.Data;
using Benchwarp.Util;
using GlobalEnums;

namespace Benchwarp.Events
{
    public static class BenchListModifiers
    {
        public static readonly SequentialEventHandler<RespawnInfo>
            OnGetStartDef = new();
        public static RespawnInfo GetStartDef() =>
            OnGetStartDef.Invoke(new(
                SceneName: "Tut_01",
                RespawnMarkerName: "Death Respawn Marker Init",
                RespawnType: 0,
                MapZone: MapZone.MOSS_CAVE));
        public static bool AtStart() => GetStartDef().IsCurrentRespawn();
        /// <summary>
        /// Sets respawn to the respawn marker specified by OnGetStartDef, defaulting to King's Pass. No effect if WarpOnly mode is active.
        /// </summary>
        public static void SetToStart()
        {
            if (BenchwarpPlugin.GS.MenuMode == Settings.MenuMode.WarpOnly) return;
            GetStartDef().SetRespawn();
        }

        /// <summary>
        /// Event invoked for each bench in the menu. Return true to prevent the bench from appearing, and false otherwise.
        /// <br/>The bench list is only updated when subscribers are added or removed, or when Bench.RefreshBenchList is called manually.
        /// </summary>
        public static event Func<BenchData, bool> BenchSuppressors
        {
            add
            {
                _benchSuppressors.Add(value);
                BenchList.RefreshBenchList();
            }
            remove
            {
                _benchSuppressors.Remove(value);
                BenchList.RefreshBenchList();
            }
        }
        private static readonly List<Func<BenchData, bool>> _benchSuppressors = [];
        internal static bool ShouldSuppressBench(BenchData bench)
        {
            bool value = false;
            foreach (var f in _benchSuppressors) value |= f(bench);
            return value;
        }


        /// <summary>
        /// Event which allows adding new benches to the menu. Benches will be organized into the existing area categories.
        /// <br/>The bench list is only updated when subscribers are added or removed, or when Bench.RefreshBenchList is called manually.
        /// </summary>
        public static event Func<IEnumerable<BenchData>> BenchInjectors
        {
            add
            {
                _benchInjectors.Add(value);
                BenchList.RefreshBenchList();
            }
            remove
            {
                _benchInjectors.Remove(value);
                BenchList.RefreshBenchList();
            }
        }
        private static readonly List<Func<IEnumerable<BenchData>>> _benchInjectors = [];
        internal static IEnumerable<BenchData> GetInjectedBenches()
        {
            return _benchInjectors.SelectMany(f => f());
        }

        /// <summary>
        /// Event which supplies comparers to sort the bench list once generated.
        /// Comparers will act in order on the list, with a stable sort. The final list will then be grouped by area and flattened.
        /// </summary>
        public static event Comparison<BenchData> BenchComparisons
        {
            add
            {
                _benchComparisons.Add(value);
                BenchList.RefreshBenchList();
            }
            remove
            {
                _benchComparisons.Remove(value);
                BenchList.RefreshBenchList();
            }
        }
        private static readonly List<Comparison<BenchData>> _benchComparisons = [];
        internal static void SortBenchList(List<BenchData> benches)
        {
            foreach (Comparison<BenchData> c in _benchComparisons)
            {
                benches.StableSort(c);
            }
        }
    }
}
