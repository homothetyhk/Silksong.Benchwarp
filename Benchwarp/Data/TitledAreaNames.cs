using System.Collections.ObjectModel;
using System.Reflection;

namespace Benchwarp.Data;

public static class TitledAreaNames
{
    public const string Bellhart = "Bellhart";
    public const string Bilewater = "Bilewater";
    public const string Blasted_Steps = "Blasted Steps";
    public const string Bone_Bottom = "Bone Bottom";
    public const string Brightvein = "Brightvein";
    public const string Chapel_of_the_Architect = "Chapel of the Architect";
    public const string Chapel_of_the_Beast = "Chapel of the Beast";
    public const string Chapel_of_the_Reaper = "Chapel of the Reaper";
    public const string Chapel_of_the_Wanderer = "Chapel of the Wanderer";
    public const string Chapel_of_the_Witch = "Chapel of the Witch";
    public const string Choral_Chambers = "Choral Chambers";
    public const string Cogwork_Core = "Cogwork Core";
    public const string Coral_Tower = "Coral Tower";
    public const string Deep_Docks = "Deep Docks";
    public const string Exhaust_Organ = "Exhaust Organ";
    public const string Far_Fields = "Far Fields";
    public const string First_Shrine = "First Shrine";
    public const string Flea_Caravan = "Flea Caravan";
    public const string Fleatopia = "Fleatopia";
    public const string Grand_Gate = "Grand Gate";
    public const string Greymoor = "Greymoor";
    public const string Halfway_Home = "Halfway Home";
    public const string High_Halls = "High Halls";
    public const string Hunter_s_March = "Hunter’s March";
    public const string Lost_Verdania = "Lost Verdania";
    public const string Memorium = "Memorium";
    public const string Moss_Grotto = "Moss Grotto";
    public const string Mosshome = "Mosshome";
    public const string Mount_Fay = "Mount Fay";
    public const string Nameless_Town = "Nameless Town";
    public const string Putrified_Ducts = "Putrified Ducts";
    public const string Ruined_Chapel = "Ruined Chapel";
    public const string Sands_of_Karak = "Sands of Karak";
    public const string Shellwood = "Shellwood";
    public const string Sinner_s_Road = "Sinner’s Road";
    public const string Songclave = "Songclave";
    public const string The_Abyss = "The Abyss";
    public const string Cradle = "The Cradle";
    public const string The_Marrow = "The Marrow";
    public const string The_Mist = "The Mist";
    public const string The_Slab = "The Slab";
    public const string Underworks = "Underworks";
    public const string Voltnest = "Voltnest";
    public const string Weavenest_Absolom = "Weavenest Absolom";
    public const string Weavenest_Alta = "Weavenest Atla";
    public const string Weavenest_Cindril = "Weavenest Cindril";
    public const string Weavenest_Karn = "Weavenest Karn";
    public const string Weavenest_Murglin = "Weavenest Murglin";
    public const string Whispering_Vaults = "Whispering Vaults";
    public const string Whiteward = "Whiteward";
    public const string Wisp_Thicket = "Wisp Thicket";
    public const string Wormways = "Wormways";

    public static string Unknown { get; } = "Unknown";

    public static ReadOnlyCollection<string> Names { get; } = new([..typeof(TitledAreaNames).GetFields(BindingFlags.Static | BindingFlags.Public)
        .Where(f => f.FieldType == typeof(string) && f.IsLiteral && !f.IsInitOnly).Select(f => (string)f.GetValue(null))]);

    public static ReadOnlyDictionary<string, string> TitledToMapArea = new(new Dictionary<string, string>
    {
        [Bellhart] = MapAreaNames.Bellhart,
        [Bilewater] = MapAreaNames.Bilewater,
        [Blasted_Steps] = MapAreaNames.Blasted_Steps,
        [Bone_Bottom] = MapAreaNames.Mosslands,
        [Brightvein] = MapAreaNames.Mount_Fay,
        [Chapel_of_the_Architect] = MapAreaNames.Underworks,
        [Chapel_of_the_Beast] = MapAreaNames.Hunter_s_March,
        [Chapel_of_the_Reaper] = MapAreaNames.Greymoor,
        [Chapel_of_the_Wanderer] = MapAreaNames.Mosslands,
        [Chapel_of_the_Witch] = MapAreaNames.Shellwood,
        [Choral_Chambers] = MapAreaNames.Choral_Chambers,
        [Cogwork_Core] = MapAreaNames.Cogwork_Core,
        [Coral_Tower] = MapAreaNames.Sands_of_Karak,
        [Cradle] = MapAreaNames.Cradle,
        [Deep_Docks] = MapAreaNames.Deep_Docks,
        [Flea_Caravan] = MapAreaNames.Putrified_Ducts,
        [Fleatopia] = MapAreaNames.Putrified_Ducts,
        [Exhaust_Organ] = MapAreaNames.Bilewater,
        [Far_Fields] = MapAreaNames.Far_Fields,
        [First_Shrine] = MapAreaNames.Choral_Chambers,
        [Grand_Gate] = MapAreaNames.Grand_Gate,
        [Greymoor] = MapAreaNames.Greymoor,
        [Halfway_Home] = MapAreaNames.Greymoor,
        [High_Halls] = MapAreaNames.High_Halls,
        [Hunter_s_March] = MapAreaNames.Hunter_s_March,
        [Lost_Verdania] = MapAreaNames.Verdania,
        [Memorium] = MapAreaNames.Memorium,
        [Mosshome] = MapAreaNames.Mosslands,
        [Moss_Grotto] = MapAreaNames.Mosslands,
        [Mount_Fay] = MapAreaNames.Mount_Fay,
        [Nameless_Town] = MapAreaNames.Cradle,
        [Putrified_Ducts] = MapAreaNames.Putrified_Ducts,
        [Ruined_Chapel] = MapAreaNames.Mosslands,
        [Sands_of_Karak] = MapAreaNames.Sands_of_Karak,
        [Shellwood] = MapAreaNames.Shellwood,
        [Sinner_s_Road] = MapAreaNames.Sinner_s_Road,
        [Songclave] = MapAreaNames.Choral_Chambers,
        [The_Abyss] = MapAreaNames.The_Abyss,
        [The_Marrow] = MapAreaNames.The_Marrow,
        [The_Mist] = MapAreaNames.Sinner_s_Road,
        [The_Slab] = MapAreaNames.The_Slab,
        [Underworks] = MapAreaNames.Underworks,
        [Voltnest] = MapAreaNames.Sands_of_Karak,
        [Weavenest_Absolom] = MapAreaNames.The_Abyss,
        [Weavenest_Alta] = MapAreaNames.Weavenest_Alta,
        [Weavenest_Cindril] = MapAreaNames.Far_Fields,
        [Weavenest_Karn] = MapAreaNames.Wormways,
        [Weavenest_Murglin] = MapAreaNames.Bilewater,
        [Whispering_Vaults] = MapAreaNames.Whispering_Vaults,
        [Whiteward] = MapAreaNames.Whiteward,
        [Wisp_Thicket] = MapAreaNames.Greymoor, // mostly greymoor, partially bellhart, according to wiki
        [Wormways] = MapAreaNames.Wormways,
    });
}
