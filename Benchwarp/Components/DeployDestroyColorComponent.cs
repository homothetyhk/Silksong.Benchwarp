using Benchwarp.Benches;
using Benchwarp.Deploy;
using Benchwarp.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

internal class DeployDestroyColorComponent : MonoBehaviour
{
    public required Text buttonText;
    public bool IsDeployed { get; private set; } = false;
    private bool queueRefetchData = true;
    private bool queueRecolor = true;

    private void Start()
    {
        Settings.SaveSettings.OnNewSettingsLoaded += OnNewSettingsLoaded;
        Settings.SaveSettings.OnDeployInfoChanged += OnNewSettingsLoaded;
    }

    private void OnDestroy()
    {
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
        IsDeployed = BenchwarpPlugin.SaveSettings.DeployInfo is not null;
    }

    private void QueueRecolor() => queueRecolor = true;
    private void QueueRefetchData() => queueRefetchData = true;

    private void UpdateTextColor()
    {
        if (!IsDeployed)
        {
            buttonText.color = UndeployedColor;
        }
        else
        {
            buttonText.color = AvailableBenchColor;
        }
    }

    private void OnNewSettingsLoaded()
    {
        QueueRefetchData();
    }

    public static Color UndeployedColor { get; } = Color.red;
    public static Color AvailableBenchColor { get; } = Color.white;
}
