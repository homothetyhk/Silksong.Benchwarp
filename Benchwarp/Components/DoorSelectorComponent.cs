using Benchwarp.Doors;
using UnityEngine;

namespace Benchwarp.Components;

public class DoorSelectorComponent : MonoBehaviour
{
    public AreaRoomGroup? Area { get; private set; }
    public RoomData? Room { get; private set; }
    public Doors.DoorData? Door { get; private set; }

    private DropdownRadioSwitch? areaSwitch;
    private DropdownRadioSwitch? roomSwitch;
    private DropdownRadioSwitch? doorSwitch;

    private Dictionary<string, AreaRoomGroup> groups = new();
    private Dictionary<string, Dictionary<string, RoomData>> roomsByGroup = new();

    public void Warp()
    {
        if (Room is not null && Door is not null) ChangeScene.WarpToDoor(Room, Door);
        else LogWarn($"Warp clicked with {Area}, {Room}, {Door}");
    }

    public void OnAreaSelectionChanged(string area)
    {
        Area = groups[area];
        roomSwitch!.Populate(Area!.Rooms.Select(r => r.Name), autoOpen: true);
    }

    public void OnAreaSelectionCanceled()
    {
        Area = null;
        doorSwitch!.Depopulate();
        roomSwitch!.Depopulate();
    }

    public void OnRoomSelectionChanged(string room)
    {
        Room = roomsByGroup[Area!.MenuArea][room];
        doorSwitch!.Populate(Room!.Gates.Select(g => g.Self.GateName), autoOpen: true);
    }

    public void OnRoomSelectionCanceled()
    {
        Room = null;
        doorSwitch!.Depopulate();
    }

    public void OnDoorSelectionChanged(string door)
    {
        Door = Room!.Gates.First(g => g.Self.GateName == door);
    }

    public void OnDoorSelectionCanceled()
    {
        Door = null;
    }

    public void Setup(DropdownRadioSwitch areaSwitch, DropdownRadioSwitch roomSwitch, DropdownRadioSwitch doorSwitch, IEnumerable<AreaRoomGroup> groups)
    {
        this.areaSwitch = areaSwitch;
        this.roomSwitch = roomSwitch;
        this.doorSwitch = doorSwitch;
        areaSwitch.onSelectionChanged += OnAreaSelectionChanged;
        areaSwitch.onSelectionCanceled += OnAreaSelectionCanceled;
        roomSwitch.onSelectionChanged += OnRoomSelectionChanged;
        roomSwitch.onSelectionCanceled += OnRoomSelectionCanceled;
        doorSwitch.onSelectionChanged += OnDoorSelectionChanged;
        doorSwitch.onSelectionCanceled += OnDoorSelectionCanceled;
        this.groups = groups.ToDictionary(g => g.MenuArea);
        this.roomsByGroup = groups.ToDictionary(g => g.MenuArea, g => g.Rooms.ToDictionary(r => r.Name));
    }

    public void Flip() 
    {
        if (Door is null || Area is null || Room is null) return;

        if (Door.Target.HasValue)
        {
            TrySet(Door.Target.Value);
        }
        else if (Door.Source.HasValue)
        {
            TrySet(Door.Source.Value);
        }
        else
        {
            LogWarn($"Aborting Flip on gate {Door.Self} with no source or target.");
        }
    }

    public void LastEntered()
    {
        string? door = GameManager.instance.entryGateName;
        string? room = GameManager.instance.sceneName;
        TrySet(new(room, door));
    }

    private void TrySet(TransitionKey key)
    {
        if (groups.Select(kvp => (kvp.Key, kvp.Value.Rooms.FirstOrDefault(r => r.Name == key.SceneName))).FirstOrDefault(p => p.Item2 is not null) is (string area, RoomData room)
            && room.Gates.FirstOrDefault(g => g.Self == key) is Doors.DoorData gate)
        {
            areaSwitch!.Select(area);
            roomSwitch!.Select(key.SceneName);
            doorSwitch!.Select(key.GateName);
        }
        else
        {
            LogWarn("Unable to retrieve selector data for transition " + key);
        }
    }
}
