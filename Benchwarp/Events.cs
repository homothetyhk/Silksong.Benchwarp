using Benchwarp.Components;
using Benchwarp.Data;
using GlobalEnums;
using static Benchwarp.Util.Localization;

namespace Benchwarp
{
    public static class Events
    {
        public delegate void BenchNameModifier(BenchData bench, ref string name);

        /// <summary>
        /// Event invoked after a bench is selected from the menu, or the deployed bench is selected.
        /// </summary>
        public static event Action OnBenchSelected;
        internal static void InvokeOnBenchSelected()
        {
            try { OnBenchSelected?.Invoke(); }
            catch (Exception e) { LogError(e); }
        }

        /// <summary>
        /// Event invoked when a request to benchwarp is made, before beginning to warp.
        /// </summary>
        public static event Action OnBenchwarp;
        internal static void InvokeOnBenchwarp()
        {
            try { OnBenchwarp?.Invoke(); }
            catch (Exception e) { LogError(e); }
        }
        /// <summary>
        /// Event with (scene, gate) parameters, invoked when a request to doorwarp is made, before beginning to warp.
        /// </summary>
        public static event Action<string, string> OnDoorwarp;
        internal static void InvokeOnDoorwarp(string sceneName, string gateName)
        {
            try { OnDoorwarp?.Invoke(sceneName, gateName); }
            catch (Exception e) { LogError(e); }
        }
        /// <summary>
        /// Event invoked when a bench is unlocked, after its key is added to local settings.
        /// </summary>
        public static event Action<BenchKey> OnBenchUnlock;
        internal static void InvokeOnBenchUnlock(BenchKey key)
        {
            try { OnBenchUnlock?.Invoke(key); }
            catch (Exception e) { LogError(e); }
        }

        /// <summary>
        /// Event invoked to determine the displayed name of a bench. The initial value of the name parameter is <see cref="BenchData.BenchName"/> after localization.
        /// It is the subscriber's responsibility to localize if the name is modified.
        /// </summary>
        public static event BenchNameModifier OnGetBenchName;
        public static string GetBenchName(BenchData bench)
        {
            string name = Localize(bench.BenchName);
            try { OnGetBenchName?.Invoke(bench, ref name); }
            catch (Exception e) { LogError(e); }
            return name;
        }

        /// <summary>
        /// Event invoked to determine the displayed area of a bench. The initial value of the name parameter is <see cref="BenchData.MenuArea"/> after localization.
        /// It is the subscriber's responsibility to localize if the name is modified.
        /// </summary>
        public static event BenchNameModifier OnGetBenchArea;
        public static string GetBenchArea(BenchData bench)
        {
            string name = Localize(bench.MenuArea);
            try { OnGetBenchArea?.Invoke(bench, ref name); }
            catch (Exception e) { LogError(e); }
            return name;
        }

        /// <summary>
        /// Event invoked to determine the displayed scene of a bench. The initial value of the name parameter is the result of <see cref="GetSceneName(string)"/> on <see cref="BenchData.SceneName"/> after localization.
        /// It is the subscriber's responsibility to localize if the name is modified.
        /// </summary>
        public static event BenchNameModifier OnGetBenchSceneName;
        public static string GetBenchSceneName(BenchData bench)
        {
            string name = GetSceneName(bench.SceneName);
            try { OnGetBenchSceneName?.Invoke(bench, ref name); }
            catch (Exception e) { LogError(e); }
            return name;
        }

        /// <summary>
        /// Event invoked to determine the displayed name of a scene. Runs before OnGetBenchSceneName, when relevant.
        /// The initial value is the unlocalized scene name. The final value is passed to localization before <see cref="GetSceneName(string)"/> returns.
        /// </summary>
        public static readonly SequentialEventHandler<string> OnGetSceneName = new();
        public static string GetSceneName(string sceneName) => Localize(OnGetSceneName.Invoke(sceneName));

        /// <summary>
        /// Event invoked to define new hotkey commands. The action will be invoked if the code is entered while the game is paused.
        /// <br/>The string must be a two letter code. The code may be overriden by GS.HotkeyOverrides.
        /// <br/>Invalid codes will be ignored, logging an error message. A null code will be silently ignored.
        /// <br/>Duplicate codes will be ignored, logging an error message. Check Hotkeys.CurrentHotkeys and GS.HotkeyOverrides before returning to avoid this.
        /// </summary>
        public static event Func<(string, Action)> HotkeyRequests
        {
            add
            {
                _hotkeyRequests.Add(value);
                Hotkeys.RefreshHotkeys();
            }
            remove
            {
                _hotkeyRequests.Remove(value);
                Hotkeys.RefreshHotkeys();
            }
        }
        /// <summary>
        /// Add many subscribers to HotkeyRequests, refreshing the hotkey list at the end.
        /// </summary>
        public static void AddHotkeyRequests(IEnumerable<Func<(string, Action)>> fs)
        {
            _hotkeyRequests.AddRange(fs);
            Hotkeys.RefreshHotkeys();
        }
        /// <summary>
        /// Remove many subscribers from HotkeyRequests, refreshing the hotkey list at the end.
        /// </summary>
        public static void RemoveHotkeyRequests(IEnumerable<Func<(string, Action)>> fs)
        {
            foreach (var f in fs) _hotkeyRequests.Remove(f);
            Hotkeys.RefreshHotkeys();
        }

