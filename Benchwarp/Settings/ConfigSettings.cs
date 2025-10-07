using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Benchwarp.Settings
{
    public class ConfigSettings(ConfigSettingsData data)
    {
        private readonly ConfigSettingsData data = data;

        /*
        public bool ShowMenu
        {
            get => data.ShowMenu;
            set
            {
                data.ShowMenu = value;
                Invoke(OnShowMenuChanged);
            }
        }
        internal static event Action? OnShowMenuChanged;
        */

        public MenuMode MenuMode
        {
            get => data.MenuMode;
            set
            {
                data.MenuMode = value;
                Invoke(OnMenuModeChanged);
            }
        }
        internal static event Action? OnMenuModeChanged;

        public bool ShowScene
        {
            get => data.ShowScene;
            set
            {
                data.ShowScene = value;
                Invoke(OnShowSceneChanged);
            }
        }
        internal static event Action? OnShowSceneChanged;

        public bool AlwaysToggleAll
        {
            get => data.AlwaysToggleAll;
            set
            {
                data.AlwaysToggleAll = value;
                Invoke(OnAlwaysToggleAllChanged);
            }
        }
        internal static event Action? OnAlwaysToggleAllChanged;
        
        public bool EnableHotkeys
        {
            get => data.EnableHotkeys;
            set
            {
                data.EnableHotkeys = value;
                Invoke(OnEnableHotkeysChanged);
            }
        }
        internal static event Action? OnEnableHotkeysChanged;

        public bool OverrideLocalization
        {
            get => data.OverrideLocalization;
            set
            {
                data.OverrideLocalization = value;
                Invoke(OnOverrideLocalizationChanged);
            }
        }
        internal static event Action? OnOverrideLocalizationChanged;

        


        internal static void Invoke(Action? a, [CallerMemberName] string? caller = "")
        {
            try
            {
                a?.Invoke();
            }
            catch (Exception e)
            {
                LogError($"Error in update event for {caller}:\n{e}");
            }
        }

        internal static void Invoke<T>(Action<T>? a, T arg, [CallerMemberName] string? caller = "")
        {
            try
            {
                a?.Invoke(arg);
            }
            catch (Exception e)
            {
                LogError($"Error in update event for {caller}:\n{e}");
            }
        }
    }
}
