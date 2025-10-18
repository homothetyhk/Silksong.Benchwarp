using Benchwarp.Data;
using Benchwarp.Events;
using Benchwarp.Util;
using GlobalEnums;

namespace Benchwarp
{
    public static class BenchListModifiers
    {
        /// <summary>
        /// Event to override the respawn information returned by <see cref="GetStartDef"/>.
        /// </summary>
        public static SequentialEvent<Func<RespawnInfo, RespawnInfo>> OnGetStartDef { get; } = new(out onGetStartDefOwner);
        private static readonly SequentialEvent<Func<RespawnInfo, RespawnInfo>>.ISequentialEventOwner onGetStartDefOwner;

        public static RespawnInfo GetStartDef() =>
            onGetStartDefOwner.InvokeToTransform(new(
                SceneName: "Tut_01",
                RespawnMarkerName: "Death Respawn Marker Init",
                RespawnType: 0,
                MapZone: MapZone.MOSS_CAVE));

        /// <summary>
        /// Returns whether the current respawn is the respawn marker specified by <see cref="GetStartDef"/>.
        /// </summary>
        public static bool AtStart() => GetStartDef().IsCurrentRespawn();

        /// <summary>
        /// Sets respawn to the respawn marker specified by <see cref="GetStartDef"/>. No effect in <see cref="Settings.MenuMode.WarpOnly"/> mode.
        /// </summary>
        public static void MenuSetToStart()
        {
            if (BenchwarpPlugin.ConfigSettings.MenuMode == Settings.MenuMode.WarpOnly) return;
            GetStartDef().SetRespawn();
        }

        /// <summary>
        /// Event invoked for each bench in the menu. Return true to prevent the bench from appearing, and false otherwise.
        /// <br/>The bench list is only updated when subscribers are added or removed, or when Bench.RefreshBenchList is called manually.
        /// </summary>
        public static SequentialEvent<Func<BenchData, bool>> BenchSuppressors { get; } = new(out benchSuppressorsOwner);
        private static readonly SequentialEvent<Func<BenchData, bool>>.ISequentialEventOwner benchSuppressorsOwner;

        internal static bool ShouldSuppressBench(BenchData bench) => benchSuppressorsOwner.InvokeAndAggregate(bench, seed: false, (b1, b2) => b1 || b2);


        /// <summary>
        /// Event which allows adding new benches to the menu. Benches will be organized into the existing area categories.
        /// <br/>The bench list is only updated when subscribers are added or removed, or when Bench.RefreshBenchList is called manually.
        /// </summary>
        public static SequentialEvent<Func<IEnumerable<BenchData>>> BenchInjectors { get; } = new(out benchInjectorsOwner);
        private static readonly SequentialEvent<Func<IEnumerable<BenchData>>>.ISequentialEventOwner benchInjectorsOwner;
        
        internal static IEnumerable<BenchData> GetInjectedBenches() => benchInjectorsOwner.InvokeAndCollectFlat();

        /// <summary>
        /// Event which supplies comparers to sort the bench list once generated.
        /// Comparers will act in order on the list, with a stable sort. The final list will then be grouped by area and flattened.
        /// </summary>
        public static SequentialEvent<Comparison<BenchData>> BenchComparisons { get; } = new(out benchComparisonsOwner);
        private static readonly SequentialEvent<Comparison<BenchData>>.ISequentialEventOwner benchComparisonsOwner;
        
        internal static void SortBenchList(List<BenchData> benches)
        {
            foreach (Comparison<BenchData> c in benchComparisonsOwner.GetSubscribers())
            {
                benches.StableSort(c);
            }
        }

        static BenchListModifiers()
        {
            benchSuppressorsOwner.OnSubscribersChanged += BenchList.RefreshBenchList;
            benchInjectorsOwner.OnSubscribersChanged += BenchList.RefreshBenchList;
        }
    }
}
