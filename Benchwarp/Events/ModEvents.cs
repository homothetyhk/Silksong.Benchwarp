using Benchwarp.Data;

namespace Benchwarp.Events
{
    public static class ModEvents
    {
        /// <summary>
        /// Event invoked after a bench is selected from the menu, or the deployed bench is selected.
        /// </summary>
        public static event Action? OnBenchSelected;
        internal static void InvokeOnBenchSelected()
        {
            try { OnBenchSelected?.Invoke(); }
            catch (Exception e) { LogError(e); }
        }

        /// <summary>
        /// Event invoked when a request to benchwarp is made, before beginning to warp.
        /// </summary>
        public static event Action? OnBenchwarp;
        internal static void InvokeOnBenchwarp()
        {
            try { OnBenchwarp?.Invoke(); }
            catch (Exception e) { LogError(e); }
        }
        /// <summary>
        /// Event with (scene, gate) parameters, invoked when a request to doorwarp is made, before beginning to warp.
        /// </summary>
        public static event Action<string, string>? OnDoorwarp;
        internal static void InvokeOnDoorwarp(string sceneName, string gateName)
        {
            try { OnDoorwarp?.Invoke(sceneName, gateName); }
            catch (Exception e) { LogError(e); }
        }
        

        

        /// <summary>
        /// Event invoked to define new hotkey commands. The action will be invoked if the code is entered while the game is paused.
        /// <br/>The string must be a two letter code. The code may be overriden by GS.HotkeyOverrides.
        /// <br/>Invalid codes will be ignored, logging an error message. A null code will be silently ignored.
        /// <br/>Duplicate codes will overwrite the existing code. A code with null action will remove any existing action bound to that code.
        /// </summary>
        public static event Func<(string, Action?)> HotkeyRequests
        {
            add
            {
                _hotkeyRequests.Add(value);
                HotkeyActions.RefreshHotkeys();
            }
            remove
            {
                _hotkeyRequests.Remove(value);
                HotkeyActions.RefreshHotkeys();
            }
        }
        /// <summary>
        /// Add many subscribers to HotkeyRequests, refreshing the hotkey list at the end.
        /// </summary>
        public static void AddHotkeyRequests(IEnumerable<Func<(string, Action?)>> fs)
        {
            _hotkeyRequests.AddRange(fs);
            HotkeyActions.RefreshHotkeys();
        }
        /// <summary>
        /// Remove many subscribers from HotkeyRequests, refreshing the hotkey list at the end.
        /// </summary>
        public static void RemoveHotkeyRequests(IEnumerable<Func<(string, Action?)>> fs)
        {
            foreach (var f in fs) _hotkeyRequests.Remove(f);
            HotkeyActions.RefreshHotkeys();
        }

        private static readonly List<Func<(string, Action?)>> _hotkeyRequests = [];
        internal static IEnumerable<(string, Action?)> GetHotkeyRequests()
        {
            return _hotkeyRequests.Select(f => f());
        }


        
    }
}
