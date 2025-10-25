namespace Benchwarp.Util;

internal class StableComparer<T> : IComparer<KeyValuePair<int, T>>
{
    public StableComparer(IComparer<T> comparison) => comparer = comparison;
    private readonly IComparer<T> comparer;

    public static Comparison<KeyValuePair<int, T>> GetStableComparison(Comparison<T> comparison)
    {
        int CompareTo(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
        {
            int diff = comparison(x.Value, y.Value);
            return diff != 0 ? diff : x.Key - y.Key;
        }
        return CompareTo;
    }

    public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
    {
        int diff = comparer.Compare(x.Value, y.Value);
        return diff != 0 ? diff : x.Key - y.Key;
    }
}