        private static readonly List<Func<(string, Action)>> _hotkeyRequests = new();
        internal static IEnumerable<(string, Action)> GetHotkeyRequests()
        {
            return _hotkeyRequests.Select(f => f());
        }


        public static readonly SequentialEventHandler<(string respawnScene, string respawnMarkerName, int respawnType, int mapZone)>
            OnGetStartDef = new();
        public static (string respawnScene, string respawnMarkerName, int respawnType, int mapZone) GetStartDef() =>
            OnGetStartDef.Invoke(("Tutorial_01", "Death Respawn Marker", 0, 2));
        public static bool AtStart()
        {
            (string respawnScene, string respawnMarkerName, int _, int _) = GetStartDef();
            return //!BenchwarpPlugin.LS.atDeployedBench &&
                respawnScene == PlayerData.instance.respawnScene
                && respawnMarkerName == PlayerData.instance.respawnMarkerName;
        }
        /// <summary>
        /// Sets respawn to the respawn marker specified by OnGetStartDef, defaulting to King's Pass. No effect if WarpOnly mode is active.
        /// </summary>
        public static void SetToStart()
        {
            if (BenchwarpPlugin.GS.WarpOnly) return;
            (string respawnScene, string respawnMarkerName, int respawnType, int mapZone) = GetStartDef();
            //BenchwarpPlugin.LS.atDeployedBench = false; // TODO
            PlayerData.instance.respawnScene = respawnScene;
            PlayerData.instance.respawnMarkerName = respawnMarkerName;
            PlayerData.instance.respawnType = respawnType;
            PlayerData.instance.mapZone = (MapZone)mapZone;
        }

        /*
         // Example code for accessing SequentialEventHandlers without referencing Benchwarp.dll
        public static void SafeAdd(Func<string, string> f)
        {
            try
            {
                FieldInfo field = Type.GetType("Benchwarp.Events, Benchwarp")
                    .GetField("OnGetSceneName", BindingFlags.Public | BindingFlags.Static);

                field.FieldType
                    .GetEvent("Event", BindingFlags.Public | BindingFlags.Instance)
                    .AddEventHandler(field.GetValue(null), f);
            }
            catch
            {
                return;
            }
        }
        */

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
        private static readonly List<Func<BenchData, bool>> _benchSuppressors = new();
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
        private static readonly List<Func<IEnumerable<BenchData>>> _benchInjectors = new();
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
        private static readonly List<Comparison<BenchData>> _benchComparisons = new();
        internal static List<BenchData> GetSortedBenchList(List<BenchData> benches)
        {
            foreach (Comparison<BenchData> c in _benchComparisons)
            {
                benches.StableSort(c);
            }
            return benches.GroupBy(b => b.MenuArea).SelectMany(g => g).ToList();
        }

        private static void StableSort<T>(this IList<T> ts, Comparison<T> comparison)
        {
            KeyValuePair<int, T>[] keys = new KeyValuePair<int, T>[ts.Count];
            for (int i = 0; i < ts.Count; i++) keys[i] = new(i, ts[i]);
            Array.Sort(keys, StableComparer<T>.GetStableComparison(comparison));

            for (int i = 0; i < ts.Count; i++)
            {
                ts[i] = keys[i].Value;
            }
        }

        private class StableComparer<T> : IComparer<KeyValuePair<int, T>>
        {
            public StableComparer(IComparer<T> comparison) => this.comparer = comparison;
            private readonly IComparer<T> comparer;

            public static Comparison<KeyValuePair<int, T>> GetStableComparison(Comparison<T> comparison)
            {
                int CompareTo(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
                {
                    int diff = comparison(x.Value, y.Value);
                    return diff != 0 ? diff : x.Key - y.Key;
                }
                return CompareTo;
            }

            public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
            {
                int diff = comparer.Compare(x.Value, y.Value);
                return diff != 0 ? diff : x.Key - y.Key;
            }
        }

        public class SequentialEventHandler<T>
        {
            private readonly List<Func<T, T>> modifiers = new();

            public event Func<T, T> Event
            {
                add => modifiers.Add(value);
                remove => modifiers.Remove(value);
            }

            public T Invoke(T defaultValue)
            {
                foreach (Func<T, T> f in modifiers)
                {
                    defaultValue = f(defaultValue);
                }
                return defaultValue;
            }
        }
    }
}
