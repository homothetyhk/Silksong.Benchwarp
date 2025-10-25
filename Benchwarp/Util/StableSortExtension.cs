namespace Benchwarp.Util;

internal static class StableSortExtension
{
    internal static void StableSort<T>(this IList<T> ts, Comparison<T> comparison)
    {
        KeyValuePair<int, T>[] keys = new KeyValuePair<int, T>[ts.Count];
        for (int i = 0; i < ts.Count; i++) keys[i] = new(i, ts[i]);
        Array.Sort(keys, StableComparer<T>.GetStableComparison(comparison));

        for (int i = 0; i < ts.Count; i++)
        {
            ts[i] = keys[i].Value;
        }
    }
}
