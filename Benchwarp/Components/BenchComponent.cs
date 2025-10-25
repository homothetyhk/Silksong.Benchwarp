using Benchwarp.Benches;
using Benchwarp.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

public class BenchComponent : MonoBehaviour
{
    public required BenchData data;
    public required Text buttonText;

    public bool Locked { get; private set; } = false;
    public bool Visited { get; private set; } = false;
    public bool IsCurrentBench { get; private set; } = false;
    private bool queueRefetchData = true;
    private bool queueRecolor = true;

    private void Start()
    {
        WorldEvents.OnRespawnChanged += OnRespawnChanged;
        Settings.SaveSettings.OnSetVisitedLocal.Add(data, OnSetVisited);
        Settings.SaveSettings.OnSetLockedLocal.Add(data, OnSetLocked);
        Settings.SaveSettings.OnNewSettingsLoaded += OnNewSettingsLoaded;
        Settings.ConfigSettings.OnMenuModeChanged += QueueRecolor;
    }

    private void OnDestroy()
    {
        WorldEvents.OnRespawnChanged -= OnRespawnChanged;
        Settings.SaveSettings.OnSetVisitedLocal.Remove(data, OnSetVisited);
        Settings.SaveSettings.OnSetLockedLocal.Remove(data, OnSetLocked);
        Settings.SaveSettings.OnNewSettingsLoaded -= OnNewSettingsLoaded;
        Settings.ConfigSettings.OnMenuModeChanged -= QueueRecolor;
    }

    private void Update()
    {
        if (queueRefetchData)
        {
            RefetchData();
            queueRefetchData = false;
            queueRecolor = true;
        }
        if (queueRecolor)
        {
            UpdateTextColor();
            queueRecolor = false;
        }
    }

    private void RefetchData()
    {
        Locked = BenchwarpPlugin.SaveSettings.IsLocked(data);
        Visited = BenchwarpPlugin.SaveSettings.IsVisited(data);
        IsCurrentBench = data.RespawnInfo.IsCurrentRespawn();
    }

    private void QueueRecolor() => queueRecolor = true;
    private void QueueRefetchData() => queueRefetchData = true;

    private void UpdateTextColor()
    {
        if (BenchwarpPlugin.ConfigSettings.MenuMode != Settings.MenuMode.UnlockAll)
        {
            if (Locked)
            {
                buttonText.color = LockedBenchColor;
            }
            else if (!Visited)
            {
                buttonText.color = UnvisitedBenchColor;
            }
            else if (IsCurrentBench)
            {
                buttonText.color = CurrentBenchColor;
            }
            else
            {
                buttonText.color = AvailableBenchColor;
            }
        }
        else
        {
            if (IsCurrentBench)
            {
                buttonText.color = CurrentBenchColor;
            }
            else
            {
                buttonText.color = AvailableBenchColor;
            }
        }
    }

    private void OnRespawnChanged(RespawnInfo info, BenchData? data)
    {
        IsCurrentBench = ReferenceEquals(this.data, data);
        queueRecolor = true;
    }

    private void OnSetVisited(bool value)
    {
        Visited = value;
        queueRecolor = true;
    }

    private void OnSetLocked(bool value)
    {
        Locked = value;
        queueRecolor = true;
    }

    private void OnNewSettingsLoaded()
    {
        QueueRefetchData();
    }

    public static Color LockedBenchColor { get; } = Color.Lerp(Color.magenta, Color.black, 0.5f);
    public static Color UnvisitedBenchColor { get; } = Color.red;
    public static Color CurrentBenchColor { get; } = Color.yellow;
    public static Color AvailableBenchColor { get; } = Color.white;
}
