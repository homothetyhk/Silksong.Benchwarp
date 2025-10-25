using Benchwarp.Doors;
using Benchwarp.Doors.Obstacles;
using Benchwarp.Hotkeys;
using Benchwarp.Util;

namespace Benchwarp.Events;

public static class ModEvents
{
    /// <summary>
    /// Event invoked after a bench is selected from the menu, or the deployed bench is selected.
    /// </summary>
    public static event Action? OnBenchSelected;
    internal static void InvokeOnBenchSelected()
    {
        try { OnBenchSelected?.Invoke(); }
        catch (Exception e) { LogError(e); }
    }

    /// <summary>
    /// Event invoked when a request to benchwarp is made, before beginning to warp.
    /// </summary>
    public static event Action? OnBenchwarp;
    internal static void InvokeOnBenchwarp()
    {
        try { OnBenchwarp?.Invoke(); }
        catch (Exception e) { LogError(e); }
    }
    /// <summary>
    /// Event with (scene, gate) parameters, invoked when a request to doorwarp is made, before beginning to warp.
    /// </summary>
    public static event Action<RoomData, DoorData>? OnDoorwarp;
    internal static void InvokeOnDoorwarp(RoomData room, DoorData gate)
    {
        try { OnDoorwarp?.Invoke(room, gate); }
        catch (Exception e) { LogError(e); }
    }

    /// <summary>
    /// The <see cref="IObstacleHandler"/> used to remove obstacles when warping to a transition by <see cref="ChangeScene.WarpToDoor(string, string)"/>.
    /// </summary>
    public static IObstacleHandler DoorwarpObstacleHandler { get; set; } = new NoSaveObstacleHandler();


    /// <summary>
    /// Event invoked to define new hotkey commands. The action will be invoked if the code is entered while the game is paused.
    /// <br/>The string must be a two letter code. The code may be overriden by GS.HotkeyOverrides.
    /// <br/>Invalid codes will be ignored, logging an error message. A null code will be silently ignored.
    /// <br/>Duplicate codes will overwrite the existing code. A code with null action will remove any existing action bound to that code.
    /// </summary>
    public static SequentialEvent<Func<(string, Action?)>> HotkeyRequests { get; } = new(out hotkeyRequestsOwner);
    private static readonly SequentialEvent<Func<(string, Action?)>>.ISequentialEventOwner hotkeyRequestsOwner;

    internal static IEnumerable<(string, Action?)> GetHotkeyRequests() => hotkeyRequestsOwner.InvokeAndCollect();

    static ModEvents()
    {
        hotkeyRequestsOwner.OnSubscribersChanged += HotkeyActions.RefreshHotkeys;
    }
}
