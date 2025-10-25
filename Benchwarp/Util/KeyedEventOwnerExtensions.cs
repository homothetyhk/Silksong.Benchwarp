using System.Runtime.CompilerServices;

namespace Benchwarp.Util;

public static class KeyedEventOwnerExtensions
{
    extension<TKey>(KeyedEvent<TKey, Action>.IKeyedEventOwner owner)
    {
        public void Invoke(TKey key, [CallerMemberName] string? caller = "")
        {
            try
            {
                owner.GetDelegate(key)?.Invoke();
            }
            catch (Exception e)
            {
                LogError($"Error invoking delegate from {caller} for key {key}:\n{e}");
            }
        }
    }

    extension<TKey, TArg>(KeyedEvent<TKey, Action<TArg>>.IKeyedEventOwner owner)
    {
        public void Invoke(TKey key, TArg arg, [CallerMemberName] string? caller = "")
        {
            try
            {
                owner.GetDelegate(key)?.Invoke(arg);
            }
            catch (Exception e)
            {
                LogError($"Error invoking delegate from {caller} for key {key} with arg {arg}:\n{e}");
            }
        }
    }

    extension<TKey, TArg1, TArg2>(KeyedEvent<TKey, Action<TArg1, TArg2>>.IKeyedEventOwner owner)
    {
        public void Invoke(TKey key, TArg1 arg1, TArg2 arg2, [CallerMemberName] string? caller = "")
        {
            try
            {
                owner.GetDelegate(key)?.Invoke(arg1, arg2);
            }
            catch (Exception e)
            {
                LogError($"Error invoking delegate from {caller} for key {key} with args {arg1}, {arg2}:\n{e}");
            }
        }
    }
}
