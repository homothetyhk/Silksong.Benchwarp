namespace Benchwarp.Events
{
    public class KeyedEvent<TKey, TDelegate> where TDelegate : Delegate
    {
        public interface IKeyedEventOwner
        {
            TDelegate? GetDelegate(TKey key);
        }
        
        private class KeyedEventOwner(KeyedEvent<TKey, TDelegate> e) : IKeyedEventOwner
        {
            public TDelegate? GetDelegate(TKey key)
            {
                return e.lookup.TryGetValue(key, out TDelegate? result) ? result : default;
            }
        }

        public KeyedEvent(out IKeyedEventOwner owner)
        {
            owner = _owner = new KeyedEventOwner(this);
        }

        private readonly Dictionary<TKey, TDelegate?> lookup = [];
        private readonly IKeyedEventOwner _owner;
        public void Add(TKey key, TDelegate? value)
        {
            if (lookup.TryGetValue(key, out TDelegate? prev))
            {
                lookup[key] = (TDelegate?)Delegate.Combine(prev, value);
            }
            else
            {
                lookup.Add(key, value);
            }
        }
        public void Remove(TKey key, TDelegate? value)
        {
            if (lookup.TryGetValue(key, out TDelegate? prev))
            {
                lookup[key] = (TDelegate?)Delegate.Remove(prev, value);
            }
        }
    }
}
