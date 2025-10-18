using Benchwarp.Data;
using UnityEngine;

namespace Benchwarp.Components
{
    internal class RespawnChangeListener : MonoBehaviour
    {
        public RespawnInfo? Current { get; private set; }

        private void Update()
        {
            if (Current is null || !Current.IsCurrentRespawn())
            {
                Current = RespawnInfo.FromPlayerData();
                WorldEvents.InvokeOnRespawnChanged(Current);
            }
        }
    }
}
