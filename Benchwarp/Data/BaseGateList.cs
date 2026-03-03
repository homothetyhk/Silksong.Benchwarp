using static Benchwarp.Data.SceneNames;
using static Benchwarp.Data.PrimitiveGateNames;
using Benchwarp.Doors;
using Benchwarp.Doors.Obstacles;
using UnityEngine;
using TeamCherry.NestedFadeGroup;
using GlobalEnums;

namespace Benchwarp.Data;

public static class BaseGateList
{
    public static DoorData Abandoned_town__bot1 { get; } = new(new(Abandoned_town, bot1), new(Cradle_Destroyed_Challenge_01, top1));
    public static DoorData Abandoned_town__door1 { get; } = new(new(Abandoned_town, door1), new(Cradle_Destroyed_Challenge_Bench, door1));
    public static DoorData Abyss_01__left1 { get; } = new(new(Abyss_01, left1), new(Abyss_06, right1));
    public static DoorData Abyss_01__right2 { get; } = new(new(Abyss_01, right2), new(Abyss_02b, left2));
    public static DoorData Abyss_01__right3 { get; } = new(new(Abyss_01, right3), new(Abyss_04, left1));
    public static DoorData Abyss_01__right4 { get; } = new(new(Abyss_01, right4), new(Abyss_07, left1));
    public static DoorData Abyss_02__left1 { get; } = new(new(Abyss_02, left1), new(Abyss_02b, right1));
    public static DoorData Abyss_02__right1 { get; } = new(new(Abyss_02, right1), new(Abyss_03, left1));
    public static DoorData Abyss_02b__left2 { get; } = new(new(Abyss_02b, left2), new(Abyss_01, right2));
    public static DoorData Abyss_02b__right1 { get; } = new(new(Abyss_02b, right1), new(Abyss_02, left1));
    public static DoorData Abyss_02b__top1 { get; } = new(new(Abyss_02b, top1), new(Abyss_11, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("top_blocker_set", ObstacleType.OneWayBreakableExit, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(Abyss_11, "Abyss_Collapse_Wall_bot"))
        ])
    };
    public static DoorData Abyss_03__door1 { get; } = new(new(Abyss_03, door1), new(Room_Diving_Bell_Abyss, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Diving Bell States", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.InterruptsEntry | ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Abyss_03__door2 { get; } = new(new(Abyss_03, door2), new(Room_Diving_Bell_Abyss_Fixed, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Diving Bell States", true, ObstacleType.ClosedAfterProgression, ObstacleSeverity.InterruptsEntry),
            new TestObjObstacleInfo("Diving Bell States/Gone", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.InterruptsEntry)
        ])
    };
    public static DoorData Abyss_03__left1 { get; } = new(new(Abyss_03, left1), new(Abyss_02, right1));
    public static DoorData Abyss_03__left2 { get; } = new(new(Abyss_03, left2), new(Abyss_13, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Shaman_Collapse_Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Abyss_04__left1 { get; } = new(new(Abyss_04, left1), new(Abyss_01, right3));
    public static DoorData Abyss_05__left2 { get; } = new(new(Abyss_05, left2), new(Abyss_12, right2));
    public static DoorData Abyss_05__right1 { get; } = new(new(Abyss_05, right1), new(Abyss_08, left1));
    public static DoorData Abyss_06__right1 { get; } = new(new(Abyss_06, right1), new(Abyss_01, left1));
    public static DoorData Abyss_07__left1 { get; } = new(new(Abyss_07, left1), new(Abyss_01, right4));
    public static DoorData Abyss_07__right1 { get; } = new(new(Abyss_07, right1), new(Abyss_12, left1));
    public static DoorData Abyss_08__left1 { get; } = new(new(Abyss_08, left1), new(Abyss_05, right1));
    public static DoorData Abyss_09__bot1 { get; } = new(new(Abyss_09, bot1), new(Abyss_13, top1));
    public static DoorData Abyss_09__top1 { get; } = new(new(Abyss_09, top1), new(Dock_06_Church, bot1));
    public static DoorData Abyss_11__bot1 { get; } = new(new(Abyss_11, bot1), new(Abyss_02b, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Abyss_Collapse_Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Abyss_Collapse_Wall_bot"))
        ])
    };
    public static DoorData Abyss_11__right1 { get; } = new(new(Abyss_11, right1), new(Abyss_13, left1));
    public static DoorData Abyss_12__left1 { get; } = new(new(Abyss_12, left1), new(Abyss_07, right1));
    public static DoorData Abyss_12__right2 { get; } = new(new(Abyss_12, right2), new(Abyss_05, left2));
    public static DoorData Abyss_13__left1 { get; } = new(new(Abyss_13, left1), new(Abyss_11, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Abyss_Collapse_Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Abyss_13__right1 { get; } = new(new(Abyss_13, right1), new(Abyss_03, left2));
    public static DoorData Abyss_13__top1 { get; } = new(new(Abyss_13, top1), new(Abyss_09, bot1));
    public static DoorData Abyss_Cocoon__door_entry { get; } = new(new(Abyss_Cocoon, door_entry));
    // public static DoorData Abyss_Cocoon__door_test { get; } = new(new(Abyss_Cocoon, door_test), new(Abyss_Cocoon, door_entry), null);
    public static DoorData Ant_02__left1 { get; } = new(new(Ant_02, left1), new(Bone_08, right3));
    public static DoorData Ant_02__right1 { get; } = new(new(Ant_02, right1), new(Ant_03, left2));
    public static DoorData Ant_03__left2 { get; } = new(new(Ant_03, left2), new(Ant_02, right1));
    public static DoorData Ant_03__right3 { get; } = new(new(Ant_03, right3), new(Ant_04_left, left1));
    public static DoorData Ant_04__left1 { get; } = new(new(Ant_04, left1), new(Ant_04_mid, right1));
    public static DoorData Ant_04__right1 { get; } = new(new(Ant_04, right1), new(Ant_14, left3));
    public static DoorData Ant_04_left__left1 { get; } = new(new(Ant_04_left, left1), new(Ant_03, right3));
    public static DoorData Ant_04_left__right1 { get; } = new(new(Ant_04_left, right1), new(Ant_04_mid, left1));
    public static DoorData Ant_04_mid__left1 { get; } = new(new(Ant_04_mid, left1), new(Ant_04_left, right1));
    public static DoorData Ant_04_mid__right1 { get; } = new(new(Ant_04_mid, right1), new(Ant_04, left1));
    public static DoorData Ant_05b__bot1 { get; } = new(new(Ant_05b, bot1), new(Bone_East_04b, top1));
    public static DoorData Ant_05b__bot2 { get; } = new(new(Ant_05b, bot2), new(Bone_East_04, top2));
    public static DoorData Ant_05b__right1 { get; } = new(new(Ant_05b, right1), new(Ant_14, left4));
    public static DoorData Ant_05c__left1 { get; } = new(new(Ant_05c, left1), new(Ant_14, right2));
    public static DoorData Ant_05c__right1 { get; } = new(new(Ant_05c, right1), new(Ant_09, left1));
    public static DoorData Ant_08__top1 { get; } = new(new(Ant_08, top1), new(Halfway_01, bot1));
    public static DoorData Ant_09__left1 { get; } = new(new(Ant_09, left1), new(Ant_05c, right1));
    public static DoorData Ant_09__right1 { get; } = new(new(Ant_09, right1), new(Bone_East_11, left1));
    public static DoorData Ant_14__left1 { get; } = new(new(Ant_14, left1), new(Ant_Merchant, right1));
    public static DoorData Ant_14__left2 { get; } = new(new(Ant_14, left2), new(Ant_17, right1));
    public static DoorData Ant_14__left3 { get; } = new(new(Ant_14, left3), new(Ant_04, right1));
    public static DoorData Ant_14__left4 { get; } = new(new(Ant_14, left4), new(Ant_05b, right1));
    public static DoorData Ant_14__left5 { get; } = new(new(Ant_14, left5), new(Ant_21, right1));
    public static DoorData Ant_14__right2 { get; } = new(new(Ant_14, right2), new(Ant_05c, left1));
    public static DoorData Ant_14__right3 { get; } = new(new(Ant_14, right3), new(Ant_20, left1));
    public static DoorData Ant_17__right1 { get; } = new(new(Ant_17, right1), new(Ant_14, left2));
    public static DoorData Ant_19__door_memoryEnd { get; } = new(new(Ant_19, door_memoryEnd));
    public static DoorData Ant_19__left1 { get; } = new(new(Ant_19, left1), new(Ant_20, door1));
    public static DoorData Ant_20__door1 { get; } = new(new(Ant_20, door1), new(Ant_19, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayMakerFSM>("Chapel Door Control", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.ModifiesSaveData | ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Chapel Door Control/door1", true, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new GameObjectActiveObstacleInfo("Chapel Door Control/Door Open", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Ant_20__left1 { get; } = new(new(Ant_20, left1), new(Ant_14, right3));
    public static DoorData Ant_21__right1 { get; } = new(new(Ant_21, right1), new(Ant_14, left5));
    public static DoorData Ant_Merchant__right1 { get; } = new(new(Ant_Merchant, right1), new(Ant_14, left1));
    public static DoorData Ant_Queen__door_wakeOnGround { get; } = new(new(Ant_Queen, door_wakeOnGround));
    public static DoorData Ant_Queen__left1 { get; } = new(new(Ant_Queen, left1), new(Bone_East_25, door1));
    public static DoorData Aqueduct_01__left1 { get; } = new(new(Aqueduct_01, left1), new(Arborium_11, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall Aqueduct Start", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Camera Locks", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Aqueduct_01__right1 { get; } = new(new(Aqueduct_01, right1), new(Aqueduct_02, left1));
    public static DoorData Aqueduct_02__left1 { get; } = new(new(Aqueduct_02, left1), new(Aqueduct_01, right1));
    public static DoorData Aqueduct_02__left2 { get; } = new(new(Aqueduct_02, left2), new(Aqueduct_04, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Aqueduct_02__left3 { get; } = new(new(Aqueduct_02, left3), new(Aqueduct_07, right1));
    public static DoorData Aqueduct_02__right1 { get; } = new(new(Aqueduct_02, right1), new(Aqueduct_03, left1));
    public static DoorData Aqueduct_02__right2 { get; } = new(new(Aqueduct_02, right2), new(Bellway_Aqueduct, left1));
    public static DoorData Aqueduct_02__right3 { get; } = new(new(Aqueduct_02, right3), new(Aqueduct_08, left1))
    {
        Obstacles = new([
            // Disabling PersistentBoolItemResponder doesn't work because it subscribes to PersistentBoolItem's hook
            new BehaviourObstacleInfo<PersistentBoolItem>("right_break_gate", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Aqueduct_08, ID: "Breakable Wall_Silhouette")),
            new GameObjectActiveObstacleInfo("right_break_gate/Closed", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
            new GameObjectActiveObstacleInfo("right_break_gate/Open", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Aqueduct_03__left1 { get; } = new(new(Aqueduct_03, left1), new(Aqueduct_02, right1));
    public static DoorData Aqueduct_03__right1 { get; } = new(new(Aqueduct_03, right1), new(Aqueduct_05, left1));
    public static DoorData Aqueduct_03__top1 { get; } = new(new(Aqueduct_03, top1), new(Aqueduct_06, bot1));
    public static DoorData Aqueduct_04__bot1 { get; } = new(new(Aqueduct_04, bot1), new(Shadow_01, top1));
    public static DoorData Aqueduct_04__door1 { get; } = new(new(Aqueduct_04, door1), new(Room_Huntress, left1));
    public static DoorData Aqueduct_04__right1 { get; } = new(new(Aqueduct_04, right1), new(Aqueduct_02, left2));
    public static DoorData Aqueduct_05__door_caravanTravelEnd { get; } = new(new(Aqueduct_05, door_caravanTravelEnd));
    public static DoorData Aqueduct_05__door2 { get; } = new(new(Aqueduct_05, door2), new(Room_Caravan_Spa, left1), null);
    public static DoorData Aqueduct_05__left1 { get; } = new(new(Aqueduct_05, left1), new(Aqueduct_03, right1));
    public static DoorData Aqueduct_06__bot1 { get; } = new(new(Aqueduct_06, bot1), new(Aqueduct_03, top1));
    public static DoorData Aqueduct_06__left1 { get; } = new(new(Aqueduct_06, left1), new(Bellway_Aqueduct, right1));
    public static DoorData Aqueduct_06__left2 { get; } = new(new(Aqueduct_06, left2), new(Aqueduct_08, right1));
    public static DoorData Aqueduct_07__right1 { get; } = new(new(Aqueduct_07, right1), new(Aqueduct_02, left3));
    public static DoorData Aqueduct_08__left1 { get; } = new(new(Aqueduct_08, left1), new(Aqueduct_02, right3))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall_Silhouette", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility)
        ])
    };
    public static DoorData Aqueduct_08__right1 { get; } = new(new(Aqueduct_08, right1), new(Aqueduct_06, left2));
    public static DoorData Arborium_01__bot1 { get; } = new(new(Arborium_01, bot1), new(Song_25, top1));
    public static DoorData Arborium_01__left1 { get; } = new(new(Arborium_01, left1), new(Arborium_09, right1));
    public static DoorData Arborium_01__left2 { get; } = new(new(Arborium_01, left2), new(Arborium_09, right2))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayerDataTestResponse>("Arborium 09 Break Wall", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess),
            new GameObjectActiveObstacleInfo("Arborium 09 Break Wall/Unbroken", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess),
            new GameObjectActiveObstacleInfo("Arborium 09 Break Wall/Broken", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Arborium_01__left3 { get; } = new(new(Arborium_01, left3), new(Arborium_Tube, right1));
    public static DoorData Arborium_01__right1 { get; } = new(new(Arborium_01, right1), new(Arborium_08, left1))
    {
        Obstacles = new([
            new ObstacleInfo("one_way_inner_craw", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.arborium_08_oneWay)))
        ])
    };
    public static DoorData Arborium_01__right2 { get; } = new(new(Arborium_01, right2), new(Arborium_07, left1));
    public static DoorData Arborium_01__right3 { get; } = new(new(Arborium_01, right3), new(Arborium_06, left1));
    public static DoorData Arborium_01__right4 { get; } = new(new(Arborium_01, right4), new(Arborium_02, left1));
    public static DoorData Arborium_01__right5 { get; } = new(new(Arborium_01, right5), new(Arborium_04, left1));
    public static DoorData Arborium_02__left1 { get; } = new(new(Arborium_02, left1), new(Arborium_01, right4));
    public static DoorData Arborium_02__right1 { get; } = new(new(Arborium_02, right1), new(Arborium_03, left3));
    public static DoorData Arborium_03__left1 { get; } = new(new(Arborium_03, left1), new(Arborium_06, right1));
    public static DoorData Arborium_03__left2 { get; } = new(new(Arborium_03, left2), new(Arborium_05, right1));
    public static DoorData Arborium_03__left3 { get; } = new(new(Arborium_03, left3), new(Arborium_02, right1));
    public static DoorData Arborium_03__left4 { get; } = new(new(Arborium_03, left4), new(Arborium_04, right1));
    public static DoorData Arborium_03__right1 { get; } = new(new(Arborium_03, right1), new(Arborium_10, left1));
    public static DoorData Arborium_03__right2 { get; } = new(new(Arborium_03, right2), new(Arborium_11, left1));
    public static DoorData Arborium_04__left1 { get; } = new(new(Arborium_04, left1), new(Arborium_01, right5));
    public static DoorData Arborium_04__right1 { get; } = new(new(Arborium_04, right1), new(Arborium_03, left4));
    public static DoorData Arborium_05__right1 { get; } = new(new(Arborium_05, right1), new(Arborium_03, left2));
    public static DoorData Arborium_05__top1 { get; } = new(new(Arborium_05, top1), new(Arborium_06, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Sphere", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Arborium_06__bot1 { get; } = new(new(Arborium_06, bot1), new(Arborium_05, top1));
    public static DoorData Arborium_06__left1 { get; } = new(new(Arborium_06, left1), new(Arborium_01, right3));
    public static DoorData Arborium_06__right1 { get; } = new(new(Arborium_06, right1), new(Arborium_03, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Tall (3)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Coral Crust Wall Small (1)", ObstacleType.Other, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Coral Goomba Ambush/Crust Wall", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Coral Goomba Ambush/Coral Goomba Large (1)", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Coral Crust Wall Tall (1)", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Arborium_07__left1 { get; } = new(new(Arborium_07, left1), new(Arborium_01, right2));
    public static DoorData Arborium_07__top1 { get; } = new(new(Arborium_07, top1), new(Arborium_08, bot1));
    public static DoorData Arborium_08__bot1 { get; } = new(new(Arborium_08, bot1), new(Arborium_07, top1));
    public static DoorData Arborium_08__left1 { get; } = new(new(Arborium_08, left1), new(Arborium_01, right1))
    {
        Obstacles = new([
            new ObstacleInfo("One Way Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Arborium_09__right1 { get; } = new(new(Arborium_09, right1), new(Arborium_01, left1));
    public static DoorData Arborium_09__right2 { get; } = new(new(Arborium_09, right2), new(Arborium_01, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Moss Vine Cluster", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Moss Vine Cluster (1)", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Arborium_10__left1 { get; } = new(new(Arborium_10, left1), new(Arborium_03, right1));
    public static DoorData Arborium_11__left1 { get; } = new(new(Arborium_11, left1), new(Arborium_03, right2));
    public static DoorData Arborium_11__right1 { get; } = new(new(Arborium_11, right1), new(Aqueduct_01, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Arborium_Tube__door_tubeEnter { get; } = new(new(Arborium_Tube, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Arborium_Tube__right1 { get; } = new(new(Arborium_Tube, right1), new(Arborium_01, left3));
    public static DoorData Aspid_01__bot1 { get; } = new(new(Aspid_01, bot1), null, new(Bonetown, top3));
    public static DoorData Aspid_01__bot2 { get; } = new(new(Aspid_01, bot2), new(Bonetown, top2));
    public static DoorData Aspid_01__bot3 { get; } = new(new(Aspid_01, bot3), null, new(Bonetown, top3));
    public static DoorData Aspid_01__bot4 { get; } = new(new(Aspid_01, bot4), null, new(Bonetown, top4));
    public static DoorData Aspid_01__bot5 { get; } = new(new(Aspid_01, bot5), null, new(Bonetown, top5));
    public static DoorData Aspid_01__bot6 { get; } = new(new(Aspid_01, bot6), null, new(Bonetown, top6));
    public static DoorData Aspid_01__bot7 { get; } = new(new(Aspid_01, bot7), null, new(Bonetown, top6));
    public static DoorData Aspid_01__bot8 { get; } = new(new(Aspid_01, bot8), null, new(Bonetown, top6));
    public static DoorData Aspid_01__left1 { get; } = new(new(Aspid_01, left1), new(Crawl_01, right1));
    public static DoorData Aspid_01__left2 { get; } = new(new(Aspid_01, left2), new(Crawl_04, right1));
    public static DoorData Aspid_01__right2 { get; } = new(new(Aspid_01, right2), new(Shellwood_08c, left1));
    public static DoorData Aspid_01__right3 { get; } = new(new(Aspid_01, right3), new(Mosstown_02, left1))
    {
        Obstacles = new([
                new ObstacleInfo("one way break from moss", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(Mosstown_02, "Breakable Wall")),
            ]),
    };
    public static DoorData Aspid_01__right4 { get; } = new(new(Aspid_01, right4), new(Bone_11, left1));
    public static DoorData Aspid_01__top1 { get; } = new(new(Aspid_01, top1), new(Coral_19, bot1), null);
    public static DoorData Aspid_01__top2 { get; } = new(new(Aspid_01, top2), new(Coral_19, bot2), null);
    public static DoorData Aspid_01__top3 { get; } = new(new(Aspid_01, top3), new(Coral_19, bot3), null);
    public static DoorData Aspid_01__top4 { get; } = new(new(Aspid_01, top4), new(Coral_19, bot4), null);
    public static DoorData Aspid_01__top5 { get; } = new(new(Aspid_01, top5), new(Coral_19, bot5), null);
    public static DoorData Aspid_01__top6 { get; } = new(new(Aspid_01, top6), new(Coral_19, bot6), null);
    public static DoorData Aspid_01__top7 { get; } = new(new(Aspid_01, top7), new(Coral_19, bot7), null);
    public static DoorData Bellshrine__left1 { get; } = new(new(Bellshrine, left1), new(Bone_05, right1));
    public static DoorData Bellshrine__right1 { get; } = new(new(Bellshrine, right1), new(Bone_03, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Whole Scene/bellshrine_gate_curved", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineBoneForest)))
        ])
    };
    public static DoorData Bellshrine_02__left1 { get; } = new(new(Bellshrine_02, left1), new(Greymoor_01, right2))
    {
        Obstacles = new([
            new ObstacleInfo("bellshrine_gate_curved", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineGreymoor)))
        ])
    };
    public static DoorData Bellshrine_02__right1 { get; } = new(new(Bellshrine_02, right1), new(Greymoor_02, left2));
    public static DoorData Bellshrine_03__left1 { get; } = new(new(Bellshrine_03, left1), new(Shellwood_08, right1));
    public static DoorData Bellshrine_03__right1 { get; } = new(new(Bellshrine_03, right1), new(Shellwood_19, left1))
    {
        Obstacles = new([
            new ObstacleInfo("bellshrine_gate_curved (1)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineShellwood)))
        ])
    };
    public static DoorData Bellshrine_05__left1 { get; } = new(new(Bellshrine_05, left1), new(Bone_East_12, right1));
    public static DoorData Bellshrine_05__right1 { get; } = new(new(Bellshrine_05, right1), new(Bone_East_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("bellshrine_gate_curved", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineWilds)))
        ])
    };
    public static DoorData Bellshrine_Coral__left1 { get; } = new(new(Bellshrine_Coral, left1), new(Coral_38, right1));
    public static DoorData Bellshrine_Enclave__left1 { get; } = new(new(Bellshrine_Enclave, left1), new(Song_Enclave, door1));
    public static DoorData Belltown__door1 { get; } = new(new(Belltown, door1), new(Belltown_basement, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown__door3 { get; } = new(new(Belltown, door3), new(Belltown_Room_pinsmith, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("hanging_bell_house_Pinsmith", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown__door4 { get; } = new(new(Belltown, door4), new(Belltown_Room_Relic, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("hanging_bell_house 2", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown__door5 { get; } = new(new(Belltown, door5), new(Belltown_Room_Spare, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<TestGameObjectActivator>("Hornet House States", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual, Index: 0),
            new BehaviourObstacleInfo<TestGameObjectActivator>("Hornet House States", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual, Index: 1),
            new BehaviourObstacleInfo<TestGameObjectActivator>("Hornet House States", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual, Index: 2),
            new GameObjectActiveObstacleInfo("Hornet House States/Full", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Hornet House States/Door Lock", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Hornet House States/door5", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown__left3 { get; } = new(new(Belltown, left3), new(Belltown_07, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown__right2 { get; } = new(new(Belltown, right2), new(Belltown_06, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Cutscene Loader", ObstacleType.Cutscene, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Belltown_04__bot1 { get; } = new(new(Belltown_04, bot1), new(Belltown_Shrine, top1));
    public static DoorData Belltown_04__left1 { get; } = new(new(Belltown_04, left1), new(Shellwood_13, right1));
    public static DoorData Belltown_04__left2 { get; } = new(new(Belltown_04, left2), new(Shellwood_15, right1))
    {
        Obstacles = new([
                new ObstacleInfo("Bell Wall Tall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            ]),
    };
    //public static DoorData Belltown_06__door1 { get; } = new(new(Belltown_06, door1), new(Belltown_Room_Fisher, right1), null); // out of bounds gate, destination scene does not exist.
    public static DoorData Belltown_06__left1 { get; } = new(new(Belltown_06, left1), new(Belltown, right2));
    public static DoorData Belltown_06__left3 { get; } = new(new(Belltown_06, left3), new(Belltown_Shrine, right1));
    public static DoorData Belltown_06__right1 { get; } = new(new(Belltown_06, right1), new(Greymoor_08, left2));
    public static DoorData Belltown_07__left1 { get; } = new(new(Belltown_07, left1), new(Shellwood_01, right2));
    public static DoorData Belltown_07__right1 { get; } = new(new(Belltown_07, right1), new(Belltown, left3));
    public static DoorData Belltown_08__right1 { get; } = new(new(Belltown_08, right1), new(Wisp_02, left1));
    public static DoorData Belltown_basement__bot1 { get; } = new(new(Belltown_basement, bot1), new(Belltown_basement_03, top1));
    public static DoorData Belltown_basement__door_fastTravelExit { get; } = new(new(Belltown_basement, door_fastTravelExit));
    public static DoorData Belltown_basement__left1 { get; } = new(new(Belltown_basement, left1), new(Belltown, door1));
    public static DoorData Belltown_basement_03__left1 { get; } = new(new(Belltown_basement_03, left1), new(Bone_08, right2));
    public static DoorData Belltown_basement_03__top1 { get; } = new(new(Belltown_basement_03, top1), new(Belltown_basement, bot1));
    public static DoorData Belltown_Room_doctor__left1 { get; } = new(new(Belltown_Room_doctor, left1), new(Wisp_03, door1));
    // public static DoorData Belltown_Room_Fisher__right1 { get; } = new(new(Belltown_Room_Fisher, right1), null, new(Belltown_06, door1));
    public static DoorData Belltown_Room_pinsmith__left1 { get; } = new(new(Belltown_Room_pinsmith, left1), new(Belltown, door3));
    public static DoorData Belltown_Room_Relic__left1 { get; } = new(new(Belltown_Room_Relic, left1), new(Belltown, door4));
    public static DoorData Belltown_Room_shellwood__left1 { get; } = new(new(Belltown_Room_shellwood, left1), new(Shellwood_01, right1));
    public static DoorData Belltown_Room_Spare__left1 { get; } = new(new(Belltown_Room_Spare, left1), new(Belltown, door5));
    public static DoorData Belltown_Shrine__door_wakeOnGround { get; } = new(new(Belltown_Shrine, door_wakeOnGround));
    public static DoorData Belltown_Shrine__right1 { get; } = new(new(Belltown_Shrine, right1), new(Belltown_06, left3));
    public static DoorData Belltown_Shrine__top1 { get; } = new(new(Belltown_Shrine, top1), new(Belltown_04, bot1));
    public static DoorData Bellway_01__door_fastTravelExit { get; } = new(new(Bellway_01, door_fastTravelExit));
    public static DoorData Bellway_01__left1 { get; } = new(new(Bellway_01, left1), new(Bonetown, door1))
    {
        Obstacles = new([
            new ObstacleInfo("Black Thread States Thread Only Variant/Black Thread World/Breakable Wall", ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Act3_Bellway_01_Breakable_wall"))
        ]),
    };
    public static DoorData Bellway_02__door_fastTravelExit { get; } = new(new(Bellway_02, door_fastTravelExit));
    public static DoorData Bellway_02__left1 { get; } = new(new(Bellway_02, left1), new(Dock_16, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks") // seems that its parent may be set to Breakable Wall in time to not be needed.
        ])
    };
    public static DoorData Bellway_02__right1 { get; } = new(new(Bellway_02, right1), new(Bone_East_01, left2));
    public static DoorData Bellway_03__door_fastTravelExit { get; } = new(new(Bellway_03, door_fastTravelExit));
    public static DoorData Bellway_03__left1 { get; } = new(new(Bellway_03, left1), new(Bone_East_07, right2));
    public static DoorData Bellway_03__right1 { get; } = new(new(Bellway_03, right1), new(Bone_East_09b, left1));
    public static DoorData Bellway_04__bot1 { get; } = new(new(Bellway_04, bot1), new(Greymoor_16, top1));
    public static DoorData Bellway_04__door_fastTravelExit { get; } = new(new(Bellway_04, door_fastTravelExit));
    public static DoorData Bellway_04__left1 { get; } = new(new(Bellway_04, left1), new(Greymoor_05, right2));
    public static DoorData Bellway_08__door_fastTravelExit { get; } = new(new(Bellway_08, door_fastTravelExit));
    public static DoorData Bellway_08__left1 { get; } = new(new(Bellway_08, left1), new(Coral_35, right1));
    public static DoorData Bellway_08__right1 { get; } = new(new(Bellway_08, right1), new(Coral_03, left1));
    public static DoorData Bellway_Aqueduct__door_fastTravelExit { get; } = new(new(Bellway_Aqueduct, door_fastTravelExit));
    public static DoorData Bellway_Aqueduct__left1 { get; } = new(new(Bellway_Aqueduct, left1), new(Aqueduct_02, right2));
    public static DoorData Bellway_Aqueduct__right1 { get; } = new(new(Bellway_Aqueduct, right1), new(Aqueduct_06, left1));
    public static DoorData Bellway_Centipede_Arena__top1 { get; } = new(new(Bellway_Centipede_Arena, top1));
    public static DoorData Bellway_City__door_fastTravelExit { get; } = new(new(Bellway_City, door_fastTravelExit));
    public static DoorData Bellway_City__door_tubeEnter { get; } = new(new(Bellway_City, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Bellway_City__left1 { get; } = new(new(Bellway_City, left1), new(Song_20, right6), new(Song_20, right_cutsceneEntry));
    public static DoorData Bellway_City__right1 { get; } = new(new(Bellway_City, right1), new(Library_11, left2));
    public static DoorData Bellway_Peak__left1 { get; } = new(new(Bellway_Peak, left1), new(Peak_04c, right1));
    public static DoorData Bellway_Peak__left2 { get; } = new(new(Bellway_Peak, left2), new(Peak_04c, right2));
    public static DoorData Bellway_Peak__right1 { get; } = new(new(Bellway_Peak, right1), new(Peak_04, left1));
    public static DoorData Bellway_Peak__right2 { get; } = new(new(Bellway_Peak, right2), new(Bellway_Peak_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Bellway_Peak__top1 { get; } = new(new(Bellway_Peak, top1), new(Peak_05, bot1));
    public static DoorData Bellway_Peak_02__left1 { get; } = new(new(Bellway_Peak_02, left1), new(Bellway_Peak, right2));
    public static DoorData Bellway_Shadow__door_fastTravelExit { get; } = new(new(Bellway_Shadow, door_fastTravelExit));
    public static DoorData Bellway_Shadow__left1 { get; } = new(new(Bellway_Shadow, left1), new(Shadow_04, right2));
    public static DoorData Bone_01__left2 { get; } = new(new(Bone_01, left2), new(Bonetown, right2));
    public static DoorData Bone_01__right1 { get; } = new(new(Bone_01, right1), new(Bone_01c, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Bone_01__right2 { get; } = new(new(Bone_01, right2), new(Bone_01c, left2));
    //public static DoorData Bone_01__top2_extra { get; } = new(new(Bone_01, top2_extra), new(Bone_04, bot2), null);
    public static DoorData Bone_01__top2 { get; } = new(new(Bone_01, top2), new(Bone_04, bot2));
    public static DoorData Bone_01b__left1 { get; } = new(new(Bone_01b, left1), new(Bone_11b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Bone_01b__left2 { get; } = new(new(Bone_01b, left2), new(Bonetown, right1));
    public static DoorData Bone_01c__left1 { get; } = new(new(Bone_01c, left1), new(Bone_01, right1));
    public static DoorData Bone_01c__left2 { get; } = new(new(Bone_01c, left2), new(Bone_01, right2));
    public static DoorData Bone_01c__right1 { get; } = new(new(Bone_01c, right1), new(Bone_02, left1));
    public static DoorData Bone_02__left1 { get; } = new(new(Bone_02, left1), new(Bone_01c, right1));
    public static DoorData Bone_02__right1 { get; } = new(new(Bone_02, right1), new(Bone_16, left1));
    public static DoorData Bone_02__top1 { get; } = new(new(Bone_02, top1), new(Bone_03, bot1));
    public static DoorData Bone_02__top2 { get; } = new(new(Bone_02, top2), new(Bone_10, bot1));
    public static DoorData Bone_03__bot1 { get; } = new(new(Bone_03, bot1), new(Bone_02, top1));
    public static DoorData Bone_03__left1 { get; } = new(new(Bone_03, left1), new(Bellshrine, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Bellshrine gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineBoneForest)))
        ])
    };
    public static DoorData Bone_03__left2 { get; } = new(new(Bone_03, left2), new(Bone_04, right1));
    public static DoorData Bone_03__left4 { get; } = new(new(Bone_03, left4), new(Bone_17, right1));
    public static DoorData Bone_03__right1 { get; } = new(new(Bone_03, right1), new(Bone_14, left1));
    public static DoorData Bone_03__right3 { get; } = new(new(Bone_03, right3), new(Bone_10, left1));
    public static DoorData Bone_03__top1 { get; } = new(new(Bone_03, top1), new(Bone_06, bot1));
    public static DoorData Bone_04__bot2 { get; } = new(new(Bone_04, bot2), new(Bone_01, top2), new(Bone_01, top2_extra));
    public static DoorData Bone_04__left1 { get; } = new(new(Bone_04, left1), new(Bone_11, right1));
    public static DoorData Bone_04__left2 { get; } = new(new(Bone_04, left2), new(Bone_11, right2));
    public static DoorData Bone_04__right1 { get; } = new(new(Bone_04, right1), new(Bone_03, left2));
    public static DoorData Bone_04__top1 { get; } = new(new(Bone_04, top1), new(Bone_05, bot1));
    public static DoorData Bone_05__bot1 { get; } = new(new(Bone_05, bot1), new(Bone_04, top1));
    public static DoorData Bone_05__door_cinematicEnd { get; } = new(new(Bone_05, door_cinematicEnd));
    public static DoorData Bone_05__door_fastTravelExit { get; } = new(new(Bone_05, door_fastTravelExit));
    public static DoorData Bone_05__left1 { get; } = new(new(Bone_05, left1), new(Mosstown_01, right1));
    public static DoorData Bone_05__right1 { get; } = new(new(Bone_05, right1), new(Bellshrine, left1));
    public static DoorData Bone_05b__left1 { get; } = new(new(Bone_05b, left1), new(Mosstown_01, right2));
    public static DoorData Bone_05b__top1 { get; } = new(new(Bone_05b, top1), new(Mosstown_02, bot2));
    public static DoorData Bone_06__bot1 { get; } = new(new(Bone_06, bot1), new(Bone_03, top1));
    public static DoorData Bone_06__left1 { get; } = new(new(Bone_06, left1), new(Mosstown_03, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Bone_face_shortcut", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.explodeWallMosstown3)))
        ])
    };
    public static DoorData Bone_06__right1 { get; } = new(new(Bone_06, right1), new(Bone_18, left1));
    public static DoorData Bone_07__left1 { get; } = new(new(Bone_07, left1), new(Bone_14, right1));
    public static DoorData Bone_07__right1 { get; } = new(new(Bone_07, right1), new(Bone_08, left2));
    public static DoorData Bone_07__right2 { get; } = new(new(Bone_07, right2), new(Bone_08, left3));
    public static DoorData Bone_07__top1 { get; } = new(new(Bone_07, top1), new(Bone_19, bot1));
    public static DoorData Bone_08__bot1 { get; } = new(new(Bone_08, bot1), new(Bone_09, top1));
    public static DoorData Bone_08__door1 { get; } = new(new(Bone_08, door1), new(Bone_12, left1));
    public static DoorData Bone_08__left2 { get; } = new(new(Bone_08, left2), new(Bone_07, right1));
    public static DoorData Bone_08__left3 { get; } = new(new(Bone_08, left3), new(Bone_07, right2));
    public static DoorData Bone_08__right2 { get; } = new(new(Bone_08, right2), new(Belltown_basement_03, left1));
    public static DoorData Bone_08__right3 { get; } = new(new(Bone_08, right3), new(Ant_02, left1));
    public static DoorData Bone_09__left1 { get; } = new(new(Bone_09, left1), new(Bone_16, right1));
    public static DoorData Bone_09__right1 { get; } = new(new(Bone_09, right1), new(Dock_08, left1));
    public static DoorData Bone_09__right2 { get; } = new(new(Bone_09, right2), new(Dock_08, left2));
    public static DoorData Bone_09__top1 { get; } = new(new(Bone_09, top1), new(Bone_08, bot1));
    public static DoorData Bone_10__bot1 { get; } = new(new(Bone_10, bot1), new(Bone_02, top2));
    public static DoorData Bone_10__door2 { get; } = new(new(Bone_10, door2), new(Room_Caravan_Spa, left1), null)
    {
        Obstacles = new([
            new BehaviourObstacleInfo<DeactivatePlayerDataTest>("Black Thread States Thread Only Variant/Normal World/Caravan", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new BehaviourObstacleInfo<DeactivateIfPlayerdataFalse>("Black Thread States Thread Only Variant/Normal World/Caravan/Caravan_Spa", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Black Thread States Thread Only Variant/Normal World/Caravan/Caravan_Spa/door2", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess)
        ])
    };
    public static DoorData Bone_10__left1 { get; } = new(new(Bone_10, left1), new(Bone_03, right3));
    public static DoorData Bone_10__right1 { get; } = new(new(Bone_10, right1), new(Bone_15, left1));
    public static DoorData Bone_11__bot1 { get; } = new(new(Bone_11, bot1), new(Bone_11b, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Plaza_closed", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsExitAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.BonePlazaOpened))),
            new BehaviourObstacleInfo<DeactivatePlayerDataTest>("Plaza_open", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Pilgrim 03 (1)", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Bone_11__left1 { get; } = new(new(Bone_11, left1), new(Aspid_01, right4));
    public static DoorData Bone_11__right1 { get; } = new(new(Bone_11, right1), new(Bone_04, left1));
    public static DoorData Bone_11__right2 { get; } = new(new(Bone_11, right2), new(Bone_04, left2));
    public static DoorData Bone_11__top1 { get; } = new(new(Bone_11, top1), new(Mosstown_01, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("trapdoor", ObstacleType.OneWayMechanismExit, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(SceneName: Mosstown_01, ID: "Trapdoor Lever"))
        ])
    };
    public static DoorData Bone_11b__right1 { get; } = new(new(Bone_11b, right1), new(Bone_01b, left1));
    public static DoorData Bone_11b__top1 { get; } = new(new(Bone_11b, top1), new(Bone_11, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Bone Drop Plat Sequence", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(ID: "Plate"))
        ])
    };
    public static DoorData Bone_12__left1 { get; } = new(new(Bone_12, left1), new(Bone_08, door1));
    public static DoorData Bone_14__left1 { get; } = new(new(Bone_14, left1), new(Bone_03, right1));
    public static DoorData Bone_14__right1 { get; } = new(new(Bone_14, right1), new(Bone_07, left1));
    public static DoorData Bone_15__bot1 { get; } = new(new(Bone_15, bot1), new(Bone_16, top1));
    public static DoorData Bone_15__left1 { get; } = new(new(Bone_15, left1), new(Bone_10, right1));
    public static DoorData Bone_16__left1 { get; } = new(new(Bone_16, left1), new(Bone_02, right1));
    public static DoorData Bone_16__right1 { get; } = new(new(Bone_16, right1), new(Bone_09, left1));
    public static DoorData Bone_16__top1 { get; } = new(new(Bone_16, top1), new(Bone_15, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Bone_17__right1 { get; } = new(new(Bone_17, right1), new(Bone_03, left4));
    public static DoorData Bone_18__left1 { get; } = new(new(Bone_18, left1), new(Bone_06, right1));
    public static DoorData Bone_19__bot1 { get; } = new(new(Bone_19, bot1), new(Bone_07, top1));
    public static DoorData Bone_East_01__left1 { get; } = new(new(Bone_East_01, left1), new(Dock_01, right2));
    public static DoorData Bone_East_01__left2 { get; } = new(new(Bone_East_01, left2), new(Bellway_02, right1));
    public static DoorData Bone_East_01__right1 { get; } = new(new(Bone_East_01, right1), new(Bone_East_03, left1));
    public static DoorData Bone_East_01__right2 { get; } = new(new(Bone_East_01, right2), new(Dock_05, left1));
    public static DoorData Bone_East_01__right3 { get; } = new(new(Bone_East_01, right3), new(Bone_East_12, left1));
    public static DoorData Bone_East_02__left1 { get; } = new(new(Bone_East_02, left1), new(Bellshrine_05, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Bellshrine gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineWilds)))
        ])
    };
    public static DoorData Bone_East_02__right1 { get; } = new(new(Bone_East_02, right1), new(Bone_East_02b, left1));
    public static DoorData Bone_East_02__top1 { get; } = new(new(Bone_East_02, top1), new(Bone_East_15, bot1));
    public static DoorData Bone_East_02b__left1 { get; } = new(new(Bone_East_02b, left1), new(Bone_East_02, right1));
    public static DoorData Bone_East_02b__right1 { get; } = new(new(Bone_East_02b, right1), new(Bone_East_07, left1));
    public static DoorData Bone_East_02b__right2 { get; } = new(new(Bone_East_02b, right2), new(Bone_East_07, left2));
    public static DoorData Bone_East_02b__top3 { get; } = new(new(Bone_East_02b, top3), new(Bone_East_16, bot1));
    public static DoorData Bone_East_03__left1 { get; } = new(new(Bone_East_03, left1), new(Bone_East_01, right1));
    public static DoorData Bone_East_03__top1 { get; } = new(new(Bone_East_03, top1), new(Bone_East_04, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall_norck", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(ID: "DockDashExplodeRock"))
        ])
    };
    public static DoorData Bone_East_04__bot1 { get; } = new(new(Bone_East_04, bot1), new(Bone_East_03, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Bottom Block", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(SceneName: Bone_East_03, ID: "DockDashExplodeRock"))
        ])
    };
    public static DoorData Bone_East_04__left1 { get; } = new(new(Bone_East_04, left1), new(Bone_East_04b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_04__right1 { get; } = new(new(Bone_East_04, right1), new(Bone_East_15, left1));
    public static DoorData Bone_East_04__right2 { get; } = new(new(Bone_East_04, right2), new(Bone_East_04c, left1));
    public static DoorData Bone_East_04__top2 { get; } = new(new(Bone_East_04, top2), new(Ant_05b, bot2));
    public static DoorData Bone_East_04b__left1 { get; } = new(new(Bone_East_04b, left1), new(Bone_East_05, right1));
    public static DoorData Bone_East_04b__right1 { get; } = new(new(Bone_East_04b, right1), new(Bone_East_04, left1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.Bone_East_04b_ExplodeWall)))
        ])
    };
    public static DoorData Bone_East_04b__top1 { get; } = new(new(Bone_East_04b, top1), new(Ant_05b, bot1));
    public static DoorData Bone_East_04c__left1 { get; } = new(new(Bone_East_04c, left1), new(Bone_East_04, right2));
    public static DoorData Bone_East_05__left1 { get; } = new(new(Bone_East_05, left1), new(Dock_01, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Song_Gate_small", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_05__right1 { get; } = new(new(Bone_East_05, right1), new(Bone_East_04b, left1));
    public static DoorData Bone_East_07__left1 { get; } = new(new(Bone_East_07, left1), new(Bone_East_02b, right1));
    public static DoorData Bone_East_07__left2 { get; } = new(new(Bone_East_07, left2), new(Bone_East_02b, right2));
    public static DoorData Bone_East_07__left3 { get; } = new(new(Bone_East_07, left3), new(Dock_03b, right1));
    public static DoorData Bone_East_07__left4 { get; } = new(new(Bone_East_07, left4), new(Bone_East_17, right1));
    public static DoorData Bone_East_07__right1 { get; } = new(new(Bone_East_07, right1), new(Bone_East_10, left2));
    public static DoorData Bone_East_07__right2 { get; } = new(new(Bone_East_07, right2), new(Bellway_03, left1));
    public static DoorData Bone_East_07__right3 { get; } = new(new(Bone_East_07, right3), new(Bone_East_08, left1));
    public static DoorData Bone_East_07__right4 { get; } = new(new(Bone_East_07, right4), new(Bone_East_22, left1));
    public static DoorData Bone_East_07__right5 { get; } = new(new(Bone_East_07, right5), new(Bone_East_21, left1));
    public static DoorData Bone_East_07__top1 { get; } = new(new(Bone_East_07, top1), new(Bone_East_11, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("trapdoor/closed", ObstacleType.OneWayMechanismExit, ObstacleSeverity.InterruptsEntry, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedGeyserShaft)))
        ])
    };
    public static DoorData Bone_East_08__door_cinematicEnd { get; } = new(new(Bone_East_08, door_cinematicEnd));
    public static DoorData Bone_East_08__left1 { get; } = new(new(Bone_East_08, left1), new(Bone_East_07, right3));
    public static DoorData Bone_East_08__right1 { get; } = new(new(Bone_East_08, right1), new(Bone_East_09, left2));
    public static DoorData Bone_East_09__door1 { get; } = new(new(Bone_East_09, door1), new(Bone_East_Umbrella, left1));
    public static DoorData Bone_East_09__left2 { get; } = new(new(Bone_East_09, left2), new(Bone_East_08, right1));
    public static DoorData Bone_East_09__left3 { get; } = new(new(Bone_East_09, left3), new(Bone_East_20, right1));
    public static DoorData Bone_East_09__right1 { get; } = new(new(Bone_East_09, right1), new(Bone_East_14, left1));
    public static DoorData Bone_East_09__right2 { get; } = new(new(Bone_East_09, right2), new(Bone_East_14, left2));
    public static DoorData Bone_East_09__top1 { get; } = new(new(Bone_East_09, top1), new(Bone_East_09b, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("top_explode_wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.InterruptsEntry, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedCauldronShortcut)))
        ])
    };
    public static DoorData Bone_East_09b__bot1 { get; } = new(new(Bone_East_09b, bot1), new(Bone_East_09, top1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.AbnormalVisual, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedCauldronShortcut)))
        ])
    };
    public static DoorData Bone_East_09b__left1 { get; } = new(new(Bone_East_09b, left1), new(Bellway_03, right1));
    public static DoorData Bone_East_09b__top1 { get; } = new(new(Bone_East_09b, top1), new(Bone_East_10_Church, bot1));
    public static DoorData Bone_East_10__door1 { get; } = new(new(Bone_East_10, door1), new(Bone_East_10_Room, right1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayMakerFSM>("Black Thread States Thread Only Variant/Normal World/toll door interactible", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(SceneName: "Pilgrims Rest", ID: "Toll Door")),
            new BehaviourObstacleInfo<BoxCollider2D>("Black Thread States Thread Only Variant/Normal World/toll door interactible", false, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("Black Thread States Thread Only Variant/Normal World/toll door interactible/door", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new TransitionObstacleInfo("door1", true, ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess),
        ])
    };
    public static DoorData Bone_East_10__left1 { get; } = new(new(Bone_East_10, left1), new(Bone_East_11, right2));
    public static DoorData Bone_East_10__left2 { get; } = new(new(Bone_East_10, left2), new(Bone_East_07, right1));
    public static DoorData Bone_East_10__right1 { get; } = new(new(Bone_East_10, right1), new(Bone_East_18c, left1))
    {
        Obstacles = new([
            new ObstacleInfo("one way wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.explodeWallBoneEast18c)))
        ])
    };
    public static DoorData Bone_East_10__right2 { get; } = new(new(Bone_East_10, right2), new(Bone_East_10_Church, left1))
    {
        Obstacles = new([
            // the PersistentBool is for the lever on the other side, NOT for the gate
            new ObstacleInfo("Rhino Scene/Gate Smashing", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(SceneName: Bone_East_10_Church, ID: "Song_lever_side"))
        ])
    };
    public static DoorData Bone_East_10_Church__bot1 { get; } = new(new(Bone_East_10_Church, bot1), new(Bone_East_09b, top1));
    public static DoorData Bone_East_10_Church__left1 { get; } = new(new(Bone_East_10_Church, left1), new(Bone_East_10, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Rhino Scene/Song_Gate_small (1)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_10_Room__right1 { get; } = new(new(Bone_East_10_Room, right1), new(Bone_East_10, door1));
    public static DoorData Bone_East_11__bot1 { get; } = new(new(Bone_East_11, bot1), new(Bone_East_07, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Song Trapdoor/Closed Collider", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(ID: "Song_lever_side")),
            new BehaviourObstacleInfo<PlayMakerFSM>("Song Trapdoor", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new GameObjectActiveObstacleInfo("Song Trapdoor/open", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new GameObjectActiveObstacleInfo("Song Trapdoor/Open Collider", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Song Trapdoor/Door L", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Song Trapdoor/Door R", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Bone_East_11__left1 { get; } = new(new(Bone_East_11, left1), new(Ant_09, right1));
    public static DoorData Bone_East_11__right1 { get; } = new(new(Bone_East_11, right1), new(Bone_East_24, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Bone East 11 Cross Over Group/Gate/right_gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Bone East 11 Cross Over Group")),
            new ObstacleInfo("Bone East 11 Cross Over Group/Gate/unmasker_right", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Bone East 11 Cross Over Group/Gate/centre_mask", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility)
        ])
    };
    public static DoorData Bone_East_11__right2 { get; } = new(new(Bone_East_11, right2), new(Bone_East_10, left1));
    public static DoorData Bone_East_11__top1 { get; } = new(new(Bone_East_11, top1), new(Greymoor_01, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Greymoor Entry/crashExit", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PlayerDataBoolSaveInfo(nameof(PlayerData.crashedIntoGreymoor))),
            new GameObjectActiveObstacleInfo("Greymoor Entry/top1", true, ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess),
            new BehaviourObstacleInfo<DeactivateIfPlayerdataFalse>("Greymoor Entry/top1", false, ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess)
        ])
    };
    public static DoorData Bone_East_12__bot1 { get; } = new(new(Bone_East_12, bot1), new(Room_Forge, top1));
    public static DoorData Bone_East_12__left1 { get; } = new(new(Bone_East_12, left1), new(Bone_East_01, right3));
    public static DoorData Bone_East_12__right1 { get; } = new(new(Bone_East_12, right1), new(Bellshrine_05, left1));
    public static DoorData Bone_East_13__left1 { get; } = new(new(Bone_East_13, left1), new(Dock_04, right2));
    public static DoorData Bone_East_14__left1 { get; } = new(new(Bone_East_14, left1), new(Bone_East_09, right1));
    public static DoorData Bone_East_14__left2 { get; } = new(new(Bone_East_14, left2), new(Bone_East_09, right2));
    public static DoorData Bone_East_14__right1 { get; } = new(new(Bone_East_14, right1), new(Bone_East_14b, left1));
    public static DoorData Bone_East_14__right2 { get; } = new(new(Bone_East_14, right2), new(Bone_East_14b, left2))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall (4)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_14b__door1 { get; } = new(new(Bone_East_14b, door1), new(Bone_East_LavaChallenge, left1));
    public static DoorData Bone_East_14b__left1 { get; } = new(new(Bone_East_14b, left1), new(Bone_East_14, right1));
    public static DoorData Bone_East_14b__left2 { get; } = new(new(Bone_East_14b, left2), new(Bone_East_14, right2));
    public static DoorData Bone_East_14b__right1 { get; } = new(new(Bone_East_14b, right1), new(Bone_East_Weavehome, left1));
    public static DoorData Bone_East_15__bot1 { get; } = new(new(Bone_East_15, bot1), new(Bone_East_02, top1));
    public static DoorData Bone_East_15__left1 { get; } = new(new(Bone_East_15, left1), new(Bone_East_04, right1));
    public static DoorData Bone_East_15__right1 { get; } = new(new(Bone_East_15, right1), new(Bone_East_17, left1));
    public static DoorData Bone_East_16__bot1 { get; } = new(new(Bone_East_16, bot1), new(Bone_East_02b, top3));
    public static DoorData Bone_East_16__right1 { get; } = new(new(Bone_East_16, right1), new(Bone_East_17b, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.TwoWayBreakable, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_17__bot1 { get; } = new(new(Bone_East_17, bot1), new(Bone_East_17b, top1));
    public static DoorData Bone_East_17__left1 { get; } = new(new(Bone_East_17, left1), new(Bone_East_15, right1));
    public static DoorData Bone_East_17__right1 { get; } = new(new(Bone_East_17, right1), new(Bone_East_07, left4));
    public static DoorData Bone_East_17b__left1 { get; } = new(new(Bone_East_17b, left1), new(Bone_East_16, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.TwoWayBreakable, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Bone_East_17b__top1 { get; } = new(new(Bone_East_17b, top1), new(Bone_East_17, bot1));
    public static DoorData Bone_East_18__left1 { get; } = new(new(Bone_East_18, left1), new(Bone_East_18c, right1));
    public static DoorData Bone_East_18__right1 { get; } = new(new(Bone_East_18, right1), new(Bone_East_18b, left1));
    public static DoorData Bone_East_18__top1 { get; } = new(new(Bone_East_18, top1), new(Bone_East_24, bot1));
    public static DoorData Bone_East_18b__door1 { get; } = new(new(Bone_East_18b, door1), new(Sprintmaster_Cave, left1));
    public static DoorData Bone_East_18b__left1 { get; } = new(new(Bone_East_18b, left1), new(Bone_East_18, right1));
    public static DoorData Bone_East_18b__top1 { get; } = new(new(Bone_East_18b, top1), new(Bone_East_26, bot1));
    public static DoorData Bone_East_18c__left1 { get; } = new(new(Bone_East_18c, left1), new(Bone_East_10, right1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.explodeWallBoneEast18c)))
        ])
    };
    public static DoorData Bone_East_18c__right1 { get; } = new(new(Bone_East_18c, right1), new(Bone_East_18, left1));
    public static DoorData Bone_East_20__right1 { get; } = new(new(Bone_East_20, right1), new(Bone_East_09, left3));
    public static DoorData Bone_East_21__left1 { get; } = new(new(Bone_East_21, left1), new(Bone_East_07, right5));
    public static DoorData Bone_East_22__left1 { get; } = new(new(Bone_East_22, left1), new(Bone_East_07, right4));
    public static DoorData Bone_East_24__bot1 { get; } = new(new(Bone_East_24, bot1), new(Bone_East_18, top1));
    public static DoorData Bone_East_24__left1 { get; } = new(new(Bone_East_24, left1), new(Bone_East_11, right1));
    public static DoorData Bone_East_24__right1 { get; } = new(new(Bone_East_24, right1), new(Bone_East_27, left1));
    public static DoorData Bone_East_25__door1 { get; } = new(new(Bone_East_25, door1), new(Ant_Queen, left1));
    public static DoorData Bone_East_25__left1 { get; } = new(new(Bone_East_25, left1), new(Bone_East_27, right1));
    public static DoorData Bone_East_26__bot1 { get; } = new(new(Bone_East_26, bot1), new(Bone_East_18b, top1));
    public static DoorData Bone_East_26__top1 { get; } = new(new(Bone_East_26, top1), new(Bone_East_27, bot1));
    public static DoorData Bone_East_27__bot1 { get; } = new(new(Bone_East_27, bot1), new(Bone_East_26, top1));
    public static DoorData Bone_East_27__left1 { get; } = new(new(Bone_East_27, left1), new(Bone_East_24, right1));
    public static DoorData Bone_East_27__right1 { get; } = new(new(Bone_East_27, right1), new(Bone_East_25, left1));
    public static DoorData Bone_East_LavaChallenge__left1 { get; } = new(new(Bone_East_LavaChallenge, left1), new(Bone_East_14b, door1));
    public static DoorData Bone_East_Umbrella__left1 { get; } = new(new(Bone_East_Umbrella, left1), new(Bone_East_09, door1));
    public static DoorData Bone_East_Weavehome__left1 { get; } = new(new(Bone_East_Weavehome, left1), new(Bone_East_14b, right1));
    public static DoorData Bone_Steel_Servant__right1 { get; } = new(new(Bone_Steel_Servant, right1), new(Bonegrave, left1));
    public static DoorData Bonegrave__door1 { get; } = new(new(Bonegrave, door1), new(Chapel_Wanderer, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayMakerFSM>("Chapel Door Control", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.ModifiesSaveData | ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Chapel Door Control/door1", true, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsExitAccess),
        ])
    };
    public static DoorData Bonegrave__left1 { get; } = new(new(Bonegrave, left1), new(Bone_Steel_Servant, right1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Steel_Servant_Tunnel", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.InterruptsEntry)
        ])
    };
    public static DoorData Bonegrave__right1 { get; } = new(new(Bonegrave, right1), new(Bonetown, left1));
    public static DoorData Bonegrave__right2 { get; } = new(new(Bonegrave, right2), new(Bonetown, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Moss Vine Cluster", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("church_gate/bone_gate_02004", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.bonegraveOpen)))
        ])
    };
    public static DoorData Bonegrave__top1 { get; } = new(new(Bonegrave, top1), new(Crawl_07, bot1));
    // public static DoorData Bonetown__bot1_firstEntry { get; } = new(new(Bonetown, bot1_firstEntry), new(Tut_03, top1), new(Tut_03, door1_firstExit));
    public static DoorData Bonetown__bot1 { get; } = new(new(Bonetown, bot1), new(Tut_03, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro))),
            new GameObjectActiveObstacleInfo("Weakness Scene", false, ObstacleType.Cutscene, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Bonetown__bot2 { get; } = new(new(Bonetown, bot2), new(Tut_01, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__door1 { get; } = new(new(Bonetown, door1), new(Bellway_01, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro))),
            new ObstacleInfo("Black Thread States/Black Thread World/Breakable Wall", ObstacleType.ClosedAfterProgression, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo(Bellway_01, "Act3_Bellway_01_Breakable_wall"))
        ])
    };
    public static DoorData Bonetown__left1 { get; } = new(new(Bonetown, left1), new(Bonegrave, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__left2 { get; } = new(new(Bonetown, left2), new(Bonegrave, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro))),
            new ObstacleInfo("bone_gate_02004", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.bonegraveOpen)))
        ])
    };
    public static DoorData Bonetown__right1 { get; } = new(new(Bonetown, right1), new(Bone_01b, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__right2 { get; } = new(new(Bonetown, right2), new(Bone_01, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top1 { get; } = new(new(Bonetown, top1), new(Aspid_01, bot1), null)
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top2 { get; } = new(new(Bonetown, top2), new(Aspid_01, bot2))
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top3 { get; } = new(new(Bonetown, top3), new(Aspid_01, bot3), null)
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top4 { get; } = new(new(Bonetown, top4), new(Aspid_01, bot4), null)
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top5 { get; } = new(new(Bonetown, top5), new(Aspid_01, bot5), null)
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Bonetown__top6 { get; } = new(new(Bonetown, top6), new(Aspid_01, bot6), null)
    {
        Obstacles = new([
            new ObstacleInfo("Churchkeeper Intro Scene", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Chapel_Wanderer__door_memoryEnd { get; } = new(new(Chapel_Wanderer, door_memoryEnd));
    public static DoorData Chapel_Wanderer__left1 { get; } = new(new(Chapel_Wanderer, left1), new(Bonegrave, door1));
    public static DoorData Clover_01__door_wakeOnGround { get; } = new(new(Clover_01, door_wakeOnGround));
    public static DoorData Clover_01__left1 { get; } = new(new(Clover_01, left1), new(Greymoor_15b, right1));
    public static DoorData Clover_01__right1 { get; } = new(new(Clover_01, right1), new(Clover_20, left1));
    public static DoorData Clover_01b__door_wakeInMemory { get; } = new(new(Clover_01b, door_wakeInMemory));
    public static DoorData Clover_01b__right1 { get; } = new(new(Clover_01b, right1), new(Clover_02c, left1));
    public static DoorData Clover_02c__left1 { get; } = new(new(Clover_02c, left1), new(Clover_01b, right1));
    public static DoorData Clover_02c__left2 { get; } = new(new(Clover_02c, left2), new(Clover_05c, right3));
    public static DoorData Clover_02c__right1 { get; } = new(new(Clover_02c, right1), new(Clover_03, left2));
    public static DoorData Clover_03__left1 { get; } = new(new(Clover_03, left1), new(Clover_04b, right1));
    public static DoorData Clover_03__left2 { get; } = new(new(Clover_03, left2), new(Clover_02c, right1));
    public static DoorData Clover_03__right1 { get; } = new(new(Clover_03, right1), new(Clover_18, left1));
    public static DoorData Clover_04b__door1 { get; } = new(new(Clover_04b, door1))
    {
        DynamicTargets = new([
            new(Clover_10, left1),
            new(Clover_10_web, left1)
        ]),
        Obstacles = new([
            new BehaviourObstacleInfo<PlayMakerFSM>("palace_control", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual),
            new BehaviourObstacleInfo<DoorTargetCondition>("palace_control/palace_top/door1", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess | ObstacleSeverity.AbnormalVisual),
            new GameObjectActiveObstacleInfo("palace_control/palace_missing", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Clover_04b__left1 { get; } = new(new(Clover_04b, left1), new(Clover_11, right1));
    public static DoorData Clover_04b__left2 { get; } = new(new(Clover_04b, left2), new(Clover_05c, right1));
    public static DoorData Clover_04b__right1 { get; } = new(new(Clover_04b, right1), new(Clover_03, left1));
    public static DoorData Clover_05c__left1 { get; } = new(new(Clover_05c, left1), new(Clover_16, right1));
    public static DoorData Clover_05c__left2 { get; } = new(new(Clover_05c, left2), new(Clover_21, right1));
    public static DoorData Clover_05c__right1 { get; } = new(new(Clover_05c, right1), new(Clover_04b, left2));
    public static DoorData Clover_05c__right2 { get; } = new(new(Clover_05c, right2), new(Clover_19, left1));
    public static DoorData Clover_05c__right3 { get; } = new(new(Clover_05c, right3), new(Clover_02c, left2));
    public static DoorData Clover_06__bot1 { get; } = new(new(Clover_06, bot1), new(Clover_16, top1));
    public static DoorData Clover_06__bot2 { get; } = new(new(Clover_06, bot2), new(Clover_19, top1));
    public static DoorData Clover_10__left1 { get; } = new(new(Clover_10, left1), new(Clover_04b, door1), null);
    public static DoorData Clover_10_web__left1 { get; } = new(new(Clover_10_web, left1), new(Clover_04b, door1), null);
    public static DoorData Clover_11__right1 { get; } = new(new(Clover_11, right1), new(Clover_04b, left1));
    public static DoorData Clover_16__right1 { get; } = new(new(Clover_16, right1), new(Clover_05c, left1));
    public static DoorData Clover_16__top1 { get; } = new(new(Clover_16, top1), new(Clover_06, bot1));
    public static DoorData Clover_18__left1 { get; } = new(new(Clover_18, left1), new(Clover_03, right1));
    public static DoorData Clover_19__left1 { get; } = new(new(Clover_19, left1), new(Clover_05c, right2));
    public static DoorData Clover_19__top1 { get; } = new(new(Clover_19, top1), new(Clover_06, bot2));
    public static DoorData Clover_20__left1 { get; } = new(new(Clover_20, left1), new(Clover_01, right1));
    public static DoorData Clover_21__right1 { get; } = new(new(Clover_21, right1), new(Clover_05c, left2));
    public static DoorData Cog_04__door1 { get; } = new(new(Cog_04, door1), new(Cog_Bench, left1));
    public static DoorData Cog_04__door2 { get; } = new(new(Cog_04, door2), new(Cog_Pass, left2));
    public static DoorData Cog_04__left2 { get; } = new(new(Cog_04, left2), new(Cog_05, right2));
    public static DoorData Cog_04__right2 { get; } = new(new(Cog_04, right2), new(Cog_06, left2));
    public static DoorData Cog_04__right3 { get; } = new(new(Cog_04, right3), new(Cog_07, left1));
    public static DoorData Cog_04__top1 { get; } = new(new(Cog_04, top1), new(Cog_Dancers, bot1));
    public static DoorData Cog_04__top2 { get; } = new(new(Cog_04, top2), new(Cog_Dancers, bot2));
    public static DoorData Cog_05__left1 { get; } = new(new(Cog_05, left1), new(Song_09, right1));
    public static DoorData Cog_05__right2 { get; } = new(new(Cog_05, right2), new(Cog_04, left2));
    public static DoorData Cog_05__top1 { get; } = new(new(Cog_05, top1), new(Cog_10, bot1));
    public static DoorData Cog_06__left2 { get; } = new(new(Cog_06, left2), new(Cog_04, right2));
    public static DoorData Cog_06__right1 { get; } = new(new(Cog_06, right1), new(Song_20b, left4))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<Animator>("cog_door_open", false, ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "cog_lever")),
            new GameObjectActiveObstacleInfo("cog_door_open/terrain collider", false, ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess),
            new GameObjectActiveObstacleInfo("cog_door_open/front_ver", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new GameObjectActiveObstacleInfo("cog_door_open/back_ver", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Cog_07__left1 { get; } = new(new(Cog_07, left1), new(Cog_04, right3));
    public static DoorData Cog_08__bot1 { get; } = new(new(Cog_08, bot1), new(Cog_Dancers, top1));
    public static DoorData Cog_08__top1 { get; } = new(new(Cog_08, top1), new(Cog_09, bot1));
    public static DoorData Cog_09__bot1 { get; } = new(new(Cog_09, bot1), new(Cog_08, top1));
    public static DoorData Cog_09_Destroyed__right1 { get; } = new(new(Cog_09_Destroyed, right1), new(Cog_10_Destroyed, left1));
    public static DoorData Cog_09_Destroyed__top1 { get; } = new(new(Cog_09_Destroyed, top1), new(Song_Tower_Destroyed, bot1));
    public static DoorData Cog_10__bot1 { get; } = new(new(Cog_10, bot1), new(Cog_05, top1));
    public static DoorData Cog_10_Destroyed__bot1 { get; } = new(new(Cog_10_Destroyed, bot1), new(Song_25, top2));
    public static DoorData Cog_10_Destroyed__left1 { get; } = new(new(Cog_10_Destroyed, left1), new(Cog_09_Destroyed, right1));
    // public static DoorData Cog_11_Destroyed__left1 { get; } = new(new(Cog_11_Destroyed, left1), null, new(Hang_08, right2));
    public static DoorData Cog_Bench__left1 { get; } = new(new(Cog_Bench, left1), new(Cog_04, door1));
    public static DoorData Cog_Dancers__bot1 { get; } = new(new(Cog_Dancers, bot1), new(Cog_04, top1));
    // {
    //     Obstacles = new([
    //         new BehaviourObstacleInfo<PlayMakerFSM>("Boss Scene/Battle Gates/gate ground", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new BehaviourObstacleInfo<Animator>("Boss Scene/Battle Gates/gate ground/Cog Dancers Trapdoor", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new ObstacleInfo("Boss Scene/Battle Gates/gate ground/ground consistency terrain collider", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new GameObjectActiveObstacleInfo("Boss Scene/Battle Gates/gate ground/ground mid terrain collider", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
    //     ])
    // };
    public static DoorData Cog_Dancers__bot2 { get; } = new(new(Cog_Dancers, bot2), new(Cog_04, top2));
    // {
    //     Obstacles = new([
    //         new BehaviourObstacleInfo<Gate>("Boss Scene/Battle Gates/gate ground/Cog Dancers Trapdoor (1)", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new BehaviourObstacleInfo<Animator>("Boss Scene/Battle Gates/gate ground/Cog Dancers Trapdoor (1)", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new ObstacleInfo("Boss Scene/Battle Gates/gate ground/ground consistency terrain collider", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
    //         new GameObjectActiveObstacleInfo("Boss Scene/Battle Gates/gate ground/ground mid terrain collider", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
    //     ])
    // };
    public static DoorData Cog_Dancers__door_arriveFromTower { get; } = new(new(Cog_Dancers, door_arriveFromTower));
    public static DoorData Cog_Dancers__door1 { get; } = new(new(Cog_Dancers, door1), new(Cog_Pass, left1));
    public static DoorData Cog_Dancers__left1 { get; } = new(new(Cog_Dancers, left1), new(Hang_07, right1));
    public static DoorData Cog_Dancers__right1 { get; } = new(new(Cog_Dancers, right1), new(Song_25, left1));
    public static DoorData Cog_Dancers__top1 { get; } = new(new(Cog_Dancers, top1), new(Cog_08, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Black Thread States/Normal World/harpoon_ring_gate/slide_gate_trapdoor", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "slide_gate_ring")),
            new ObstacleInfo("Boss Scene/Battle Gates/gate ground/hero blocker top", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess)
        ])
    };
    public static DoorData Cog_Pass__left1 { get; } = new(new(Cog_Pass, left1), new(Cog_Dancers, door1));
    public static DoorData Cog_Pass__left2 { get; } = new(new(Cog_Pass, left2), new(Cog_04, door2));
    public static DoorData Coral_02__bot2 { get; } = new(new(Coral_02, bot2), new(Coral_19, top2));
    public static DoorData Coral_02__right1 { get; } = new(new(Coral_02, right1), new(Coral_03, left3));
    public static DoorData Coral_03__bot1 { get; } = new(new(Coral_03, bot1), new(Coral_19, top3), null);
    public static DoorData Coral_03__bot2 { get; } = new(new(Coral_03, bot2), new(Coral_19, top4), null);
    public static DoorData Coral_03__bot3 { get; } = new(new(Coral_03, bot3), new(Coral_19, top5), null);
    public static DoorData Coral_03__bot4 { get; } = new(new(Coral_03, bot4), new(Coral_19, top6), null);
    public static DoorData Coral_03__bot5 { get; } = new(new(Coral_03, bot5), new(Coral_19, top7), null);
    public static DoorData Coral_03__bot6 { get; } = new(new(Coral_03, bot6), new(Coral_19, top8), null);
    public static DoorData Coral_03__left1 { get; } = new(new(Coral_03, left1), new(Bellway_08, right1));
    public static DoorData Coral_03__left2 { get; } = new(new(Coral_03, left2), new(Coral_11, right1));
    public static DoorData Coral_03__left3 { get; } = new(new(Coral_03, left3), new(Coral_02, right1));
    public static DoorData Coral_03__right1 { get; } = new(new(Coral_03, right1), new(Coral_32, left1));
    public static DoorData Coral_03__right2 { get; } = new(new(Coral_03, right2), new(Coral_12, left2));
    public static DoorData Coral_03__right3 { get; } = new(new(Coral_03, right3), new(Coral_12, left3));
    public static DoorData Coral_10__left_firstEntrance { get; } = new(new(Coral_10, left_firstEntrance));
    public static DoorData Coral_10__left1 { get; } = new(new(Coral_10, left1), new(Coral_Judge_Arena, right1))
    {
        Obstacles = new([
            // PlayerData.defeatedLastJudge
            new ObstacleInfo("closed gate", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess),
            new ObstacleInfo("Gate Quest Ender", ObstacleType.Other, ObstacleSeverity.ModifiesSaveData)
        ])
    };
    public static DoorData Coral_10__right1 { get; } = new(new(Coral_10, right1), new(Song_19_entrance, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Song Gate Entrance Right", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Coral10rightsidegate")),
        ])
    };
    public static DoorData Coral_11__left1 { get; } = new(new(Coral_11, left1), new(Coral_11b, right1));
    public static DoorData Coral_11__right1 { get; } = new(new(Coral_11, right1), new(Coral_03, left2));
    public static DoorData Coral_11b__left1 { get; } = new(new(Coral_11b, left1), new(Coral_34, right1));
    public static DoorData Coral_11b__right1 { get; } = new(new(Coral_11b, right1), new(Coral_11, left1));
    public static DoorData Coral_12__left2 { get; } = new(new(Coral_12, left2), new(Coral_03, right2));
    public static DoorData Coral_12__left3 { get; } = new(new(Coral_12, left3), new(Coral_03, right3));
    public static DoorData Coral_12__right1 { get; } = new(new(Coral_12, right1), new(Coral_37, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Coral_19__bot1 { get; } = new(new(Coral_19, bot1), new(Aspid_01, top1), null);
    public static DoorData Coral_19__bot2 { get; } = new(new(Coral_19, bot2), new(Aspid_01, top2), null);
    public static DoorData Coral_19__bot3 { get; } = new(new(Coral_19, bot3), new(Aspid_01, top3), null);
    public static DoorData Coral_19__bot4 { get; } = new(new(Coral_19, bot4), new(Aspid_01, top4), null);
    public static DoorData Coral_19__bot5 { get; } = new(new(Coral_19, bot5), new(Aspid_01, top5), null);
    public static DoorData Coral_19__bot6 { get; } = new(new(Coral_19, bot6), new(Aspid_01, top6), null);
    public static DoorData Coral_19__bot7 { get; } = new(new(Coral_19, bot7), new(Aspid_01, top7), null);
    public static DoorData Coral_19__right1 { get; } = new(new(Coral_19, right1), new(Shellwood_08, left1));
    public static DoorData Coral_19__top1 { get; } = new(new(Coral_19, top1), new(Coral_19b, bot1));
    public static DoorData Coral_19__top2 { get; } = new(new(Coral_19, top2), new(Coral_02, bot2));
    public static DoorData Coral_19__top3 { get; } = new(new(Coral_19, top3), new(Coral_19, top3), new(Coral_03, bot1));
    public static DoorData Coral_19__top4 { get; } = new(new(Coral_19, top4), new(Coral_19, top3), new(Coral_03, bot2));
    public static DoorData Coral_19__top5 { get; } = new(new(Coral_19, top5), new(Coral_19, top3), new(Coral_03, bot3));
    public static DoorData Coral_19__top6 { get; } = new(new(Coral_19, top6), new(Coral_19, top3), new(Coral_03, bot4));
    public static DoorData Coral_19__top7 { get; } = new(new(Coral_19, top7), new(Coral_19, top3), new(Coral_03, bot5));
    public static DoorData Coral_19__top8 { get; } = new(new(Coral_19, top8), new(Coral_19, top3), new(Coral_03, bot6));
    public static DoorData Coral_19b__bot1 { get; } = new(new(Coral_19b, bot1), new(Coral_19, top1));
    public static DoorData Coral_23__left1 { get; } = new(new(Coral_23, left1), new(Coral_25, right1));
    public static DoorData Coral_23__left2 { get; } = new(new(Coral_23, left2), new(Coral_39, right1));
    public static DoorData Coral_23__right1 { get; } = new(new(Coral_23, right1), new(Coral_35b, left3));
    public static DoorData Coral_24__left1 { get; } = new(new(Coral_24, left1), new(Coral_35b, right2));
    public static DoorData Coral_24__right1 { get; } = new(new(Coral_24, right1), new(Coral_26, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Tall (4)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Coral_25__bot1 { get; } = new(new(Coral_25, bot1), new(Coral_34, top1));
    public static DoorData Coral_25__right1 { get; } = new(new(Coral_25, right1), new(Coral_23, left1));
    public static DoorData Coral_26__left1 { get; } = new(new(Coral_26, left1), new(Coral_24, right1));
    public static DoorData Coral_26__left2 { get; } = new(new(Coral_26, left2), new(Coral_44, right1));
    public static DoorData Coral_26__right1 { get; } = new(new(Coral_26, right1), new(Coral_38, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Tall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Coral_27__left1 { get; } = new(new(Coral_27, left1), new(Coral_28, right1));
    public static DoorData Coral_27__right1 { get; } = new(new(Coral_27, right1), new(Coral_35b, left2));
    public static DoorData Coral_28__door1 { get; } = new(new(Coral_28, door1), new(Coral_Tower_01, left1));
    public static DoorData Coral_28__right1 { get; } = new(new(Coral_28, right1), new(Coral_27, left1));
    public static DoorData Coral_29__left1 { get; } = new(new(Coral_29, left1), new(Coral_35b, door1));
    public static DoorData Coral_32__left1 { get; } = new(new(Coral_32, left1), new(Coral_03, right1));
    public static DoorData Coral_32__right1 { get; } = new(new(Coral_32, right1), new(Coral_Judge_Arena, left1));
    public static DoorData Coral_32__top1 { get; } = new(new(Coral_32, top1), new(Coral_38, bot1));
    public static DoorData Coral_33__right1 { get; } = new(new(Coral_33, right1), new(Coral_43, left1));
    public static DoorData Coral_34__door1 { get; } = new(new(Coral_34, door1), new(Room_Pinstress, left1));
    public static DoorData Coral_34__right1 { get; } = new(new(Coral_34, right1), new(Coral_11b, left1));
    public static DoorData Coral_34__top1 { get; } = new(new(Coral_34, top1), new(Coral_25, bot1));
    public static DoorData Coral_35__left1 { get; } = new(new(Coral_35, left1), new(Coral_43, right1));
    public static DoorData Coral_35__left2 { get; } = new(new(Coral_35, left2), new(Coral_42, right1));
    public static DoorData Coral_35__right1 { get; } = new(new(Coral_35, right1), new(Bellway_08, left1));
    public static DoorData Coral_35__right2 { get; } = new(new(Coral_35, right2), new(Coral_36, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Coral_35__top1 { get; } = new(new(Coral_35, top1), new(Coral_35b, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("boulder_shortcut (1)", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Coral_35b, ID: "Stalactite Group Bottom"))
        ])
    };
    public static DoorData Coral_35b__bot1 { get; } = new(new(Coral_35b, bot1), new(Coral_35, top1))
    {
        Obstacles = new([
            new ObstacleInfo("boulder_shortcut", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(ID: "Stalactite Group Bottom")),
            new ObstacleInfo("boulder_shortcut/shortcut_block", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess),
        ])
    };
    public static DoorData Coral_35b__door1 { get; } = new(new(Coral_35b, door1), new(Coral_29, left1));
    public static DoorData Coral_35b__left2 { get; } = new(new(Coral_35b, left2), new(Coral_27, right1));
    public static DoorData Coral_35b__left3 { get; } = new(new(Coral_35b, left3), new(Coral_23, right1));
    public static DoorData Coral_35b__left4 { get; } = new(new(Coral_35b, left4), new(Coral_40, right1));
    public static DoorData Coral_35b__left5 { get; } = new(new(Coral_35b, left5), new(Coral_41, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Tall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Coral_35b__right1 { get; } = new(new(Coral_35b, right1), new(Coral_44, left1));
    public static DoorData Coral_35b__right2 { get; } = new(new(Coral_35b, right2), new(Coral_24, left1));
    public static DoorData Coral_36__left1 { get; } = new(new(Coral_36, left1), new(Coral_35, right2));
    public static DoorData Coral_37__left1 { get; } = new(new(Coral_37, left1), new(Coral_12, right1));
    public static DoorData Coral_38__bot1 { get; } = new(new(Coral_38, bot1), new(Coral_32, top1));
    public static DoorData Coral_38__left1 { get; } = new(new(Coral_38, left1), new(Coral_26, right1));
    public static DoorData Coral_38__right1 { get; } = new(new(Coral_38, right1), new(Bellshrine_Coral, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Coral Crust Wall Tall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Coral_39__right1 { get; } = new(new(Coral_39, right1), new(Coral_23, left2));
    public static DoorData Coral_40__right1 { get; } = new(new(Coral_40, right1), new(Coral_35b, left4));
    public static DoorData Coral_41__right1 { get; } = new(new(Coral_41, right1), new(Coral_35b, left5));
    public static DoorData Coral_42__right1 { get; } = new(new(Coral_42, right1), new(Coral_35, left2));
    public static DoorData Coral_43__left1 { get; } = new(new(Coral_43, left1), new(Coral_33, right1));
    public static DoorData Coral_43__right1 { get; } = new(new(Coral_43, right1), new(Coral_35, left1));
    public static DoorData Coral_44__left1 { get; } = new(new(Coral_44, left1), new(Coral_35b, right1));
    public static DoorData Coral_44__right1 { get; } = new(new(Coral_44, right1), new(Coral_26, left2));
    public static DoorData Coral_Judge_Arena__door_caravanTravelEnd { get; } = new(new(Coral_Judge_Arena, door_caravanTravelEnd));
    public static DoorData Coral_Judge_Arena__door2 { get; } = new(new(Coral_Judge_Arena, door2), new(Room_Caravan_Spa, left1), null);
    public static DoorData Coral_Judge_Arena__left1 { get; } = new(new(Coral_Judge_Arena, left1), new(Coral_32, right1));
    public static DoorData Coral_Judge_Arena__right1 { get; } = new(new(Coral_Judge_Arena, right1), new(Coral_10, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<BoxCollider2D>("Boss Scene/Great Gate/terrain collider", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("Boss Scene/Great Gate/Gate/Gate", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Black Thread States Thread Only Variant/Black Thread World/Big Battle Gate", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Coral_Tower_01__door_wakeOnGround { get; } = new(new(Coral_Tower_01, door_wakeOnGround));
    public static DoorData Coral_Tower_01__left1 { get; } = new(new(Coral_Tower_01, left1), new(Coral_28, door1));
    public static DoorData Cradle_01__left1 { get; } = new(new(Cradle_01, left1), new(Cradle_02, right2));
    public static DoorData Cradle_01__right1 { get; } = new(new(Cradle_01, right1), new(Tube_Hub, left4));
    public static DoorData Cradle_01_Destroyed__bot1 { get; } = new(new(Cradle_01_Destroyed, bot1), new(Song_Tower_Destroyed, top1));
    public static DoorData Cradle_01_Destroyed__top1 { get; } = new(new(Cradle_01_Destroyed, top1), new(Cradle_03_Destroyed, bot1));
    public static DoorData Cradle_02__left2 { get; } = new(new(Cradle_02, left2), new(Cradle_02b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("breakable blocker struts", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Cradle_02__right1 { get; } = new(new(Cradle_02, right1), new(Cradle_03, left2));
    public static DoorData Cradle_02__right2 { get; } = new(new(Cradle_02, right2), new(Cradle_01, left1));
    public static DoorData Cradle_02b__right1 { get; } = new(new(Cradle_02b, right1), new(Cradle_02, left2));
    public static DoorData Cradle_03__left2 { get; } = new(new(Cradle_03, left2), new(Cradle_02, right1));
    public static DoorData Cradle_03__right2 { get; } = new(new(Cradle_03, right2), new(Tube_Hub, left3));
    public static DoorData Cradle_03_Destroyed__bot1 { get; } = new(new(Cradle_03_Destroyed, bot1), new(Cradle_01_Destroyed, top1));
    public static DoorData Cradle_03_Destroyed__door1 { get; } = new(new(Cradle_03_Destroyed, door1), new(Cradle_Destroyed_Challenge_02, left1));
    public static DoorData Cradle_Destroyed_Challenge_01__left1 { get; } = new(new(Cradle_Destroyed_Challenge_01, left1), new(Cradle_Destroyed_Challenge_Bench, right1));
    public static DoorData Cradle_Destroyed_Challenge_01__top1 { get; } = new(new(Cradle_Destroyed_Challenge_01, top1), new(Abandoned_town, bot1));
    public static DoorData Cradle_Destroyed_Challenge_02__left1 { get; } = new(new(Cradle_Destroyed_Challenge_02, left1), new(Cradle_03_Destroyed, door1));
    public static DoorData Cradle_Destroyed_Challenge_02__top1 { get; } = new(new(Cradle_Destroyed_Challenge_02, top1), new(Cradle_Destroyed_Challenge_Bench, bot1));
    public static DoorData Cradle_Destroyed_Challenge_Bench__bot1 { get; } = new(new(Cradle_Destroyed_Challenge_Bench, bot1), new(Cradle_Destroyed_Challenge_02, top1));
    public static DoorData Cradle_Destroyed_Challenge_Bench__door1 { get; } = new(new(Cradle_Destroyed_Challenge_Bench, door1), new(Abandoned_town, door1));
    public static DoorData Cradle_Destroyed_Challenge_Bench__right1 { get; } = new(new(Cradle_Destroyed_Challenge_Bench, right1), new(Cradle_Destroyed_Challenge_01, left1));
    public static DoorData Crawl_01__left1 { get; } = new(new(Crawl_01, left1), new(Crawl_02, right1));
    public static DoorData Crawl_01__right1 { get; } = new(new(Crawl_01, right1), new(Aspid_01, left1));
    public static DoorData Crawl_02__left1 { get; } = new(new(Crawl_02, left1), new(Crawl_03, right1))
    {
        Obstacles = new([
            new ObstacleInfo("One Way Wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.crawl03_oneWayWall)))
        ])
    };
    public static DoorData Crawl_02__left2 { get; } = new(new(Crawl_02, left2), new(Crawl_03b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("aspid_sealed_gate_stone", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Crawl_02__right1 { get; } = new(new(Crawl_02, right1), new(Crawl_01, left1));
    public static DoorData Crawl_02__right2 { get; } = new(new(Crawl_02, right2), new(Crawl_04, left1));
    public static DoorData Crawl_02__right3 { get; } = new(new(Crawl_02, right3), new(Crawl_06, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Crawl_03__bot1 { get; } = new(new(Crawl_03, bot1), new(Crawl_03b, top1));
    public static DoorData Crawl_03__left1 { get; } = new(new(Crawl_03, left1), new(Crawl_05, right1));
    public static DoorData Crawl_03__right1 { get; } = new(new(Crawl_03, right1), new(Crawl_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Crawl_03__top1 { get; } = new(new(Crawl_03, top1), new(Crawl_08, bot1));
    public static DoorData Crawl_03b__bot1 { get; } = new(new(Crawl_03b, bot1), new(Crawl_07, top1));
    public static DoorData Crawl_03b__right1 { get; } = new(new(Crawl_03b, right1), new(Crawl_02, left2));
    public static DoorData Crawl_03b__top1 { get; } = new(new(Crawl_03b, top1), new(Crawl_03, bot1));
    public static DoorData Crawl_04__left1 { get; } = new(new(Crawl_04, left1), new(Crawl_02, right2));
    public static DoorData Crawl_04__right1 { get; } = new(new(Crawl_04, right1), new(Aspid_01, left2));
    public static DoorData Crawl_05__right1 { get; } = new(new(Crawl_05, right1), new(Crawl_03, left1));
    public static DoorData Crawl_06__left1 { get; } = new(new(Crawl_06, left1), new(Crawl_02, right3));
    public static DoorData Crawl_07__bot1 { get; } = new(new(Crawl_07, bot1), new(Bonegrave, top1));
    public static DoorData Crawl_07__left1 { get; } = new(new(Crawl_07, left1), new(Crawl_09, right1));
    public static DoorData Crawl_07__top1 { get; } = new(new(Crawl_07, top1), new(Crawl_03b, bot1));
    public static DoorData Crawl_08__bot1 { get; } = new(new(Crawl_08, bot1), new(Crawl_03, top1));
    public static DoorData Crawl_09__left1 { get; } = new(new(Crawl_09, left1), new(Crawl_10, right1))
    {
        Obstacles = new([
            new UnmaskerInfo("Breakable Wall/Masks"), // the wall fsm unparents the masks
            new ObstacleInfo("Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo()),
        ]),
    };
    public static DoorData Crawl_09__right1 { get; } = new(new(Crawl_09, right1), new(Crawl_07, left1));
    public static DoorData Crawl_10__right1 { get; } = new(new(Crawl_10, right1), new(Crawl_09, left1));
    public static DoorData Dock_01__left1 { get; } = new(new(Dock_01, left1), new(Dock_08, right1));
    public static DoorData Dock_01__right1 { get; } = new(new(Dock_01, right1), new(Bone_East_05, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Song_Gate_small", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(SceneName: Bone_East_05, ID: "Song_lever_side"))
        ])
    };
    public static DoorData Dock_01__right2 { get; } = new(new(Dock_01, right2), new(Bone_East_01, left1));
    public static DoorData Dock_02__left1 { get; } = new(new(Dock_02, left1), new(Room_Forge, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Song Knight Gate Backside", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedSongGateDocks)))
        ])
    };
    public static DoorData Dock_02__left2 { get; } = new(new(Dock_02, left2), new(Dock_09, right1));
    public static DoorData Dock_02__right1 { get; } = new(new(Dock_02, right1), new(Dock_02b, left1));
    public static DoorData Dock_02__right2 { get; } = new(new(Dock_02, right2), new(Dock_02b, left2));
    public static DoorData Dock_02__right3 { get; } = new(new(Dock_02, right3), new(Dock_02b, left3));
    public static DoorData Dock_02b__left1 { get; } = new(new(Dock_02b, left1), new(Dock_02, right1));
    public static DoorData Dock_02b__left2 { get; } = new(new(Dock_02b, left2), new(Dock_02, right2));
    public static DoorData Dock_02b__left3 { get; } = new(new(Dock_02b, left3), new(Dock_02, right3));
    public static DoorData Dock_02b__right1 { get; } = new(new(Dock_02b, right1), new(Dock_03, left1));
    public static DoorData Dock_02b__right2 { get; } = new(new(Dock_02b, right2), new(Dock_03c, left2));
    public static DoorData Dock_03__bot1 { get; } = new(new(Dock_03, bot1), new(Dock_03c, top2));
    public static DoorData Dock_03__left1 { get; } = new(new(Dock_03, left1), new(Dock_02b, right1));
    public static DoorData Dock_03__right1 { get; } = new(new(Dock_03, right1), new(Dock_03b, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall_Silhouette", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Camera Locks", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Dock_03b__left1 { get; } = new(new(Dock_03b, left1), new(Dock_03, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Dock_03b__right1 { get; } = new(new(Dock_03b, right1), new(Bone_East_07, left3));
    public static DoorData Dock_03c__left2 { get; } = new(new(Dock_03c, left2), new(Dock_02b, right2))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Dock_03c__top1 { get; } = new(new(Dock_03c, top1), new(Dock_03d, bot1));
    public static DoorData Dock_03c__top2 { get; } = new(new(Dock_03c, top2), new(Dock_03, bot1));
    public static DoorData Dock_03d__bot1 { get; } = new(new(Dock_03d, bot1), new(Dock_03c, top1));
    public static DoorData Dock_04__left1 { get; } = new(new(Dock_04, left1), new(Dock_06_Church, right1));
    public static DoorData Dock_04__right1 { get; } = new(new(Dock_04, right1), new(Room_Forge, left1));
    public static DoorData Dock_04__right2 { get; } = new(new(Dock_04, right2), new(Bone_East_13, left1));
    public static DoorData Dock_04__right3 { get; } = new(new(Dock_04, right3), new(Dock_10, left1));
    public static DoorData Dock_05__left1 { get; } = new(new(Dock_05, left1), new(Bone_East_01, right2));
    public static DoorData Dock_06_Church__bot1 { get; } = new(new(Dock_06_Church, bot1), new(Abyss_09, top1));
    public static DoorData Dock_06_Church__right1 { get; } = new(new(Dock_06_Church, right1), new(Dock_04, left1));
    public static DoorData Dock_08__left1 { get; } = new(new(Dock_08, left1), new(Bone_09, right1));
    public static DoorData Dock_08__left2 { get; } = new(new(Dock_08, left2), new(Bone_09, right2));
    public static DoorData Dock_08__right1 { get; } = new(new(Dock_08, right1), new(Dock_01, left1));
    public static DoorData Dock_09__left1 { get; } = new(new(Dock_09, left1), new(Dock_15, right1));
    public static DoorData Dock_09__right1 { get; } = new(new(Dock_09, right1), new(Dock_02, left2));
    public static DoorData Dock_10__left1 { get; } = new(new(Dock_10, left1), new(Dock_04, right3));
    public static DoorData Dock_10__right1 { get; } = new(new(Dock_10, right1), new(Dock_15, left1));
    public static DoorData Dock_11__left1 { get; } = new(new(Dock_11, left1), new(Dock_15, right3));
    public static DoorData Dock_11__right1 { get; } = new(new(Dock_11, right1), new(Dock_12, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Dock Pipe Grate Door (2)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Song_lever_side (2)")),
        ])
    };
    public static DoorData Dock_12__door1 { get; } = new(new(Dock_12, door1), new(Room_Diving_Bell, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Diving Bell/States", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Diving Bell/States/Standard/door1", true, ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("Diving Bell/States/Standard/Diving Bell Door", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Dock_12__left1 { get; } = new(new(Dock_12, left1), new(Dock_11, right1));
    public static DoorData Dock_13__right1 { get; } = new(new(Dock_13, right1), new(Dock_15, left2));
    public static DoorData Dock_14__left1 { get; } = new(new(Dock_14, left1), new(Dock_15, right2));
    public static DoorData Dock_15__left1 { get; } = new(new(Dock_15, left1), new(Dock_10, right1));
    public static DoorData Dock_15__left2 { get; } = new(new(Dock_15, left2), new(Dock_13, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Dock_15__right1 { get; } = new(new(Dock_15, right1), new(Dock_09, left1));
    public static DoorData Dock_15__right2 { get; } = new(new(Dock_15, right2), new(Dock_14, left1));
    public static DoorData Dock_15__right3 { get; } = new(new(Dock_15, right3), new(Dock_11, left1));
    public static DoorData Dock_16__right1 { get; } = new(new(Dock_16, right1), new(Bellway_02, left1));
    public static DoorData Dust_01__left1 { get; } = new(new(Dust_01, left1), new(Greymoor_03, right1));
    public static DoorData Dust_01__right1 { get; } = new(new(Dust_01, right1), new(Dust_02, left2));
    public static DoorData Dust_02__left1 { get; } = new(new(Dust_02, left1), new(Dust_10, right1));
    public static DoorData Dust_02__left2 { get; } = new(new(Dust_02, left2), new(Dust_01, right1));
    public static DoorData Dust_02__right1 { get; } = new(new(Dust_02, right1), new(Dust_04, left1))
    {
        Obstacles = new([
            new ObstacleInfo("grey_lever_gate_right_top", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Dust_02Gate")),
        ])
    };
    public static DoorData Dust_02__right2 { get; } = new(new(Dust_02, right2), new(Dust_04, left2));
    public static DoorData Dust_02__right3 { get; } = new(new(Dust_02, right3), new(Dust_03, left1));
    public static DoorData Dust_02__top1 { get; } = new(new(Dust_02, top1), new(Dust_05, bot1));
    public static DoorData Dust_03__bot1 { get; } = new(new(Dust_03, bot1), new(Dust_Barb, top1));
    public static DoorData Dust_03__left1 { get; } = new(new(Dust_03, left1), new(Dust_02, right3));
    public static DoorData Dust_03__top1 { get; } = new(new(Dust_03, top1), new(Dust_Chef, bot1));
    public static DoorData Dust_04__door1 { get; } = new(new(Dust_04, door1), new(Dust_Shack, left1));
    public static DoorData Dust_04__left1 { get; } = new(new(Dust_04, left1), new(Dust_02, right1))
    {
        Obstacles = new([
            new ObstacleInfo("grey_lever_gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(SceneName: Dust_02, ID: "Dust_02Gate")),
        ])
    };
    public static DoorData Dust_04__left2 { get; } = new(new(Dust_04, left2), new(Dust_02, right2));
    public static DoorData Dust_04__right1 { get; } = new(new(Dust_04, right1), new(Dust_Chef, left1))
    {
        Obstacles = new([
            new ObstacleInfo("gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(SceneName: Dust_Chef, ID: "greymoor_lever_simple")),
        ])
    };
    public static DoorData Dust_05__bot1 { get; } = new(new(Dust_05, bot1), new(Dust_02, top1));
    public static DoorData Dust_05__left1 { get; } = new(new(Dust_05, left1))
    {
        DynamicTargets = new([
            new(Dust_Maze_09_entrance, right1),
            new(Dust_Maze_08_completed, right1)
        ])
    };
    public static DoorData Dust_05__right1 { get; } = new(new(Dust_05, right1), new(Dust_06, left1))
    {
        Obstacles = new([
            new ObstacleInfo("greymoor_metal_gate/Gate Parent", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedDust05Gate))),
        ])
    };
    public static DoorData Dust_06__left1 { get; } = new(new(Dust_06, left1), new(Dust_05, right1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Dust_05 Gate", true, ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedDust05Gate))),
        ])
    };
    public static DoorData Dust_06__right1 { get; } = new(new(Dust_06, right1), new(Shadow_05, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.TwoWayBreakable, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Shadow_05))
        ])
    };
    public static DoorData Dust_06__right2 { get; } = new(new(Dust_06, right2), new(Dust_11, left1));
    public static DoorData Dust_06__right3 { get; } = new(new(Dust_06, right3), new(Dust_12, left1));
    public static DoorData Dust_09__door1 { get; } = new(new(Dust_09, door1), new(Organ_01, left1));
    public static DoorData Dust_09__door2 { get; } = new(new(Dust_09, door2), new(Organ_01, left2));
    public static DoorData Dust_09__left2 { get; } = new(new(Dust_09, left2))
    {
        DynamicTargets = new([
            new(Dust_Maze_Last_Hall, right1),
            new(Dust_Maze_08_completed, right2)
        ])
    };
    public static DoorData Dust_09__right1 { get; } = new(new(Dust_09, right1))
    {
        Obstacles = new([
            new ObstacleInfo("right_wall_one_way", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Shadow_04, ID: "Breakable Wall"))
        ]),
        DynamicTargets = new([
            new(Dust_Maze_Last_Hall, left1),
            new(Shadow_04, left1)
        ])
    };
    public static DoorData Dust_10__right1 { get; } = new(new(Dust_10, right1), new(Dust_02, left1));
    public static DoorData Dust_11__bot1 { get; } = new(new(Dust_11, bot1), new(Greymoor_17, top1));
    public static DoorData Dust_11__left1 { get; } = new(new(Dust_11, left1), new(Dust_06, right2));
    public static DoorData Dust_12__left1 { get; } = new(new(Dust_12, left1), new(Dust_06, right3));
    public static DoorData Dust_Barb__top1 { get; } = new(new(Dust_Barb, top1), new(Dust_03, bot1));
    public static DoorData Dust_Chef__bot1 { get; } = new(new(Dust_Chef, bot1), new(Dust_03, top1));
    public static DoorData Dust_Chef__left1 { get; } = new(new(Dust_Chef, left1), new(Dust_04, right1))
    {
        Obstacles = new([
            new ObstacleInfo("dust_chef_door_inner/gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "greymoor_lever_simple")),
        ])
    };
    public static DoorData Dust_Maze_01__left1 { get; } = new(new(Dust_Maze_01, left1));
    public static DoorData Dust_Maze_01__right1 { get; } = new(new(Dust_Maze_01, right1));
    public static DoorData Dust_Maze_01__top1 { get; } = new(new(Dust_Maze_01, top1));
    public static DoorData Dust_Maze_02__bot1 { get; } = new(new(Dust_Maze_02, bot1));
    public static DoorData Dust_Maze_02__left1 { get; } = new(new(Dust_Maze_02, left1));
    public static DoorData Dust_Maze_02__left2 { get; } = new(new(Dust_Maze_02, left2));
    public static DoorData Dust_Maze_02__right1 { get; } = new(new(Dust_Maze_02, right1));
    public static DoorData Dust_Maze_02__top1 { get; } = new(new(Dust_Maze_02, top1));
    public static DoorData Dust_Maze_03__left1 { get; } = new(new(Dust_Maze_03, left1));
    public static DoorData Dust_Maze_03__left2 { get; } = new(new(Dust_Maze_03, left2));
    public static DoorData Dust_Maze_03__right1 { get; } = new(new(Dust_Maze_03, right1));
    public static DoorData Dust_Maze_03__top1 { get; } = new(new(Dust_Maze_03, top1));
    public static DoorData Dust_Maze_04__bot1 { get; } = new(new(Dust_Maze_04, bot1));
    public static DoorData Dust_Maze_04__left1 { get; } = new(new(Dust_Maze_04, left1));
    public static DoorData Dust_Maze_04__right1 { get; } = new(new(Dust_Maze_04, right1));
    public static DoorData Dust_Maze_04__top1 { get; } = new(new(Dust_Maze_04, top1));
    public static DoorData Dust_Maze_04__top1_1 { get; } = new(new(Dust_Maze_04, top1_1));
    public static DoorData Dust_Maze_05__bot1 { get; } = new(new(Dust_Maze_05, bot1));
    public static DoorData Dust_Maze_05__left1 { get; } = new(new(Dust_Maze_05, left1));
    public static DoorData Dust_Maze_05__right1 { get; } = new(new(Dust_Maze_05, right1));
    public static DoorData Dust_Maze_05__right2 { get; } = new(new(Dust_Maze_05, right2));
    public static DoorData Dust_Maze_05__top1 { get; } = new(new(Dust_Maze_05, top1));
    public static DoorData Dust_Maze_06__left1 { get; } = new(new(Dust_Maze_06, left1));
    public static DoorData Dust_Maze_06__right1 { get; } = new(new(Dust_Maze_06, right1));
    public static DoorData Dust_Maze_06__top1 { get; } = new(new(Dust_Maze_06, top1));
    public static DoorData Dust_Maze_07__bot1 { get; } = new(new(Dust_Maze_07, bot1));
    public static DoorData Dust_Maze_07__left1 { get; } = new(new(Dust_Maze_07, left1));
    public static DoorData Dust_Maze_07__top1 { get; } = new(new(Dust_Maze_07, top1));
    public static DoorData Dust_Maze_08__left1 { get; } = new(new(Dust_Maze_08, left1));
    public static DoorData Dust_Maze_08__right2 { get; } = new(new(Dust_Maze_08, right2));
    public static DoorData Dust_Maze_08__right3 { get; } = new(new(Dust_Maze_08, right3));
    public static DoorData Dust_Maze_08__top1 { get; } = new(new(Dust_Maze_08, top1));
    public static DoorData Dust_Maze_08_completed__right1 { get; } = new(new(Dust_Maze_08_completed, right1), new(Dust_05, left1), null)
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
        ])
    };
    public static DoorData Dust_Maze_08_completed__right2 { get; } = new(new(Dust_Maze_08_completed, right2), new(Dust_09, left2), null);
    public static DoorData Dust_Maze_09_entrance__left1 { get; } = new(new(Dust_Maze_09_entrance, left1));
    public static DoorData Dust_Maze_09_entrance__right1 { get; } = new(new(Dust_Maze_09_entrance, right1));
    public static DoorData Dust_Maze_crossing__left1 { get; } = new(new(Dust_Maze_crossing, left1));
    public static DoorData Dust_Maze_crossing__right1 { get; } = new(new(Dust_Maze_crossing, right1));
    public static DoorData Dust_Maze_Last_Hall__left1 { get; } = new(new(Dust_Maze_Last_Hall, left1));
    public static DoorData Dust_Maze_Last_Hall__right1 { get; } = new(new(Dust_Maze_Last_Hall, right1));
    public static DoorData Dust_Shack__left1 { get; } = new(new(Dust_Shack, left1), new(Dust_04, door1));
    public static DoorData Greymoor_01__bot1 { get; } = new(new(Greymoor_01, bot1), new(Bone_East_11, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Floor Control Scene/Floor Unbroken", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.crashedIntoGreymoor))),
            new GameObjectActiveObstacleInfo("Floor Control Scene/Floor Broken", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Greymoor_01__left1 { get; } = new(new(Greymoor_01, left1), new(Greymoor_12, right1));
    public static DoorData Greymoor_01__left2 { get; } = new(new(Greymoor_01, left2), new(Greymoor_13, right1));
    public static DoorData Greymoor_01__right1 { get; } = new(new(Greymoor_01, right1), new(Greymoor_02, left1));
    public static DoorData Greymoor_01__right2 { get; } = new(new(Greymoor_01, right2), new(Bellshrine_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Bellshrine gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineGreymoor)))
        ])
    };
    public static DoorData Greymoor_01__right3 { get; } = new(new(Greymoor_01, right3), new(Greymoor_02, left3));
    public static DoorData Greymoor_02__left1 { get; } = new(new(Greymoor_02, left1), new(Greymoor_01, right1));
    public static DoorData Greymoor_02__left2 { get; } = new(new(Greymoor_02, left2), new(Bellshrine_02, right1));
    public static DoorData Greymoor_02__left3 { get; } = new(new(Greymoor_02, left3), new(Greymoor_01, right3));
    public static DoorData Greymoor_02__right1 { get; } = new(new(Greymoor_02, right1), new(Greymoor_15, left1));
    public static DoorData Greymoor_02__right2 { get; } = new(new(Greymoor_02, right2), new(Greymoor_17, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks"),
            new ObstacleInfo("Camera Locks", ObstacleType.Mask, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Greymoor_02__right3 { get; } = new(new(Greymoor_02, right3), new(Greymoor_15, left3));
    public static DoorData Greymoor_03__left1 { get; } = new(new(Greymoor_03, left1), new(Greymoor_04, right1));
    public static DoorData Greymoor_03__left2 { get; } = new(new(Greymoor_03, left2), new(Greymoor_04, right2));
    public static DoorData Greymoor_03__left3 { get; } = new(new(Greymoor_03, left3), new(Halfway_01, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Grey Door", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Halfway_01, ID: "Hornet_pressure_plate_small_persistent"))
        ])
    };
    public static DoorData Greymoor_03__right1 { get; } = new(new(Greymoor_03, right1), new(Dust_01, left1));
    public static DoorData Greymoor_03__right2 { get; } = new(new(Greymoor_03, right2), new(Greymoor_12, left1));
    public static DoorData Greymoor_03__right3 { get; } = new(new(Greymoor_03, right3), new(Greymoor_13, left1));
    public static DoorData Greymoor_03__right4 { get; } = new(new(Greymoor_03, right4), new(Halfway_01, left1));
    public static DoorData Greymoor_03__right5 { get; } = new(new(Greymoor_03, right5), new(Greymoor_24, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Greymoor_04__left1 { get; } = new(new(Greymoor_04, left1), new(Greymoor_11, right1));
    public static DoorData Greymoor_04__left2 { get; } = new(new(Greymoor_04, left2), new(Greymoor_10, right1));
    public static DoorData Greymoor_04__left3 { get; } = new(new(Greymoor_04, left3), new(Greymoor_05, right1));
    public static DoorData Greymoor_04__right1 { get; } = new(new(Greymoor_04, right1), new(Greymoor_03, left1));
    public static DoorData Greymoor_04__right2 { get; } = new(new(Greymoor_04, right2), new(Greymoor_03, left2));
    public static DoorData Greymoor_05__left1 { get; } = new(new(Greymoor_05, left1), new(Greymoor_06, right3));
    public static DoorData Greymoor_05__left2 { get; } = new(new(Greymoor_05, left2), new(Greymoor_06, right4));
    public static DoorData Greymoor_05__right1 { get; } = new(new(Greymoor_05, right1), new(Greymoor_04, left3));
    public static DoorData Greymoor_05__right2 { get; } = new(new(Greymoor_05, right2), new(Bellway_04, left1));
    public static DoorData Greymoor_06__left1 { get; } = new(new(Greymoor_06, left1), new(Wisp_03, right1));
    public static DoorData Greymoor_06__left2 { get; } = new(new(Greymoor_06, left2), new(Greymoor_07, right1));
    public static DoorData Greymoor_06__left3 { get; } = new(new(Greymoor_06, left3), new(Greymoor_07, right2));
    public static DoorData Greymoor_06__right1 { get; } = new(new(Greymoor_06, right1), new(Greymoor_11, left1));
    public static DoorData Greymoor_06__right2 { get; } = new(new(Greymoor_06, right2), new(Greymoor_10, left1));
    public static DoorData Greymoor_06__right3 { get; } = new(new(Greymoor_06, right3), new(Greymoor_05, left1));
    public static DoorData Greymoor_06__right4 { get; } = new(new(Greymoor_06, right4), new(Greymoor_05, left2));
    public static DoorData Greymoor_06__top1 { get; } = new(new(Greymoor_06, top1), new(Wisp_04, bot1));
    public static DoorData Greymoor_07__bot1 { get; } = new(new(Greymoor_07, bot1), new(Greymoor_08, top1));
    public static DoorData Greymoor_07__left1 { get; } = new(new(Greymoor_07, left1), new(Greymoor_20b, right1));
    public static DoorData Greymoor_07__right1 { get; } = new(new(Greymoor_07, right1), new(Greymoor_06, left2));
    public static DoorData Greymoor_07__right2 { get; } = new(new(Greymoor_07, right2), new(Greymoor_06, left3));
    public static DoorData Greymoor_08__door_caravanTravelEnd { get; } = new(new(Greymoor_08, door_caravanTravelEnd));
    public static DoorData Greymoor_08__door1 { get; } = new(new(Greymoor_08, door1), new(Room_Caravan_Interior, right1));
    public static DoorData Greymoor_08__door2 { get; } = new(new(Greymoor_08, door2), new(Room_Caravan_Spa, left1), null);
    public static DoorData Greymoor_08__left2 { get; } = new(new(Greymoor_08, left2), new(Belltown_06, right1));
    public static DoorData Greymoor_08__right1 { get; } = new(new(Greymoor_08, right1), new(Greymoor_16, left1));
    public static DoorData Greymoor_08__top1 { get; } = new(new(Greymoor_08, top1), new(Greymoor_07, bot1));
    public static DoorData Greymoor_10__left1 { get; } = new(new(Greymoor_10, left1), new(Greymoor_06, right2));
    public static DoorData Greymoor_10__right1 { get; } = new(new(Greymoor_10, right1), new(Greymoor_04, left2));
    public static DoorData Greymoor_11__left1 { get; } = new(new(Greymoor_11, left1), new(Greymoor_06, right1));
    public static DoorData Greymoor_11__right1 { get; } = new(new(Greymoor_11, right1), new(Greymoor_04, left1));
    public static DoorData Greymoor_12__left1 { get; } = new(new(Greymoor_12, left1), new(Greymoor_03, right2));
    public static DoorData Greymoor_12__right1 { get; } = new(new(Greymoor_12, right1), new(Greymoor_01, left1));
    public static DoorData Greymoor_13__bot1 { get; } = new(new(Greymoor_13, bot1), new(Greymoor_21, top1));
    public static DoorData Greymoor_13__left1 { get; } = new(new(Greymoor_13, left1), new(Greymoor_03, right3));
    public static DoorData Greymoor_13__right1 { get; } = new(new(Greymoor_13, right1), new(Greymoor_01, left2));
    public static DoorData Greymoor_15__left1 { get; } = new(new(Greymoor_15, left1), new(Greymoor_02, right1));
    public static DoorData Greymoor_15__left3 { get; } = new(new(Greymoor_15, left3), new(Greymoor_02, right3));
    public static DoorData Greymoor_15__right2 { get; } = new(new(Greymoor_15, right2), new(Greymoor_15b, left2));
    public static DoorData Greymoor_15__right3 { get; } = new(new(Greymoor_15, right3), new(Greymoor_15b, left3));
    public static DoorData Greymoor_15b__door1 { get; } = new(new(Greymoor_15b, door1), new(Room_CrowCourt, left1));
    public static DoorData Greymoor_15b__left2 { get; } = new(new(Greymoor_15b, left2), new(Greymoor_15, right2));
    public static DoorData Greymoor_15b__left3 { get; } = new(new(Greymoor_15b, left3), new(Greymoor_15, right3));
    public static DoorData Greymoor_15b__right1 { get; } = new(new(Greymoor_15b, right1), new(Clover_01, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Clover Entry Gate (1)", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataIntSaveInfo("GreenPrinceLocation", (int)GreenPrinceLocations.Clover))
        ])
    };
    public static DoorData Greymoor_15b__top1 { get; } = new(new(Greymoor_15b, top1), new(Greymoor_22, bot1));
    public static DoorData Greymoor_16__left1 { get; } = new(new(Greymoor_16, left1), new(Greymoor_08, right1));
    public static DoorData Greymoor_16__top1 { get; } = new(new(Greymoor_16, top1), new(Bellway_04, bot1));
    public static DoorData Greymoor_17__left1 { get; } = new(new(Greymoor_17, left1), new(Greymoor_02, right2));
    public static DoorData Greymoor_17__top1 { get; } = new(new(Greymoor_17, top1), new(Dust_11, bot1));
    public static DoorData Greymoor_20b__door1 { get; } = new(new(Greymoor_20b, door1), new(Greymoor_20c, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayMakerFSM>("Chapel Door Control", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.ModifiesSaveData | ObstacleSeverity.LimitsExitAccess),
            new TransitionObstacleInfo("Chapel Door Control/door1", true, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsExitAccess),
        ])
    };
    public static DoorData Greymoor_20b__right1 { get; } = new(new(Greymoor_20b, right1), new(Greymoor_07, left1));
    public static DoorData Greymoor_20c__door_memoryEnd { get; } = new(new(Greymoor_20c, door_memoryEnd));
    public static DoorData Greymoor_20c__left1 { get; } = new(new(Greymoor_20c, left1), new(Greymoor_20b, door1));
    public static DoorData Greymoor_21__top1 { get; } = new(new(Greymoor_21, top1), new(Greymoor_13, bot1));
    public static DoorData Greymoor_22__bot1 { get; } = new(new(Greymoor_22, bot1), new(Greymoor_15b, top1));
    public static DoorData Greymoor_24__left1 { get; } = new(new(Greymoor_24, left1), new(Greymoor_03, right5));
    public static DoorData Halfway_01__bot1 { get; } = new(new(Halfway_01, bot1), new(Ant_08, top1));
    public static DoorData Halfway_01__left1 { get; } = new(new(Halfway_01, left1), new(Greymoor_03, right4));
    public static DoorData Halfway_01__right1 { get; } = new(new(Halfway_01, right1), new(Greymoor_03, left3))
    {
        Obstacles = new([
            new ObstacleInfo("Grey Door Container", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Hornet_pressure_plate_small_persistent"))
        ])
    };
    public static DoorData Hang_01__right1 { get; } = new(new(Hang_01, right1), new(Hang_02, left1));
    public static DoorData Hang_01__right2 { get; } = new(new(Hang_01, right2), new(Song_17, left1));
    public static DoorData Hang_02__left1 { get; } = new(new(Hang_02, left1), new(Hang_01, right1));
    public static DoorData Hang_02__right1 { get; } = new(new(Hang_02, right1), new(Hang_03, left1));
    public static DoorData Hang_03__left1 { get; } = new(new(Hang_03, left1), new(Hang_02, right1));
    public static DoorData Hang_03__left2 { get; } = new(new(Hang_03, left2), new(Hang_15, right1));
    public static DoorData Hang_03__right1 { get; } = new(new(Hang_03, right1), new(Hang_13, left1));
    public static DoorData Hang_03__right2 { get; } = new(new(Hang_03, right2), new(Hang_10, left1))
    {
        Obstacles = new([
            new ObstacleInfo("sauna_grate", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.hang_10_oneWay)))
        ])
    };
    public static DoorData Hang_03__top1 { get; } = new(new(Hang_03, top1), new(Hang_03_top, bot1));
    public static DoorData Hang_03_top__bot1 { get; } = new(new(Hang_03_top, bot1), new(Hang_03, top1));
    public static DoorData Hang_04__left1 { get; } = new(new(Hang_04, left1), new(Hang_12, right1));
    public static DoorData Hang_04__right1 { get; } = new(new(Hang_04, right1), new(Hang_06, left1));
    public static DoorData Hang_06__bot1 { get; } = new(new(Hang_06, bot1), new(Hang_07, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Bot Blocker", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Hang_06__door1 { get; } = new(new(Hang_06, door1), new(Hang_06_bank, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<BoxCollider2D>("door1", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("bank_door", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Hang_06__left1 { get; } = new(new(Hang_06, left1), new(Hang_04, right1));
    public static DoorData Hang_06__right1 { get; } = new(new(Hang_06, right1), new(Hang_06b, left1));
    public static DoorData Hang_06__top1 { get; } = new(new(Hang_06, top1), new(Hang_08, bot1));
    public static DoorData Hang_06_bank__left1 { get; } = new(new(Hang_06_bank, left1), new(Hang_06, door1));
    public static DoorData Hang_06b__door_tubeEnter { get; } = new(new(Hang_06b, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("new_scene/City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Hang_06b__left1 { get; } = new(new(Hang_06b, left1), new(Hang_06, right1));
    public static DoorData Hang_07__bot1 { get; } = new(new(Hang_07, bot1), new(Song_09, top1));
    public static DoorData Hang_07__left1 { get; } = new(new(Hang_07, left1), new(Song_11, right2))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<PlayerDataTestResponse>("shortcut_states", false, ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.song_11_oneway))),
            new GameObjectActiveObstacleInfo("shortcut_states/closed", false, ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
            new GameObjectActiveObstacleInfo("shortcut_states/open", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Hang_07__right1 { get; } = new(new(Hang_07, right1), new(Cog_Dancers, left1));
    public static DoorData Hang_07__top1 { get; } = new(new(Hang_07, top1), new(Hang_06, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Song Knight Quest Parent/Blocker", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Hang_06, ID: "Bot Blocker"))
        ])
    };
    public static DoorData Hang_08__bot1 { get; } = new(new(Hang_08, bot1), new(Hang_06, top1));
    public static DoorData Hang_08__left1 { get; } = new(new(Hang_08, left1), new(Hang_13, right1));
    public static DoorData Hang_08__left2 { get; } = new(new(Hang_08, left2), new(Hang_09, right1));
    public static DoorData Hang_08__left3 { get; } = new(new(Hang_08, left3), new(Hang_10, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Hang_08__left4 { get; } = new(new(Hang_08, left4), new(Hang_16, right1));
    public static DoorData Hang_08__right1 { get; } = new(new(Hang_08, right1), new(Hang_17b, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Song_Knight_Wall", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility)
        ])
    };
    // public static DoorData Hang_08__right2 { get; } = new(new(Hang_08, right2), new(Cog_11_Destroyed, left1), null);
    public static DoorData Hang_09__right1 { get; } = new(new(Hang_09, right1), new(Hang_08, left2));
    public static DoorData Hang_10__left1 { get; } = new(new(Hang_10, left1), new(Hang_03, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Hang_10__right1 { get; } = new(new(Hang_10, right1), new(Hang_08, left3));
    public static DoorData Hang_12__right1 { get; } = new(new(Hang_12, right1), new(Hang_04, left1));
    public static DoorData Hang_13__left1 { get; } = new(new(Hang_13, left1), new(Hang_03, right1));
    public static DoorData Hang_13__right1 { get; } = new(new(Hang_13, right1), new(Hang_08, left1));
    public static DoorData Hang_14__left1 { get; } = new(new(Hang_14, left1), new(Hang_16, door1));
    public static DoorData Hang_15__right1 { get; } = new(new(Hang_15, right1), new(Hang_03, left2));
    public static DoorData Hang_16__door1 { get; } = new(new(Hang_16, door1), new(Hang_14, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Black Thread States Thread Only Variant/Black Thread World/Roof Collider_Basic", ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsRoomAccess),
            new ObstacleInfo("Black Thread States Thread Only Variant/Black Thread World/city_collapse_chunk_generic", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility)
        ])
    };
    public static DoorData Hang_16__right1 { get; } = new(new(Hang_16, right1), new(Hang_08, left4));
    public static DoorData Hang_17b__left1 { get; } = new(new(Hang_17b, left1), new(Hang_08, right1));
    public static DoorData Last_Dive__door_cutscenePosition { get; } = new(new(Last_Dive, door_cutscenePosition));
    public static DoorData Last_Dive_Return__door_cutscenePosition { get; } = new(new(Last_Dive_Return, door_cutscenePosition));
    public static DoorData Library_01__left1 { get; } = new(new(Library_01, left1), new(Library_02, right1));
    public static DoorData Library_01__left2 { get; } = new(new(Library_01, left2), new(Library_03, right1));
    public static DoorData Library_01__left3 { get; } = new(new(Library_01, left3), new(Library_15, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Black Thread States/Normal World/Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Library_01__right1 { get; } = new(new(Library_01, right1), new(Library_04, left1));
    public static DoorData Library_01__right2 { get; } = new(new(Library_01, right2), new(Library_04, left2));
    public static DoorData Library_02__left1 { get; } = new(new(Library_02, left1), new(Song_20b, right3));
    public static DoorData Library_02__left2 { get; } = new(new(Library_02, left2), new(Song_20b, right2));
    public static DoorData Library_02__right1 { get; } = new(new(Library_02, right1), new(Library_01, left1));
    public static DoorData Library_02__right2 { get; } = new(new(Library_02, right2), new(Song_Enclave, left2));
    public static DoorData Library_03__left1 { get; } = new(new(Library_03, left1), new(Song_20, right4));
    public static DoorData Library_03__right1 { get; } = new(new(Library_03, right1), new(Library_01, left2));
    public static DoorData Library_04__left1 { get; } = new(new(Library_04, left1), new(Library_01, right1));
    public static DoorData Library_04__left2 { get; } = new(new(Library_04, left2), new(Library_01, right2));
    public static DoorData Library_04__left3 { get; } = new(new(Library_04, left3), new(Library_13b, right1));
    public static DoorData Library_04__left4 { get; } = new(new(Library_04, left4), new(Library_16, right1));
    public static DoorData Library_04__right1 { get; } = new(new(Library_04, right1), new(Library_09, left1))
    {
        Obstacles = new([
            new ObstacleInfo("secret wall library slide/closed", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.libraryRoofShortcut))),
        ])
    };
    public static DoorData Library_04__right2 { get; } = new(new(Library_04, right2), new(Library_08, left1));
    public static DoorData Library_04__right3 { get; } = new(new(Library_04, right3), new(Library_05, left1));
    public static DoorData Library_04__right4 { get; } = new(new(Library_04, right4), new(Library_05, left2));
    public static DoorData Library_04__right5 { get; } = new(new(Library_04, right5), new(Library_10, left1));
    public static DoorData Library_04__right6 { get; } = new(new(Library_04, right6), new(Library_14, left1));
    public static DoorData Library_04__top1 { get; } = new(new(Library_04, top1), new(Song_Enclave, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("shortcut/One Way Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(ID: "Top Shortcut")),
            new GameObjectActiveObstacleInfo("shortcut/after_wall_glows", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Library_05__left1 { get; } = new(new(Library_05, left1), new(Library_04, right3));
    public static DoorData Library_05__left2 { get; } = new(new(Library_05, left2), new(Library_04, right4));
    public static DoorData Library_05__right1 { get; } = new(new(Library_05, right1), new(Library_06, left1));
    public static DoorData Library_05__right2 { get; } = new(new(Library_05, right2), new(Library_06, left2));
    public static DoorData Library_06__left1 { get; } = new(new(Library_06, left1), new(Library_05, right1));
    public static DoorData Library_06__left2 { get; } = new(new(Library_06, left2), new(Library_05, right2));
    public static DoorData Library_06__right1 { get; } = new(new(Library_06, right1), new(Library_07, left2));
    public static DoorData Library_07__bot1 { get; } = new(new(Library_07, bot1), new(Shadow_22, top1));
    public static DoorData Library_07__bot2 { get; } = new(new(Library_07, bot2), new(Shadow_22, top2));
    public static DoorData Library_07__bot3 { get; } = new(new(Library_07, bot3), new(Shadow_22, top3));
    public static DoorData Library_07__left1 { get; } = new(new(Library_07, left1), new(Library_08, right1));
    public static DoorData Library_07__left2 { get; } = new(new(Library_07, left2), new(Library_06, right1));
    public static DoorData Library_07__top1 { get; } = new(new(Library_07, top1), new(Library_09, bot1));
    public static DoorData Library_08__left1 { get; } = new(new(Library_08, left1), new(Library_04, right2));
    public static DoorData Library_08__right1 { get; } = new(new(Library_08, right1), new(Library_07, left1));
    public static DoorData Library_09__bot1 { get; } = new(new(Library_09, bot1), new(Library_07, top1));
    public static DoorData Library_09__left1 { get; } = new(new(Library_09, left1), new(Library_04, right1));
    public static DoorData Library_10__bot1 { get; } = new(new(Library_10, bot1), new(Library_12b, top1));
    public static DoorData Library_10__left1 { get; } = new(new(Library_10, left1), new(Library_04, right5));
    public static DoorData Library_11__left1 { get; } = new(new(Library_11, left1), new(Library_13, right2));
    public static DoorData Library_11__left2 { get; } = new(new(Library_11, left2), new(Bellway_City, right1));
    public static DoorData Library_11__left3 { get; } = new(new(Library_11, left3), new(Library_11b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Understore Big Plate Gate/terrain collider whole", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Understore Big Plate Gate")),
            new ObstacleInfo("Understore Big Plate Gate/Lever", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Mid Joiner", ObstacleType.Other,  ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Back Strut Top F", ObstacleType.Other,  ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Understore Big Plate Gate/Back Strut Top B", ObstacleType.Other,  ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Understore Big Plate Gate/Plate Top 1", ObstacleType.Other,  ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Plate Bot 1", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Block Top", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Block Bot", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
            new ObstacleInfo("Understore Big Plate Gate/Back Plate Top 1", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Understore Big Plate Gate/Back Plate Bot 1", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new ObstacleInfo("Understore Big Plate Gate/Masks", ObstacleType.Other, ObstacleSeverity.LimitsVisibility),
        ])
    };
    public static DoorData Library_11__right1 { get; } = new(new(Library_11, right1), new(Library_12, left1));
    public static DoorData Library_11__right2 { get; } = new(new(Library_11, right2), new(Library_12, left2));
    public static DoorData Library_11b__left3 { get; } = new(new(Library_11b, left3), new(Under_17, right1));
    public static DoorData Library_11b__right1 { get; } = new(new(Library_11b, right1), new(Library_11, left3))
    {
        Obstacles = new([
            new ObstacleInfo("door states (1)/Understore Big Plate Gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Library_11)),
        ])
    };
    public static DoorData Library_12__door1 { get; } = new(new(Library_12, door1), new(Organ_01, left3));
    public static DoorData Library_12__left1 { get; } = new(new(Library_12, left1), new(Library_11, right1));
    public static DoorData Library_12__left2 { get; } = new(new(Library_12, left2), new(Library_11, right2));
    public static DoorData Library_12__right1 { get; } = new(new(Library_12, right1), new(Library_12b, left1))
    {
        Obstacles = new([
            new ObstacleInfo("breakable blocker struts", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Library_12b__left1 { get; } = new(new(Library_12b, left1), new(Library_12, right1));
    public static DoorData Library_12b__top1 { get; } = new(new(Library_12b, top1), new(Library_10, bot1));
    public static DoorData Library_13__left1 { get; } = new(new(Library_13, left1), new(Song_20, right5));
    public static DoorData Library_13__right1 { get; } = new(new(Library_13, right1), new(Library_13b, left1));
    public static DoorData Library_13__right2 { get; } = new(new(Library_13, right2), new(Library_11, left1));
    public static DoorData Library_13b__left1 { get; } = new(new(Library_13b, left1), new(Library_13, right1));
    public static DoorData Library_13b__right1 { get; } = new(new(Library_13b, right1), new(Library_04, left3));
    public static DoorData Library_14__left1 { get; } = new(new(Library_14, left1), new(Library_04, right6));
    public static DoorData Library_15__right1 { get; } = new(new(Library_15, right1), new(Library_01, left3));
    public static DoorData Library_16__right1 { get; } = new(new(Library_16, right1), new(Library_04, left4));
    public static DoorData Memory_Ant_Queen__door_wakeInMemory { get; } = new(new(Memory_Ant_Queen, door_wakeInMemory));
    public static DoorData Memory_Coral_Tower__door_wakeInMemory { get; } = new(new(Memory_Coral_Tower, door_wakeInMemory));
    public static DoorData Memory_First_Sinner__door_wakeOnGround { get; } = new(new(Memory_First_Sinner, door_wakeOnGround));
    public static DoorData Memory_Needolin__door_wakeOnGround { get; } = new(new(Memory_Needolin, door_wakeOnGround));
    public static DoorData Memory_Needolin__left1 { get; } = new(new(Memory_Needolin, left1), new(Memory_Needolin, right1));
    public static DoorData Memory_Needolin__right1 { get; } = new(new(Memory_Needolin, right1), new(Memory_Needolin, left1));
    public static DoorData Memory_Red__door_enterRedMemory_Beast { get; } = new(new(Memory_Red, door_enterRedMemory_Beast), new(Memory_Red, door_wakeInRedMemory_Beast), null)
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Scenery Groups/Deepnest Scenery", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Memory_Red__door_enterRedMemory_Hive { get; } = new(new(Memory_Red, door_enterRedMemory_Hive), new(Memory_Red, door_wakeInRedMemory_Hive), null)
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Scenery Groups/Hive Scenery", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Memory_Red__door_enterRedMemory_Weaver { get; } = new(new(Memory_Red, door_enterRedMemory_Weaver), new(Memory_Red, door_wakeInRedMemory_Weaver), null)
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Scenery Groups/Entry Scenery", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Memory_Red__door_wakeInMemory { get; } = new(new(Memory_Red, door_wakeInMemory));
    public static DoorData Memory_Red__door_wakeInRedMemory_Beast { get; } = new(new(Memory_Red, door_wakeInRedMemory_Beast), null, new(Memory_Red, door_enterRedMemory_Beast));
    public static DoorData Memory_Red__door_wakeInRedMemory_Hive { get; } = new(new(Memory_Red, door_wakeInRedMemory_Hive), null, new(Memory_Red, door_enterRedMemory_Hive));
    public static DoorData Memory_Red__door_wakeInRedMemory_Root { get; } = new(new(Memory_Red, door_wakeInRedMemory_Root));
    public static DoorData Memory_Red__door_wakeInRedMemory_Weaver { get; } = new(new(Memory_Red, door_wakeInRedMemory_Weaver), null, new(Memory_Red, door_enterRedMemory_Weaver));
    public static DoorData Memory_Red__top1 { get; } = new(new(Memory_Red, top1));
    public static DoorData Memory_Silk_Heart_BellBeast__door_wakeOnGround { get; } = new(new(Memory_Silk_Heart_BellBeast, door_wakeOnGround));
    public static DoorData Memory_Silk_Heart_LaceTower__door_wakeOnGround { get; } = new(new(Memory_Silk_Heart_LaceTower, door_wakeOnGround));
    public static DoorData Memory_Silk_Heart_WardBoss__door_wakeOnGround { get; } = new(new(Memory_Silk_Heart_WardBoss, door_wakeOnGround));
    public static DoorData Mosstown_01__bot1 { get; } = new(new(Mosstown_01, bot1), new(Bone_11, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Bone Trapdoor Slide", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.mosstown01_shortcut)))
        ])
    };
    public static DoorData Mosstown_01__right1 { get; } = new(new(Mosstown_01, right1), new(Bone_05, left1));
    public static DoorData Mosstown_01__right2 { get; } = new(new(Mosstown_01, right2), new(Bone_05b, left1));
    public static DoorData Mosstown_01__top1 { get; } = new(new(Mosstown_01, top1), new(Mosstown_02, bot1));
    public static DoorData Mosstown_02__bot1 { get; } = new(new(Mosstown_02, bot1), new(Mosstown_01, top1));
    public static DoorData Mosstown_02__bot2 { get; } = new(new(Mosstown_02, bot2), new(Bone_05b, top1));
    public static DoorData Mosstown_02__left1 { get; } = new(new(Mosstown_02, left1), new(Aspid_01, right3))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Mosstown_02__right1 { get; } = new(new(Mosstown_02, right1), new(Mosstown_02c, left2));
    public static DoorData Mosstown_02c__left2 { get; } = new(new(Mosstown_02c, left2), new(Mosstown_02, right1));
    public static DoorData Mosstown_03__right1 { get; } = new(new(Mosstown_03, right1), new(Bone_06, left1))
    {
        Obstacles = new([
            new ObstacleInfo("explode_wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.explodeWallMosstown3)))
        ])
    };
    public static DoorData Mosstown_03__right2 { get; } = new(new(Mosstown_03, right2), new(Shellwood_25, left1));
    public static DoorData Mosstown_03__top1 { get; } = new(new(Mosstown_03, top1), new(Shellwood_03, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood Twig Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Organ_01__left1 { get; } = new(new(Organ_01, left1), new(Dust_09, door1));
    public static DoorData Organ_01__left2 { get; } = new(new(Organ_01, left2), new(Dust_09, door2));
    public static DoorData Organ_01__left3 { get; } = new(new(Organ_01, left3), new(Library_12, door1));
    public static DoorData Peak_01__left1 { get; } = new(new(Peak_01, left1), new(Peak_02, right4));
    public static DoorData Peak_01__left2 { get; } = new(new(Peak_01, left2), new(Peak_02, right1));
    public static DoorData Peak_01__left3 { get; } = new(new(Peak_01, left3), new(Peak_02, right2));
    public static DoorData Peak_01__left4 { get; } = new(new(Peak_01, left4), new(Peak_02, right3));
    public static DoorData Peak_01__right1 { get; } = new(new(Peak_01, right1), new(Slab_16, left1));
    public static DoorData Peak_01__right2 { get; } = new(new(Peak_01, right2), new(Slab_15, left1));
    public static DoorData Peak_01__right3 { get; } = new(new(Peak_01, right3), new(Slab_13, left1));
    public static DoorData Peak_01__right4 { get; } = new(new(Peak_01, right4), new(Slab_06, left1));
    public static DoorData Peak_01__top1 { get; } = new(new(Peak_01, top1), new(Peak_07, bot1));
    public static DoorData Peak_01__top2 { get; } = new(new(Peak_01, top2), new(Peak_07, bot2));
    public static DoorData Peak_01__top3 { get; } = new(new(Peak_01, top3), new(Peak_07, bot3), new(Peak_07, bot5));
    public static DoorData Peak_01__top4 { get; } = new(new(Peak_01, top4), new(Peak_07, bot3), null);
    public static DoorData Peak_02__left1 { get; } = new(new(Peak_02, left1), new(Peak_04d, right1));
    public static DoorData Peak_02__left2 { get; } = new(new(Peak_02, left2), new(Peak_10, right1));
    public static DoorData Peak_02__left3 { get; } = new(new(Peak_02, left3), new(Peak_05e, right1));
    public static DoorData Peak_02__right1 { get; } = new(new(Peak_02, right1), new(Peak_01, left2));
    public static DoorData Peak_02__right2 { get; } = new(new(Peak_02, right2), new(Peak_01, left3));
    public static DoorData Peak_02__right3 { get; } = new(new(Peak_02, right3), new(Peak_01, left4));
    public static DoorData Peak_02__right4 { get; } = new(new(Peak_02, right4), new(Peak_01, left1));
    public static DoorData Peak_04__left1 { get; } = new(new(Peak_04, left1), new(Bellway_Peak, right1));
    public static DoorData Peak_04__right1 { get; } = new(new(Peak_04, right1), new(Peak_04d, left1));
    public static DoorData Peak_04c__right1 { get; } = new(new(Peak_04c, right1), new(Bellway_Peak, left1));
    public static DoorData Peak_04c__right2 { get; } = new(new(Peak_04c, right2), new(Bellway_Peak, left2))
    {
        Obstacles = new([
            new ObstacleInfo("One Way Wall Crystal", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Peak_04d__left1 { get; } = new(new(Peak_04d, left1), new(Peak_04, right1));
    public static DoorData Peak_04d__right1 { get; } = new(new(Peak_04d, right1), new(Peak_02, left1));
    public static DoorData Peak_05__bot1 { get; } = new(new(Peak_05, bot1), new(Bellway_Peak, top1));
    public static DoorData Peak_05__right3 { get; } = new(new(Peak_05, right3), new(Peak_05c, left2));
    public static DoorData Peak_05__top2 { get; } = new(new(Peak_05, top2), new(Peak_08, bot1));
    public static DoorData Peak_05c__left2 { get; } = new(new(Peak_05c, left2), new(Peak_05, right3));
    public static DoorData Peak_05c__right1 { get; } = new(new(Peak_05c, right1), new(Peak_05e, left1));
    public static DoorData Peak_05d__bot1 { get; } = new(new(Peak_05d, bot1), new(Peak_08, top1));
    public static DoorData Peak_05d__door1 { get; } = new(new(Peak_05d, door1), new(Peak_Mask_Maker, right1));
    public static DoorData Peak_05e__left1 { get; } = new(new(Peak_05e, left1), new(Peak_05c, right1));
    public static DoorData Peak_05e__right1 { get; } = new(new(Peak_05e, right1), new(Peak_02, left3));
    public static DoorData Peak_05e__right2 { get; } = new(new(Peak_05e, right2), new(Peak_06b, left1));
    public static DoorData Peak_06__left1 { get; } = new(new(Peak_06, left1), new(Peak_06b, door1));
    public static DoorData Peak_06b__door1 { get; } = new(new(Peak_06b, door1), new(Peak_06, left1));
    public static DoorData Peak_06b__left1 { get; } = new(new(Peak_06b, left1), new(Peak_05e, right2));
    public static DoorData Peak_07__bot1 { get; } = new(new(Peak_07, bot1), new(Peak_01, top1));
    // public static DoorData Peak_07__bot2 { get; } = new(new(Peak_07, bot2), new(Peak_01, top2));
    public static DoorData Peak_07__bot3 { get; } = new(new(Peak_07, bot3), new(Peak_01, top3), new(Peak_01, top4));
    public static DoorData Peak_07__bot4 { get; } = new(new(Peak_07, bot4), new(Peak_01, top3), null);
    public static DoorData Peak_07__bot5 { get; } = new(new(Peak_07, bot5), new(Peak_01, top3), null);
    public static DoorData Peak_07__top1 { get; } = new(new(Peak_07, top1), new(Peak_08b, bot4));
    public static DoorData Peak_07__top2 { get; } = new(new(Peak_07, top2), new(Peak_08b, bot5), new(Peak_08b, bot6));
    public static DoorData Peak_08__bot1 { get; } = new(new(Peak_08, bot1), new(Peak_05, top2));
    public static DoorData Peak_08__right1 { get; } = new(new(Peak_08, right1), new(Peak_08b, left1));
    public static DoorData Peak_08__top1 { get; } = new(new(Peak_08, top1), new(Peak_05d, bot1));
    public static DoorData Peak_08b__bot4 { get; } = new(new(Peak_08b, bot4), new(Peak_07, top1));
    public static DoorData Peak_08b__bot5 { get; } = new(new(Peak_08b, bot5), new(Peak_07, top2));
    public static DoorData Peak_08b__bot6 { get; } = new(new(Peak_08b, bot6), new(Peak_07, top2), null);
    public static DoorData Peak_08b__left1 { get; } = new(new(Peak_08b, left1), new(Peak_08, right1));
    public static DoorData Peak_08b__left2 { get; } = new(new(Peak_08b, left2), new(Peak_12, right1));
    public static DoorData Peak_10__right1 { get; } = new(new(Peak_10, right1), new(Peak_02, left2));
    public static DoorData Peak_12__right1 { get; } = new(new(Peak_12, right1), new(Peak_08b, left2));
    public static DoorData Peak_Mask_Maker__right1 { get; } = new(new(Peak_Mask_Maker, right1), new(Peak_05d, door1));
    public static DoorData Room_Caravan_Interior__right1 { get; } = new(new(Room_Caravan_Interior, right1), new(Greymoor_08, door1));
    public static DoorData Room_Caravan_Spa__left1 { get; } = new(new(Room_Caravan_Spa, left1))
    {
        DynamicTargets = new([
            new("Bone_10", door2),
            new("Greymoor_08", door2),
            new("Coral_Judge_Arena", door2),
            new("Aqueduct_05", door2)
        ])
    };
    public static DoorData Room_CrowCourt__bot1 { get; } = new(new(Room_CrowCourt, bot1), new(Room_CrowCourt_02, top1))
    {
        Obstacles = new([
            new ObstacleInfo("court_door", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.OpenedCrowSummonsDoor))),
            new ObstacleInfo("Door Mask", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility)
        ]),
    };
    public static DoorData Room_CrowCourt__left1 { get; } = new(new(Room_CrowCourt, left1), new(Greymoor_15b, door1));
    public static DoorData Room_CrowCourt_02__top1 { get; } = new(new(Room_CrowCourt_02, top1), new(Room_CrowCourt, bot1));
    public static DoorData Room_Diving_Bell__door_cinematicEnd { get; } = new(new(Room_Diving_Bell, door_cinematicEnd));
    public static DoorData Room_Diving_Bell__left1 { get; } = new(new(Room_Diving_Bell, left1), new(Dock_12, door1));
    public static DoorData Room_Diving_Bell_Abyss__door_wakeOnGround { get; } = new(new(Room_Diving_Bell_Abyss, door_wakeOnGround));
    public static DoorData Room_Diving_Bell_Abyss__left1 { get; } = new(new(Room_Diving_Bell_Abyss, left1), new(Abyss_03, door1))
    {
        Obstacles = new([
            new ObstacleInfo("diving_bell_door_breakable", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Room_Diving_Bell_Abyss_Fixed__door_cinematicEnd { get; } = new(new(Room_Diving_Bell_Abyss_Fixed, door_cinematicEnd));
    public static DoorData Room_Diving_Bell_Abyss_Fixed__left1 { get; } = new(new(Room_Diving_Bell_Abyss_Fixed, left1), new(Abyss_03, door2));
    public static DoorData Room_Forge__left1 { get; } = new(new(Room_Forge, left1), new(Dock_04, right1));
    public static DoorData Room_Forge__right1 { get; } = new(new(Room_Forge, right1), new(Dock_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("dock_sealed_gate/gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo("dock_sealed_gate")),
            new ObstacleInfo("dock_sealed_gate/song_knight_lock", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Room_Forge__top1 { get; } = new(new(Room_Forge, top1), new(Bone_East_12, bot1));
    public static DoorData Room_Huntress__left1 { get; } = new(new(Room_Huntress, left1), new(Aqueduct_04, door1));
    public static DoorData Room_Pinstress__left1 { get; } = new(new(Room_Pinstress, left1), new(Coral_34, door1));
    public static DoorData Room_Witch__left1 { get; } = new(new(Room_Witch, left1), new(Shellwood_Witch, door1));
    public static DoorData Shadow_01__left1 { get; } = new(new(Shadow_01, left1), new(Shadow_15, right1));
    public static DoorData Shadow_01__left2 { get; } = new(new(Shadow_01, left2), new(Shadow_14, right1));
    public static DoorData Shadow_01__left3 { get; } = new(new(Shadow_01, left3), new(Shadow_15, right2));
    public static DoorData Shadow_01__right1 { get; } = new(new(Shadow_01, right1), new(Shadow_16, left1));
    public static DoorData Shadow_01__right2 { get; } = new(new(Shadow_01, right2), new(Shadow_26, left1));
    public static DoorData Shadow_01__right3 { get; } = new(new(Shadow_01, right3), new(Shadow_18, left1));
    public static DoorData Shadow_01__top1 { get; } = new(new(Shadow_01, top1), new(Aqueduct_04, bot1));
    public static DoorData Shadow_02__left1 { get; } = new(new(Shadow_02, left1), new(Shadow_14, right2));
    public static DoorData Shadow_02__left2 { get; } = new(new(Shadow_02, left2), new(Shadow_04b, right1));
    public static DoorData Shadow_02__right1 { get; } = new(new(Shadow_02, right1), new(Shadow_26, left2));
    public static DoorData Shadow_02__right2 { get; } = new(new(Shadow_02, right2), new(Shadow_03, left1));
    public static DoorData Shadow_02__right3 { get; } = new(new(Shadow_02, right3), new(Shadow_23, left1));
    public static DoorData Shadow_03__left1 { get; } = new(new(Shadow_03, left1), new(Shadow_02, right2));
    public static DoorData Shadow_03__right1 { get; } = new(new(Shadow_03, right1), new(Shadow_09, left1));
    public static DoorData Shadow_03__top1 { get; } = new(new(Shadow_03, top1), new(Shadow_21, bot1));
    public static DoorData Shadow_04__left1 { get; } = new(new(Shadow_04, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ]),
        DynamicTargets = new([
            new(Dust_Maze_09_entrance, right1),
            new(Dust_09, right1)
        ])
    };
    public static DoorData Shadow_04__right1 { get; } = new(new(Shadow_04, right1), new(Shadow_04b, left1));
    public static DoorData Shadow_04__right2 { get; } = new(new(Shadow_04, right2), new(Bellway_Shadow, left1));
    public static DoorData Shadow_04__top1 { get; } = new(new(Shadow_04, top1), new(Shadow_20, bot1));
    public static DoorData Shadow_04b__left1 { get; } = new(new(Shadow_04b, left1), new(Shadow_04, right1));
    public static DoorData Shadow_04b__right1 { get; } = new(new(Shadow_04b, right1), new(Shadow_02, left2));
    public static DoorData Shadow_05__left1 { get; } = new(new(Shadow_05, left1), new(Dust_06, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.TwoWayBreakable, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shadow_05__right1 { get; } = new(new(Shadow_05, right1), new(Shadow_09, left2));
    public static DoorData Shadow_08__left1 { get; } = new(new(Shadow_08, left1), new(Shadow_27, right1))
    {
        Obstacles = new([
            new UnmaskerInfo("Masks"),
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Breakable Wall Swamp Shortcut", ObstacleType.Other, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo(ID: "BreakableWallSwampBenchShortcut"))
        ])
    };
    public static DoorData Shadow_08__top1 { get; } = new(new(Shadow_08, top1), new(Shadow_10, bot1));
    public static DoorData Shadow_09__left1 { get; } = new(new(Shadow_09, left1), new(Shadow_03, right1));
    public static DoorData Shadow_09__left2 { get; } = new(new(Shadow_09, left2), new(Shadow_05, right1));
    public static DoorData Shadow_09__left3 { get; } = new(new(Shadow_09, left3), new(Shadow_28, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shadow_09__right1 { get; } = new(new(Shadow_09, right1), new(Shadow_Weavehome, left1));
    public static DoorData Shadow_10__bot1 { get; } = new(new(Shadow_10, bot1), new(Shadow_08, top1))
    {
        Obstacles = new([
            new UnmaskerInfo("Masks"),
            new ObstacleInfo("Breakable Wall", ObstacleType.Other, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shadow_10__left1 { get; } = new(new(Shadow_10, left1), new(Shadow_16, right1));
    public static DoorData Shadow_10__right1 { get; } = new(new(Shadow_10, right1), new(Shadow_19, left2));
    public static DoorData Shadow_11__left1 { get; } = new(new(Shadow_11, left1), new(Shadow_26, right1));
    public static DoorData Shadow_11__right1 { get; } = new(new(Shadow_11, right1), new(Shadow_13, left1));
    public static DoorData Shadow_12__left1 { get; } = new(new(Shadow_12, left1), new(Shadow_18, right1));
    public static DoorData Shadow_12__right1 { get; } = new(new(Shadow_12, right1), new(Shadow_19, left1));
    public static DoorData Shadow_13__left1 { get; } = new(new(Shadow_13, left1), new(Shadow_11, right1));
    public static DoorData Shadow_14__right1 { get; } = new(new(Shadow_14, right1), new(Shadow_01, left2));
    public static DoorData Shadow_14__right2 { get; } = new(new(Shadow_14, right2), new(Shadow_02, left1));
    public static DoorData Shadow_15__right1 { get; } = new(new(Shadow_15, right1), new(Shadow_01, left1));
    public static DoorData Shadow_15__right2 { get; } = new(new(Shadow_15, right2), new(Shadow_01, left3));
    public static DoorData Shadow_16__left1 { get; } = new(new(Shadow_16, left1), new(Shadow_01, right1));
    public static DoorData Shadow_16__right1 { get; } = new(new(Shadow_16, right1), new(Shadow_10, left1));
    public static DoorData Shadow_18__door1 { get; } = new(new(Shadow_18, door1), new(Shadow_Bilehaven_Room, left1));
    public static DoorData Shadow_18__left1 { get; } = new(new(Shadow_18, left1), new(Shadow_01, right3));
    public static DoorData Shadow_18__right1 { get; } = new(new(Shadow_18, right1), new(Shadow_12, left1));
    public static DoorData Shadow_19__left1 { get; } = new(new(Shadow_19, left1), new(Shadow_12, right1));
    public static DoorData Shadow_19__left2 { get; } = new(new(Shadow_19, left2), new(Shadow_10, right1));
    public static DoorData Shadow_19__right1 { get; } = new(new(Shadow_19, right1), new(Shadow_25, left1));
    public static DoorData Shadow_19__right2 { get; } = new(new(Shadow_19, right2), new(Shadow_24, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Shakra Trail Quest Parent (1)", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility)
        ])
    };
    public static DoorData Shadow_20__bot1 { get; } = new(new(Shadow_20, bot1), new(Shadow_04, top1));
    public static DoorData Shadow_20__top1 { get; } = new(new(Shadow_20, top1), new(Shadow_22, bot1));
    public static DoorData Shadow_21__bot1 { get; } = new(new(Shadow_21, bot1), new(Shadow_03, top1));
    public static DoorData Shadow_22__bot1 { get; } = new(new(Shadow_22, bot1), new(Shadow_20, top1));
    public static DoorData Shadow_22__top1 { get; } = new(new(Shadow_22, top1), new(Library_07, bot1));
    public static DoorData Shadow_22__top2 { get; } = new(new(Shadow_22, top2), new(Library_07, bot2));
    public static DoorData Shadow_22__top3 { get; } = new(new(Shadow_22, top3), new(Library_07, bot3));
    public static DoorData Shadow_23__left1 { get; } = new(new(Shadow_23, left1), new(Shadow_02, right3));
    public static DoorData Shadow_24__left1 { get; } = new(new(Shadow_24, left1), new(Shadow_19, right2));
    public static DoorData Shadow_25__left1 { get; } = new(new(Shadow_25, left1), new(Shadow_19, right1));
    public static DoorData Shadow_26__left1 { get; } = new(new(Shadow_26, left1), new(Shadow_01, right2));
    public static DoorData Shadow_26__left2 { get; } = new(new(Shadow_26, left2), new(Shadow_02, right1));
    public static DoorData Shadow_26__right1 { get; } = new(new(Shadow_26, right1), new(Shadow_11, left1));
    public static DoorData Shadow_26__right2 { get; } = new(new(Shadow_26, right2), new(Shadow_27, left1));
    public static DoorData Shadow_27__left1 { get; } = new(new(Shadow_27, left1), new(Shadow_26, right2));
    public static DoorData Shadow_27__right1 { get; } = new(new(Shadow_27, right1), new(Shadow_08, left1))
    {
        Obstacles = new([
            new ObstacleInfo("shortcut", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Shadow_08, ID: "BreakableWallSwampBenchShortcut"))
        ])
    };
    public static DoorData Shadow_28__right1 { get; } = new(new(Shadow_28, right1), new(Shadow_09, left3));
    public static DoorData Shadow_Bilehaven_Room__left1 { get; } = new(new(Shadow_Bilehaven_Room, left1), new(Shadow_18, door1));
    public static DoorData Shadow_Weavehome__left1 { get; } = new(new(Shadow_Weavehome, left1), new(Shadow_09, right1));
    public static DoorData Shellgrave__bot1 { get; } = new(new(Shellgrave, bot1), new(Shellwood_04b, top2));
    public static DoorData Shellwood_01__left1 { get; } = new(new(Shellwood_01, left1), new(Shellwood_01b, right2));
    public static DoorData Shellwood_01__left2 { get; } = new(new(Shellwood_01, left2), new(Shellwood_02, right2))
    {
        Obstacles = new([
            new ObstacleInfo("GameObject (3)/Shellwood_large_gates (1)/Gate Parent/Gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(SceneName: Shellwood_02, ID: "Hornet_pressure_plate"))
        ])
    };
    public static DoorData Shellwood_01__right1 { get; } = new(new(Shellwood_01, right1), new(Belltown_Room_shellwood, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Wasp Scene/Hive Scene/Shellwood Hive", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_01__right2 { get; } = new(new(Shellwood_01, right2), new(Belltown_07, left1));
    public static DoorData Shellwood_01b__left1 { get; } = new(new(Shellwood_01b, left1), new(Shellwood_20, right1));
    public static DoorData Shellwood_01b__left2 { get; } = new(new(Shellwood_01b, left2), new(Shellwood_02, right1));
    public static DoorData Shellwood_01b__right1 { get; } = new(new(Shellwood_01b, right1), new(Shellwood_13, left2));
    public static DoorData Shellwood_01b__right2 { get; } = new(new(Shellwood_01b, right2), new(Shellwood_01, left1));
    public static DoorData Shellwood_01b__right3 { get; } = new(new(Shellwood_01b, right3), new(Shellwood_15, left1))
    {
        Obstacles = new([
            new ObstacleInfo("wall_patch", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.shellwoodTwigShortcut)))
        ])
    };
    public static DoorData Shellwood_02__left2 { get; } = new(new(Shellwood_02, left2), new(Shellwood_16, right1));
    public static DoorData Shellwood_02__left3 { get; } = new(new(Shellwood_02, left3), new(Shellwood_Witch, right1));
    public static DoorData Shellwood_02__right1 { get; } = new(new(Shellwood_02, right1), new(Shellwood_01b, left2));
    public static DoorData Shellwood_02__right2 { get; } = new(new(Shellwood_02, right2), new(Shellwood_01, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood_large_gates-EDITED (1)/Gate Parent", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Hornet_pressure_plate"))
        ])
    };
    public static DoorData Shellwood_03__bot1 { get; } = new(new(Shellwood_03, bot1), new(Mosstown_03, top1))
    {
        Obstacles = new([
            new ObstacleInfo("One Way Wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo(ID: "Shellwood Twig Wall"))
        ])
    };
    public static DoorData Shellwood_03__left1 { get; } = new(new(Shellwood_03, left1), new(Shellwood_19, right1));
    public static DoorData Shellwood_03__left3 { get; } = new(new(Shellwood_03, left3), new(Shellwood_04b, right1));
    public static DoorData Shellwood_03__right1 { get; } = new(new(Shellwood_03, right1), new(Shellwood_10, left3));
    public static DoorData Shellwood_03__right2 { get; } = new(new(Shellwood_03, right2), new(Shellwood_14, left1));
    public static DoorData Shellwood_03__right3 { get; } = new(new(Shellwood_03, right3), new(Shellwood_16, left1));
    public static DoorData Shellwood_04b__left1 { get; } = new(new(Shellwood_04b, left1), new(Shellwood_08c, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood Twig Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_04b__right1 { get; } = new(new(Shellwood_04b, right1), new(Shellwood_03, left3));
    public static DoorData Shellwood_04b__top1 { get; } = new(new(Shellwood_04b, top1), new(Shellwood_04c, bot1));
    public static DoorData Shellwood_04b__top2 { get; } = new(new(Shellwood_04b, top2), new(Shellgrave, bot1));
    public static DoorData Shellwood_04c__bot1 { get; } = new(new(Shellwood_04c, bot1), new(Shellwood_04b, top1));
    public static DoorData Shellwood_04c__top1 { get; } = new(new(Shellwood_04c, top1), new(Shellwood_08, bot1));
    public static DoorData Shellwood_08__bot1 { get; } = new(new(Shellwood_08, bot1), new(Shellwood_04c, top1));
    public static DoorData Shellwood_08__left1 { get; } = new(new(Shellwood_08, left1), new(Coral_19, right1));
    public static DoorData Shellwood_08__right1 { get; } = new(new(Shellwood_08, right1), new(Bellshrine_03, left1));
    public static DoorData Shellwood_08c__left1 { get; } = new(new(Shellwood_08c, left1), new(Aspid_01, right2));
    public static DoorData Shellwood_08c__right1 { get; } = new(new(Shellwood_08c, right1), new(Shellwood_04b, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood Twig Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_10__left1 { get; } = new(new(Shellwood_10, left1), new(Shellwood_11, right1));
    public static DoorData Shellwood_10__left2 { get; } = new(new(Shellwood_10, left2), new(Shellwood_11, right2));
    public static DoorData Shellwood_10__left3 { get; } = new(new(Shellwood_10, left3), new(Shellwood_03, right1));
    public static DoorData Shellwood_10__right1 { get; } = new(new(Shellwood_10, right1), new(Shellwood_26, left1));
    public static DoorData Shellwood_10__right2 { get; } = new(new(Shellwood_10, right2), new(Shellwood_20, left1));
    public static DoorData Shellwood_10__right3 { get; } = new(new(Shellwood_10, right3), new(Shellwood_18, left1));
    public static DoorData Shellwood_11__right1 { get; } = new(new(Shellwood_11, right1), new(Shellwood_10, left1));
    public static DoorData Shellwood_11__right2 { get; } = new(new(Shellwood_11, right2), new(Shellwood_10, left2));
    public static DoorData Shellwood_11b__door_wakeOnGround { get; } = new(new(Shellwood_11b, door_wakeOnGround));
    public static DoorData Shellwood_11b__right1 { get; } = new(new(Shellwood_11b, right1), new(Shellwood_22, door1));
    public static DoorData Shellwood_11b_Memory__door_wakeInMemory { get; } = new(new(Shellwood_11b_Memory, door_wakeInMemory));
    public static DoorData Shellwood_13__left1 { get; } = new(new(Shellwood_13, left1), new(Shellwood_18, right1));
    public static DoorData Shellwood_13__left2 { get; } = new(new(Shellwood_13, left2), new(Shellwood_01b, right1));
    public static DoorData Shellwood_13__right1 { get; } = new(new(Shellwood_13, right1), new(Belltown_04, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Bell Wall Tall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Bell Wall Tall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Bell Wall Tall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_14__left1 { get; } = new(new(Shellwood_14, left1), new(Shellwood_03, right2));
    public static DoorData Shellwood_15__left1 { get; } = new(new(Shellwood_15, left1), new(Shellwood_01b, right3))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood Twig Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_15__right1 { get; } = new(new(Shellwood_15, right1), new(Belltown_04, left2));
    public static DoorData Shellwood_16__left1 { get; } = new(new(Shellwood_16, left1), new(Shellwood_03, right3));
    public static DoorData Shellwood_16__right1 { get; } = new(new(Shellwood_16, right1), new(Shellwood_02, left2));
    public static DoorData Shellwood_18__left1 { get; } = new(new(Shellwood_18, left1), new(Shellwood_10, right3));
    public static DoorData Shellwood_18__right1 { get; } = new(new(Shellwood_18, right1), new(Shellwood_13, left1));
    public static DoorData Shellwood_18__top1 { get; } = new(new(Shellwood_18, top1), new(Shellwood_26, bot1));
    public static DoorData Shellwood_19__door_fastTravelExit { get; } = new(new(Shellwood_19, door_fastTravelExit));
    public static DoorData Shellwood_19__left1 { get; } = new(new(Shellwood_19, left1), new(Bellshrine_03, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Bellshrine gate (1)", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PlayerDataBoolSaveInfo(nameof(PlayerData.bellShrineShellwood)))
        ])
    };
    public static DoorData Shellwood_19__right1 { get; } = new(new(Shellwood_19, right1), new(Shellwood_03, left1));
    public static DoorData Shellwood_20__left1 { get; } = new(new(Shellwood_20, left1), new(Shellwood_10, right2));
    public static DoorData Shellwood_20__right1 { get; } = new(new(Shellwood_20, right1), new(Shellwood_01b, left1));
    public static DoorData Shellwood_22__door1 { get; } = new(new(Shellwood_22, door1), new(Shellwood_11b, right1));
    public static DoorData Shellwood_22__right1 { get; } = new(new(Shellwood_22, right1), new(Under_27, left1));
    public static DoorData Shellwood_25__door1 { get; } = new(new(Shellwood_25, door1), new(Shellwood_25b, left1))
    {
        Obstacles = new([
            new TransitionObstacleInfo("door1", true, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new ObstacleInfo("Witch Chapel Door Control", ObstacleType.ClosedAfterProgression, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Shellwood_25__left1 { get; } = new(new(Shellwood_25, left1), new(Mosstown_03, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Shellwood Twig Wall (3)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Shellwood Twig Wall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Shellwood Twig Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Shellwood Twig Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Shellwood_25b__door_curseSequenceEnd { get; } = new(new(Shellwood_25b, door_curseSequenceEnd));
    public static DoorData Shellwood_25b__left1 { get; } = new(new(Shellwood_25b, left1), new(Shellwood_25, door1));
    public static DoorData Shellwood_26__bot1 { get; } = new(new(Shellwood_26, bot1), new(Shellwood_18, top1));
    public static DoorData Shellwood_26__left1 { get; } = new(new(Shellwood_26, left1), new(Shellwood_10, right1));
    public static DoorData Shellwood_Witch__door1 { get; } = new(new(Shellwood_Witch, door1), new(Room_Witch, left1));
    public static DoorData Shellwood_Witch__right1 { get; } = new(new(Shellwood_Witch, right1), new(Shellwood_02, left3));
    public static DoorData Slab_01__left1 { get; } = new(new(Slab_01, left1), new(Slab_02, right1));
    public static DoorData Slab_01__right1 { get; } = new(new(Slab_01, right1), new(Song_04, left1));
    public static DoorData Slab_02__left1 { get; } = new(new(Slab_02, left1), new(Slab_03, right5))
    {
        Obstacles = new([
                new ObstacleInfo("slab_gate_simple (1)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "slab_jail_lever")),
                new ObstacleInfo("slab_gate_simple", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess),
                new ObstacleInfo("slab_gate_simple (7)", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility),
                new ObstacleInfo("slab_gate_simple (5)", ObstacleType.Mask, ObstacleSeverity.LimitsVisibility),
                new ObstacleInfo("slab_gate_simple (4)", ObstacleType.Mask, ObstacleSeverity.AbnormalVisual),
                new ObstacleInfo("slab_gate_simple (6)", ObstacleType.Mask, ObstacleSeverity.AbnormalVisual)
            ])
    };
    public static DoorData Slab_02__right1 { get; } = new(new(Slab_02, right1), new(Slab_01, left1));
    public static DoorData Slab_03__door_slabCaged { get; } = new(new(Slab_03, door_slabCaged));
    public static DoorData Slab_03__left1 { get; } = new(new(Slab_03, left1), new(Slab_16, right1));
    public static DoorData Slab_03__left2 { get; } = new(new(Slab_03, left2), new(Slab_15, right1));
    public static DoorData Slab_03__left3 { get; } = new(new(Slab_03, left3), new(Slab_14, right1));
    public static DoorData Slab_03__left4 { get; } = new(new(Slab_03, left4), new(Slab_13, right1));
    public static DoorData Slab_03__left5 { get; } = new(new(Slab_03, left5), new(Slab_04, right1));
    public static DoorData Slab_03__left6 { get; } = new(new(Slab_03, left6), new(Slab_05, right1))
    {
        Obstacles = new([
                new ObstacleInfo("Jail Gate Door (1)", ObstacleType.TwoWayMechanism, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Slab Lock (2)")),
                new BehaviourObstacleInfo<BoxCollider2D>("Slab Lock (2)", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            ])
    };
    public static DoorData Slab_03__left7 { get; } = new(new(Slab_03, left7), new(Slab_07, right1));
    public static DoorData Slab_03__left8 { get; } = new(new(Slab_03, left8), new(Slab_07, right2));
    public static DoorData Slab_03__right1 { get; } = new(new(Slab_03, right1), new(Slab_17, left1))
    {
        Obstacles = new([
                new ObstacleInfo("Jail Gate Door (2)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Slab Lock (1)")),
                new BehaviourObstacleInfo<BoxCollider2D>("Slab Lock (1)", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            ])
    };
    public static DoorData Slab_03__right2 { get; } = new(new(Slab_03, right2), new(Slab_18, left1))
    {
        Obstacles = new([
                new TestObjObstacleInfo("Cage_Rubbish", true, ObstacleType.OneWayBreakableExit, ObstacleSeverity.InterruptsEntry, new PlayerDataBoolSaveInfo(nameof(PlayerData.slab_03_rubbishCleared)))
            ])
    };
    public static DoorData Slab_03__right3 { get; } = new(new(Slab_03, right3), new(Slab_20, left1));
    public static DoorData Slab_03__right4 { get; } = new(new(Slab_03, right4), new(Slab_23, left1));
    public static DoorData Slab_03__right5 { get; } = new(new(Slab_03, right5), new(Slab_02, left1))
    {
        Obstacles = new([
                // the PersistentBool is for the lever on the other side, NOT for the gate
                new ObstacleInfo("slab_gate_entrance_inside/slab_gate_simple (2)", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(SceneName: Slab_02, ID: "slab_jail_lever"))
            ])
    };
    public static DoorData Slab_03__right7 { get; } = new(new(Slab_03, right7), new(Slab_19b, left1))
    {
        Obstacles = new ([
                new ObstacleInfo("Jail Gate Door (4)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Slab Lock (4)")),
                new BehaviourObstacleInfo<BoxCollider2D>("Slab Lock (4)", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            ])
    };
    public static DoorData Slab_03__right8 { get; } = new(new(Slab_03, right8), new(Slab_08, left1));
    public static DoorData Slab_03__right9 { get; } = new(new(Slab_03, right9), new(Slab_12, left1))
    {
        Obstacles = new([
                new ObstacleInfo("Coral Crust Wall Tall (2)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            ])
    };
    public static DoorData Slab_04__bot1 { get; } = new(new(Slab_04, bot1), new(Slab_05, top1));
    //public static DoorData Slab_04__door1 { get; } = new(new(Slab_04, door1), new(Slab_Cell_Quiet, left1), null);
    public static DoorData Slab_04__right1 { get; } = new(new(Slab_04, right1), new(Slab_03, left5));
    public static DoorData Slab_04__top1 { get; } = new(new(Slab_04, top1), new(Slab_13, bot1));
    public static DoorData Slab_05__bot1 { get; } = new(new(Slab_05, bot1), new(Slab_06, top1));
    public static DoorData Slab_05__right1 { get; } = new(new(Slab_05, right1), new(Slab_03, left6))
    {
        Obstacles = new([
                new ObstacleInfo("Jail Gate Door (2)", ObstacleType.TwoWayMechanism, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(ID: "Slab Lock (2)")),
                new BehaviourObstacleInfo<BoxCollider2D>("Slab Lock (2)", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            ])
    };
    public static DoorData Slab_05__top1 { get; } = new(new(Slab_05, top1), new(Slab_04, bot1));
    public static DoorData Slab_06__door_fastTravelExit { get; } = new(new(Slab_06, door_fastTravelExit));
    //public static DoorData Slab_06__door1 { get; } = new(new(Slab_06, door1), new(Slab_Cell_Quiet, left1), null);
    public static DoorData Slab_06__left1 { get; } = new(new(Slab_06, left1), new(Peak_01, right4));
    public static DoorData Slab_06__top1 { get; } = new(new(Slab_06, top1), new(Slab_05, bot1));
    public static DoorData Slab_07__right1 { get; } = new(new(Slab_07, right1), new(Slab_03, left7));
    public static DoorData Slab_07__right2 { get; } = new(new(Slab_07, right2), new(Slab_03, left8));
    public static DoorData Slab_08__door1 { get; } = new(new(Slab_08, door1), new(Slab_Cell_Quiet, left2));
    public static DoorData Slab_08__left1 { get; } = new(new(Slab_08, left1), new(Slab_03, right8));
    public static DoorData Slab_10b__door_wakeOnGround { get; } = new(new(Slab_10b, door_wakeOnGround));
    public static DoorData Slab_10b__left1 { get; } = new(new(Slab_10b, left1), new(Slab_10c, door1));
    public static DoorData Slab_10c__door1 { get; } = new(new(Slab_10c, door1), new(Slab_10b, left1))
    {
        Obstacles = new ([
                new BehaviourObstacleInfo<PlayMakerFSM>("Break Gate Group", false, ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess),
                new TransitionObstacleInfo("Break Gate Group/door1", true, ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess),
                new ObstacleInfo("Break Gate Group/slab_break_weaver_gate_ring", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo()),
                new ObstacleInfo("Break Gate Group/slab_break_weaver_gate_ring (1)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo()),
                new ObstacleInfo("Break Gate Group/slab_break_weaver_gate_ring (2)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo()),
                new ObstacleInfo("Break Gate Group/slab_break_weaver_gate_ring (3)", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo()),
                new ObstacleInfo("Break Gate Group/Group", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess),
                new ObstacleInfo("Break Gate Group/dampening shield", ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            ])
    };
    public static DoorData Slab_10c__left1 { get; } = new(new(Slab_10c, left1), new(Slab_19b, right1));
    public static DoorData Slab_12__left1 { get; } = new(new(Slab_12, left1), new(Slab_03, right9));
    public static DoorData Slab_13__bot1 { get; } = new(new(Slab_13, bot1), new(Slab_04, top1));
    public static DoorData Slab_13__door1 { get; } = new(new(Slab_13, door1), new(Slab_Cell, left1));
    public static DoorData Slab_13__left1 { get; } = new(new(Slab_13, left1), new(Peak_01, right3));
    public static DoorData Slab_13__right1 { get; } = new(new(Slab_13, right1), new(Slab_03, left4));
    public static DoorData Slab_14__right1 { get; } = new(new(Slab_14, right1), new(Slab_03, left3));
    public static DoorData Slab_14__top1 { get; } = new(new(Slab_14, top1), new(Slab_15, bot1));
    public static DoorData Slab_15__bot1 { get; } = new(new(Slab_15, bot1), new(Slab_14, top1));
    public static DoorData Slab_15__left1 { get; } = new(new(Slab_15, left1), new(Peak_01, right2));
    public static DoorData Slab_15__right1 { get; } = new(new(Slab_15, right1), new(Slab_03, left2));
    public static DoorData Slab_15__top1 { get; } = new(new(Slab_15, top1), new(Slab_16, bot1))
    {
        Obstacles = new([
                new ObstacleInfo("Breakable Wall Waterways", ObstacleType.TwoWayBreakable, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
                new UnmaskerInfo("Masks"),
                new ObstacleInfo("Camera Locks", ObstacleType.Other, ObstacleSeverity.LimitsVisibility)
            ])
    };
    public static DoorData Slab_16__bot1 { get; } = new(new(Slab_16, bot1), new(Slab_15, top1));
    public static DoorData Slab_16__door1 { get; } = new(new(Slab_16, door1), new(Slab_16b, left1))
    {
        Obstacles = new([
                new GameObjectActiveObstacleInfo("Broodmother_Gate", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.InterruptsEntry | ObstacleSeverity.LimitsExitAccess),
            ])
    };
    public static DoorData Slab_16__left1 { get; } = new(new(Slab_16, left1), new(Peak_01, right1));
    public static DoorData Slab_16__right1 { get; } = new(new(Slab_16, right1), new(Slab_03, left1));
    public static DoorData Slab_16__top1 { get; } = new(new(Slab_16, top1), new(Slab_22, bot1));
    public static DoorData Slab_16b__left1 { get; } = new(new(Slab_16b, left1), new(Slab_16, door1));
    public static DoorData Slab_17__left1 { get; } = new(new(Slab_17, left1), new(Slab_03, right1));
    public static DoorData Slab_18__left1 { get; } = new(new(Slab_18, left1), new(Slab_03, right2))
    {
        Obstacles = new([
                new ObstacleInfo("One Way Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo()),
            ])
    };
    public static DoorData Slab_18__right1 { get; } = new(new(Slab_18, right1), new(Slab_21, left1));
    public static DoorData Slab_19b__left1 { get; } = new(new(Slab_19b, left1), new(Slab_03, right7));
    public static DoorData Slab_19b__right1 { get; } = new(new(Slab_19b, right1), new(Slab_10c, left1));
    public static DoorData Slab_20__left1 { get; } = new(new(Slab_20, left1), new(Slab_03, right3));
    public static DoorData Slab_21__left1 { get; } = new(new(Slab_21, left1), new(Slab_18, right1))
    {
        Obstacles = new([
                new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
                new UnmaskerInfo("Masks")
            ])
    };
    public static DoorData Slab_21__left3 { get; } = new(new(Slab_21, left3), new(Slab_23, right1));
    public static DoorData Slab_21__top1 { get; } = new(new(Slab_21, top1), new(Slab_22, bot2));
    public static DoorData Slab_22__bot1 { get; } = new(new(Slab_22, bot1), new(Slab_16, top1));
    public static DoorData Slab_22__bot2 { get; } = new(new(Slab_22, bot2), new(Slab_21, top1));
    public static DoorData Slab_23__door1 { get; } = new(new(Slab_23, door1), new(Slab_Cell_Creature, left1));
    public static DoorData Slab_23__door2 { get; } = new(new(Slab_23, door2), new(Slab_Cell_Quiet, left1));
    public static DoorData Slab_23__left1 { get; } = new(new(Slab_23, left1), new(Slab_03, right4));
    public static DoorData Slab_23__right1 { get; } = new(new(Slab_23, right1), new(Slab_21, left3))
    {
        Obstacles = new([
                new ObstacleInfo("Battle Scene/Gates/Battle Gate Slab", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess),
                new ObstacleInfo("Battle Scene/Gates/Battle Gate Slab (1)", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess),
            ])
    };
    public static DoorData Slab_Cell__left1 { get; } = new(new(Slab_Cell, left1), new(Slab_13, door1));
    public static DoorData Slab_Cell_Creature__left1 { get; } = new(new(Slab_Cell_Creature, left1), new(Slab_23, door1));
    public static DoorData Slab_Cell_Quiet__left1 { get; } = new(new(Slab_Cell_Quiet, left1), new(Slab_23, door2));
    public static DoorData Slab_Cell_Quiet__left2 { get; } = new(new(Slab_Cell_Quiet, left2), new(Slab_08, door1));
    public static DoorData Song_01__bot1 { get; } = new(new(Song_01, bot1), new(Song_01c, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Floor_basic Song_01", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Song_01__right2 { get; } = new(new(Song_01, right2), new(Under_07b, left1));
    public static DoorData Song_01__top1 { get; } = new(new(Song_01, top1), new(Song_01b, bot1));
    public static DoorData Song_01b__bot1 { get; } = new(new(Song_01b, bot1), new(Song_01, top1));
    public static DoorData Song_01b__door_tubeEnter { get; } = new(new(Song_01b, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Song_01b__right1 { get; } = new(new(Song_01b, right1), new(Song_02, left2));
    public static DoorData Song_01b__top1 { get; } = new(new(Song_01b, top1), new(Song_03, bot1));
    public static DoorData Song_01c__left1 { get; } = new(new(Song_01c, left1), new(Song_19_entrance, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(SceneName: Song_19_entrance, ID: "Breakable Wall Entrance Secret"))
        ])
    };
    public static DoorData Song_01c__top1 { get; } = new(new(Song_01c, top1), new(Song_01, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("One Way Wall", ObstacleType.OneWayBreakableExit, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(SceneName: Song_01, ID: "Breakable Floor_basic Song_01"))
        ])
    };
    public static DoorData Song_02__left2 { get; } = new(new(Song_02, left2), new(Song_01b, right1));
    public static DoorData Song_02__right1 { get; } = new(new(Song_02, right1), new(Song_05, left5));
    public static DoorData Song_03__bot1 { get; } = new(new(Song_03, bot1), new(Song_01b, top1));
    public static DoorData Song_03__top1 { get; } = new(new(Song_03, top1), new(Song_04, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("bot_blocker/before", ObstacleType.OneWayMechanismExit, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo(SceneName: Song_04, ID: "Bot Blocker")),
            new GameObjectActiveObstacleInfo("bot_blocker/after", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Song_04__bot1 { get; } = new(new(Song_04, bot1), new(Song_03, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Bot Blocker", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Song_04__left1 { get; } = new(new(Song_04, left1), new(Slab_01, right1));
    public static DoorData Song_04__right1 { get; } = new(new(Song_04, right1), new(Song_12, left1));
    public static DoorData Song_04__right2 { get; } = new(new(Song_04, right2), new(Song_10, left1));
    public static DoorData Song_05__left3 { get; } = new(new(Song_05, left3), new(Song_11, right3));
    public static DoorData Song_05__left4 { get; } = new(new(Song_05, left4), new(Song_07, right1));
    public static DoorData Song_05__left5 { get; } = new(new(Song_05, left5), new(Song_02, right1));
    public static DoorData Song_05__right2 { get; } = new(new(Song_05, right2), new(Song_18, left1));
    public static DoorData Song_05__right3 { get; } = new(new(Song_05, right3), new(Ward_01, left1));
    public static DoorData Song_05__right4 { get; } = new(new(Song_05, right4), new(Song_27, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Shortcut Wall", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.song_27_opened))),
        ])
    };
    public static DoorData Song_07__right1 { get; } = new(new(Song_07, right1), new(Song_05, left4));
    public static DoorData Song_08__right1 { get; } = new(new(Song_08, right1), new(Song_12, left3));
    public static DoorData Song_09__bot1 { get; } = new(new(Song_09, bot1), new(Song_09b, top1));
    public static DoorData Song_09__right1 { get; } = new(new(Song_09, right1), new(Cog_05, left1));
    public static DoorData Song_09__top1 { get; } = new(new(Song_09, top1), new(Hang_07, bot1));
    public static DoorData Song_09b__left1 { get; } = new(new(Song_09b, left1), new(Song_11, right1));
    public static DoorData Song_09b__top1 { get; } = new(new(Song_09b, top1), new(Song_09, bot1));
    public static DoorData Song_10__left1 { get; } = new(new(Song_10, left1), new(Song_04, right2));
    public static DoorData Song_10__right1 { get; } = new(new(Song_10, right1), new(Song_11, left4))
    {
        Obstacles = new([
            new ObstacleInfo("Pipe_Vent_Hatch_Gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedCitadelSpaRight))),
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Song_11__left1 { get; } = new(new(Song_11, left1), new(Song_17, right1));
    public static DoorData Song_11__left2 { get; } = new(new(Song_11, left2), new(Song_15, right1));
    public static DoorData Song_11__left3 { get; } = new(new(Song_11, left3), new(Song_13, right1));
    public static DoorData Song_11__left4 { get; } = new(new(Song_11, left4), new(Song_10, right1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Song_10_hidden_gate", true, ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.openedCitadelSpaRight)))
        ])
    };
    public static DoorData Song_11__right1 { get; } = new(new(Song_11, right1), new(Song_09b, left1));
    public static DoorData Song_11__right2 { get; } = new(new(Song_11, right2), new(Hang_07, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Plug_Gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Song_11__right3 { get; } = new(new(Song_11, right3), new(Song_05, left3));
    public static DoorData Song_12__left1 { get; } = new(new(Song_12, left1), new(Song_04, right1));
    public static DoorData Song_12__left2 { get; } = new(new(Song_12, left2), new(Song_26, right1));
    public static DoorData Song_12__left3 { get; } = new(new(Song_12, left3), new(Song_08, right1));
    public static DoorData Song_12__left4 { get; } = new(new(Song_12, left4), new(Song_28, right1));
    public static DoorData Song_12__right1 { get; } = new(new(Song_12, right1), new(Song_15, left1));
    public static DoorData Song_12__right2 { get; } = new(new(Song_12, right2), new(Song_14, left1));
    public static DoorData Song_12__right3 { get; } = new(new(Song_12, right3), new(Song_13, left1));
    public static DoorData Song_13__left1 { get; } = new(new(Song_13, left1), new(Song_12, right3));
    public static DoorData Song_13__right1 { get; } = new(new(Song_13, right1), new(Song_11, left3));
    public static DoorData Song_14__left1 { get; } = new(new(Song_14, left1), new(Song_12, right2));
    public static DoorData Song_15__left1 { get; } = new(new(Song_15, left1), new(Song_12, right1));
    public static DoorData Song_15__right1 { get; } = new(new(Song_15, right1), new(Song_11, left2));
    public static DoorData Song_17__left1 { get; } = new(new(Song_17, left1), new(Hang_01, right2));
    public static DoorData Song_17__right1 { get; } = new(new(Song_17, right1), new(Song_11, left1));
    public static DoorData Song_18__bot1 { get; } = new(new(Song_18, bot1), new(Song_27, top1));
    public static DoorData Song_18__left1 { get; } = new(new(Song_18, left1), new(Song_05, right2));
    public static DoorData Song_19_entrance__left1 { get; } = new(new(Song_19_entrance, left1), new(Coral_10, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Entrance gate small", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Coral_10, ID: "Coral10rightsidegate"))
        ])
    };
    public static DoorData Song_19_entrance__right1 { get; } = new(new(Song_19_entrance, right1), new(Song_01c, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall Entrance Secret", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Song_19_entrance__right2 { get; } = new(new(Song_19_entrance, right2), new(Under_01, left1));
    public static DoorData Song_20__left1 { get; } = new(new(Song_20, left1), new(Song_27, right1));
    public static DoorData Song_20__left2 { get; } = new(new(Song_20, left2), new(Song_24, right1));
    public static DoorData Song_20__right_cutsceneEntry { get; } = new(new(Song_20, right_cutsceneEntry), new(Bellway_City, left1), null);
    public static DoorData Song_20__right4 { get; } = new(new(Song_20, right4), new(Library_03, left1));
    public static DoorData Song_20__right5 { get; } = new(new(Song_20, right5), new(Library_13, left1));
    public static DoorData Song_20__right6 { get; } = new(new(Song_20, right6), new(Bellway_City, left1));
    public static DoorData Song_20__top1 { get; } = new(new(Song_20, top1), new(Song_20b, bot1));
    public static DoorData Song_20b__bot1 { get; } = new(new(Song_20b, bot1), new(Song_20, top1));
    public static DoorData Song_20b__left2 { get; } = new(new(Song_20b, left2), new(Song_29, right1));
    public static DoorData Song_20b__left4 { get; } = new(new(Song_20b, left4), new(Cog_06, right1));
    public static DoorData Song_20b__right2 { get; } = new(new(Song_20b, right2), new(Library_02, left2));
    public static DoorData Song_20b__right3 { get; } = new(new(Song_20b, right3), new(Library_02, left1));
    public static DoorData Song_20b__top1 { get; } = new(new(Song_20b, top1), new(Song_25, bot1));
    public static DoorData Song_24__right1 { get; } = new(new(Song_24, right1), new(Song_20, left2));
    public static DoorData Song_25__bot1 { get; } = new(new(Song_25, bot1), new(Song_20b, top1));
    public static DoorData Song_25__left1 { get; } = new(new(Song_25, left1), new(Cog_Dancers, right1));
    public static DoorData Song_25__right1 { get; } = new(new(Song_25, right1), new(Song_Enclave, left1));
    public static DoorData Song_25__top1 { get; } = new(new(Song_25, top1), new(Arborium_01, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("GameObject (6)/Moss Vine Cluster", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Song_25__top2 { get; } = new(new(Song_25, top2), new(Cog_10_Destroyed, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Black Thread States/Black Thread World/Weakness Scene Act3 Final", ObstacleType.Cutscene, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Song_26__right1 { get; } = new(new(Song_26, right1), new(Song_12, left2));
    public static DoorData Song_27__left1 { get; } = new(new(Song_27, left1), new(Song_05, right4))
    {
        // May also have some strange dependency on a quest
        Obstacles = new([
            new ObstacleInfo("Citadel Switch Gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo(ID: "Song_lever_side"))
        ])
    };
    public static DoorData Song_27__right1 { get; } = new(new(Song_27, right1), new(Song_20, left1));
    public static DoorData Song_27__top1 { get; } = new(new(Song_27, top1), new(Song_18, bot1));
    public static DoorData Song_28__right1 { get; } = new(new(Song_28, right1), new(Song_12, left4));
    public static DoorData Song_29__right1 { get; } = new(new(Song_29, right1), new(Song_20b, left2));
    public static DoorData Song_Enclave__bot1 { get; } = new(new(Song_Enclave, bot1), new(Library_04, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Library_shortcut/before", ObstacleType.OneWayBreakableExit, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(SceneName: Library_04, ID: "Top Shortcut")),
            new GameObjectActiveObstacleInfo("Library_shortcut/after", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Song_Enclave__door_act3_wakeUp { get; } = new(new(Song_Enclave, door_act3_wakeUp));
    public static DoorData Song_Enclave__door1 { get; } = new(new(Song_Enclave, door1), new(Bellshrine_Enclave, left1));
    public static DoorData Song_Enclave__left1 { get; } = new(new(Song_Enclave, left1), new(Song_25, right1));
    public static DoorData Song_Enclave__left2 { get; } = new(new(Song_Enclave, left2), new(Library_02, right2));
    public static DoorData Song_Enclave__top1 { get; } = new(new(Song_Enclave, top1), new(Song_Enclave_Tube, bot1));
    public static DoorData Song_Enclave_Tube__bot1 { get; } = new(new(Song_Enclave_Tube, bot1), new(Song_Enclave, top1));
    public static DoorData Song_Enclave_Tube__door_tubeEnter { get; } = new(new(Song_Enclave_Tube, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Song_Tower_01__door_cinematicEnd { get; } = new(new(Song_Tower_01, door_cinematicEnd));
    public static DoorData Song_Tower_01__door_cutsceneEndLaceTower { get; } = new(new(Song_Tower_01, door_cutsceneEndLaceTower));
    public static DoorData Song_Tower_01__right1 { get; } = new(new(Song_Tower_01, right1), new(Tube_Hub, left1))
    {
        Obstacles = new([
            new ObstacleInfo("State Control/song_tower_right_gate", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility)
        ])
    };
    public static DoorData Song_Tower_Destroyed__bot1 { get; } = new(new(Song_Tower_Destroyed, bot1), new(Cog_09_Destroyed, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Collapser Small", ObstacleType.Other, ObstacleSeverity.AbnormalVisual, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Song_Tower_Destroyed__top1 { get; } = new(new(Song_Tower_Destroyed, top1), new(Cradle_01_Destroyed, bot1));
    public static DoorData Sprintmaster_Cave__left1 { get; } = new(new(Sprintmaster_Cave, left1), new(Bone_East_18b, door1));
    public static DoorData Tube_Hub__door_tubeEnter { get; } = new(new(Tube_Hub, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Tube_Hub__left1 { get; } = new(new(Tube_Hub, left1), new(Song_Tower_01, right1))
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Black Thread States/Black Thread World", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
            new GameObjectActiveObstacleInfo("Black Thread States/Normal World", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Tube_Hub__left3 { get; } = new(new(Tube_Hub, left3), new(Cradle_03, right2))
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Black Thread States/Black Thread World", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
            new GameObjectActiveObstacleInfo("Black Thread States/Normal World", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Tube_Hub__left4 { get; } = new(new(Tube_Hub, left4), new(Cradle_01, right1))
    {
        Obstacles = new([
            new GameObjectActiveObstacleInfo("Black Thread States/Black Thread World", false, ObstacleType.ClosedAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility),
            new GameObjectActiveObstacleInfo("Black Thread States/Normal World", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Tut_01__left1 { get; } = new(new(Tut_01, left1), new(Tut_03, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Moss Vine Cluster (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Tut_01__left2 { get; } = new(new(Tut_01, left2), new(Tut_02, right1));
    public static DoorData Tut_01__left3 { get; } = new(new(Tut_01, left3), new(Tut_02, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Moss Vine Cluster", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Tut_01__right1 { get; } = new(new(Tut_01, right1), new(Tut_01b, left1));
    public static DoorData Tut_01__right2 { get; } = new(new(Tut_01, right2), new(Tut_01b, left2));
    public static DoorData Tut_01__top1 { get; } = new(new(Tut_01, top1), new(Bonetown, bot2))
    {
        Obstacles = new([
            new ObstacleInfo("Tutorial Blocker", ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.churchKeeperIntro)))
        ])
    };
    public static DoorData Tut_01b__left1 { get; } = new(new(Tut_01b, left1), new(Tut_01, right1));
    public static DoorData Tut_01b__left2 { get; } = new(new(Tut_01b, left2), new(Tut_01, right2));
    public static DoorData Tut_01b__right1 { get; } = new(new(Tut_01b, right1), new(Weave_04, left1));
    public static DoorData Tut_02__right1 { get; } = new(new(Tut_02, right1), new(Tut_01, left2));
    public static DoorData Tut_02__right2 { get; } = new(new(Tut_02, right2), new(Tut_01, left3));
    // public static DoorData Tut_03__door1_firstExit { get; } = new(new(Tut_03, door1_firstExit), new(Bonetown, bot1_firstEntry), null);
    public static DoorData Tut_03__door1 { get; } = new(new(Tut_03, door1), new(Bonetown, bot1), null);
    public static DoorData Tut_03__door2 { get; } = new(new(Tut_03, door2), new(Tut_04, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Sanctum Door", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.InterruptsEntry)
        ])
    };
    public static DoorData Tut_03__right1 { get; } = new(new(Tut_03, right1), new(Tut_01, left1));
    public static DoorData Tut_03__top1 { get; } = new(new(Tut_03, top1), new(Bonetown, bot1));
    public static DoorData Tut_04__door_memoryEnd { get; } = new(new(Tut_04, door_memoryEnd));
    public static DoorData Tut_04__door_ritualEnd { get; } = new(new(Tut_04, door_ritualEnd));
    public static DoorData Tut_04__left1 { get; } = new(new(Tut_04, left1), new(Tut_03, door2));
    public static DoorData Tut_04__right1 { get; } = new(new(Tut_04, right1), new(Tut_05, left1));
    public static DoorData Tut_05__door_memoryEnd { get; } = new(new(Tut_05, door_memoryEnd));
    public static DoorData Tut_05__left1 { get; } = new(new(Tut_05, left1), new(Tut_04, right1));
    public static DoorData Under_01__left1 { get; } = new(new(Under_01, left1), new(Song_19_entrance, right2));
    public static DoorData Under_01__left2 { get; } = new(new(Under_01, left2), new(Under_27, right1))
    {
        Obstacles = new([
            new UnmaskerInfo("Masks"),
            new ObstacleInfo("break wall/Breakable Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess, new PersistentBoolSaveInfo()),
            new ObstacleInfo("Shellwood Twig Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ]),
    };
    public static DoorData Under_01__left3 { get; } = new(new(Under_01, left3), new(Under_27, right2))
    {
        Obstacles = new([
            new ObstacleInfo("Vine Wall Shortcut", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PlayerDataBoolSaveInfo(nameof(PlayerData.sethShortcut))),
        ]),
    };
    public static DoorData Under_01__right1 { get; } = new(new(Under_01, right1), new(Under_01b, left1));
    public static DoorData Under_01b__left1 { get; } = new(new(Under_01b, left1), new(Under_01, right1));
    public static DoorData Under_01b__right1 { get; } = new(new(Under_01b, right1), new(Under_02, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Understore Big Plate Gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ]),
    };
    public static DoorData Under_02__left1 { get; } = new(new(Under_02, left1), new(Under_01b, right1))
    {
        Obstacles = new([
            new ObstacleInfo("door states/Understore Big Plate Gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(Under_01b, "Understore Big Plate Gate")),
        ]),
    };
    public static DoorData Under_02__left3 { get; } = new(new(Under_02, left3), new(Under_16, right1));
    public static DoorData Under_02__right1 { get; } = new(new(Under_02, right1), new(Under_07c, left2));
    public static DoorData Under_02__right2 { get; } = new(new(Under_02, right2), new(Under_07, left3));
    public static DoorData Under_02__right3 { get; } = new(new(Under_02, right3), new(Under_03b, left1));
    public static DoorData Under_02__right4 { get; } = new(new(Under_02, right4), new(Under_14, left1));
    public static DoorData Under_03__right1 { get; } = new(new(Under_03, right1), new(Under_03c, left2));
    public static DoorData Under_03b__left1 { get; } = new(new(Under_03b, left1), new(Under_02, right3));
    public static DoorData Under_03b__right1 { get; } = new(new(Under_03b, right1), new(Under_03c, left1));
    public static DoorData Under_03c__left1 { get; } = new(new(Under_03c, left1), new(Under_03b, right1));
    public static DoorData Under_03c__left2 { get; } = new(new(Under_03c, left2), new(Under_03, right1));
    public static DoorData Under_03c__right1 { get; } = new(new(Under_03c, right1), new(Under_04, left1));
    public static DoorData Under_03d__bot1 { get; } = new(new(Under_03d, bot1), new(Under_04, top1));
    public static DoorData Under_04__left1 { get; } = new(new(Under_04, left1), new(Under_03c, right1));
    public static DoorData Under_04__right1 { get; } = new(new(Under_04, right1), new(Under_05, left2))
    {
        Obstacles = new([
            new ObstacleInfo("Understore Big Plate Gate", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ]),
    };
    public static DoorData Under_04__top1 { get; } = new(new(Under_04, top1), new(Under_03d, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo()),
        ]),
    };
    public static DoorData Under_05__left1 { get; } = new(new(Under_05, left1), new(Under_06, right1));
    public static DoorData Under_05__left2 { get; } = new(new(Under_05, left2), new(Under_04, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Understore Big Plate Gate", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo(SceneName: Under_04)),
        ]),
    };
    public static DoorData Under_05__left3 { get; } = new(new(Under_05, left3), new(Under_23, right1));
    public static DoorData Under_05__right1 { get; } = new(new(Under_05, right1), new(Under_11, left1));
    public static DoorData Under_05__right2 { get; } = new(new(Under_05, right2), new(Under_12, left1));
    public static DoorData Under_05__right3 { get; } = new(new(Under_05, right3), new(Under_10, left1));
    public static DoorData Under_06__left1 { get; } = new(new(Under_06, left1), new(Under_07, right2));
    public static DoorData Under_06__right1 { get; } = new(new(Under_06, right1), new(Under_05, left1));
    public static DoorData Under_06__top1 { get; } = new(new(Under_06, top1), new(Under_08, bot1));
    public static DoorData Under_07__left3 { get; } = new(new(Under_07, left3), new(Under_02, right2));
    public static DoorData Under_07__right2 { get; } = new(new(Under_07, right2), new(Under_06, left1));
    // public static DoorData Under_07__top1 { get; } = new(new(Under_07, top1), new(Under_07c, bot1));
    public static DoorData Under_07b__bot1 { get; } = new(new(Under_07b, bot1), new(Under_07c, top1))
    {
        Obstacles = new([
            new ObstacleInfo("Trapdoor Control/Trapdoor Closed", ObstacleType.OneWayMechanismExit, ObstacleSeverity.LimitsExitAccess, new PersistentBoolSaveInfo(Under_07c, "Bot Blocker")),
            new GameObjectActiveObstacleInfo("Trapdoor Control/Trapdoor Opened", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
            new GameObjectActiveObstacleInfo("Trapdoor Control/Audio Understore Atmos", true, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Under_07b__left1 { get; } = new(new(Under_07b, left1), new(Song_01, right2));
    // public static DoorData Under_07c__bot1 { get; } = new(new(Under_07c, bot1), new(Under_07, top1));
    public static DoorData Under_07c__left2 { get; } = new(new(Under_07c, left2), new(Under_02, right1));
    public static DoorData Under_07c__top1 { get; } = new(new(Under_07c, top1), new(Under_07b, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("Bot Blocker", ObstacleType.OneWayMechanismEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new BehaviourObstacleInfo<NestedFadeGroup>("top1", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Under_08__bot1 { get; } = new(new(Under_08, bot1), new(Under_06, top1));
    public static DoorData Under_08__top1 { get; } = new(new(Under_08, top1), new(Ward_02, bot1));
    public static DoorData Under_10__left1 { get; } = new(new(Under_10, left1), new(Under_05, right3));
    public static DoorData Under_10__right1 { get; } = new(new(Under_10, right1), new(Under_13, left2));
    public static DoorData Under_11__left1 { get; } = new(new(Under_11, left1), new(Under_05, right1));
    public static DoorData Under_11__right1 { get; } = new(new(Under_11, right1), new(Under_13, left1));
    public static DoorData Under_12__left1 { get; } = new(new(Under_12, left1), new(Under_05, right2));
    public static DoorData Under_13__left1 { get; } = new(new(Under_13, left1), new(Under_11, right1));
    public static DoorData Under_13__left2 { get; } = new(new(Under_13, left2), new(Under_10, right1));
    public static DoorData Under_13__left3 { get; } = new(new(Under_13, left3), new(Under_21, right1));
    public static DoorData Under_13__left4 { get; } = new(new(Under_13, left4), new(Under_22, right1));
    public static DoorData Under_13__right1 { get; } = new(new(Under_13, right1), new(Under_17, left1));
    public static DoorData Under_13__right2 { get; } = new(new(Under_13, right2), new(Under_18, left1));
    public static DoorData Under_13__right3 { get; } = new(new(Under_13, right3), new(Under_19, left1));
    public static DoorData Under_14__left1 { get; } = new(new(Under_14, left1), new(Under_02, right4));
    public static DoorData Under_16__right1 { get; } = new(new(Under_16, right1), new(Under_02, left3));
    public static DoorData Under_17__bot1 { get; } = new(new(Under_17, bot1), new(Under_18, top1));
    public static DoorData Under_17__bot2 { get; } = new(new(Under_17, bot2), new(Under_18, top2));
    public static DoorData Under_17__door1 { get; } = new(new(Under_17, door1), new(Under_20, left1))
    {
        Obstacles = new([
            new BehaviourObstacleInfo<ItemReceptacle>("Architect Shrine Door", false, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new BehaviourObstacleInfo<BoxCollider2D>("Architect Shrine Door/door1", true, ObstacleType.OpenAfterProgression, ObstacleSeverity.LimitsExitAccess),
            new GameObjectActiveObstacleInfo("Architect Shrine Door/door", false, ObstacleType.Other, ObstacleSeverity.AbnormalVisual),
        ])
    };
    public static DoorData Under_17__left1 { get; } = new(new(Under_17, left1), new(Under_13, right1));
    public static DoorData Under_17__right1 { get; } = new(new(Under_17, right1), new(Library_11b, left3));
    public static DoorData Under_17__top1 { get; } = new(new(Under_17, top1), new(Ward_06, bot1));
    public static DoorData Under_18__left1 { get; } = new(new(Under_18, left1), new(Under_13, right2));
    public static DoorData Under_18__right1 { get; } = new(new(Under_18, right1), new(Under_19c, left1));
    public static DoorData Under_18__top1 { get; } = new(new(Under_18, top1), new(Under_17, bot1));
    public static DoorData Under_18__top2 { get; } = new(new(Under_18, top2), new(Under_17, bot2))
    {
        Obstacles = new([
            new FsmEventObstacleInfo("Battle Scene/Gates/Pipe_Vent_Hatch (1)", "BG QUICK OPEN", ObstacleType.OpenAfterProgression, ObstacleSeverity.InterruptsEntry),
        ])
    };
    public static DoorData Under_19__left1 { get; } = new(new(Under_19, left1), new(Under_13, right3));
    public static DoorData Under_19__top1 { get; } = new(new(Under_19, top1), new(Under_19c, bot1));
    public static DoorData Under_19b__right1 { get; } = new(new(Under_19b, right1), new(Under_19c, left2));
    public static DoorData Under_19c__bot1 { get; } = new(new(Under_19c, bot1), new(Under_19, top1));
    public static DoorData Under_19c__left1 { get; } = new(new(Under_19c, left1), new(Under_18, right1));
    public static DoorData Under_19c__left2 { get; } = new(new(Under_19c, left2), new(Under_19b, right1));
    public static DoorData Under_20__door_memoryEnd { get; } = new(new(Under_20, door_memoryEnd));
    public static DoorData Under_20__left1 { get; } = new(new(Under_20, left1), new(Under_17, door1));
    public static DoorData Under_21__right1 { get; } = new(new(Under_21, right1), new(Under_13, left3));
    public static DoorData Under_22__door_tubeEnter { get; } = new(new(Under_22, door_tubeEnter))
    {
        Obstacles = new([
            new ObstacleInfo("City Travel Tube/tube_toll_machine", ObstacleType.Other, ObstacleSeverity.AbnormalVisual)
        ])
    };
    public static DoorData Under_22__right1 { get; } = new(new(Under_22, right1), new(Under_13, left4));
    public static DoorData Under_23__bot1 { get; } = new(new(Under_23, bot1), new(Wisp_09, top1));
    public static DoorData Under_23__right1 { get; } = new(new(Under_23, right1), new(Under_05, left3));
    public static DoorData Under_27__left1 { get; } = new(new(Under_27, left1), new(Shellwood_22, right1));
    public static DoorData Under_27__right1 { get; } = new(new(Under_27, right1), new(Under_01, left2));
    public static DoorData Under_27__right2 { get; } = new(new(Under_27, right2), new(Under_01, left3))
    {
        Obstacles = new([
            new ObstacleInfo("Group (1)/Shellwood Twig Wall (1)", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new TransitionObstacleInfo("Group (1)/right2", true, ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess),
            new BehaviourObstacleInfo<BoxCollider2D>("Group (1)/right2", true, ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsExitAccess)
        ])
    };
    public static DoorData Ward_01__left1 { get; } = new(new(Ward_01, left1), new(Song_05, right3));
    public static DoorData Ward_01__left2 { get; } = new(new(Ward_01, left2), new(Ward_02b, right1));
    public static DoorData Ward_01__left3 { get; } = new(new(Ward_01, left3), new(Ward_02, right1));
    public static DoorData Ward_01__right1 { get; } = new(new(Ward_01, right1), new(Ward_03, left1));
    public static DoorData Ward_01__right2 { get; } = new(new(Ward_01, right2), new(Ward_04, left1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
        ])
    };
    public static DoorData Ward_01__right3 { get; } = new(new(Ward_01, right3), new(Ward_05, left1));
    public static DoorData Ward_02__bot1 { get; } = new(new(Ward_02, bot1), new(Under_08, top1));
    public static DoorData Ward_02__door_cinematicEnd { get; } = new(new(Ward_02, door_cinematicEnd));
    public static DoorData Ward_02__right1 { get; } = new(new(Ward_02, right1), new(Ward_01, left3));
    public static DoorData Ward_02__top1 { get; } = new(new(Ward_02, top1), new(Ward_02b, bot1));
    public static DoorData Ward_02b__bot1 { get; } = new(new(Ward_02b, bot1), new(Ward_02, top1));
    public static DoorData Ward_02b__right1 { get; } = new(new(Ward_02b, right1), new(Ward_01, left2));
    public static DoorData Ward_03__bot1 { get; } = new(new(Ward_03, bot1), new(Ward_06, top1));
    public static DoorData Ward_03__door1 { get; } = new(new(Ward_03, door1), new(Ward_09, left1))
    {
        Obstacles = new([
            new TestObjObstacleInfo("Sherma_Door_Open", true, ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry),
        ])
    };
    public static DoorData Ward_03__left1 { get; } = new(new(Ward_03, left1), new(Ward_01, right1));
    public static DoorData Ward_03__top1 { get; } = new(new(Ward_03, top1), new(Ward_07, bot1));
    public static DoorData Ward_04__left1 { get; } = new(new(Ward_04, left1), new(Ward_01, right2));
    public static DoorData Ward_05__left1 { get; } = new(new(Ward_05, left1), new(Ward_01, right3));
    public static DoorData Ward_06__bot1 { get; } = new(new(Ward_06, bot1), new(Under_17, top1));
    public static DoorData Ward_06__top1 { get; } = new(new(Ward_06, top1), new(Ward_03, bot1));
    public static DoorData Ward_07__bot1 { get; } = new(new(Ward_07, bot1), new(Ward_03, top1));
    public static DoorData Ward_09__left1 { get; } = new(new(Ward_09, left1), new(Ward_03, door1));
    public static DoorData Weave_02__left2 { get; } = new(new(Weave_02, left2), new(Weave_04, right2));
    public static DoorData Weave_02__left3 { get; } = new(new(Weave_02, left3), new(Weave_11, right1));
    public static DoorData Weave_02__left4 { get; } = new(new(Weave_02, left4), new(Weave_07, right1));
    public static DoorData Weave_02__right1 { get; } = new(new(Weave_02, right1), new(Weave_12, left1));
    public static DoorData Weave_02__right2 { get; } = new(new(Weave_02, right2), new(Weave_13, left1));
    public static DoorData Weave_02__right3 { get; } = new(new(Weave_02, right3), new(Weave_10, left1))
    {
        Obstacles = new([
            new ObstacleInfo("crest_shrine_break_tube", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Weave_03__right1 { get; } = new(new(Weave_03, right1), new(Weave_07, left1));
    public static DoorData Weave_04__left1 { get; } = new(new(Weave_04, left1), new(Tut_01b, right1));
    public static DoorData Weave_04__right2 { get; } = new(new(Weave_04, right2), new(Weave_02, left2));
    public static DoorData Weave_05b__left1 { get; } = new(new(Weave_05b, left1), new(Weave_08, right1));
    public static DoorData Weave_07__left1 { get; } = new(new(Weave_07, left1), new(Weave_03, right1));
    public static DoorData Weave_07__right1 { get; } = new(new(Weave_07, right1), new(Weave_02, left4));
    public static DoorData Weave_08__left1 { get; } = new(new(Weave_08, left1), new(Weave_13, right1));
    public static DoorData Weave_08__right1 { get; } = new(new(Weave_08, right1), new(Weave_05b, left1));
    public static DoorData Weave_10__left1 { get; } = new(new(Weave_10, left1), new(Weave_02, right3));
    public static DoorData Weave_11__right1 { get; } = new(new(Weave_11, right1), new(Weave_02, left3));
    public static DoorData Weave_11__top1 { get; } = new(new(Weave_11, top1), new(Weave_14, bot1));
    public static DoorData Weave_12__left1 { get; } = new(new(Weave_12, left1), new(Weave_02, right1));
    public static DoorData Weave_13__left1 { get; } = new(new(Weave_13, left1), new(Weave_02, right2));
    public static DoorData Weave_13__right1 { get; } = new(new(Weave_13, right1), new(Weave_08, left1));
    public static DoorData Weave_14__bot1 { get; } = new(new(Weave_14, bot1), new(Weave_11, top1));
    public static DoorData Wisp_02__left1 { get; } = new(new(Wisp_02, left1), new(Belltown_08, right1));
    public static DoorData Wisp_02__right1 { get; } = new(new(Wisp_02, right1), new(Wisp_04, left1));
    public static DoorData Wisp_02__top1 { get; } = new(new(Wisp_02, top1), new(Wisp_05, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("plank_wall_cluster_swamp", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Wisp_03__door1 { get; } = new(new(Wisp_03, door1), new(Belltown_Room_doctor, left1));
    public static DoorData Wisp_03__right1 { get; } = new(new(Wisp_03, right1), new(Greymoor_06, left1));
    public static DoorData Wisp_03__top1 { get; } = new(new(Wisp_03, top1), new(Wisp_06, bot1))
    {
        Obstacles = new([
            new ObstacleInfo("plank_wall_cluster", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.InterruptsEntry, new PersistentBoolSaveInfo())
        ])
    };
    public static DoorData Wisp_04__bot1 { get; } = new(new(Wisp_04, bot1), new(Greymoor_06, top1));
    public static DoorData Wisp_04__left1 { get; } = new(new(Wisp_04, left1), new(Wisp_02, right1));
    public static DoorData Wisp_04__right1 { get; } = new(new(Wisp_04, right1), new(Wisp_08, left1));
    public static DoorData Wisp_05__bot1 { get; } = new(new(Wisp_05, bot1), new(Wisp_02, top1));
    public static DoorData Wisp_05__left1 { get; } = new(new(Wisp_05, left1), new(Wisp_09, right1))
    {
        Obstacles = new([
            new ObstacleInfo("Breakable Wall", ObstacleType.OneWayBreakableEntry, ObstacleSeverity.LimitsRoomAccess | ObstacleSeverity.LimitsVisibility, new PersistentBoolSaveInfo()),
            new UnmaskerInfo("Masks")
        ])
    };
    public static DoorData Wisp_06__bot1 { get; } = new(new(Wisp_06, bot1), new(Wisp_03, top1));
    public static DoorData Wisp_07__left1 { get; } = new(new(Wisp_07, left1), new(Wisp_08, right1));
    public static DoorData Wisp_08__left1 { get; } = new(new(Wisp_08, left1), new(Wisp_04, right1));
    public static DoorData Wisp_08__right1 { get; } = new(new(Wisp_08, right1), new(Wisp_07, left1));
    public static DoorData Wisp_09__right1 { get; } = new(new(Wisp_09, right1), new(Wisp_05, left1));
    public static DoorData Wisp_09__top1 { get; } = new(new(Wisp_09, top1), new(Under_23, bot1));
}
