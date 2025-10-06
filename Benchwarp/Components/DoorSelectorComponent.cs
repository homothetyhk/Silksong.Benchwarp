using Benchwarp.Data;
using UnityEngine;

namespace Benchwarp.Components
{
    public class DoorSelectorComponent : MonoBehaviour
    {
        public string? Area { get; private set; }
        public string? Room { get; private set; }
        public string? Door { get; private set; }

        private DropdownRadioSwitch? areaSwitch;
        private DropdownRadioSwitch? roomSwitch;
        private DropdownRadioSwitch? doorSwitch;

        private Dictionary<string, AreaRoomGroup> groups;
        private Dictionary<string, Dictionary<string, Room>> roomsByGroup;

        public void Warp()
        {
            if (Room is not null && Door is not null) ChangeScene.WarpToDoor(Room, Door);
            else LogWarn($"Warp clicked with {Area}, {Room}, {Door}");
        }

        public void OnAreaSelectionChanged(string area)
        {
            Area = area;
            roomSwitch?.Populate(groups[area].Rooms.Select(r => r.Name), autoOpen: true);
        }

        public void OnAreaSelectionCanceled()
        {
            Area = null;
            doorSwitch?.Depopulate();
            roomSwitch?.Depopulate();
        }

        public void OnRoomSelectionChanged(string room)
        {
            Room = room;
            doorSwitch?.Populate(roomsByGroup[Area!][room].Gates.Select(g => g.Self.GateName), autoOpen: true);
        }

        public void OnRoomSelectionCanceled()
        {
            Room = null;
            doorSwitch?.Depopulate();
        }

        public void OnDoorSelectionChanged(string door)
        {
            Door = door;
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

            Data.Gate g = roomsByGroup[Area][Room].Gates.First(g => g.Self.GateName == Door);
            if (g.Target.HasValue)
            {
                TrySet(g.Target.Value);
            }
            else if (g.Source.HasValue)
            {
                TrySet(g.Source.Value);
            }
            else
            {
                LogWarn($"Aborting Flip on gate {g.Self} with no source or target.");
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
            if (groups.Select(kvp => (kvp.Key, kvp.Value.Rooms.FirstOrDefault(r => r.Name == key.SceneName))).FirstOrDefault(p => p.Item2 is not null) is (string area, Room room)
                && room.Gates.FirstOrDefault(g => g.Self == key) is Data.Gate gate)
            {
                areaSwitch?.Select(area);
                roomSwitch?.Select(key.SceneName);
                doorSwitch?.Select(key.GateName);
            }
            else
            {
                LogWarn("Unable to retrieve selector data for transition " + key);
            }
        }
    }
}
