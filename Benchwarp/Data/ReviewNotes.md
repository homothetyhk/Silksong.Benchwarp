- Place any review notes in here, using bullets to keep the document organized.

## Unresolved Notes

### Wormways
  - Crawl_02__left1: puts you behind wall if Crawl_03__right1 breakable wall isn't destroyed
  - Crawl_02__left2: puts you behind simple key door, which can't be interacted with from behind 
  - Crawl_02__right3: pushed out of bounds if breakable wall isn't destroyed
  - Crawl_03__right1: pushed out of bounds if breakable wall isn't destroyed

### Memorium
  - Arborium_01__left2: puts you behind glass if Arborium_09__right2 vines aren't destroyed
  - Arborium_01__right1: pushed out of bounds if Arborium_08__left1 shortcut isn't opened
  - Arborium_05__top1: pushed back through transition if coral isn't destroyed
  - Arborium_06__right1: black screen if coral in the middle of room isn't destroyed
  - Arborium_07__top1: closed vent door pushes you back through transition
  - Arborium_08__bot1: slight visual weirdness from being pushed through door
  - Arborium_08__left1: pushed out of bounds if shortcut isn't opened
  - Arborium_09__right2: black screen if vines in middle of room aren't destroyed
  - Arborium_11__right1: hornet hidden if breakable wall isn't destroyed

### Bilewater
  - Bellway_08: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
  - Shadow_04 missing a transition into the mist
  - Shadow_05[left1] and Dust_06[right1] put you behind a breakable wall and not visible. You can still break it though
  - Shadow_08[left1] and Shadow_27[right1] need lots of crap removed
    - _08 has breakable walls that need to be broken
    - _27 has a solid wall unless the b-wall in _08 is broken
  - Shadow_09[left3] puts you behind a breakable wall, you can break but you're invisible
  - Shadow_10[bot1] you're invisible unless a nearby b-wall is broken
  - Shadow_15[right2] is fine, but if you go further into the room there's a visual mask unless you've sat on the trap bench. Probably no action needed
  - Shadow_19[right2] is blocked off, I believe only opened by the Shakra quest
  - Shadow_22[topi] correctly maps to Library_07[boti] for i=1,2,3 but they're the same one-way drop transition
  - Shadow_Weavehome should be Weavenest Murglin titled area-wise

