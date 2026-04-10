using Benchwarp.Data;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Benchwarp.Doors;

public static class DoorList
{
    public static ReadOnlyDictionary<string, RoomData> Rooms { get; }
    public static ReadOnlyDictionary<TransitionKey, DoorData> Doors { get; }
    public static ReadOnlyCollection<AreaRoomGroup> RoomGroups { get; }
    
    public static int RoomCount { get; }
    public static int DoorCount { get; }
    public static int MaxRoomsPerArea { get; }
    public static int MaxDoorsPerRoom { get; }

    static DoorList()
    {
        Rooms = new(typeof(BaseRoomList).GetProperties(BindingFlags.Public | BindingFlags.Static).Where(p => p.PropertyType == typeof(RoomData))
            .Select(p => (RoomData)p.GetValue(null)).ToDictionary(d => d.Name, d => d));
        Doors = new(Rooms.Values.SelectMany(r => r.Gates).ToDictionary(g => g.Self));

        RoomGroups = new([.. Rooms.Values.GroupBy(r => r.TitledArea).Select(g => new AreaRoomGroup { MenuArea = g.Key, Rooms = new([.. g]) }).OrderBy(g => g.MenuArea)]);
        static int CountRooms(AreaRoomGroup g) => g.Rooms.Count;
        static int CountGates(RoomData r) => r.Gates.Count;
        RoomCount = RoomGroups.Sum(CountRooms);
        DoorCount = RoomGroups.Sum(g => g.Rooms.Sum(CountGates));
        MaxRoomsPerArea = RoomGroups.Max(CountRooms);
        MaxDoorsPerRoom = RoomGroups.Max(g => g.Rooms.Max(CountGates));
    }
}