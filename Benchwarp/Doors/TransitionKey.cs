using System.Text.RegularExpressions;

namespace Benchwarp.Doors;

public readonly record struct TransitionKey(string SceneName, string GateName)
{
    public static TransitionKey FromName(string name)
    {
        if (!(r.Match(name) is Match m && m.Success)) throw new ArgumentException("Illformated transition name" + name, nameof(name));
        return new(m.Groups[1].Value, m.Groups[2].Value);
    }

    private static readonly Regex r = new(@"^(\w+)\[([\w\s]+)\]$");

    public string Name { get; } = $"{SceneName}[{GateName}]";
}
