using Benchwarp.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components
{
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
            Events.WorldEvents.OnRespawnChanged += OnRespawnChanged;
            Settings.LocalSettings.OnSetVisitedLocal.Add(data, OnSetVisited);
            Settings.LocalSettings.OnSetLockedLocal.Add(data, OnSetLocked);
        }

        private void OnDestroy()
        {
            Events.WorldEvents.OnRespawnChanged -= OnRespawnChanged;
            Settings.LocalSettings.OnSetVisitedLocal.Remove(data, OnSetVisited);
            Settings.LocalSettings.OnSetLockedLocal.Remove(data, OnSetLocked);
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
            Locked = BenchwarpPlugin.LS.IsLocked(data);
            Visited = BenchwarpPlugin.LS.IsVisited(data);
            IsCurrentBench = data.RespawnInfo.IsCurrentRespawn();
        }

        private void UpdateTextColor()
        {
            if (BenchwarpPlugin.GS.MenuMode != Settings.MenuMode.UnlockAll)
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

        public static Color LockedBenchColor { get; } = Color.Lerp(Color.magenta, Color.black, 0.5f);
        public static Color UnvisitedBenchColor { get; } = Color.red;
        public static Color CurrentBenchColor { get; } = Color.yellow;
        public static Color AvailableBenchColor { get; } = Color.white;
    }
}
