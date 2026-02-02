using Benchwarp.Benches;
using Newtonsoft.Json;
using UnityEngine;

namespace Benchwarp.Deploy
{
    public record DeployInfo : IRespawnInfo
    {
        public required RespawnInfo RespawnInfo { get; init; }
        /// <summary>
        /// The x position of Hornet, at the time the bench was deployed.
        /// </summary>
        public required float HeroX { get; init; }
        /// <summary>
        /// The y position of Hornet, at the time the bench was deployed.
        /// </summary>
        public required float HeroY { get; init; }
        /// <summary>
        /// The z position of Hornet, at the time the bench was deployed.
        /// </summary>
        public required float HeroZ { get; init; }
        public required DeployStyles Style { get; init; }

        [JsonIgnore] public string SceneName => RespawnInfo.SceneName;
        [JsonIgnore] public Vector3 HeroPosition => new(HeroX, HeroY, HeroZ);

        RespawnInfo IRespawnInfo.GetRespawnInfo()
        {
            return RespawnInfo;
        }
    }
}