### High Halls
  - Hang_03[right2] and Hang_10[left1] are blocked unless the b-wall in _10 is broken
    - _03 puts you behind a gate
    - _10 puts you behind a b-wall and clipped into the floor
  - Walking into Hang_06_bank[left1] (when the simple key hasn't been used on the other side) crashed my game, not sure how reproducible this is. Doorwarping to Hang_06[door1] was fine.
  - Hang_07[left1] and Song_11[right2] are blocked unless the lever in Song_11 has been hit
  - Hang_07[top1] is blocked unless the lever in Hang_06[bot1] has been hit - doorwarping to Hang_06[bot1] was fine though.
  - Hang_08[right1] is blocked unless the sentinel quest has started (I believe) - this is a blocked wall, not the metal thingy (which goes away when you catch the clawline ring, and I believe is far enough away from the transition to be fine as-is)
  - Hang_08[right2] does not exist, and warping there puts you at a different transition. Its partner, Cog_11_Destroyed[left1], softlocks the game when you try to warp there.
  - Hang_16[door1] needs special handling in act 3 mode
  - Hang_01 and Hang_07 are in the Choral Chambers titled/map area

### Hunter's March
  - Ant_08 should be Halfway Home / Greymoor 
  - Ant_Queen should be Far Fields
  - Ant_19 titled area should be Chapel of the Beast
  - Note - Ant_20[door1] is fine, even if the chapel has been closed

The below areas have been checked when using the old door warp coroutine - many issues with softlocks/camera are likely already fixed with the new coroutine.

### Bone_Bottom
    - Aspid_01__bot1/bot3/bot4/bot5/bot6/bot7/bot8 (NOT bot2): big bot transition at several different positions.
    - Aspid_01__bot1: flip gives Aspid_01__top1 but should be Bonetown__top1.
    - Aspid_01__right3: collider obstacle.
    - Aspid_01__top1/top2/top3/top4/top5/top6/top7: big top transition at several different positions.
    - Bellway_01: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Bellway_01__left1: collider obstacle in Act 3.
    - Bonegrave__door1: Door closes if the corresponding crest was obtained. It doesn't matter how hornet enters the scene.
    - Bonegrave__left1: arrives via right1 instead if Steel Soul questline is not advanced enough. (possibly always arrives via right1 regardless of steel soul progress, this needs to be checked)
    - Bonegrave_right2: collider obstacle.
    - Bonetown__bot1_firstEntry: seems to be effectively the same as bot1. However, the flipped transition is Tut_03__top1_firstExit.
    - Bonetown__bot2: large dark vignette to the left of the transition is there if Chapel Maid isn't encountered.
    - Bonetown__door1: collider obstacle in Act 3.
    - Bonetown__left2: collider obstacle.
    - Bonetown__top1/top3/top4/top5/top6 (NOT bot2): big top transition at several different positions.

### The_Abyss
    - Abyss_02b__top1: collider obstacle.
    - Abyss_03__door1/door2: arrives via left2 instead of in front of the diving bell.
    - Abyss_03__left2: collider obstacle.
    - Abyss_11__bot1: collider obstacle.
    - Abyss_13__left1: collider obstacle.
    - Abyss_Cocoon__door_entry: visual glitch where player is on ground before falling from top.
    - Abyss_Cocoon__door_test: seems to be effectively the same as door_entry.
    - Room_Diving_Bell_Abyss__left1: collider obstacle.
    - Room_Diving_Bell_Abyss__left1: missing Abyss_03__door1 as flip target.
    - Room_Diving_Bell_Abyss_Fixed__left1: missing Abyss_03__door2 as flip target.

### Lost_Verdania
    - Clover_04b__door1: entire door/platform is missing.

### Underworks
    - Under_01: map/titled area should be Grand Gate.
    - Under_01__left2: collider obstacle.
    - Under_01__left3: collider obstacle.
    - Under_01b__right1: collider obstacle.
    - Under_02__left1: collider obstacle.
    - Under_04__right1: collider obstacle.
    - Under_04__top1: collider obstacle.
    - Under_05__left2: collider obstacle.
    - Under_06__top1: collider obstacle.
    - Under_07__top1: arrives via right1 instead.
    - Under_07b: map/titled area should be Choral Chambers.
    - Under_07b__bot1: collider obstacle.
    - Under_07c__bot1: arrives via left2 instead.
    - Under_07c__top1: collider obstacle.
    - Under_08__bot1: visual obstacle (hatch isn't open on entering scene).
    - Under_17__door1: door is locked if player hasn't opened it before.
    - Under_18__right1: collider obstacle.
    - Under_18__top2: collider obstacle.
    - Under_19c__left1: collider obstacle.
    - Under_20: titled area should be Chapel of the Architect.
    - Under_27: map/titled area should be Grand Gate.
    - Under_27__right2: collider obstacle.

### Mount_Fay
    - Bellway_Peak__right2: collider obstacle.
    - Peak_01__left1: abnormal camera.
    - Peak_01__top2/top3/top4: big top transition at several different positions.
    - Peak_04c__right2: collider obstacle.
    - Peak_05__right3: abnormal camera.
    - Peak_07__bot2: hornet glitches through terrain and softlocks the game.
    - Peak_07__bot3/bot4: big bot transition at two different positions.
    - Peak_07__bot5: hornet glitches through terrain.
    - Peak_08b__bot4: big bot transition.
    - Peak_08b__bot5: big bot transition, but hornet isn't visible.

### Putrified_Ducts
    - Aqueduct_01__left1: collider obstacle.
    - Aqueduct_02__left2: collider obstacle.
    - Aqueduct_02__right3: collider obstacle.
    - Aqueduct_04__bot1: screen is pitch-black (either collider or camera issue).
    - Aqueduct_05__door2: arrives at left1 instead if Fleatopia isn't there.
    - Aqueduct_08__left1: collider obstacle.
    - Bellway_Aqueduct: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.

### Far_Fields
    - Bellshrine_05: map/titled area should be Deep Docks.
    - Bellshrine_05__right1: collider obstacle.
    - Bellway_03: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Bone_East_01: map/titled area should be Deep Docks.
    - Bone_East_02__left1: collider obstacle.
    - Bone_East_03: map/titled area should be Deep Docks.
    - Bone_East_03__top1: collider obstacle.
    - Bone_East_04: map/titled area should be Deep Docks.
    - Bone_East_04__bot1: collider obstacle.
    - Bone_East_04__left1: collider obstacle.
    - Bone_East_04b: map/titled area should be Deep Docks.
    - Bone_East_04b__right1: collider obstacle.
    - Bone_East_04c: map/titled area should be Deep Docks.
    - Bone_East_05: map/titled area should be Deep Docks.
    - Bone_East_05__left1: collider obstacle.
    - Bone_East_07__top1: collider obstacle.
    - Bone_East_09__right2: potential visual obstacle.
    - Bone_East_09__top1: collider obstacle.
    - Bone_East_09b__bot1: collider obstacle.
    - Bone_East_10__door1: Door is closed when hornet enters the scene and the door mechanism hasn't been broken.
    - Bone_East_10__right1: collider obstacle.
    - Bone_East_10__right2: collider obstacle.
    - Bone_East_10_Church__left1: collider obstacle.
    - Bone_East_10_Room: titled area should be Pilgrim's Rest (?)
    - Bone_East_11__bot1: collider obstacle.
    - Bone_East_11__right1: collider obstacle.
    - Bone_East_11__top1: collider obstacle (forces hornet to enter the transition).
    - Bone_East_12: map/titled area should be Deep Docks.
    - Bone_East_12__bot1: visual obstacle (hatch isn't open when hornet enters scene).
    - Bone_East_13: map/titled area should be Deep Docks.
    - Bone_East_14__right2: collider obstacle.
    - Bone_East_16__right1: collider obstacle.
    - Bone_East_17b__left1: collider obstacle.
    - Bone_East_18c__left1: collider obstacle.

### Deep_Docks
    - Bellway_02: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Bellway_02__left1: collider obstacle.
    - Dock_01__right1: collider obstacle.
    - Dock_02__left1: collider obstacle.
    - Dock_03__bot1: visual obstacle (hatch isn't open when hornet enters scene).
    - Dock_03__right1: collider obstacle.
    - Dock_03b: map/titled area should be Far Fields.
    - Dock_03b__left1: collider obstacle.
    - Dock_03c__left2: collider obstacle.
    - Dock_03c__top1: collider obstacle.
    - Dock_03c__top2: collider obstacle.
    - Dock_03d__bot1: visual obstacle (hatch isn't open when hornet enters scene).
    - Dock_11__right1: collider obstacle.
    - Dock_12__door1: arrives at left1 instead if Diving Bell isn't unlocked.
    - Dock_15__left2: collider obstacle.
    - Room_Forge__right1: collider obstacle (simple key door).
    - Room_Forge__top1: collider obstacle.

### Moss_Grotto
    - Tut_01__left1: collider obstacle.
    - Tut_01__left3: collider obstacle.
    - Tut_01__top1: hornet is stuck above the visible area, if the sequence of Hornet passing out when reaching Bone Bottom is not triggered.
    - Tut_02: credits appear for a split second on the bottom right when entering the scene.
    - Tut_03: titled area should be Ruined Chapel.
    - Tut_03__door1: corresponds to the "Ascend" prompt.
    - Tut_03__door1_firstExit: appears to behave the same as door1. However, the flipped transition is Bonetown__bot1_firstEntry.
    - Tut_03__door2: Should arrive at the door to the Chapel, but arrives at top1 regardless of whether if in Act 3 or not. Also need to handle door being closed when not Act 3.
    - Tut_04: titled area should be Ruined Chapel.
    - Tut_05: titled area should be Ruined Chapel.

### Greymoor
    - Bellshrine_02__left1: collider obstacle.
    - Bellway_04: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Greymoor_01__bot1: collider obstacle.
    - Greymoor_01__right2: collider obstacle (lever).
    - Greymoor_02__right2: collider obstacle.
    - Greymoor_03__left3: collider obstacle.
    - Greymoor_03__right5: collider obstacle.
    - Greymoor_06__top1: may need to handle availability of top1 entry in a unique way (dependent on act 1/2 and 3?).
    - Greymoor_08__door1: arrives at right1 instead if flea caravan isn't in scene.
    - Greymoor_08__door2: arrives at right1 instead if flea caravan isn't in scene.
    - Greymoor_15b__right1: collider obstacle.
    - Greymoor_17__top1: strange visual bug with the camera.
    - Greymoor_20b__door1: Door closes if the corresponding crest was obtained. It doesn't matter how hornet enters the scene.
    - Greymoor_20b__right1: same thing happens with the door from here.
    - Greymoor_20c: titled area should be Chapel of the Reaper.
    - Room_CrowCourt__bot1: collider obstacle.

### Unknown
    - Memory_Needolin: map/titled area should be Bellhart.
    - Memory_Needolin__right1: abnormal camera.
    - Memory_Red: map area should be Mosslands and titled area should be Ruined Chapel.
    - Memory_Red: multiple door names in the UI look the same.
    - Memory_Red__door_enterRedMemory_Beast: background graphics missing.
    - Memory_Red__door_enterRedMemory_Hive: background graphics missing.
    - Memory_Red__door_enterRedMemory_Hive: background graphics missing.
    - Memory_Red__door_wakeInRedMemory_Beast: visual glitch with hornet appearing for a split second before cutscene.
    - Memory_Red__door_wakeInRedMemory_Hive: visual glitch with hornet appearing for a split second before cutscene.
    - Memory_Red__door_wakeInRedMemory_Weaver: visual glitch with hornet appearing for a split second before cutscene.
    - Room_Caravan_Interior__right1: map/titled area should be Greymoor.
    - Room_Caravan_Spa__left1: map/titled area and flipped transition would depend on current position of flea caravan.

### Exhaust_Organ

### Halfway_Home
    - Halfway_01__bot1: If the vintage nectar gauntlet hasn't been completed, the hatch will appear and stay open. If the vintage nectar gauntlet was previously cleared, the hatch closes off and the conversation with Creige happens every time.
    - Halfway_01__right1: collider obstacle.

### Grand_Gate
    - Coral_10__left1: collider obstacle.
    - Coral_10__right1: collider obstacle.

### Nameless_Town

### The_Mist
    - Dust_Maze_08_completed__right1: collider obstacle.

### Chapel_of_the_Wanderer
    - Name is cut off in the area selection UI.

### Coral_Tower

### First_Shrine

### Voltnest

### Blasted_Steps
    - Bellway_08: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Coral_03__bot1/bot2/bot3/bot4/bot5/bot6: big bot transition at several different positions.
    - Coral_12__right1: collider obstacle.
    - Coral_19__bot1/bot2/bot3/bot4/bot5/bot6/bot7: big bot transition at several different positions.
    - Coral_19__top3/top4/top5/top6/top7/top8: big top transition at several different positions.
    - Coral_35__right2: collider obstacle.
    - Coral_35__top1: collider obstacle.
    - Coral_Judge_Arena__door2: arrives at right1 instead if flea caravan isn't in scene.
    - Coral_Judge_Arena__right1: collider obstacle.

### Mosshome
    - Mosstown_01__bot1: collider obstacle.
    - Mosstown_02__left1: collider obstacle.
    - Mosstown_03: map/titled area should be Shellwood.
    - Mosstown_03__right1: collider obstacle.
    - Mosstown_03__top1: collider obstacle.

### Wisp_Thicket
    - Wisp_02__top1: collider obstacle.
    - Wisp_03: titled area should be Greymoor.
    - Wisp_03__door1: door closes behind Hornet. Keep it open as a transition fix?
    - Wisp_03__top1: collider obstacle.
    - Wisp_05__left1: collider obstacle.
    - Wisp_06: titled area should be Greymoor.

### Weavenest_Atla
    - Weave_02__right3: collider obstacle.

### The_Cradle
    - Cradle_02__left2: collider obstacle.
    - Tube_Hub: in Act 3 only, all three transition gates are blocked.

### Bellhart
    - Belltown__door3/door4/door5: Spawns hornet in the middle of the scene. Not sure if this always happens or it depends on saving the town/Act 3 or a combination of both.
    - Belltown_04__left2: collider obstacle.
    - Belltown_basement: game softlocks if door warping to this scene during Act 3 if bell beast fast travel isn't unlocked.
    - Belltown_Room_doctor: map/titled area should be Greymoor.
    - Belltown_Room_fisher: this room doesn't seem to exist. Attempting to door warp here softlocks the game.
    - Belltown_Room_shellwood: map/titled area should be Shellwood.

The below areas have been checked when using the new door warp coroutine.

### Cogwork_Core
    - Cog_06__right1: collider obstacle.
    - Cog_Dancers__bot1: collider obstacle, only when not in Act 3.
    - Cog_Dancers__bot2: collider obstacle, only when not in Act 3.
    - Cog_Dancers__top1: collider obstacle. Different objects in Act 3.
    - Cog_11_Destroyed__left1: attempting to door warp here softlocks the game, regardless of Act 3 or not. The scene probably doesn't exist.

### Sinner's_Road
    - Dust_02__right1: collider obstacle.
    - Dust_04__left1: collider obstacle.
    - Dust_04__right1: collider obstacle.
    - Dust_05__right1: collider obstacle (lever).
    - Dust_06__left1: collider obstacle.
    - Dust_06__right1: collider obstacle.
    - Dust_09: map/titled area should be Bilewater.
    - Dust_Chef__left1: collider obstacle (lever).

### Whispering_Vaults
    - Library_01__left3: collider obstacle.
    - Library_03: map/titled area for LEFT SIDE corresponds to Choral Chambers, and RIGHT SIDE is Whispering Vaults.
    - Library_04__right1: collider obstacle.
    - Library_04__top1: collider obstacle.
    - Library_07__bot1/bot2/bot3: big bot transition at three different points.
    - Library_07__top1: obstacles on floor on entry. Keep or remove?
    - Library_11: map/titled area should be Underworks.
    - Library_11__left3: collider obstacle.
    - Library_11b: map/titled area should be Underworks.
    - Library_11b__right1: collider obstacle.
    - Library_12: map/titled area should be Underworks.
    - Library_12__right1: collider obstacle.
    - Library_12b: map/titled area should be Underworks.

### Shellwood
    - Bellshrine_03__right1: collider obstacle.
    - Shellwood_01__left2: collider obstacle.
    - Shellwood_01__right1: collider obstacle.
    - Shellwood_01b__right3: collider obstacle.
    - Shellwood_02__right2: collider obstacle.
    - Shellwood_03__bot1: collider obstacle.
    - Shellwood_04b__left1: collider obstacle.
    - Shellwood_08c__right1: collider obstacle.
    - Shellwood_11: map/titled area should be Grand Gate.
    - Shellwood_13__right1: collider obstacle.
    - Shellwood_15__left1: collider obstacle.
    - Shellwood_19__left1: collider obstacle.
    - Shellwood_22: map/titled area should be Grand Gate.
    - Shellwood_25__door1: game saves and door closes on entry.
    - Shellwood_25__left1: collider obstacle.
    - Shellwood_25b: titled area should be Chapel of the Witch.

### The_Slab
    - Slab_02__left1: collider obstacle.
    - Slab_03__left6: collider obstacle.
    - Slab_03__right1: collider obstacle.
    - Slab_03__right2: collider obstacle.
    - Slab_03__right5: collider obstacle.
    - Slab_03__right7: collider obstacle.
    - Slab_03__right9: collider obstacle.
    - Slab_04__door1: arrives at right1 instead. The transition gate doesn't seem to exist.
    - Slab_05__right1: collider obstacle.
    - Slab_06__door1: arrives at top1 instead. The transition gate doesn't seem to exist.
    - Slab_10c__door1: collider obstacle (door locked by numerous chains).
    - Slab_15__top1: visual obstacle (secret area behind breakable wall on right side of room).
    - Slab_16__door1: arrives at bot1 instead. Existence of door1 seems to depend on Broodmother quest (should be checked).
    - Slab_18__left1: collider obstacle.
    - Slab_21__left1: collider obstacle.
    - Slab_23__right1: collider obstacle. Gate is shut and the arena starts.
    - Slab_Cell_Quiet__left1: when flipped, it should be Slab_23__door2, not Slab_04__door1.

### The_Marrow
    - Bellshrine__right1: collider obstacle.
    - Bone_01__right1: collider obstacle.
    - Bone_01__top2_extra: corresponds to the left side of the same top transition as top2. Never normally enters via this transition.
    - Bone_01b: map area should be Mosslands and titled area should be Bone Bottom.
    - Bone_01b__left1: collider obstacle.
    - Bone_03__left1: collider obstacle.
    - Bone_05b: map area should be Mosslands and titled area should be Bone Bottom.
    - Bone_06__left1: collider obstacle.
    - Bone_10__door2: Not Act 3: arrives in the correct position, but the door/spa caravan is only there if the first flea quest hasn't been completed and Kratt is saved. Act 3: arrives by bot1 instead.
    - Bone_11: map area should be Mosslands and titled area should be Bone Bottom.
    - Bone_11__bot1: collider obstacle.
    - Bone_11__top1: collider obstacle.
    - Bone_11b: map area should be Mosslands and titled area should be Bone Bottom.
    - Bone_11b__top1: collider obstacle.
    - Bone_16__top1: collider obstacle (hidden area behind breakable wall to the left).
    - Bone_Steel_Servant: map area should be Mosslands and titled area should be Bone Bottom.

### Choral_Chambers
    - Song_01__bot1: collider obstacle.
    - Song_01c__left1: collider obstacle.
    - Song_01c: map/titled area should be Grand Gate.
    - Song_01c__top1: collider obstacle.
    - Song_03__top1: collider obstacle.
    - Song_04__bot1: gate animation doesn't trigger on entering scene.
    - Song_05__right4: collider obstacle.
    - Song_10__right1: collider obstacle (entire spa room revealed from breaking wall to the left). Also the lever gate at the transition itself.
    - Song_11__left4: collider obstacle.
    - Song_11__right2: collider obstacle.
    - Song_19_entrance: map/titled area should be Grand Gate.
    - Song_19_entrance__left1: collider obstacle.
    - Song_19_entrance__right1: collider obstacle.
    - Song_20__right_cutsceneEntry: functionally the same as right6, but with a short cutscene.
    - Song_25__top1: collider obstacle.
    - Song_25__top2: In Act 3 the sequence of Hornet being weak happens if not previously triggered.
    - Song_27__left1: collider obstacle.
    - Song_Enclave__bot1: collider obstacle.
    - Song_Enclave__door1: In Act 3, arrives by left2 instead. 
    - Song_Tower_01__right1: collider obstacle. Lace fight immediately starts.
    - Song_Tower_Destroyed: map/titled area should be The Cradle.
    - Song_Tower_Destroyed__bot1: breaking animation of object plays, but ideally the object should not be there at all on entry.

### Whiteward
    - Ward_01__right2: Collider obstacle.
    - Ward_02__bot1: Works fine. Note-worthy: Unravelled can't be fought coming from here.
    - Ward_03__door1: Door1 is not recognized - warps to bot1 instead.
    - Ward_06__bot1: Automatically flings you into a hazard with invincibility. Funny softlock.
    - Ward_09__left1: Leads to Ward_03__bot1 instead of the door if it hasn't been unlocked.

### Sands of Karak
    - Coral_23__left1/left2: Camera shows partial black screen.
    - Coral_24__right1: Collider obstacle.
    - Coral_26__right1: Collider obstacle.
    - Coral_35b__bot1: One-way wall from Coral_35 - warping is possible but can't enter the transition.
    - Coral_35b__left5: Collider obstacle.
    - Coral_38__right1: Collider obstacle - bypassable by taking damage.

### Doors with missing targets
    The following was all done from a fresh save state.

    - Ant_19__door_memoryEnd: Gives the player Beast Crest and saves the game. The HUD isn't correct (doesn't show Beast Crest flair), but the crest is active and also appears in inventory. The screen is black if you already have Beast Crest.
    - Ant_Queen__door_wakeOnGround: the game saves.
    - Aqueduct_05__door_caravanTravelEnd: Arrives at left1 instead, because the door is in the "caravan" additive scene.
    - Arborium_Tube__door_tubeEnter, and every other Ventrica arrival: Visual bug where the pedestal before buying the Ventrica overlaps with the arriving elevator.
    - Belltown_basement__door_fastTravelExit, and every other Bell Beast arrival: Instead of the animation of Hornet leaping out of the bells, she appears in front of the pedestal.
    - Belltown_Shrine__door_wakeOnGround: the game saves.
    - Bone_05__door_cinematicEnd: Hornet is stuck on the ground and cannot get up.
    - Bone_East_08__door_cinematicEnd: Hornet instantly takes damage in lava and hazard respawns.
    - Chapel_Wanderer__door_memoryEnd: Gives the player Wanderer's Crest and saves the game. The HUD isn't correct (doesn't show Wanderer's Crest flair), but the crest is active and also appears in inventory. The screen is black if the player already have Wanderer's Crest.
    - Clover_01__door_wakeOnGround: Immediately enters conversation with Green Prince if not already triggered. Enters a funny state where Hornet can move during conversation. The game saves.
    - Cog_Dancers__door_arriveFromTower: black screen.
    - Coral_10__left_firstEntrance: Collider obstacle.
    - Coral_Judge_Arena__door_caravanTravelEnd: Hornet appears in the middle of the room and cannot move.
    - Coral_Tower_01__door_wakeOnGround: the game saves.
    - Greymoor_08__door_caravanTravelEnd: arrives via right1 instead, because the door is in the "caravan" additive scene.
    - Greymoor_20c__door_memoryEnd: Gives the player Reaper Crest and saves the game. The HUD isn't correct (doesn't show Reaper Crest flair), but the crest is active and also appears in inventory. The screen is black if the player already has Reaper Crest.
    - Last_Dive__door_cutscenePosition: cutscene plays and player arrives in Abyss_Cocoon, as per normal.
    - Last_Dive_Return__door_cutscenePosition: cutscene plays and player arrives in Abyss_Cocoon, as per normal.
    - Memory_Red__door_wakeInRedMemory_Root: plays a cutscene, gives the player Everbloom and arrives in Tut_04 like usual.
    - Memory_Red__top1: saves the game. If already entered Red Memory previously, the game softlocks with Hornet unable to get up.
    - Shellwood_11b__door_wakeOnGround: the game saves.
    - Shellwood_25b__door_curseSequenceEnd: Gives the player the cursed Crest and saves the game.
    - Slab_03__door_slabCaged: Hornet appears in the cage as per getting captured normally, but isn't naked when broken out of the cage. The game then saves. The screen is black if the cage sequence was already triggered before.
    - Slab_10b__door_wakeOnGround: The game saves.
    - Song_Enclave__door_act3_wakeUp: Hornet talks with an invisible Sherma, then quest progress is advanced and the game is saved.
    - Song_Tower_01__door_cinematicEnd: Hornet wakes up in the middle of the Lace fight, quest progress is advanced and the game is saved. Game seems to softlock if you die in the scene under certain conditions.
    - Song_Tower_01__door_cutsceneEndLaceTower: Plays cutscene (first time only) and enters Lace fight.
    - Tut_04__door_memoryEnd: Gives and equips the Shaman crest, then saves the game. The screen is black if the player already has Shaman Crest.
    - Tut_04__door_ritualEnd: Arrives at right1 instead.
    - Tut_05__door_memoryEnd: Gives and equips the Shaman crest, then saves the game. The screen is black. The HUD isn't correct (doesn't show Reaper Crest flair), but the crest is active and also appears in inventory.
    - Under_20__door_memoryEnd: Gives the player Architect Crest and saves the game. The HUD isn't correct (doesn't show Architect Crest flair), but the crest is active and also appears in inventory. The screen is black if the player already has Architect Crest.
    - Ward_02__door_cinematicEnd: Hornet never gets up

## Resolved Notes

### Wormways
    - Crawl_09__left1: black screen if breakable wall in middle of room isn't destroyed
