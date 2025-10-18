using System.Runtime.CompilerServices;

namespace Benchwarp.Events
{
    public static class SequentialEventOwnerExtensions
    {
        extension<TValue>(SequentialEvent<Func<TValue,TValue>>.ISequentialEventOwner owner)
        {
            public TValue InvokeToTransform(TValue seed, [CallerMemberName] string? caller = "")
            {
                foreach (Func<TValue, TValue> f in owner.GetSubscribers())
                {
                    try
                    {
                        seed = f(seed);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking sequential transformer from {caller}:\n{e}");
                    }
                }
                return seed;
            }
        }

        extension<TValue, TArg>(SequentialEvent<Func<TArg, TValue, TValue>>.ISequentialEventOwner owner)
        {
            public TValue InvokeToTransform(TArg arg, TValue seed, [CallerMemberName] string? caller = "")
            {
                foreach (Func<TArg, TValue, TValue> f in owner.GetSubscribers())
                {
                    try
                    {
                        seed = f(arg, seed);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking sequential transformer from {caller}:\n{e}");
                    }
                }
                return seed;
            }
        }

        extension<TValue>(SequentialEvent<Func<TValue>>.ISequentialEventOwner owner)
        {
            public List<TValue> InvokeAndCollect([CallerMemberName] string? caller = "")
            {
                IReadOnlyList<Func<TValue>> delegateList = owner.GetSubscribers();
                List<TValue> resultList = new(delegateList.Count);
                foreach (Func<TValue> f in delegateList)
                {
                    try
                    {
                        TValue value = f();
                        resultList.Add(value);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking subscriber to {caller}:\n{e}");
                    }
                }
                return resultList;
            }

            public TResult InvokeAndAggregate<TResult>(TResult seed, Func<TResult, TValue, TResult> combiner, [CallerMemberName] string? caller = "")
            {
                foreach (Func<TValue> f in owner.GetSubscribers())
                {
                    try
                    {
                        TValue value = f();
                        seed = combiner(seed, value);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking sequential aggreator from {caller}:\n{e}");
                    }
                }
                return seed;
            }
        }

        extension<TValue, TArg>(SequentialEvent<Func<TArg, TValue>>.ISequentialEventOwner owner)
        {
            public List<TValue> InvokeAndCollect(TArg arg, [CallerMemberName] string? caller = "")
            {
                IReadOnlyList<Func<TArg, TValue>> delegateList = owner.GetSubscribers();
                List<TValue> resultList = new(delegateList.Count);
                foreach (Func<TArg, TValue> f in delegateList)
                {
                    try
                    {
                        TValue value = f(arg);
                        resultList.Add(value);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking subscriber to {caller}:\n{e}");
                    }
                }
                return resultList;
            }

            public TResult InvokeAndAggregate<TResult>(TArg arg, TResult seed, Func<TResult, TValue, TResult> combiner, [CallerMemberName] string? caller = "")
            {
                foreach (Func<TArg, TValue> f in owner.GetSubscribers())
                {
                    try
                    {
                        TValue value = f(arg);
                        seed = combiner(seed, value);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking sequential aggreator from {caller} with arg {arg}:\n{e}");
                    }
                }
                return seed;
            }
        }

        extension<TValue>(SequentialEvent<Func<IEnumerable<TValue>>>.ISequentialEventOwner owner)
        {
            public List<TValue> InvokeAndCollectFlat([CallerMemberName] string? caller = "")
            {
                IReadOnlyList<Func<IEnumerable<TValue>>> delegateList = owner.GetSubscribers();
                List<TValue> resultList = new(delegateList.Count);
                foreach (Func<IEnumerable<TValue>> f in delegateList)
                {
                    try
                    {
                        IEnumerable<TValue> value = f();
                        resultList.AddRange(value);
                    }
                    catch (Exception e)
                    {
                        LogError($"Error invoking subscriber to {caller}:\n{e}");
                    }
                }
                return resultList;
            }
        }

    }
}
