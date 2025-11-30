using System;
using Benchwarp.Components;
using Benchwarp.Settings;

namespace Benchwarp.Hotkeys;

internal static class DoorHotkeyActions
{
    public static bool TryHandleDoorGridHotkey(int columnIndex, int rowIndex)
    {
        if (!CanHandleDoorHotkeys()) return false;

        DropdownRadioSwitch? dropdown = GetTargetDropdown();
        return dropdown is not null && dropdown.TrySelectByGridPosition(columnIndex, rowIndex);
    }

    public static void WarpSelectedDoor() => WithDoorSelector(selector => selector.Warp());

    public static void FlipSelectedDoor() => WithDoorSelector(selector => selector.Flip());

    public static void SelectLastDoor() => WithDoorSelector(selector => selector.LastEntered());

    public static void ToggleAreaDropdown() => ToggleDropdown(gui => gui.DoorAreaSwitch);

    public static void ToggleRoomDropdown() => ToggleDropdown(gui => gui.DoorRoomSwitch);

    public static void ToggleDoorDropdown() => ToggleDropdown(gui => gui.DoorDoorSwitch);

    private static void ToggleDropdown(Func<GUIController, DropdownRadioSwitch> getter)
    {
        if (!CanHandleDoorHotkeys()) return;
        getter(GUIController.Instance).ToggleDropdown();
    }

    private static void WithDoorSelector(Action<DoorSelectorComponent> action)
    {
        if (!CanHandleDoorHotkeys()) return;
        action(GUIController.Instance.DoorSelector);
    }

    private static DropdownRadioSwitch? GetTargetDropdown()
    {
        GUIController gui = GUIController.Instance;
        DropdownRadioSwitch door = gui.DoorDoorSwitch;
        DropdownRadioSwitch room = gui.DoorRoomSwitch;
        DropdownRadioSwitch area = gui.DoorAreaSwitch;

        if (door.Open) return door;
        if (room.Open) return room;
        if (area.Open) return area;

        DoorSelectorComponent selector = gui.DoorSelector;
        if (selector.Area is null)
        {
            area.Show();
            return area;
        }
        if (selector.Room is null)
        {
            room.Show();
            return room;
        }
        door.Show();
        return door;
    }

    private static bool CanHandleDoorHotkeys()
        => BenchwarpPlugin.ConfigSettings.MenuMode == MenuMode.DoorWarp
            && GUIController.Instance.IsDisplaying;
}
