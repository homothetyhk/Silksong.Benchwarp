- Place any review notes in here, using bullets to keep the document organized.

- Wormways
  - Crawl_02__left1: puts you behind wall if Crawl_03__right1 breakable wall isn't destroyed
  - Crawl_02__left2: puts you behind simple key door, which can't be interacted with from behind 
  - Crawl_02__right3: pushed out of bounds if breakable wall isn't destroyed
  - Crawl_03__right1: pushed out of bounds if breakable wall isn't destroyed
  - Crawl_09__left1: black screen if breakable wall in middle of room isn't destroyed

- Memorium
  - Arborium_01__left2: puts you behind glass if Arborium_09__right2 vines aren't destroyed
  - Arborium_01__right1: pushed out of bounds if Arborium_08__left1 shortcut isn't opened
  - Arborium_05__top1: pushed back through transition if coral isn't destroyed
  - Arborium_06__right1: black screen if coral in the middle of room isn't destroyed
  - Arborium_07__top1: closed vent door pushes you back through transition
  - Arborium_08__bot1: slight visual weirdness from being pushed through door
  - Arborium_08__left1: pushed out of bounds if shortcut isn't opened
  - Arborium_09__right2: black screen if vines in middle of room aren't destroyed
  - Arborium_11__right1: hornet hidden if breakable wall isn't destroyed

- Bilewater
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

### Bone_Bottom
    - Aspid_01__bot1/bot3/bot4/bot5/bot6/bot7/bot8 (NOT bot2): big bot transition at several different positions.
    - Aspid_01__bot1: flip gives Aspid_01__top1 but should be Bonetown__top1.
    - Aspid_01__right3: collider obstacle.
    - Aspid_01__top1/top2/top3/top4/top5/top6/top7: big top transition at several different positions.
    - Bonegrave__door1: visual obstacle (closed after getting Wanderer's Crest).
    - Bonegrave__left1: arrives via right1 instead if Steel Soul questline is not advanced enough.
    - Bonegrave_right2: collider obstacle.
    - Bonetown__bot1_firstEntry: seems to be effectively the same as bot1.
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
