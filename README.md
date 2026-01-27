# Silksong.Benchwarp

Work-in-progress port of Hollow Knight's [Benchwarp mod](https://github.com/homothetyhk/HollowKnight.BenchwarpMod) to Hollow Knight: Silksong.

## Dependencies

- AutoHookGenPatcher, available on Thunderstore.
- ConfigurationManager, available on Thunderstore.

## Features
### Hotkeys
Benchwarp supports hotkeys which can be used in place of menu buttons while the game is paused. All hotkeys consist of two sequential button presses. The presses do not need to be simultaneous. There are two types of hotkey commands:
1. Letter, followed by a number: selects a bench from the menu, and warps to it (or to current respawn, if the bench is not selectable). Labels for these hotkey combinations are displayed when hotkeys are enabled.
2. A pair of letters, which executes a special command, such as:
- **LB**: **L**ast **B**ench (equivalent to just clicking Warp).
- **SB**: **S**tart **B**ench (equivalent to clicking Set Start, then Warp).
- **DW**: **D**oor **W**arp (equivalent to selecting Door Warp as the menu mode). If used while Door Warp is enabled, switches the mode to Standard Benchwarp.
- **WD**: Warp to the currently selected door.
- **DF**: Flip between the linked door pair.
- **DL**: Select the door you most recently entered.
- **DA/DR/DD**: Toggle the Area, Room, or Door dropdowns while in Door Warp mode.
- **NP**: **N**ext **P**age (equivalent to clicking the pages button).

When the Door Warp menu mode is active, letter+number combinations operate the door selector dropdowns instead of bench lists. The letter picks a column (A is the leftmost column on the dropdown grid) and the number picks the row, letting you navigate areas, rooms, and doors without the mouse.

Tip: by default, some letters such as **A** are bound to actions that can cancel the menu. To enter the hotkeys including these letters, you can move the mouse to deselect the Resume button. Alternatively, you can input the hotkey by pressing the buttons nearly simultaneously.

## Credits

- Special thanks: GamingInfinite (VoidBaroness) for bench research and UI design!

## License

Benchwarp is licensed under LGPL. Source code and license can be found at https://github.com/homothetyhk/Silksong.BenchwarpMod/.
