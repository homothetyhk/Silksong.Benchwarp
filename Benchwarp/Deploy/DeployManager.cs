using Benchwarp.Benches;
using Benchwarp.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Deploy
{
    internal static class DeployManager
    {
        /// <summary>
        /// Creates and returns a respawn point at Hornet's position. The type of respawn point depends on <see cref="Settings.SharedSettings.DeployStyle"/>.
        /// </summary>
        public static GameObject DeployAtHero()
        {
            try
            {
                DeployStyles style = BenchwarpPlugin.SharedSettings.DeployStyle;
                Vector3 heroPos = HeroController.instance.transform.position;
                GameObject result = style switch
                {
                    DeployStyles.Marker => DeployMarkerAtHero(heroPos),
                    DeployStyles.Bone => DeployBenchAtHero(heroPos),
                    _ => throw new NotImplementedException($"Unimplemented deploy style: {BenchwarpPlugin.SharedSettings.DeployStyle}"),
                };
                BenchwarpPlugin.SaveSettings.DeployInfo = new()
                {
                    RespawnInfo = new(GameManager.instance.sceneName, DeployAssets.DeployedRespawnMarkerName, style.ToRespawnType(), GameManager.instance.sm.mapZone),
                    HeroX = heroPos.x, 
                    HeroY = heroPos.y, 
                    HeroZ = heroPos.z,
                    Style = style,
                };
                return result;
            }
            catch (Exception e)
            {
                LogError(e);
                throw;
            }
        }

        /// <summary>
        /// If <see cref="Settings.SaveSettings.DeployInfo"/> indicates that the scene contains a deployed respawn, creates and returns said respawn.
        /// </summary>
        public static GameObject? Redeploy()
        {
            if (BenchwarpPlugin.SaveSettings.DeployInfo is not DeployInfo info || GameManager.instance.sceneName != info.SceneName) return null;

            try
            {
                Vector3 heroPos = info.HeroPosition;
                GameObject result = BenchwarpPlugin.SharedSettings.DeployStyle switch
                {
                    DeployStyles.Marker => DeployMarkerAtHero(heroPos),
                    DeployStyles.Bone => DeployBenchAtHero(heroPos),
                    _ => throw new NotImplementedException($"Unimplemented deploy style: {BenchwarpPlugin.SharedSettings.DeployStyle}"),
                };
                return result;
            }
            catch (Exception e)
            {
                LogError(e);
                throw;
            }
        }

        public static GameObject DeployMarkerAtHero(Vector3 heroPos)
        {
            GameObject go = DeployAssets.CreateMarker();
            DeployAssets.PlaceMarkerRelativeToHero(go, heroPos);
            return go;
        }

        public static GameObject DeployBenchAtHero(Vector3 heroPos)
        {
            GameObject go = DeployAssets.CreateBench();
            DeployAssets.PlaceBenchRelativeToHero(go, heroPos);
            return go;
        }

        public static void Undeploy()
        {
            DeployComponent.DestroyAll();
            if (BenchwarpPlugin.SaveSettings.DeployInfo?.IsCurrentRespawn() ?? false)
            {
                Events.BenchListModifiers.GetStartDef().SetRespawn();
            }
            BenchwarpPlugin.SaveSettings.DeployInfo = null;
        }
    }
}
