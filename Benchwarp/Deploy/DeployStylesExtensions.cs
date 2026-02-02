using Benchwarp.Data;

namespace Benchwarp.Deploy
{
    public static class DeployStylesExtensions
    {
        extension(DeployStyles style)
        {
            public int ToRespawnType()
            {
                return style switch { DeployStyles.Marker => RespawnTypes.Floor, _ => RespawnTypes.Bench };
            }
        }
    }
}
