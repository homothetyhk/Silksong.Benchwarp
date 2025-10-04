using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components
{
    public class AtStartListener : MonoBehaviour
    {
        public required Text buttonText;

        public bool AtStart { get; private set; }
        private bool queueRefetchData = true;
        private bool queueRecolor = true;

        private void Start()
        {
            Events.WorldEvents.OnRespawnChanged += OnRespawnChanged;
        }

        private void OnDestroy()
        {
            Events.WorldEvents.OnRespawnChanged -= OnRespawnChanged;
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
                Recolor();
                queueRecolor = false;
            }
        }

        private void RefetchData()
        {
            AtStart = Events.BenchListModifiers.AtStart();
        }

        private void Recolor()
        {
            buttonText.color = AtStart ? BenchComponent.CurrentBenchColor : BenchComponent.AvailableBenchColor;
        }

        private void OnRespawnChanged(Data.RespawnInfo arg1, Data.BenchData? arg2)
        {
            queueRefetchData = true;
        }
    }
}
