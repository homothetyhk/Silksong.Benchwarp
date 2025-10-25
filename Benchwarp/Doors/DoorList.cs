using Benchwarp.Data;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Benchwarp.Doors;

public static class DoorList
{
    /*
    /// <summary>
    /// Look up a transition source using its target as a key.
    /// </summary>
    public static ReadOnlyDictionary<TransitionKey, TransitionKey> SourceLookup { get; }
    /// <summary>
    /// Look up a transition target using its source as a key.
    /// </summary>
    public static ReadOnlyDictionary<TransitionKey, TransitionKey> TargetLookup { get; }
    */
    
    public static ReadOnlyCollection<AreaRoomGroup> RoomGroups { get; }
    public static int RoomCount { get; }
    public static int DoorCount { get; }
    public static int MaxRoomsPerArea { get; }
    public static int MaxDoorsPerRoom { get; }

    static DoorList()
    {
        RoomGroups = new([.. typeof(BaseRoomList).GetProperties(BindingFlags.Public | BindingFlags.Static).Where(p => p.PropertyType == typeof(RoomData))
            .Select(p => (RoomData)p.GetValue(null)).GroupBy(r => r.TitledArea).Select(g => new AreaRoomGroup { MenuArea = g.Key, Rooms = new([.. g]) }).OrderBy(g => g.MenuArea)]);
        static int CountRooms(AreaRoomGroup g) => g.Rooms.Count;
        static int CountGates(RoomData r) => r.Gates.Count;
        RoomCount = RoomGroups.Sum(CountRooms);
        DoorCount = RoomGroups.Sum(g => g.Rooms.Sum(CountGates));
        MaxRoomsPerArea = RoomGroups.Max(CountRooms);
        MaxDoorsPerRoom = RoomGroups.Max(g => g.Rooms.Max(CountGates));

        /*
        SourceLookup = new(JsonUtil.Deserialize<Dictionary<string, string>>("Benchwarp.Resources.Doors.source_lookup.json")
            .ToDictionary(kvp => TransitionKey.FromName(kvp.Key), kvp => TransitionKey.FromName(kvp.Value)));
        TargetLookup = new(JsonUtil.Deserialize<Dictionary<string, string>>("Benchwarp.Resources.Doors.target_lookup.json")
            .ToDictionary(kvp => TransitionKey.FromName(kvp.Key), kvp => TransitionKey.FromName(kvp.Value)));
        HashSet<TransitionKey> all = [];
        all.UnionWith(SourceLookup.Keys.Concat(SourceLookup.Values).Concat(TargetLookup.Keys).Concat(TargetLookup.Values));

        Dictionary<string, string> tempAreaLookup = JsonUtil.Deserialize<Dictionary<string, string>>("Benchwarp.Resources.Doors.temp_areas.json");

        string GetMapArea(string sceneName)
        {
            string prefix = sceneName.Split('_')[0];
            if (sceneName.StartsWith("Bone_East")) prefix = "Bone_East";
            else if (sceneName.StartsWith("Dust_Maze")) prefix = "Dust_Maze";
            prefix = tempAreaLookup[prefix];
            prefix = RawData.TitledAreaNames.TitledToMapArea.TryGetValue(prefix, out string mapArea) ? mapArea : prefix;
            if (!RawData.MapAreaNames.Names.Contains(prefix))
            {
                LogWarn($"{prefix} is not a map area!");
                prefix = RawData.MapAreaNames.Unknown;
            }

            return prefix;
        }

        string GetAreaName(string sceneName)
        {
            string prefix = sceneName.Split('_')[0];
            if (sceneName.StartsWith("Bone_East")) prefix = "Bone_East";
            else if (sceneName.StartsWith("Dust_Maze")) prefix = "Dust_Maze";
            prefix = tempAreaLookup[prefix];
            if (!RawData.TitledAreaNames.TitledToMapArea.ContainsKey(prefix))
            {
                LogWarn($"{prefix} is not a titled area!");
                prefix = RawData.TitledAreaNames.Unknown;
            }
            return prefix;
        }

        List<AreaRoomGroup> groups = [.. all
            .GroupBy(t => t.SceneName)
            .Select(g => new Room
            {
                Name = g.Key,
                Gates = [.. g.Select(t => t.GateName).OrderBy(s => s)],
                MapArea = GetMapArea(g.Key),
                TitledArea = GetAreaName(g.Key),
            }).GroupBy(r => r.TitledArea)
            .Select(g => new AreaRoomGroup { MenuArea = g.Key, Rooms = [.. g] })];
        RoomGroups = new(groups);
        WriteRoomList();
        */
    }

