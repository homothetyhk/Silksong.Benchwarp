namespace Benchwarp.Data
{
    /// <summary>
    /// Interface for data carriers to provide a respawn on request.
    /// </summary>
    public interface IRespawnInfo
    {
        /// <summary>
        /// Returns the data for a respawn marker, which may vary depending on world state.
        /// The return value should not change if called multiple times in one frame.
        /// </summary>
        RespawnInfo GetRespawnInfo();
    }
}
