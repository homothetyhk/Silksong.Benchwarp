using Benchwarp.Benches;
using Benchwarp.Util;
using System.Runtime.CompilerServices;

namespace Benchwarp.Settings;

public class SaveSettings(SaveSettingsData data)
{
    private SaveSettingsData data = data;

    public bool IsVisited(BenchKey key) => data.VisitedBenches.Contains(key);
    public bool IsLocked(BenchKey key) => data.LockedBenches.Contains(key);

    public void SetVisited(BenchKey key, bool value)
    {
        if (IsLocked(key)) return;

        if (value)
        {
            if (data.VisitedBenches.Add(key))
            {
                Invoke(OnSetVisitedGlobal, key, value);
                onSetVisitedLocalOwner.Invoke(key, value);
            }
        }
        else
        {
            if (data.VisitedBenches.Remove(key))
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
            if (data.LockedBenches.Add(key))
            {
                Invoke(OnSetLocked, key, value);
                onSetLockedLocalOwner.Invoke(key, value);
            }
        }
        else
        {
            if (data.LockedBenches.Remove(key))
            {
                Invoke(OnSetLocked, key, value);
                onSetLockedLocalOwner.Invoke(key, value);
            }
        }
    }
    internal static event Action<BenchKey, bool>? OnSetLocked;
    internal static KeyedEvent<BenchKey, Action<bool>> OnSetLockedLocal { get; } = new(out onSetLockedLocalOwner);
    private static readonly KeyedEvent<BenchKey, Action<bool>>.IKeyedEventOwner onSetLockedLocalOwner;

    public Deploy.DeployInfo? DeployInfo
    {
        get => data.DeployInfo;
        set
        {
            data.DeployInfo = value;
            Invoke(OnDeployInfoChanged);
        }
    }
    internal static event Action? OnDeployInfoChanged;

    internal static event Action? OnNewSettingsLoaded;

    private static void Invoke(Action? a, [CallerMemberName] string? caller = "")
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

    internal SaveSettingsData GetSerializationData() => data;
    internal void Load(SaveSettingsData data)
    {
        this.data = data;
        try
        {
            OnNewSettingsLoaded?.Invoke();
        }
        catch (Exception e)
        {
            LogError($"Error invoking OnNewSettingsLoaded:\n{e}");
        }
    }
}
