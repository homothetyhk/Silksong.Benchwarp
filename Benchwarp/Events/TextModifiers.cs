using Benchwarp.Benches;
using Benchwarp.Util;

namespace Benchwarp.Events;

public delegate void BenchTextModifier(BenchData bench, ref string text);

public static class TextModifiers
{
    /// <summary>
    /// Event invoked to determine the displayed name of a bench. The initial value of the name parameter is <see cref="BenchData.BenchName"/> after localization.
    /// It is the subscriber's responsibility to localize if the name is modified.
    /// </summary>
    public static event BenchTextModifier? OnGetBenchName;
    public static string GetBenchName(BenchData bench)
    {
        string name = bench.BenchName.Localize();
        try { OnGetBenchName?.Invoke(bench, ref name); }
        catch (Exception e) { LogError(e); }
        return name;
    }

    /// <summary>
    /// Event invoked to determine the displayed area of a bench. The initial value of the name parameter is <see cref="BenchData.MenuArea"/> after localization.
    /// It is the subscriber's responsibility to localize if the name is modified.
    /// </summary>
    public static event BenchTextModifier? OnGetBenchArea;
    public static string GetBenchArea(BenchData bench)
    {
        string name = bench.MenuArea.Localize();
        try { OnGetBenchArea?.Invoke(bench, ref name); }
        catch (Exception e) { LogError(e); }
        return name;
    }

    /// <summary>
    /// Event invoked to determine the displayed scene of a bench. The initial value of the name parameter is the result of <see cref="GetSceneName(string)"/> on <see cref="BenchData.SceneName"/> after localization.
    /// It is the subscriber's responsibility to localize if the name is modified.
    /// </summary>
    public static event BenchTextModifier? OnGetBenchSceneName;
    public static string GetBenchSceneName(BenchData bench)
    {
        string name = GetSceneName(bench.RespawnInfo.GetRespawnInfo().SceneName);
        try { OnGetBenchSceneName?.Invoke(bench, ref name); }
        catch (Exception e) { LogError(e); }
        return name;
    }

    /// <summary>
    /// Event invoked to determine the displayed name of a scene. Runs before OnGetBenchSceneName, when relevant.
    /// The initial value is the unlocalized scene name. The final value is passed to localization before <see cref="GetSceneName(string)"/> returns.
    /// </summary>
    public static SequentialEvent<Func<string, string>> OnGetSceneName { get; } = new(out onGetSceneNameOwner);
    private static readonly SequentialEvent<Func<string, string>>.ISequentialEventOwner onGetSceneNameOwner;
    public static string GetSceneName(string sceneName) => onGetSceneNameOwner.InvokeToTransform(sceneName).Localize();
}
