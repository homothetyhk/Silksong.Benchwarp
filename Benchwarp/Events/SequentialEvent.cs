namespace Benchwarp.Events
{
    /// <summary>
    /// Class for managing a list of delegates to be invoked individually, such as a list of Funcs whose results are to be aggregated.
    /// </summary>
    public class SequentialEvent<TDelegate> where TDelegate : Delegate
    {
        public SequentialEvent(out ISequentialEventOwner owner) => owner = new SequentialEventOwner(this);

        public interface ISequentialEventOwner
        {
            IReadOnlyList<TDelegate> GetSubscribers();
            event Action? OnSubscribersChanged;
        }

        private class SequentialEventOwner(SequentialEvent<TDelegate> e) : ISequentialEventOwner
        {
            event Action? ISequentialEventOwner.OnSubscribersChanged
            {
                add => e.OnSubscribersChanged += value;
                remove => e.OnSubscribersChanged -= value;
            }

            IReadOnlyList<TDelegate> ISequentialEventOwner.GetSubscribers()
            {
                return e.modifiers;
            }
        }

        private readonly List<TDelegate> modifiers = [];
        private event Action? OnSubscribersChanged;

        public void Add(TDelegate value)
        {
            modifiers.Add(value);
            OnSubscribersChanged?.Invoke();
        }

        public void Remove(TDelegate value)
        {
            modifiers.Remove(value);
            OnSubscribersChanged?.Invoke();
        }
    }
}
