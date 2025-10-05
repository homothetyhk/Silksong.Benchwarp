using System.Collections.ObjectModel;
using System.Reflection;

namespace Benchwarp.Data.RawData
{
    public static class MapAreaNames
    {
        public const string Bellhart = "Bellhart";
        public const string Bilewater = "Bilewater";
        public const string Blasted_Steps = "Blasted Steps";
        public const string Choral_Chambers = "Choral Chambers";
        public const string Cogwork_Core = "Cogwork Core";
        public const string Cradle = "Cradle";
        public const string Deep_Docks = "Deep Docks";
        public const string Far_Fields = "Far Fields";
        public const string Grand_Gate = "Grand Gate";
        public const string Greymoor = "Greymoor";
        public const string High_Halls = "High Halls";
        public const string Hunter_s_March = "Hunter's March";
        public const string Memorium = "Memorium";
        public const string Mosslands = "Mosslands";
        public const string Mount_Fay = "Mount Fay";
        public const string Putrified_Ducts = "Putrified Ducts";
        public const string Sands_of_Karak = "Sands of Karak";
        public const string Shellwood = "Shellwood";
        public const string Sinner_s_Road = "Sinner's Road";
        public const string The_Abyss = "The Abyss";
        public const string The_Marrow = "The Marrow";
        public const string The_Slab = "The Slab";
        public const string Underworks = "Underworks";
        public const string Verdania = "Verdania";
        public const string Weavenest_Alta = "Weavenest Alta";
        public const string Whispering_Vaults = "Whispering Vaults";
        public const string Whiteward = "Whiteward";
        public const string Wormways = "Wormways";

        public static string Unknown { get; } = "Unknown";

        public static ReadOnlyCollection<string> Names { get; } = new([..typeof(MapAreaNames).GetFields(BindingFlags.Static | BindingFlags.Public)
            .Where(f => f.FieldType == typeof(string) && f.IsLiteral && !f.IsInitOnly).Select(f => (string)f.GetValue(null))]);
    }
}
