namespace Benchwarp.Data
{
    /// <summary>
    /// Data carrier for a bench that can appear on the menu.
    /// </summary>
    /// <param name="BenchName">The name of the bench, displayed on the bench button.</param>
    /// <param name="MenuArea">The group of the bench, displayed on the dropdown label.</param>
    /// <param name="RespawnInfo">The data of the bench, which may point to a different respawn marker depending on world state.</param>
    public record BenchData(string BenchName, string MenuArea, IRespawnInfo RespawnInfo)
    {
        /// <summary>
        /// A unique identifier for the bench.
        /// </summary>
        public BenchKey Key { get; } = new(BenchName, MenuArea);

        public static implicit operator BenchKey(BenchData obj) => obj.Key;

        /// <summary>
        /// The effect of clicking the bench button. Returns true if the respawn was set.
        /// </summary>
        public bool MenuSetBench()
        {
            switch (BenchwarpPlugin.ConfigSettings.MenuMode)
            {
                case Settings.MenuMode.UnlockAll:
                case Settings.MenuMode.DoorWarp:
                    break;
                case Settings.MenuMode.WarpOnly:
                    return false;
                default:
                    if (BenchwarpPlugin.SaveSettings.IsLocked(Key) || !BenchwarpPlugin.SaveSettings.IsVisited(Key)) return false;
                    else break;
            }
            RespawnInfo.SetRespawn();
            Events.ModEvents.InvokeOnBenchSelected();
            return true;
        }
    }
}
