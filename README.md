# Silksong.Benchwarp

This mod ports Hollow Knight's [Benchwarp mod](https://github.com/homothetyhk/HollowKnight.BenchwarpMod) to Hollow Knight: Silksong. Among its features, Benchwarp allows:
- Using the menu to set respawn to any bench.
- Using the menu to warp to the current respawn point.
- Using the menu to warp to a transition.

Benchwarp has various modes which can be selected in the config, or from the mod menu:
- StandardBenchwarp: Only warp to visited benches.
- WarpOnly: Only warp to the current respawn.
- UnlockAll: Warp to any bench.
- Doorwarp: Warp to any door transition.

In the menu, bench status is displayed as follows:
- Yellow: current respawn.
- White: previously visited.
- Red: unvisited.
- Purple: locked (only used in integrations with other mods).

## Dependencies

- Core Silksong modding libraries: DataManager, I18N, ModMenu.

## Features
### Hotkeys
Benchwarp supports hotkeys which can be used in place of menu buttons while the game is paused. All hotkeys consist of two sequential button presses. The presses do not need to be simultaneous. There are two types of hotkey commands:
1. Letter, followed by a number: selects a bench from the menu, and warps to it (or to current respawn, if the bench is not selectable). Labels for these hotkey combinations are displayed when hotkeys are enabled.
2. A pair of letters, which executes a special command, such as:
- **LB**: **L**ast **B**ench (equivalent to just clicking Warp).
- **SB**: **S**tart **B**ench (equivalent to clicking Set Start, then Warp).
- **DW**: **D**oor **W**arp (equivalent to selecting Door Warp as the menu mode). If used while Door Warp is enabled, switches the mode to Standard Benchwarp.
- **NP**: **N**ext **P**age (equivalent to clicking the pages button).

Tip: by default, some letters such as **A** are bound to actions that can cancel the menu. To enter the hotkeys including these letters, you can move the mouse to deselect the Resume button. Alternatively, you can input the hotkey by pressing the buttons nearly simultaneously.

### Deploy
- The deploy submenu can be found in the bottom-left portion of the screen, when the EnableDeploy config setting is active. This menu allows 
- The *Deploy* button places a bench or respawn marker at Hornet's current position. The deployed respawn will persist even if you exit the room or quit the game.
- The *Set* button sets the deployed respawn as Hornet's current respawn point. This can be used to warp back to the deployed respawn.
- The *Destroy* button destroys the deployed respawn. If Hornet's current respawn was the deployed respawn, her current respawn will be set to Start.
- The *Style* button opens a dropdown to select the deployed respawn type. Currently, the options are "Floor", for a respawn where Hornet gets up from the ground, and "Bone Bench", for the bench style used at the Bone Bottom and Mosshome Gate benches.
- Please read the next section regarding RecoveryMpde if you become unable to load a save due to a deployed respawn in an unsafe position.

## Compatibility
- If DebugMod's *NoClip* mode is enabled, Warping may cause Hornet to become immobile. This can be fixed by toggling *NoClip* again.
- If a save file ends up nonloadable (e.g. respawn is set to a nonexistent respawn point), activate RecoveryMode in the Benchwarp Config (or Mod Menu). While active, any existing save file loaded from the main menu will load into Tut_01 (Moss Grotto, the first room in the game). This allows you to save your game at a safe bench, after which you should deactivate RecoveryMode.

## Credits

- Huge special thanks to **Phenomenol** for leading the effort to clean transition data and handle obstacles for Doorwarp mode.
- Thanks to Flibber, Nerthul, and Annalythic for contributions to the transition data cleaning effort and to Posneg for contributions to obstacle handling.
- Special thanks to GamingInfinite (VoidBaroness) for bench research and UI design!


## License

Benchwarp is licensed under LGPL. Source code and license can be found at https://github.com/homothetyhk/Silksong.BenchwarpMod/.