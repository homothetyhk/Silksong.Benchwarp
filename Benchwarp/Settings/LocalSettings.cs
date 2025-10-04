using Benchwarp.Data;
using Benchwarp.Events;
using System.Runtime.CompilerServices;

namespace Benchwarp.Settings
{
    public class LocalSettings(LocalSettingsData data)
    {
        private readonly LocalSettingsData data = data;

        public bool IsVisited(BenchKey key) => data.visitedBenches.Contains(key);
        public bool IsLocked(BenchKey key) => data.lockedBenches.Contains(key);

        public void SetVisited(BenchKey key, bool value)
        {
            if (IsLocked(key)) return;

            if (value)
            {
                if (data.visitedBenches.Add(key))
                {
                    Invoke(OnSetVisitedGlobal, key, value);
                    onSetVisitedLocalOwner.Invoke(key, value);
                }
            }
            else
            {
                if (data.visitedBenches.Remove(key))
                {
                    Invoke(OnSetVisitedGlobal, key, value);
                    onSetVisitedLocalOwner.Invoke(key, value);
                }
            }
        }
        internal static event Action<BenchKey, bool>? OnSetVisitedGlobal;
        internal static KeyedEvent<BenchKey, Action<bool>> OnSetVisitedLocal { get; } = new(out onSetVisitedLocalOwner);
        private static readonly KeyedEvent<BenchKey, Action<bool>>.IKeyedEventOwner onSetVisitedLocalOwner;

        public void SetLocked(BenchKey key, bool value)
        {
            if (value)
            {
                if (data.lockedBenches.Add(key))
                {
                    Invoke(OnSetLocked, key, value);
                    onSetLockedLocalOwner.Invoke(key, value);
                }
            }
            else
            {
                if (data.lockedBenches.Remove(key))
                {
                    Invoke(OnSetLocked, key, value);
                    onSetLockedLocalOwner.Invoke(key, value);
                }
            }
        }
        internal static event Action<BenchKey, bool>? OnSetLocked;
        internal static KeyedEvent<BenchKey, Action<bool>> OnSetLockedLocal { get; } = new(out onSetLockedLocalOwner);
        private static readonly KeyedEvent<BenchKey, Action<bool>>.IKeyedEventOwner onSetLockedLocalOwner;

        private static void Invoke<T1, T2>(Action<T1,T2>? a, T1 arg1, T2 arg2, [CallerMemberName] string? caller = "")
        {
            try
            {
                a?.Invoke(arg1, arg2);
            }
            catch (Exception e)
            {
                LogError($"Error invoking global update event for {caller}:\n{e}");
            }
        }
    }
}