    /*
    private static void WritePrimitiveGateList(IEnumerable<TransitionKey> keys)
    {
        using StreamWriter sw = File.CreateText("primitive_gates.cs");
        sw.WriteLine("namespace Benchwarp.Data.RawData;");
        sw.WriteLine();
        sw.WriteLine("public static class PrimitiveGateNames");
        sw.WriteLine("{");
        foreach (var s in keys.Select(k => k.GateName).Distinct().OrderBy(g => g))
        {
            string escapedName = s.Replace(' ', '_');
            sw.WriteLine($"    public const string {escapedName} = \"{s}\";");
        }
        sw.WriteLine("}");
    }
    */

    /*
    private static void WriteGateList(IEnumerable<TransitionKey> keys)
    {
        using StreamWriter sw = File.CreateText("gates.cs");
        sw.WriteLine("using static Benchwarp.Data.RawData.SceneNames;");
        sw.WriteLine("using static Benchwarp.Data.RawData.PrimitiveGateNames;");
        sw.WriteLine("namespace Benchwarp.Data.RawData;");
        sw.WriteLine();
        sw.WriteLine("public static class BaseGateList");
        sw.WriteLine("{");

        foreach (TransitionKey key in keys.OrderBy(k => k.Name))
        {
            TransitionKey? target = TargetLookup.TryGetValue(key, out TransitionKey _t) ? _t : null;
            TransitionKey? primarySource = SourceLookup.TryGetValue(key, out TransitionKey _s) ? _s : null;
            string escapedName = key.SceneName + "__" + key.GateName.Replace(' ', '_');
            if (target.HasValue && primarySource.HasValue && target.Value.Name == primarySource.Value.Name)
            {
                sw.WriteLine($"    public static Gate {escapedName} {{ get; }} = new(new({key.SceneName}, {key.GateName.Replace(' ', '_')}), new({target.Value.SceneName}, {target.Value.GateName.Replace(' ', '_')}));");
            }
            else
            {
                string targ = target is not null ? $"new({target.Value.SceneName}, {target.Value.GateName.Replace(' ', '_')})" : "null";
                string sour = primarySource is not null ? $"new({primarySource.Value.SceneName}, {primarySource.Value.GateName.Replace(' ', '_')})" : "null";
                sw.WriteLine($"    public static Gate {escapedName} {{ get; }} = new(new({key.SceneName}, {key.GateName.Replace(' ', '_')}), {targ}, {sour});");
            }
        }
        sw.WriteLine("}");
    }
    */

    /*
    private static void WriteRoomList()
    {
        using StreamWriter sw = File.CreateText("rooms.cs");
        sw.WriteLine("using static Benchwarp.Data.RawData.BaseGateList;");
        sw.WriteLine();
        sw.WriteLine("namespace Benchwarp.Data.RawData;");
        sw.WriteLine();
        sw.WriteLine("public static class BaseRoomList");
        sw.WriteLine("{");

        foreach (Room r in RoomGroups.SelectMany(g => g.Rooms).OrderBy(r => r.Name))
        {
            sw.WriteLine($"    public static Room {r.Name} {{ get; }} = new Room");
            sw.WriteLine("    {");
            sw.WriteLine($"        Name = SceneNames.{r.Name},");
            sw.WriteLine($"        MapArea = MapAreaNames.{r.MapArea.Replace('\'', '_').Replace(' ', '_')}, ");
            sw.WriteLine($"        TitledArea = TitledAreaNames.{r.TitledArea.Replace('\'', '_').Replace(' ', '_')},");
            sw.WriteLine($"        Gates = new([");
            foreach (string g in r.Gates)
            {
                sw.WriteLine($"            {r.Name}__{g.Replace(' ', '_')},");
            }
            sw.WriteLine("        ]),");
            sw.WriteLine("        ManuallyVerified = false,");
            sw.WriteLine("    };");
        }
        sw.WriteLine("}");
    }
    */
}
