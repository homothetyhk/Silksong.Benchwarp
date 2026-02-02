using Benchwarp.Benches;
using Benchwarp.Deploy;
using Benchwarp.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

internal class DeploySetColorComponent : MonoBehaviour
{
    public required Text buttonText;
    public bool IsDeployed { get; private set; } = false;
    public bool IsCurrentBench { get; private set; } = false;
    private bool queueRefetchData = true;
    private bool queueRecolor = true;

    private void Start()
    {
        WorldEvents.OnRespawnChanged += OnRespawnChanged;
        Settings.SaveSettings.OnNewSettingsLoaded += OnNewSettingsLoaded;
        Settings.SaveSettings.OnDeployInfoChanged += OnNewSettingsLoaded;
    }

    private void OnDestroy()
    {
        WorldEvents.OnRespawnChanged -= OnRespawnChanged;
        Settings.SaveSettings.OnNewSettingsLoaded -= OnNewSettingsLoaded;
        Settings.SaveSettings.OnDeployInfoChanged -= OnNewSettingsLoaded;
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
        DeployInfo? info = BenchwarpPlugin.SaveSettings.DeployInfo;
        IsDeployed = info is not null;
        IsCurrentBench = info?.IsCurrentRespawn() ?? false;
    }

    private void QueueRecolor() => queueRecolor = true;
    private void QueueRefetchData() => queueRefetchData = true;

    private void UpdateTextColor()
    {
        if (!IsDeployed)
        {
            buttonText.color = UndeployedColor;
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

    private void OnRespawnChanged(RespawnInfo info, BenchData? data)
    {
        Log("Checking changed respawn to " + info);
        IsCurrentBench = BenchwarpPlugin.SaveSettings.DeployInfo?.IsCurrentRespawn() ?? false;
        queueRecolor = true;
    }

    private void OnNewSettingsLoaded()
    {
        QueueRefetchData();
    }

    public static Color UndeployedColor { get; } = Color.red;
    public static Color CurrentBenchColor { get; } = Color.yellow;
    public static Color AvailableBenchColor { get; } = Color.white;
}
