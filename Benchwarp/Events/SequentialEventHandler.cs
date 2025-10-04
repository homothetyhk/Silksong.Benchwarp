namespace Benchwarp.Events
{
    public class SequentialEventHandler<T>
    {
        private readonly List<Func<T, T>> modifiers = [];

        public event Func<T, T> Event
        {
            add => modifiers.Add(value);
            remove => modifiers.Remove(value);
        }

        public T Invoke(T defaultValue)
        {
            foreach (Func<T, T> f in modifiers)
            {
                defaultValue = f(defaultValue);
            }
            return defaultValue;
        }
    }
}
