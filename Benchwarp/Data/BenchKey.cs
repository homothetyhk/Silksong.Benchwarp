namespace Benchwarp.Data
{
    /// <summary>
    /// A unique identifier for benches which remains consistent across acts.
    /// </summary>
    public readonly record struct BenchKey(string BenchName, string MenuArea);
}
