using Benchwarp.Doors;
using GlobalEnums;
using static Benchwarp.Data.BaseGateList;

namespace Benchwarp.Data;

public static class BaseRoomList
{
    public static RoomData Abandoned_town { get; } = new RoomData
    {
        Name = SceneNames.Abandoned_town,
        MapZone = MapZone.SURFACE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Nameless_Town,
        Gates = new([
            Abandoned_town__bot1,
            Abandoned_town__door1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_01 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_01,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_01__left1,
            Abyss_01__right2,
            Abyss_01__right3,
            Abyss_01__right4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_02 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_02,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_02__left1,
            Abyss_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_02b { get; } = new RoomData
    {
        Name = SceneNames.Abyss_02b,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_02b__left2,
            Abyss_02b__right1,
            Abyss_02b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_03 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_03,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_03__door1,
            Abyss_03__door2,
            Abyss_03__left1,
            Abyss_03__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_04 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_04,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_04__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_05 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_05,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_05__left2,
            Abyss_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_06 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_06,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_07 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_07,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_07__left1,
            Abyss_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_08 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_08,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_08__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_09 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_09,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_09__bot1,
            Abyss_09__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_11 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_11,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_11__bot1,
            Abyss_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_12 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_12,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_12__left1,
            Abyss_12__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_13 { get; } = new RoomData
    {
        Name = SceneNames.Abyss_13,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_13__left1,
            Abyss_13__right1,
            Abyss_13__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Abyss_Cocoon { get; } = new RoomData
    {
        Name = SceneNames.Abyss_Cocoon,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_Cocoon__door_entry,
            Abyss_Cocoon__door_test,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ant_02 { get; } = new RoomData
    {
        Name = SceneNames.Ant_02,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_02__left1,
            Ant_02__right1,
        ]),
    };
    public static RoomData Ant_03 { get; } = new RoomData
    {
        Name = SceneNames.Ant_03,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_03__left2,
            Ant_03__right3,
        ]),
    };
    public static RoomData Ant_04 { get; } = new RoomData
    {
        Name = SceneNames.Ant_04,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04__left1,
            Ant_04__right1,
        ]),
    };
    public static RoomData Ant_04_left { get; } = new RoomData
    {
        Name = SceneNames.Ant_04_left,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04_left__left1,
            Ant_04_left__right1,
        ]),
    };
    public static RoomData Ant_04_mid { get; } = new RoomData
    {
        Name = SceneNames.Ant_04_mid,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04_mid__left1,
            Ant_04_mid__right1,
        ]),
    };
    public static RoomData Ant_05b { get; } = new RoomData
    {
        Name = SceneNames.Ant_05b,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_05b__bot1,
            Ant_05b__bot2,
            Ant_05b__right1,
        ]),
    };
    public static RoomData Ant_05c { get; } = new RoomData
    {
        Name = SceneNames.Ant_05c,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_05c__left1,
            Ant_05c__right1,
        ]),
    };
    public static RoomData Ant_08 { get; } = new RoomData
    {
        Name = SceneNames.Ant_08,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_08__top1,
        ]),
    };
    public static RoomData Ant_09 { get; } = new RoomData
    {
        Name = SceneNames.Ant_09,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_09__left1,
            Ant_09__right1,
        ]),
    };
    public static RoomData Ant_14 { get; } = new RoomData
    {
        Name = SceneNames.Ant_14,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_14__left1,
            Ant_14__left2,
            Ant_14__left3,
            Ant_14__left4,
            Ant_14__left5,
            Ant_14__right2,
            Ant_14__right3,
        ]),
    };
    public static RoomData Ant_17 { get; } = new RoomData
    {
        Name = SceneNames.Ant_17,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_17__right1,
        ]),
    };
    public static RoomData Ant_19 { get; } = new RoomData
    {
        Name = SceneNames.Ant_19,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_19__door_memoryEnd,
            Ant_19__left1,
        ]),
    };
    public static RoomData Ant_20 { get; } = new RoomData
    {
        Name = SceneNames.Ant_20,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_20__door1,
            Ant_20__left1,
        ]),
    };
    public static RoomData Ant_21 { get; } = new RoomData
    {
        Name = SceneNames.Ant_21,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_21__right1,
        ]),
    };
    public static RoomData Ant_Merchant { get; } = new RoomData
    {
        Name = SceneNames.Ant_Merchant,
        MapZone = MapZone.HUNTERS_NEST,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_Merchant__right1,
        ]),
    };
    public static RoomData Ant_Queen { get; } = new RoomData
    {
        Name = SceneNames.Ant_Queen,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_Queen__door_wakeOnGround,
            Ant_Queen__left1,
        ]),
    };
    public static RoomData Aqueduct_01 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_01,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_01__left1,
            Aqueduct_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_02 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_02,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_02__left1,
            Aqueduct_02__left2,
            Aqueduct_02__left3,
            Aqueduct_02__right1,
            Aqueduct_02__right2,
            Aqueduct_02__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_03 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_03,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_03__left1,
            Aqueduct_03__right1,
            Aqueduct_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_04 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_04,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_04__bot1,
            Aqueduct_04__door1,
            Aqueduct_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_05 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_05,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_05__door_caravanTravelEnd,
            Aqueduct_05__door2,
            Aqueduct_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_06 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_06,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_06__bot1,
            Aqueduct_06__left1,
            Aqueduct_06__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_07 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_07,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Aqueduct_08 { get; } = new RoomData
    {
        Name = SceneNames.Aqueduct_08,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_08__left1,
            Aqueduct_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Arborium_01 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_01,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_01__bot1,
            Arborium_01__left1,
            Arborium_01__left2,
            Arborium_01__left3,
            Arborium_01__right1,
            Arborium_01__right2,
            Arborium_01__right3,
            Arborium_01__right4,
            Arborium_01__right5,
        ]),
    };
    public static RoomData Arborium_02 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_02,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_02__left1,
            Arborium_02__right1,
        ]),
    };
    public static RoomData Arborium_03 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_03,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_03__left1,
            Arborium_03__left2,
            Arborium_03__left3,
            Arborium_03__left4,
            Arborium_03__right1,
            Arborium_03__right2,
        ]),
    };
    public static RoomData Arborium_04 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_04,
        MapZone = MapZone.ARBORIUM,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_04__left1,
            Arborium_04__right1,
        ]),
    };
    public static RoomData Arborium_05 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_05,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_05__right1,
            Arborium_05__top1,
        ]),
    };
    public static RoomData Arborium_06 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_06,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_06__bot1,
            Arborium_06__left1,
            Arborium_06__right1,
        ]),
    };
    public static RoomData Arborium_07 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_07,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_07__left1,
            Arborium_07__top1,
        ]),
    };
    public static RoomData Arborium_08 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_08,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_08__bot1,
            Arborium_08__left1,
        ]),
    };
    public static RoomData Arborium_09 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_09,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_09__right1,
            Arborium_09__right2,
        ]),
    };
    public static RoomData Arborium_10 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_10,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_10__left1,
        ]),
    };
    public static RoomData Arborium_11 { get; } = new RoomData
    {
        Name = SceneNames.Arborium_11,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_11__left1,
            Arborium_11__right1,
        ]),
    };
    public static RoomData Arborium_Tube { get; } = new RoomData
    {
        Name = SceneNames.Arborium_Tube,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_Tube__door_tubeEnter,
            Arborium_Tube__right1,
        ]),
    };
    public static RoomData Aspid_01 { get; } = new RoomData
    {
        Name = SceneNames.Aspid_01,
        MapZone = MapZone.MOSS_CAVE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Aspid_01__bot1,
            Aspid_01__bot2,
            Aspid_01__bot3,
            Aspid_01__bot4,
            Aspid_01__bot5,
            Aspid_01__bot6,
            Aspid_01__bot7,
            Aspid_01__bot8,
            Aspid_01__left1,
            Aspid_01__left2,
            Aspid_01__right2,
            Aspid_01__right3,
            Aspid_01__right4,
            Aspid_01__top1,
            Aspid_01__top2,
            Aspid_01__top3,
            Aspid_01__top4,
            Aspid_01__top5,
            Aspid_01__top6,
            Aspid_01__top7,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bellshrine__left1,
            Bellshrine__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine_02 { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine_02,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Bellshrine_02__left1,
            Bellshrine_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine_03 { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine_03,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Bellshrine_03__left1,
            Bellshrine_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine_05 { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine_05,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bellshrine_05__left1,
            Bellshrine_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine_Coral { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine_Coral,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Bellshrine_Coral__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellshrine_Enclave { get; } = new RoomData
    {
        Name = SceneNames.Bellshrine_Enclave,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.First_Shrine,
        Gates = new([
            Bellshrine_Enclave__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown { get; } = new RoomData
    {
        Name = SceneNames.Belltown,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown__door1,
            Belltown__door3,
            Belltown__door4,
            Belltown__door5,
            Belltown__left3,
            Belltown__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_04 { get; } = new RoomData
    {
        Name = SceneNames.Belltown_04,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_04__bot1,
            Belltown_04__left1,
            Belltown_04__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_06 { get; } = new RoomData
    {
        Name = SceneNames.Belltown_06,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_06__door1,
            Belltown_06__left1,
            Belltown_06__left3,
            Belltown_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_07 { get; } = new RoomData
    {
        Name = SceneNames.Belltown_07,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_07__left1,
            Belltown_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_08 { get; } = new RoomData
    {
        Name = SceneNames.Belltown_08,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_basement { get; } = new RoomData
    {
        Name = SceneNames.Belltown_basement,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_basement__door_fastTravelExit,
            Belltown_basement__bot1,
            Belltown_basement__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_basement_03 { get; } = new RoomData
    {
        Name = SceneNames.Belltown_basement_03,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_basement_03__left1,
            Belltown_basement_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_doctor { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_doctor,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_doctor__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_Fisher { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_Fisher,
        MapZone = MapZone.NONE,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Fisher__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_pinsmith { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_pinsmith,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_pinsmith__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_Relic { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_Relic,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Relic__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_shellwood { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_shellwood,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_shellwood__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Room_Spare { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Room_Spare,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Spare__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Belltown_Shrine { get; } = new RoomData
    {
        Name = SceneNames.Belltown_Shrine,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Shrine__door_wakeOnGround,
            Belltown_Shrine__right1,
            Belltown_Shrine__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_01 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_01,
        MapZone = MapZone.BONETOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Bellway_01__door_fastTravelExit,
            Bellway_01__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_02 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_02,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Bellway_02__door_fastTravelExit,
            Bellway_02__left1,
            Bellway_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_03 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_03,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bellway_03__door_fastTravelExit,
            Bellway_03__left1,
            Bellway_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_04 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_04,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Bellway_04__door_fastTravelExit,
            Bellway_04__bot1,
            Bellway_04__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_08 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_08,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Bellway_08__door_fastTravelExit,
            Bellway_08__left1,
            Bellway_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_Aqueduct { get; } = new RoomData
    {
        Name = SceneNames.Bellway_Aqueduct,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Bellway_Aqueduct__door_fastTravelExit,
            Bellway_Aqueduct__left1,
            Bellway_Aqueduct__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_Centipede_Arena { get; } = new RoomData
    {
        Name = SceneNames.Bellway_Centipede_Arena,
        MapZone = MapZone.BELLTOWN,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Bellway_Centipede_Arena__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_City { get; } = new RoomData
    {
        Name = SceneNames.Bellway_City,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Bellway_City__door_fastTravelExit,
            Bellway_City__door_tubeEnter,
            Bellway_City__left1,
            Bellway_City__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_Peak { get; } = new RoomData
    {
        Name = SceneNames.Bellway_Peak,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Bellway_Peak__left1,
            Bellway_Peak__left2,
            Bellway_Peak__right1,
            Bellway_Peak__right2,
            Bellway_Peak__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_Peak_02 { get; } = new RoomData
    {
        Name = SceneNames.Bellway_Peak_02,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Bellway_Peak_02__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bellway_Shadow { get; } = new RoomData
    {
        Name = SceneNames.Bellway_Shadow,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Bellway_Shadow__door_fastTravelExit,
            Bellway_Shadow__left1,
        ]),
    };
    public static RoomData Bone_01 { get; } = new RoomData
    {
        Name = SceneNames.Bone_01,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01__left2,
            Bone_01__right1,
            Bone_01__right2,
            Bone_01__top2,
            Bone_01__top2_extra,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_01b { get; } = new RoomData
    {
        Name = SceneNames.Bone_01b,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01b__left1,
            Bone_01b__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_01c { get; } = new RoomData
    {
        Name = SceneNames.Bone_01c,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01c__left1,
            Bone_01c__left2,
            Bone_01c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_02 { get; } = new RoomData
    {
        Name = SceneNames.Bone_02,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_02__left1,
            Bone_02__right1,
            Bone_02__top1,
            Bone_02__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_03 { get; } = new RoomData
    {
        Name = SceneNames.Bone_03,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_03__bot1,
            Bone_03__left1,
            Bone_03__left2,
            Bone_03__left4,
            Bone_03__right1,
            Bone_03__right3,
            Bone_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_04 { get; } = new RoomData
    {
        Name = SceneNames.Bone_04,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_04__bot2,
            Bone_04__left1,
            Bone_04__left2,
            Bone_04__right1,
            Bone_04__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_05 { get; } = new RoomData
    {
        Name = SceneNames.Bone_05,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_05__door_cinematicEnd,
            Bone_05__door_fastTravelExit,
            Bone_05__bot1,
            Bone_05__left1,
            Bone_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_05b { get; } = new RoomData
    {
        Name = SceneNames.Bone_05b,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_05b__left1,
            Bone_05b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_06 { get; } = new RoomData
    {
        Name = SceneNames.Bone_06,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_06__bot1,
            Bone_06__left1,
            Bone_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_07 { get; } = new RoomData
    {
        Name = SceneNames.Bone_07,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_07__left1,
            Bone_07__right1,
            Bone_07__right2,
            Bone_07__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_08 { get; } = new RoomData
    {
        Name = SceneNames.Bone_08,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_08__bot1,
            Bone_08__door1,
            Bone_08__left2,
            Bone_08__left3,
            Bone_08__right2,
            Bone_08__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_09 { get; } = new RoomData
    {
        Name = SceneNames.Bone_09,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_09__left1,
            Bone_09__right1,
            Bone_09__right2,
            Bone_09__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_10 { get; } = new RoomData
    {
        Name = SceneNames.Bone_10,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_10__bot1,
            Bone_10__door2,
            Bone_10__left1,
            Bone_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_11 { get; } = new RoomData
    {
        Name = SceneNames.Bone_11,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_11__bot1,
            Bone_11__left1,
            Bone_11__right1,
            Bone_11__right2,
            Bone_11__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_11b { get; } = new RoomData
    {
        Name = SceneNames.Bone_11b,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_11b__right1,
            Bone_11b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_12 { get; } = new RoomData
    {
        Name = SceneNames.Bone_12,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_14 { get; } = new RoomData
    {
        Name = SceneNames.Bone_14,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_14__left1,
            Bone_14__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_15 { get; } = new RoomData
    {
        Name = SceneNames.Bone_15,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_15__bot1,
            Bone_15__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_16 { get; } = new RoomData
    {
        Name = SceneNames.Bone_16,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_16__left1,
            Bone_16__right1,
            Bone_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_17 { get; } = new RoomData
    {
        Name = SceneNames.Bone_17,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_17__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_18 { get; } = new RoomData
    {
        Name = SceneNames.Bone_18,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_18__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_19 { get; } = new RoomData
    {
        Name = SceneNames.Bone_19,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_19__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_01 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_01,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_01__left1,
            Bone_East_01__left2,
            Bone_East_01__right1,
            Bone_East_01__right2,
            Bone_East_01__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_02 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_02,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_02__left1,
            Bone_East_02__right1,
            Bone_East_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_02b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_02b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_02b__left1,
            Bone_East_02b__right1,
            Bone_East_02b__right2,
            Bone_East_02b__top3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_03 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_03,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_03__left1,
            Bone_East_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_04 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_04,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_04__bot1,
            Bone_East_04__left1,
            Bone_East_04__right1,
            Bone_East_04__right2,
            Bone_East_04__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_04b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_04b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_04b__left1,
            Bone_East_04b__right1,
            Bone_East_04b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_04c { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_04c,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_04c__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_05 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_05,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_05__left1,
            Bone_East_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_07 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_07,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_07__left1,
            Bone_East_07__left2,
            Bone_East_07__left3,
            Bone_East_07__left4,
            Bone_East_07__right1,
            Bone_East_07__right2,
            Bone_East_07__right3,
            Bone_East_07__right4,
            Bone_East_07__right5,
            Bone_East_07__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_08 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_08,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_08__door_cinematicEnd,
            Bone_East_08__left1,
            Bone_East_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_09 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_09,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_09__door1,
            Bone_East_09__left2,
            Bone_East_09__left3,
            Bone_East_09__right1,
            Bone_East_09__right2,
            Bone_East_09__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_09b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_09b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_09b__bot1,
            Bone_East_09b__left1,
            Bone_East_09b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_10 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_10,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_10__door1,
            Bone_East_10__left1,
            Bone_East_10__left2,
            Bone_East_10__right1,
            Bone_East_10__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_10_Church { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_10_Church,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_10_Church__bot1,
            Bone_East_10_Church__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_10_Room { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_10_Room,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_10_Room__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_11 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_11,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_11__bot1,
            Bone_East_11__left1,
            Bone_East_11__right1,
            Bone_East_11__right2,
            Bone_East_11__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_12 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_12,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_12__bot1,
            Bone_East_12__left1,
            Bone_East_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_13 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_13,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_13__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_14 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_14,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_14__left1,
            Bone_East_14__left2,
            Bone_East_14__right1,
            Bone_East_14__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_14b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_14b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_14b__door1,
            Bone_East_14b__left1,
            Bone_East_14b__left2,
            Bone_East_14b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_15 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_15,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_15__bot1,
            Bone_East_15__left1,
            Bone_East_15__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_16 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_16,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_16__bot1,
            Bone_East_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_17 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_17,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_17__bot1,
            Bone_East_17__left1,
            Bone_East_17__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_17b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_17b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_17b__left1,
            Bone_East_17b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_18 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_18,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18__left1,
            Bone_East_18__right1,
            Bone_East_18__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_18b { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_18b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18b__door1,
            Bone_East_18b__left1,
            Bone_East_18b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_18c { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_18c,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18c__left1,
            Bone_East_18c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_20 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_20,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_20__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_21 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_21,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_21__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_22 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_22,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_22__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_24 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_24,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_24__bot1,
            Bone_East_24__left1,
            Bone_East_24__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_25 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_25,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_25__door1,
            Bone_East_25__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_26 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_26,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_26__bot1,
            Bone_East_26__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_27 { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_27,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_27__bot1,
            Bone_East_27__left1,
            Bone_East_27__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_LavaChallenge { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_LavaChallenge,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_LavaChallenge__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_Umbrella { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_Umbrella,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_Umbrella__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_East_Weavehome { get; } = new RoomData
    {
        Name = SceneNames.Bone_East_Weavehome,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_Weavehome__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bone_Steel_Servant { get; } = new RoomData
    {
        Name = SceneNames.Bone_Steel_Servant,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_Steel_Servant__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bonegrave { get; } = new RoomData
    {
        Name = SceneNames.Bonegrave,
        MapZone = MapZone.BONETOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Bonegrave__door1,
            Bonegrave__left1,
            Bonegrave__right1,
            Bonegrave__right2,
            Bonegrave__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Bonetown { get; } = new RoomData
    {
        Name = SceneNames.Bonetown,
        MapZone = MapZone.BONETOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Bonetown__bot1,
            // Bonetown__bot1_firstEntry,
            Bonetown__bot2,
            Bonetown__door1,
            Bonetown__left1,
            Bonetown__left2,
            Bonetown__right1,
            Bonetown__right2,
            Bonetown__top1,
            Bonetown__top2,
            Bonetown__top3,
            Bonetown__top4,
            Bonetown__top5,
            Bonetown__top6,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Chapel_Wanderer { get; } = new RoomData
    {
        Name = SceneNames.Chapel_Wanderer,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Chapel_of_the_Wanderer,
        Gates = new([
            Chapel_Wanderer__door_memoryEnd,
            Chapel_Wanderer__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_01 { get; } = new RoomData
    {
        Name = SceneNames.Clover_01,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_01__door_wakeOnGround,
            Clover_01__left1,
            Clover_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_01b { get; } = new RoomData
    {
        Name = SceneNames.Clover_01b,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_01b__door_wakeInMemory,
            Clover_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_02c { get; } = new RoomData
    {
        Name = SceneNames.Clover_02c,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_02c__left1,
            Clover_02c__left2,
            Clover_02c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_03 { get; } = new RoomData
    {
        Name = SceneNames.Clover_03,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_03__left1,
            Clover_03__left2,
            Clover_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_04b { get; } = new RoomData
    {
        Name = SceneNames.Clover_04b,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_04b__door1,
            Clover_04b__left1,
            Clover_04b__left2,
            Clover_04b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_05c { get; } = new RoomData
    {
        Name = SceneNames.Clover_05c,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_05c__left1,
            Clover_05c__left2,
            Clover_05c__right1,
            Clover_05c__right2,
            Clover_05c__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_06 { get; } = new RoomData
    {
        Name = SceneNames.Clover_06,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_06__bot1,
            Clover_06__bot2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_10 { get; } = new RoomData
    {
        Name = SceneNames.Clover_10,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_10__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_10_web { get; } = new RoomData
    {
        Name = SceneNames.Clover_10_web,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_10_web__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_11 { get; } = new RoomData
    {
        Name = SceneNames.Clover_11,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_16 { get; } = new RoomData
    {
        Name = SceneNames.Clover_16,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_16__right1,
            Clover_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_18 { get; } = new RoomData
    {
        Name = SceneNames.Clover_18,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_18__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_19 { get; } = new RoomData
    {
        Name = SceneNames.Clover_19,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_19__left1,
            Clover_19__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_20 { get; } = new RoomData
    {
        Name = SceneNames.Clover_20,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_20__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Clover_21 { get; } = new RoomData
    {
        Name = SceneNames.Clover_21,
        MapZone = MapZone.CLOVER,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_21__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_04 { get; } = new RoomData
    {
        Name = SceneNames.Cog_04,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_04__door1,
            Cog_04__door2,
            Cog_04__left2,
            Cog_04__right2,
            Cog_04__right3,
            Cog_04__top1,
            Cog_04__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_05 { get; } = new RoomData
    {
        Name = SceneNames.Cog_05,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_05__left1,
            Cog_05__right2,
            Cog_05__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_06 { get; } = new RoomData
    {
        Name = SceneNames.Cog_06,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_06__left2,
            Cog_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_07 { get; } = new RoomData
    {
        Name = SceneNames.Cog_07,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_07__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_08 { get; } = new RoomData
    {
        Name = SceneNames.Cog_08,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_08__bot1,
            Cog_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_09 { get; } = new RoomData
    {
        Name = SceneNames.Cog_09,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_09__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_09_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Cog_09_Destroyed,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_09_Destroyed__right1,
            Cog_09_Destroyed__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_10 { get; } = new RoomData
    {
        Name = SceneNames.Cog_10,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_10__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_10_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Cog_10_Destroyed,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_10_Destroyed__bot1,
            Cog_10_Destroyed__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_11_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Cog_11_Destroyed,
        MapZone = MapZone.NONE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_11_Destroyed__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_Bench { get; } = new RoomData
    {
        Name = SceneNames.Cog_Bench,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Bench__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_Dancers { get; } = new RoomData
    {
        Name = SceneNames.Cog_Dancers,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Dancers__bot1,
            Cog_Dancers__bot2,
            Cog_Dancers__door_arriveFromTower,
            Cog_Dancers__door1,
            Cog_Dancers__left1,
            Cog_Dancers__right1,
            Cog_Dancers__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cog_Pass { get; } = new RoomData
    {
        Name = SceneNames.Cog_Pass,
        MapZone = MapZone.COG_CORE,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Pass__left1,
            Cog_Pass__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_02 { get; } = new RoomData
    {
        Name = SceneNames.Coral_02,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_02__bot2,
            Coral_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_03 { get; } = new RoomData
    {
        Name = SceneNames.Coral_03,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_03__bot1,
            Coral_03__bot2,
            Coral_03__bot3,
            Coral_03__bot4,
            Coral_03__bot5,
            Coral_03__bot6,
            Coral_03__left1,
            Coral_03__left2,
            Coral_03__left3,
            Coral_03__right1,
            Coral_03__right2,
            Coral_03__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_10 { get; } = new RoomData
    {
        Name = SceneNames.Coral_10,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Grand_Gate,
        TitledArea = TitledAreaNames.Grand_Gate,
        Gates = new([
            Coral_10__left_firstEntrance,
            Coral_10__left1,
            Coral_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_11 { get; } = new RoomData
    {
        Name = SceneNames.Coral_11,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_11__left1,
            Coral_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_11b { get; } = new RoomData
    {
        Name = SceneNames.Coral_11b,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_11b__left1,
            Coral_11b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_12 { get; } = new RoomData
    {
        Name = SceneNames.Coral_12,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_12__left2,
            Coral_12__left3,
            Coral_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_19 { get; } = new RoomData
    {
        Name = SceneNames.Coral_19,
        MapZone = MapZone.RED_CORAL_GORGE,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_19__bot1,
            Coral_19__bot2,
            Coral_19__bot3,
            Coral_19__bot4,
            Coral_19__bot5,
            Coral_19__bot6,
            Coral_19__bot7,
            Coral_19__right1,
            Coral_19__top1,
            Coral_19__top2,
            Coral_19__top3,
            Coral_19__top4,
            Coral_19__top5,
            Coral_19__top6,
            Coral_19__top7,
            Coral_19__top8,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_19b { get; } = new RoomData
    {
        Name = SceneNames.Coral_19b,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_19b__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_23 { get; } = new RoomData
    {
        Name = SceneNames.Coral_23,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_23__left1,
            Coral_23__left2,
            Coral_23__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_24 { get; } = new RoomData
    {
        Name = SceneNames.Coral_24,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_24__left1,
            Coral_24__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_25 { get; } = new RoomData
    {
        Name = SceneNames.Coral_25,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_25__bot1,
            Coral_25__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_26 { get; } = new RoomData
    {
        Name = SceneNames.Coral_26,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_26__left1,
            Coral_26__left2,
            Coral_26__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_27 { get; } = new RoomData
    {
        Name = SceneNames.Coral_27,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_27__left1,
            Coral_27__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_28 { get; } = new RoomData
    {
        Name = SceneNames.Coral_28,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_28__door1,
            Coral_28__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_29 { get; } = new RoomData
    {
        Name = SceneNames.Coral_29,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Voltnest,
        Gates = new([
            Coral_29__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_32 { get; } = new RoomData
    {
        Name = SceneNames.Coral_32,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_32__left1,
            Coral_32__right1,
            Coral_32__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_33 { get; } = new RoomData
    {
        Name = SceneNames.Coral_33,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_33__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_34 { get; } = new RoomData
    {
        Name = SceneNames.Coral_34,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_34__door1,
            Coral_34__right1,
            Coral_34__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_35 { get; } = new RoomData
    {
        Name = SceneNames.Coral_35,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_35__left1,
            Coral_35__left2,
            Coral_35__right1,
            Coral_35__right2,
            Coral_35__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_35b { get; } = new RoomData
    {
        Name = SceneNames.Coral_35b,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_35b__bot1,
            Coral_35b__door1,
            Coral_35b__left2,
            Coral_35b__left3,
            Coral_35b__left4,
            Coral_35b__left5,
            Coral_35b__right1,
            Coral_35b__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_36 { get; } = new RoomData
    {
        Name = SceneNames.Coral_36,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_36__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_37 { get; } = new RoomData
    {
        Name = SceneNames.Coral_37,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_37__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_38 { get; } = new RoomData
    {
        Name = SceneNames.Coral_38,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_38__bot1,
            Coral_38__left1,
            Coral_38__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_39 { get; } = new RoomData
    {
        Name = SceneNames.Coral_39,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_39__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_40 { get; } = new RoomData
    {
        Name = SceneNames.Coral_40,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_40__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_41 { get; } = new RoomData
    {
        Name = SceneNames.Coral_41,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_41__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_42 { get; } = new RoomData
    {
        Name = SceneNames.Coral_42,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_42__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_43 { get; } = new RoomData
    {
        Name = SceneNames.Coral_43,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_43__left1,
            Coral_43__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_44 { get; } = new RoomData
    {
        Name = SceneNames.Coral_44,
        MapZone = MapZone.CORAL_CAVERNS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_44__left1,
            Coral_44__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_Judge_Arena { get; } = new RoomData
    {
        Name = SceneNames.Coral_Judge_Arena,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_Judge_Arena__door_caravanTravelEnd,
            Coral_Judge_Arena__door2,
            Coral_Judge_Arena__left1,
            Coral_Judge_Arena__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Coral_Tower_01 { get; } = new RoomData
    {
        Name = SceneNames.Coral_Tower_01,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Coral_Tower,
        Gates = new([
            Coral_Tower_01__door_wakeOnGround,
            Coral_Tower_01__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_01 { get; } = new RoomData
    {
        Name = SceneNames.Cradle_01,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_01__left1,
            Cradle_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_01_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Cradle_01_Destroyed,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_01_Destroyed__bot1,
            Cradle_01_Destroyed__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_02 { get; } = new RoomData
    {
        Name = SceneNames.Cradle_02,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_02__left2,
            Cradle_02__right1,
            Cradle_02__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_02b { get; } = new RoomData
    {
        Name = SceneNames.Cradle_02b,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_02b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_03 { get; } = new RoomData
    {
        Name = SceneNames.Cradle_03,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_03__left2,
            Cradle_03__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_03_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Cradle_03_Destroyed,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_03_Destroyed__bot1,
            Cradle_03_Destroyed__door1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_Destroyed_Challenge_01 { get; } = new RoomData
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_01,
        MapZone = MapZone.SURFACE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_01__left1,
            Cradle_Destroyed_Challenge_01__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_Destroyed_Challenge_02 { get; } = new RoomData
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_02,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_02__left1,
            Cradle_Destroyed_Challenge_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Cradle_Destroyed_Challenge_Bench { get; } = new RoomData
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_Bench,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_Bench__bot1,
            Cradle_Destroyed_Challenge_Bench__door1,
            Cradle_Destroyed_Challenge_Bench__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Crawl_01 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_01,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_01__left1,
            Crawl_01__right1,
        ]),
    };
    public static RoomData Crawl_02 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_02,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_02__left1,
            Crawl_02__left2,
            Crawl_02__right1,
            Crawl_02__right2,
            Crawl_02__right3,
        ]),
    };
    public static RoomData Crawl_03 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_03,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_03__bot1,
            Crawl_03__left1,
            Crawl_03__right1,
            Crawl_03__top1,
        ]),
    };
    public static RoomData Crawl_03b { get; } = new RoomData
    {
        Name = SceneNames.Crawl_03b,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_03b__bot1,
            Crawl_03b__right1,
            Crawl_03b__top1,
        ]),
    };
    public static RoomData Crawl_04 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_04,
        MapZone = MapZone.PATH_OF_BONE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_04__left1,
            Crawl_04__right1,
        ]),
    };
    public static RoomData Crawl_05 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_05,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Weavenest_Karn,
        Gates = new([
            Crawl_05__right1,
        ]),
    };
    public static RoomData Crawl_06 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_06,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_06__left1,
        ]),
    };
    public static RoomData Crawl_07 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_07,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_07__bot1,
            Crawl_07__left1,
            Crawl_07__top1,
        ]),
    };
    public static RoomData Crawl_08 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_08,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_08__bot1,
        ]),
    };
    public static RoomData Crawl_09 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_09,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_09__left1,
            Crawl_09__right1,
        ]),
    };
    public static RoomData Crawl_10 { get; } = new RoomData
    {
        Name = SceneNames.Crawl_10,
        MapZone = MapZone.CRAWLSPACE,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_10__right1,
        ]),
    };
    public static RoomData Dock_01 { get; } = new RoomData
    {
        Name = SceneNames.Dock_01,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_01__left1,
            Dock_01__right1,
            Dock_01__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_02 { get; } = new RoomData
    {
        Name = SceneNames.Dock_02,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_02__left1,
            Dock_02__left2,
            Dock_02__right1,
            Dock_02__right2,
            Dock_02__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_02b { get; } = new RoomData
    {
        Name = SceneNames.Dock_02b,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_02b__left1,
            Dock_02b__left2,
            Dock_02b__left3,
            Dock_02b__right1,
            Dock_02b__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_03 { get; } = new RoomData
    {
        Name = SceneNames.Dock_03,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03__bot1,
            Dock_03__left1,
            Dock_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_03b { get; } = new RoomData
    {
        Name = SceneNames.Dock_03b,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03b__left1,
            Dock_03b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_03c { get; } = new RoomData
    {
        Name = SceneNames.Dock_03c,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03c__left2,
            Dock_03c__top1,
            Dock_03c__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_03d { get; } = new RoomData
    {
        Name = SceneNames.Dock_03d,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03d__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_04 { get; } = new RoomData
    {
        Name = SceneNames.Dock_04,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_04__left1,
            Dock_04__right1,
            Dock_04__right2,
            Dock_04__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_05 { get; } = new RoomData
    {
        Name = SceneNames.Dock_05,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_06_Church { get; } = new RoomData
    {
        Name = SceneNames.Dock_06_Church,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_06_Church__bot1,
            Dock_06_Church__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_08 { get; } = new RoomData
    {
        Name = SceneNames.Dock_08,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_08__left1,
            Dock_08__left2,
            Dock_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_09 { get; } = new RoomData
    {
        Name = SceneNames.Dock_09,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_09__left1,
            Dock_09__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_10 { get; } = new RoomData
    {
        Name = SceneNames.Dock_10,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_10__left1,
            Dock_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_11 { get; } = new RoomData
    {
        Name = SceneNames.Dock_11,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_11__left1,
            Dock_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_12 { get; } = new RoomData
    {
        Name = SceneNames.Dock_12,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_12__door1,
            Dock_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_13 { get; } = new RoomData
    {
        Name = SceneNames.Dock_13,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_14 { get; } = new RoomData
    {
        Name = SceneNames.Dock_14,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_15 { get; } = new RoomData
    {
        Name = SceneNames.Dock_15,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_15__left1,
            Dock_15__left2,
            Dock_15__right1,
            Dock_15__right2,
            Dock_15__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dock_16 { get; } = new RoomData
    {
        Name = SceneNames.Dock_16,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_01 { get; } = new RoomData
    {
        Name = SceneNames.Dust_01,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_01__left1,
            Dust_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_02 { get; } = new RoomData
    {
        Name = SceneNames.Dust_02,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_02__left1,
            Dust_02__left2,
            Dust_02__right1,
            Dust_02__right2,
            Dust_02__right3,
            Dust_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_03 { get; } = new RoomData
    {
        Name = SceneNames.Dust_03,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_03__bot1,
            Dust_03__left1,
            Dust_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_04 { get; } = new RoomData
    {
        Name = SceneNames.Dust_04,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_04__door1,
            Dust_04__left1,
            Dust_04__left2,
            Dust_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_05 { get; } = new RoomData
    {
        Name = SceneNames.Dust_05,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_05__bot1,
            Dust_05__left1,
            Dust_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_06 { get; } = new RoomData
    {
        Name = SceneNames.Dust_06,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_06__left1,
            Dust_06__right1,
            Dust_06__right2,
            Dust_06__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_09 { get; } = new RoomData
    {
        Name = SceneNames.Dust_09,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_09__door1,
            Dust_09__door2,
            Dust_09__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_10 { get; } = new RoomData
    {
        Name = SceneNames.Dust_10,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_11 { get; } = new RoomData
    {
        Name = SceneNames.Dust_11,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_11__bot1,
            Dust_11__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_12 { get; } = new RoomData
    {
        Name = SceneNames.Dust_12,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_Barb { get; } = new RoomData
    {
        Name = SceneNames.Dust_Barb,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Barb__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_Chef { get; } = new RoomData
    {
        Name = SceneNames.Dust_Chef,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Chef__bot1,
            Dust_Chef__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_Maze_08_completed { get; } = new RoomData
    {
        Name = SceneNames.Dust_Maze_08_completed,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.The_Mist,
        Gates = new([
            Dust_Maze_08_completed__right1,
            Dust_Maze_08_completed__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Dust_Shack { get; } = new RoomData
    {
        Name = SceneNames.Dust_Shack,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Shack__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_01 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_01,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_01__bot1,
            Greymoor_01__left1,
            Greymoor_01__left2,
            Greymoor_01__right1,
            Greymoor_01__right2,
            Greymoor_01__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_02 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_02,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_02__left1,
            Greymoor_02__left2,
            Greymoor_02__left3,
            Greymoor_02__right1,
            Greymoor_02__right2,
            Greymoor_02__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_03 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_03,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_03__left1,
            Greymoor_03__left2,
            Greymoor_03__left3,
            Greymoor_03__right1,
            Greymoor_03__right2,
            Greymoor_03__right3,
            Greymoor_03__right4,
            Greymoor_03__right5,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_04 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_04,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_04__left1,
            Greymoor_04__left2,
            Greymoor_04__left3,
            Greymoor_04__right1,
            Greymoor_04__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_05 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_05,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_05__left1,
            Greymoor_05__left2,
            Greymoor_05__right1,
            Greymoor_05__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_06 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_06,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_06__left1,
            Greymoor_06__left2,
            Greymoor_06__left3,
            Greymoor_06__right1,
            Greymoor_06__right2,
            Greymoor_06__right3,
            Greymoor_06__right4,
            Greymoor_06__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_07 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_07,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_07__bot1,
            Greymoor_07__left1,
            Greymoor_07__right1,
            Greymoor_07__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_08 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_08,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_08__door_caravanTravelEnd,
            Greymoor_08__door1,
            Greymoor_08__door2,
            Greymoor_08__left2,
            Greymoor_08__right1,
            Greymoor_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_10 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_10,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_10__left1,
            Greymoor_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_11 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_11,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_11__left1,
            Greymoor_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_12 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_12,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_12__left1,
            Greymoor_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_13 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_13,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_13__bot1,
            Greymoor_13__left1,
            Greymoor_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_15 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_15,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_15__left1,
            Greymoor_15__left3,
            Greymoor_15__right2,
            Greymoor_15__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_15b { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_15b,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_15b__door1,
            Greymoor_15b__left2,
            Greymoor_15b__left3,
            Greymoor_15b__right1,
            Greymoor_15b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_16 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_16,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_16__left1,
            Greymoor_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_17 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_17,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_17__left1,
            Greymoor_17__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_20b { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_20b,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_20b__door1,
            Greymoor_20b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_20c { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_20c,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_20c__door_memoryEnd,
            Greymoor_20c__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_21 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_21,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_21__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_22 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_22,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_22__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Greymoor_24 { get; } = new RoomData
    {
        Name = SceneNames.Greymoor_24,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_24__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Halfway_01 { get; } = new RoomData
    {
        Name = SceneNames.Halfway_01,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Halfway_Home,
        Gates = new([
            Halfway_01__bot1,
            Halfway_01__left1,
            Halfway_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Hang_01 { get; } = new RoomData
    {
        Name = SceneNames.Hang_01,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_01__right1,
            Hang_01__right2,
        ]),
    };
    public static RoomData Hang_02 { get; } = new RoomData
    {
        Name = SceneNames.Hang_02,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_02__left1,
            Hang_02__right1,
        ]),
    };
    public static RoomData Hang_03 { get; } = new RoomData
    {
        Name = SceneNames.Hang_03,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_03__left1,
            Hang_03__left2,
            Hang_03__right1,
            Hang_03__right2,
            Hang_03__top1,
        ]),
    };
    public static RoomData Hang_03_top { get; } = new RoomData
    {
        Name = SceneNames.Hang_03_top,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_03_top__bot1,
        ]),
    };
    public static RoomData Hang_04 { get; } = new RoomData
    {
        Name = SceneNames.Hang_04,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_04__left1,
            Hang_04__right1,
        ]),
    };
    public static RoomData Hang_06 { get; } = new RoomData
    {
        Name = SceneNames.Hang_06,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_06__bot1,
            Hang_06__door1,
            Hang_06__left1,
            Hang_06__right1,
            Hang_06__top1,
        ]),
    };
    public static RoomData Hang_06_bank { get; } = new RoomData
    {
        Name = SceneNames.Hang_06_bank,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_06_bank__left1,
        ]),
    };
    public static RoomData Hang_06b { get; } = new RoomData
    {
        Name = SceneNames.Hang_06b,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_06b__door_tubeEnter,
            Hang_06b__left1,
        ]),
    };
    public static RoomData Hang_07 { get; } = new RoomData
    {
        Name = SceneNames.Hang_07,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_07__bot1,
            Hang_07__left1,
            Hang_07__right1,
            Hang_07__top1,
        ]),
    };
    public static RoomData Hang_08 { get; } = new RoomData
    {
        Name = SceneNames.Hang_08,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_08__bot1,
            Hang_08__left1,
            Hang_08__left2,
            Hang_08__left3,
            Hang_08__left4,
            Hang_08__right1,
            Hang_08__right2,
        ]),
    };
    public static RoomData Hang_09 { get; } = new RoomData
    {
        Name = SceneNames.Hang_09,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_09__right1,
        ]),
    };
    public static RoomData Hang_10 { get; } = new RoomData
    {
        Name = SceneNames.Hang_10,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_10__left1,
            Hang_10__right1,
        ]),
    };
    public static RoomData Hang_12 { get; } = new RoomData
    {
        Name = SceneNames.Hang_12,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_12__right1,
        ]),
    };
    public static RoomData Hang_13 { get; } = new RoomData
    {
        Name = SceneNames.Hang_13,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_13__left1,
            Hang_13__right1,
        ]),
    };
    public static RoomData Hang_14 { get; } = new RoomData
    {
        Name = SceneNames.Hang_14,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_14__left1,
        ]),
    };
    public static RoomData Hang_15 { get; } = new RoomData
    {
        Name = SceneNames.Hang_15,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_15__right1,
        ]),
    };
    public static RoomData Hang_16 { get; } = new RoomData
    {
        Name = SceneNames.Hang_16,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_16__door1,
            Hang_16__right1,
        ]),
    };
    public static RoomData Hang_17b { get; } = new RoomData
    {
        Name = SceneNames.Hang_17b,
        MapZone = MapZone.HANG,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_17b__left1,
        ]),
    };
    public static RoomData Last_Dive { get; } = new RoomData
    {
        Name = SceneNames.Last_Dive,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Last_Dive__door_cutscenePosition,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Last_Dive_Return { get; } = new RoomData
    {
        Name = SceneNames.Last_Dive_Return,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Last_Dive_Return__door_cutscenePosition,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_01 { get; } = new RoomData
    {
        Name = SceneNames.Library_01,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_01__left1,
            Library_01__left2,
            Library_01__left3,
            Library_01__right1,
            Library_01__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_02 { get; } = new RoomData
    {
        Name = SceneNames.Library_02,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_02__left1,
            Library_02__left2,
            Library_02__right1,
            Library_02__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_03 { get; } = new RoomData
    {
        Name = SceneNames.Library_03,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_03__left1,
            Library_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_04 { get; } = new RoomData
    {
        Name = SceneNames.Library_04,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_04__left1,
            Library_04__left2,
            Library_04__left3,
            Library_04__left4,
            Library_04__right1,
            Library_04__right2,
            Library_04__right3,
            Library_04__right4,
            Library_04__right5,
            Library_04__right6,
            Library_04__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_05 { get; } = new RoomData
    {
        Name = SceneNames.Library_05,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_05__left1,
            Library_05__left2,
            Library_05__right1,
            Library_05__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_06 { get; } = new RoomData
    {
        Name = SceneNames.Library_06,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_06__left1,
            Library_06__left2,
            Library_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_07 { get; } = new RoomData
    {
        Name = SceneNames.Library_07,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_07__bot1,
            Library_07__bot2,
            Library_07__bot3,
            Library_07__left1,
            Library_07__left2,
            Library_07__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_08 { get; } = new RoomData
    {
        Name = SceneNames.Library_08,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_08__left1,
            Library_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_09 { get; } = new RoomData
    {
        Name = SceneNames.Library_09,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_09__bot1,
            Library_09__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_10 { get; } = new RoomData
    {
        Name = SceneNames.Library_10,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_10__bot1,
            Library_10__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_11 { get; } = new RoomData
    {
        Name = SceneNames.Library_11,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_11__left1,
            Library_11__left2,
            Library_11__left3,
            Library_11__right1,
            Library_11__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_11b { get; } = new RoomData
    {
        Name = SceneNames.Library_11b,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_11b__left3,
            Library_11b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_12 { get; } = new RoomData
    {
        Name = SceneNames.Library_12,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_12__door1,
            Library_12__left1,
            Library_12__left2,
            Library_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_12b { get; } = new RoomData
    {
        Name = SceneNames.Library_12b,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_12b__left1,
            Library_12b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_13 { get; } = new RoomData
    {
        Name = SceneNames.Library_13,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_13__left1,
            Library_13__right1,
            Library_13__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_13b { get; } = new RoomData
    {
        Name = SceneNames.Library_13b,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_13b__left1,
            Library_13b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_14 { get; } = new RoomData
    {
        Name = SceneNames.Library_14,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_15 { get; } = new RoomData
    {
        Name = SceneNames.Library_15,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_15__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Library_16 { get; } = new RoomData
    {
        Name = SceneNames.Library_16,
        MapZone = MapZone.LIBRARY,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Ant_Queen { get; } = new RoomData
    {
        Name = SceneNames.Memory_Ant_Queen,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Memory_Ant_Queen__door_wakeInMemory,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Coral_Tower { get; } = new RoomData
    {
        Name = SceneNames.Memory_Coral_Tower,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Coral_Tower,
        Gates = new([
            Memory_Coral_Tower__door_wakeInMemory,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_First_Sinner { get; } = new RoomData
    {
        Name = SceneNames.Memory_First_Sinner,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Memory_First_Sinner__door_wakeOnGround,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Needolin { get; } = new RoomData
    {
        Name = SceneNames.Memory_Needolin,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Memory_Needolin__door_wakeOnGround,
            Memory_Needolin__left1,
            Memory_Needolin__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Red { get; } = new RoomData
    {
        Name = SceneNames.Memory_Red,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Memory_Red__door_enterRedMemory_Beast,
            Memory_Red__door_enterRedMemory_Hive,
            Memory_Red__door_enterRedMemory_Weaver,
            Memory_Red__door_wakeInMemory,
            Memory_Red__door_wakeInRedMemory_Beast,
            Memory_Red__door_wakeInRedMemory_Hive,
            Memory_Red__door_wakeInRedMemory_Root,
            Memory_Red__door_wakeInRedMemory_Weaver,
            Memory_Red__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Silk_Heart_BellBeast { get; } = new RoomData
    {
        Name = SceneNames.Memory_Silk_Heart_BellBeast,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Memory_Silk_Heart_BellBeast__door_wakeOnGround,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Silk_Heart_LaceTower { get; } = new RoomData
    {
        Name = SceneNames.Memory_Silk_Heart_BellBeast,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Memory_Silk_Heart_LaceTower__door_wakeOnGround,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Memory_Silk_Heart_WardBoss { get; } = new RoomData
    {
        Name = SceneNames.Memory_Silk_Heart_WardBoss,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Memory_Silk_Heart_WardBoss__door_wakeOnGround,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Mosstown_01 { get; } = new RoomData
    {
        Name = SceneNames.Mosstown_01,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_01__bot1,
            Mosstown_01__right1,
            Mosstown_01__right2,
            Mosstown_01__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Mosstown_02 { get; } = new RoomData
    {
        Name = SceneNames.Mosstown_02,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_02__bot1,
            Mosstown_02__bot2,
            Mosstown_02__left1,
            Mosstown_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Mosstown_02c { get; } = new RoomData
    {
        Name = SceneNames.Mosstown_02c,
        MapZone = MapZone.MOSSTOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_02c__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Mosstown_03 { get; } = new RoomData
    {
        Name = SceneNames.Mosstown_03,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_03__right1,
            Mosstown_03__right2,
            Mosstown_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Organ_01 { get; } = new RoomData
    {
        Name = SceneNames.Organ_01,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Exhaust_Organ,
        Gates = new([
            Organ_01__left1,
            Organ_01__left2,
            Organ_01__left3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_01 { get; } = new RoomData
    {
        Name = SceneNames.Peak_01,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_01__left1,
            Peak_01__left2,
            Peak_01__left3,
            Peak_01__left4,
            Peak_01__right1,
            Peak_01__right2,
            Peak_01__right3,
            Peak_01__right4,
            Peak_01__top1,
            Peak_01__top2,
            Peak_01__top3,
            Peak_01__top4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_02 { get; } = new RoomData
    {
        Name = SceneNames.Peak_02,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_02__left1,
            Peak_02__left2,
            Peak_02__left3,
            Peak_02__right1,
            Peak_02__right2,
            Peak_02__right3,
            Peak_02__right4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_04 { get; } = new RoomData
    {
        Name = SceneNames.Peak_04,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04__left1,
            Peak_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_04c { get; } = new RoomData
    {
        Name = SceneNames.Peak_04c,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04c__right1,
            Peak_04c__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_04d { get; } = new RoomData
    {
        Name = SceneNames.Peak_04d,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04d__left1,
            Peak_04d__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_05 { get; } = new RoomData
    {
        Name = SceneNames.Peak_05,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05__bot1,
            Peak_05__right3,
            Peak_05__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_05c { get; } = new RoomData
    {
        Name = SceneNames.Peak_05c,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05c__left2,
            Peak_05c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_05d { get; } = new RoomData
    {
        Name = SceneNames.Peak_05d,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05d__bot1,
            Peak_05d__door1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_05e { get; } = new RoomData
    {
        Name = SceneNames.Peak_05e,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05e__left1,
            Peak_05e__right1,
            Peak_05e__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_06 { get; } = new RoomData
    {
        Name = SceneNames.Peak_06,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_06__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_06b { get; } = new RoomData
    {
        Name = SceneNames.Peak_06b,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_06b__door1,
            Peak_06b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_07 { get; } = new RoomData
    {
        Name = SceneNames.Peak_07,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_07__bot1,
            Peak_07__bot2,
            Peak_07__bot3,
            Peak_07__bot4,
            Peak_07__bot5,
            Peak_07__top1,
            Peak_07__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_08 { get; } = new RoomData
    {
        Name = SceneNames.Peak_08,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_08__bot1,
            Peak_08__right1,
            Peak_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_08b { get; } = new RoomData
    {
        Name = SceneNames.Peak_08b,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_08b__bot4,
            Peak_08b__bot5,
            Peak_08b__bot6,
            Peak_08b__left1,
            Peak_08b__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_10 { get; } = new RoomData
    {
        Name = SceneNames.Peak_10,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_12 { get; } = new RoomData
    {
        Name = SceneNames.Peak_12,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Peak_Mask_Maker { get; } = new RoomData
    {
        Name = SceneNames.Peak_Mask_Maker,
        MapZone = MapZone.PEAK,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_Mask_Maker__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Caravan_Interior { get; } = new RoomData
    {
        Name = SceneNames.Room_Caravan_Interior,
        MapZone = MapZone.NONE,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Room_Caravan_Interior__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Caravan_Spa { get; } = new RoomData
    {
        Name = SceneNames.Room_Caravan_Spa,
        MapZone = MapZone.NONE,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Room_Caravan_Spa__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_CrowCourt { get; } = new RoomData
    {
        Name = SceneNames.Room_CrowCourt,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Room_CrowCourt__bot1,
            Room_CrowCourt__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_CrowCourt_02 { get; } = new RoomData
    {
        Name = SceneNames.Room_CrowCourt_02,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Room_CrowCourt_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Diving_Bell { get; } = new RoomData
    {
        Name = SceneNames.Room_Diving_Bell,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Room_Diving_Bell__door_cinematicEnd,
            Room_Diving_Bell__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Diving_Bell_Abyss { get; } = new RoomData
    {
        Name = SceneNames.Room_Diving_Bell_Abyss,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Room_Diving_Bell_Abyss__door_wakeOnGround,
            Room_Diving_Bell_Abyss__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Diving_Bell_Abyss_Fixed { get; } = new RoomData
    {
        Name = SceneNames.Room_Diving_Bell_Abyss_Fixed,
        MapZone = MapZone.ABYSS,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Room_Diving_Bell_Abyss_Fixed__door_cinematicEnd,
            Room_Diving_Bell_Abyss_Fixed__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Forge { get; } = new RoomData
    {
        Name = SceneNames.Room_Forge,
        MapZone = MapZone.DOCKS,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Room_Forge__left1,
            Room_Forge__right1,
            Room_Forge__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Huntress { get; } = new RoomData
    {
        Name = SceneNames.Room_Huntress,
        MapZone = MapZone.AQUEDUCT,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Room_Huntress__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Pinstress { get; } = new RoomData
    {
        Name = SceneNames.Room_Pinstress,
        MapZone = MapZone.JUDGE_STEPS,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Room_Pinstress__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Room_Witch { get; } = new RoomData
    {
        Name = SceneNames.Room_Witch,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Room_Witch__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shadow_01 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_01,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_01__left1,
            Shadow_01__left2,
            Shadow_01__left3,
            Shadow_01__right1,
            Shadow_01__right2,
            Shadow_01__right3,
            Shadow_01__top1,
        ]),
    };
    public static RoomData Shadow_02 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_02,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_02__left1,
            Shadow_02__left2,
            Shadow_02__right1,
            Shadow_02__right2,
            Shadow_02__right3,
        ]),
    };
    public static RoomData Shadow_03 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_03,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_03__left1,
            Shadow_03__right1,
            Shadow_03__top1,
        ]),
    };
    public static RoomData Shadow_04 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_04,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_04__right1,
            Shadow_04__right2,
            Shadow_04__top1,
        ]),
    };
    public static RoomData Shadow_04b { get; } = new RoomData
    {
        Name = SceneNames.Shadow_04b,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_04b__left1,
            Shadow_04b__right1,
        ]),
    };
    public static RoomData Shadow_05 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_05,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_05__left1,
            Shadow_05__right1,
        ]),
    };
    public static RoomData Shadow_08 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_08,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_08__left1,
            Shadow_08__top1,
        ]),
    };
    public static RoomData Shadow_09 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_09,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_09__left1,
            Shadow_09__left2,
            Shadow_09__left3,
            Shadow_09__right1,
        ]),
    };
    public static RoomData Shadow_10 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_10,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_10__bot1,
            Shadow_10__left1,
            Shadow_10__right1,
        ]),
    };
    public static RoomData Shadow_11 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_11,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_11__left1,
            Shadow_11__right1,
        ]),
    };
    public static RoomData Shadow_12 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_12,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_12__left1,
            Shadow_12__right1,
        ]),
    };
    public static RoomData Shadow_13 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_13,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_13__left1,
        ]),
    };
    public static RoomData Shadow_14 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_14,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_14__right1,
            Shadow_14__right2,
        ]),
    };
    public static RoomData Shadow_15 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_15,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_15__right1,
            Shadow_15__right2,
        ]),
    };
    public static RoomData Shadow_16 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_16,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_16__left1,
            Shadow_16__right1,
        ]),
    };
    public static RoomData Shadow_18 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_18,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_18__door1,
            Shadow_18__left1,
            Shadow_18__right1,
        ]),
    };
    public static RoomData Shadow_19 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_19,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_19__left1,
            Shadow_19__left2,
            Shadow_19__right1,
            Shadow_19__right2,
        ]),
    };
    public static RoomData Shadow_20 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_20,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_20__bot1,
            Shadow_20__top1,
        ]),
    };
    public static RoomData Shadow_21 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_21,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_21__bot1,
        ]),
    };
    public static RoomData Shadow_22 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_22,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_22__bot1,
            Shadow_22__top1,
            Shadow_22__top2,
            Shadow_22__top3,
        ]),
    };
    public static RoomData Shadow_23 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_23,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_23__left1,
        ]),
    };
    public static RoomData Shadow_24 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_24,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_24__left1,
        ]),
    };
    public static RoomData Shadow_25 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_25,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_25__left1,
        ]),
    };
    public static RoomData Shadow_26 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_26,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_26__left1,
            Shadow_26__left2,
            Shadow_26__right1,
            Shadow_26__right2,
        ]),
    };
    public static RoomData Shadow_27 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_27,
        MapZone = MapZone.SWAMP,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_27__left1,
            Shadow_27__right1,
        ]),
    };
    public static RoomData Shadow_28 { get; } = new RoomData
    {
        Name = SceneNames.Shadow_28,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_28__right1,
        ]),
    };
    public static RoomData Shadow_Bilehaven_Room { get; } = new RoomData
    {
        Name = SceneNames.Shadow_Bilehaven_Room,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_Bilehaven_Room__left1,
        ]),
    };
    public static RoomData Shadow_Weavehome { get; } = new RoomData
    {
        Name = SceneNames.Shadow_Weavehome,
        MapZone = MapZone.DUSTPENS,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_Weavehome__left1,
        ]),
    };
    public static RoomData Shellgrave { get; } = new RoomData
    {
        Name = SceneNames.Shellgrave,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellgrave__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_01 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_01,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_01__left1,
            Shellwood_01__left2,
            Shellwood_01__right1,
            Shellwood_01__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_01b { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_01b,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_01b__left1,
            Shellwood_01b__left2,
            Shellwood_01b__right1,
            Shellwood_01b__right2,
            Shellwood_01b__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_02 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_02,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_02__left2,
            Shellwood_02__left3,
            Shellwood_02__right1,
            Shellwood_02__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_03 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_03,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_03__bot1,
            Shellwood_03__left1,
            Shellwood_03__left3,
            Shellwood_03__right1,
            Shellwood_03__right2,
            Shellwood_03__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_04b { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_04b,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_04b__left1,
            Shellwood_04b__right1,
            Shellwood_04b__top1,
            Shellwood_04b__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_04c { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_04c,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_04c__bot1,
            Shellwood_04c__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_08 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_08,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_08__bot1,
            Shellwood_08__left1,
            Shellwood_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_08c { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_08c,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_08c__left1,
            Shellwood_08c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_10 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_10,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_10__left1,
            Shellwood_10__left2,
            Shellwood_10__left3,
            Shellwood_10__right1,
            Shellwood_10__right2,
            Shellwood_10__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_11 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_11,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_11__right1,
            Shellwood_11__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_11b { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_11b,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_11b__door_wakeOnGround,
            Shellwood_11b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_11b_Memory { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_11b_Memory,
        MapZone = MapZone.MEMORY,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_11b_Memory__door_wakeInMemory
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_13 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_13,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_13__left1,
            Shellwood_13__left2,
            Shellwood_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_14 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_14,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_15 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_15,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_15__left1,
            Shellwood_15__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_16 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_16,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_16__left1,
            Shellwood_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_18 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_18,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_18__left1,
            Shellwood_18__right1,
            Shellwood_18__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_19 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_19,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_19__door_fastTravelExit,
            Shellwood_19__left1,
            Shellwood_19__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_20 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_20,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_20__left1,
            Shellwood_20__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_22 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_22,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_22__door1,
            Shellwood_22__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_25 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_25,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_25__door1,
            Shellwood_25__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_25b { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_25b,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_25b__door_curseSequenceEnd,
            Shellwood_25b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_26 { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_26,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_26__bot1,
            Shellwood_26__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Shellwood_Witch { get; } = new RoomData
    {
        Name = SceneNames.Shellwood_Witch,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_Witch__door1,
            Shellwood_Witch__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_01 { get; } = new RoomData
    {
        Name = SceneNames.Slab_01,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_01__left1,
            Slab_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_02 { get; } = new RoomData
    {
        Name = SceneNames.Slab_02,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_02__left1,
            Slab_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_03 { get; } = new RoomData
    {
        Name = SceneNames.Slab_03,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_03__door_slabCaged,
            Slab_03__left1,
            Slab_03__left2,
            Slab_03__left3,
            Slab_03__left4,
            Slab_03__left5,
            Slab_03__left6,
            Slab_03__left7,
            Slab_03__left8,
            Slab_03__right1,
            Slab_03__right2,
            Slab_03__right3,
            Slab_03__right4,
            Slab_03__right5,
            Slab_03__right7,
            Slab_03__right8,
            Slab_03__right9,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_04 { get; } = new RoomData
    {
        Name = SceneNames.Slab_04,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_04__bot1,
            Slab_04__door1,
            Slab_04__right1,
            Slab_04__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_05 { get; } = new RoomData
    {
        Name = SceneNames.Slab_05,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_05__bot1,
            Slab_05__right1,
            Slab_05__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_06 { get; } = new RoomData
    {
        Name = SceneNames.Slab_06,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_06__door_fastTravelExit,
            Slab_06__door1,
            Slab_06__left1,
            Slab_06__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_07 { get; } = new RoomData
    {
        Name = SceneNames.Slab_07,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_07__right1,
            Slab_07__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_08 { get; } = new RoomData
    {
        Name = SceneNames.Slab_08,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_08__door1,
            Slab_08__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_10b { get; } = new RoomData
    {
        Name = SceneNames.Slab_10b,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_10b__door_wakeOnGround,
            Slab_10b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_10c { get; } = new RoomData
    {
        Name = SceneNames.Slab_10c,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_10c__door1,
            Slab_10c__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_12 { get; } = new RoomData
    {
        Name = SceneNames.Slab_12,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_13 { get; } = new RoomData
    {
        Name = SceneNames.Slab_13,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_13__bot1,
            Slab_13__door1,
            Slab_13__left1,
            Slab_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_14 { get; } = new RoomData
    {
        Name = SceneNames.Slab_14,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_14__right1,
            Slab_14__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_15 { get; } = new RoomData
    {
        Name = SceneNames.Slab_15,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_15__bot1,
            Slab_15__left1,
            Slab_15__right1,
            Slab_15__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_16 { get; } = new RoomData
    {
        Name = SceneNames.Slab_16,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_16__bot1,
            Slab_16__door1,
            Slab_16__left1,
            Slab_16__right1,
            Slab_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_16b { get; } = new RoomData
    {
        Name = SceneNames.Slab_16b,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_16b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_17 { get; } = new RoomData
    {
        Name = SceneNames.Slab_17,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_17__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_18 { get; } = new RoomData
    {
        Name = SceneNames.Slab_18,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_18__left1,
            Slab_18__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_19b { get; } = new RoomData
    {
        Name = SceneNames.Slab_19b,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_19b__left1,
            Slab_19b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_20 { get; } = new RoomData
    {
        Name = SceneNames.Slab_20,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_20__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_21 { get; } = new RoomData
    {
        Name = SceneNames.Slab_21,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_21__left1,
            Slab_21__left3,
            Slab_21__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_22 { get; } = new RoomData
    {
        Name = SceneNames.Slab_22,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_22__bot1,
            Slab_22__bot2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_23 { get; } = new RoomData
    {
        Name = SceneNames.Slab_23,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_23__door1,
            Slab_23__door2,
            Slab_23__left1,
            Slab_23__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_Cell { get; } = new RoomData
    {
        Name = SceneNames.Slab_Cell,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_Cell_Creature { get; } = new RoomData
    {
        Name = SceneNames.Slab_Cell_Creature,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell_Creature__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Slab_Cell_Quiet { get; } = new RoomData
    {
        Name = SceneNames.Slab_Cell_Quiet,
        MapZone = MapZone.THE_SLAB,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell_Quiet__left1,
            Slab_Cell_Quiet__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_01 { get; } = new RoomData
    {
        Name = SceneNames.Song_01,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01__bot1,
            Song_01__right2,
            Song_01__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_01b { get; } = new RoomData
    {
        Name = SceneNames.Song_01b,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01b__door_tubeEnter,
            Song_01b__bot1,
            Song_01b__right1,
            Song_01b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_01c { get; } = new RoomData
    {
        Name = SceneNames.Song_01c,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01c__left1,
            Song_01c__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_02 { get; } = new RoomData
    {
        Name = SceneNames.Song_02,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_02__left2,
            Song_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_03 { get; } = new RoomData
    {
        Name = SceneNames.Song_03,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_03__bot1,
            Song_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_04 { get; } = new RoomData
    {
        Name = SceneNames.Song_04,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_04__bot1,
            Song_04__left1,
            Song_04__right1,
            Song_04__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_05 { get; } = new RoomData
    {
        Name = SceneNames.Song_05,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_05__left3,
            Song_05__left4,
            Song_05__left5,
            Song_05__right2,
            Song_05__right3,
            Song_05__right4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_07 { get; } = new RoomData
    {
        Name = SceneNames.Song_07,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_08 { get; } = new RoomData
    {
        Name = SceneNames.Song_08,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_09 { get; } = new RoomData
    {
        Name = SceneNames.Song_09,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_09__bot1,
            Song_09__right1,
            Song_09__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_09b { get; } = new RoomData
    {
        Name = SceneNames.Song_09b,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_09b__left1,
            Song_09b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_10 { get; } = new RoomData
    {
        Name = SceneNames.Song_10,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_10__left1,
            Song_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_11 { get; } = new RoomData
    {
        Name = SceneNames.Song_11,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_11__left1,
            Song_11__left2,
            Song_11__left3,
            Song_11__left4,
            Song_11__right1,
            Song_11__right2,
            Song_11__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_12 { get; } = new RoomData
    {
        Name = SceneNames.Song_12,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_12__left1,
            Song_12__left2,
            Song_12__left3,
            Song_12__left4,
            Song_12__right1,
            Song_12__right2,
            Song_12__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_13 { get; } = new RoomData
    {
        Name = SceneNames.Song_13,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_13__left1,
            Song_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_14 { get; } = new RoomData
    {
        Name = SceneNames.Song_14,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_15 { get; } = new RoomData
    {
        Name = SceneNames.Song_15,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_15__left1,
            Song_15__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_17 { get; } = new RoomData
    {
        Name = SceneNames.Song_17,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_17__left1,
            Song_17__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_18 { get; } = new RoomData
    {
        Name = SceneNames.Song_18,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_18__bot1,
            Song_18__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_19_entrance { get; } = new RoomData
    {
        Name = SceneNames.Song_19_entrance,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_19_entrance__left1,
            Song_19_entrance__right1,
            Song_19_entrance__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_20 { get; } = new RoomData
    {
        Name = SceneNames.Song_20,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_20__left1,
            Song_20__left2,
            Song_20__right_cutsceneEntry,
            Song_20__right4,
            Song_20__right5,
            Song_20__right6,
            Song_20__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_20b { get; } = new RoomData
    {
        Name = SceneNames.Song_20b,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_20b__bot1,
            Song_20b__left2,
            Song_20b__left4,
            Song_20b__right2,
            Song_20b__right3,
            Song_20b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_24 { get; } = new RoomData
    {
        Name = SceneNames.Song_24,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_24__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_25 { get; } = new RoomData
    {
        Name = SceneNames.Song_25,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_25__bot1,
            Song_25__left1,
            Song_25__right1,
            Song_25__top1,
            Song_25__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_26 { get; } = new RoomData
    {
        Name = SceneNames.Song_26,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_26__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_27 { get; } = new RoomData
    {
        Name = SceneNames.Song_27,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_27__left1,
            Song_27__right1,
            Song_27__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_28 { get; } = new RoomData
    {
        Name = SceneNames.Song_28,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_28__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_29 { get; } = new RoomData
    {
        Name = SceneNames.Song_29,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_29__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_Enclave { get; } = new RoomData
    {
        Name = SceneNames.Song_Enclave,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Enclave__bot1,
            Song_Enclave__door_act3_wakeUp,
            Song_Enclave__door1,
            Song_Enclave__left1,
            Song_Enclave__left2,
            Song_Enclave__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_Enclave_Tube { get; } = new RoomData
    {
        Name = SceneNames.Song_Enclave_Tube,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Enclave_Tube__bot1,
            Song_Enclave_Tube__door_tubeEnter,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_Tower_01 { get; } = new RoomData
    {
        Name = SceneNames.Song_Tower_01,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Tower_01__door_cinematicEnd,
            Song_Tower_01__door_cutsceneEndLaceTower,
            Song_Tower_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Song_Tower_Destroyed { get; } = new RoomData
    {
        Name = SceneNames.Song_Tower_Destroyed,
        MapZone = MapZone.CRADLE,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Tower_Destroyed__bot1,
            Song_Tower_Destroyed__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Sprintmaster_Cave { get; } = new RoomData
    {
        Name = SceneNames.Sprintmaster_Cave,
        MapZone = MapZone.WILDS,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Sprintmaster_Cave__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tube_Hub { get; } = new RoomData
    {
        Name = SceneNames.Tube_Hub,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Tube_Hub__door_tubeEnter,
            Tube_Hub__left1,
            Tube_Hub__left3,
            Tube_Hub__left4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_01 { get; } = new RoomData
    {
        Name = SceneNames.Tut_01,
        MapZone = MapZone.MOSS_CAVE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_01__left1,
            Tut_01__left2,
            Tut_01__left3,
            Tut_01__right1,
            Tut_01__right2,
            Tut_01__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_01b { get; } = new RoomData
    {
        Name = SceneNames.Tut_01b,
        MapZone = MapZone.MOSS_CAVE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_01b__left1,
            Tut_01b__left2,
            Tut_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_02 { get; } = new RoomData
    {
        Name = SceneNames.Tut_02,
        MapZone = MapZone.MOSS_CAVE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_02__right1,
            Tut_02__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_03 { get; } = new RoomData
    {
        Name = SceneNames.Tut_03,
        MapZone = MapZone.BONETOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_03__door1,
            Tut_03__door1_firstExit,
            Tut_03__door2,
            Tut_03__right1,
            Tut_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_04 { get; } = new RoomData
    {
        Name = SceneNames.Tut_04,
        MapZone = MapZone.BONETOWN,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_04__door_memoryEnd,
            Tut_04__door_ritualEnd,
            Tut_04__left1,
            Tut_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Tut_05 { get; } = new RoomData
    {
        Name = SceneNames.Tut_05,
        MapZone = MapZone.MOSS_CAVE,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_05__door_memoryEnd,
            Tut_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_01 { get; } = new RoomData
    {
        Name = SceneNames.Under_01,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_01__left1,
            Under_01__left2,
            Under_01__left3,
            Under_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_01b { get; } = new RoomData
    {
        Name = SceneNames.Under_01b,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_01b__left1,
            Under_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_02 { get; } = new RoomData
    {
        Name = SceneNames.Under_02,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_02__left1,
            Under_02__left3,
            Under_02__right1,
            Under_02__right2,
            Under_02__right3,
            Under_02__right4,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_03 { get; } = new RoomData
    {
        Name = SceneNames.Under_03,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_03b { get; } = new RoomData
    {
        Name = SceneNames.Under_03b,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03b__left1,
            Under_03b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_03c { get; } = new RoomData
    {
        Name = SceneNames.Under_03c,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03c__left1,
            Under_03c__left2,
            Under_03c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_03d { get; } = new RoomData
    {
        Name = SceneNames.Under_03d,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03d__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_04 { get; } = new RoomData
    {
        Name = SceneNames.Under_04,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_04__left1,
            Under_04__right1,
            Under_04__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_05 { get; } = new RoomData
    {
        Name = SceneNames.Under_05,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_05__left1,
            Under_05__left2,
            Under_05__left3,
            Under_05__right1,
            Under_05__right2,
            Under_05__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_06 { get; } = new RoomData
    {
        Name = SceneNames.Under_06,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_06__left1,
            Under_06__right1,
            Under_06__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_07 { get; } = new RoomData
    {
        Name = SceneNames.Under_07,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07__left3,
            Under_07__right2,
            Under_07__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_07b { get; } = new RoomData
    {
        Name = SceneNames.Under_07b,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07b__bot1,
            Under_07b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_07c { get; } = new RoomData
    {
        Name = SceneNames.Under_07c,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07c__bot1,
            Under_07c__left2,
            Under_07c__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_08 { get; } = new RoomData
    {
        Name = SceneNames.Under_08,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_08__bot1,
            Under_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_10 { get; } = new RoomData
    {
        Name = SceneNames.Under_10,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_10__left1,
            Under_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_11 { get; } = new RoomData
    {
        Name = SceneNames.Under_11,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_11__left1,
            Under_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_12 { get; } = new RoomData
    {
        Name = SceneNames.Under_12,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_13 { get; } = new RoomData
    {
        Name = SceneNames.Under_13,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_13__left1,
            Under_13__left2,
            Under_13__left3,
            Under_13__left4,
            Under_13__right1,
            Under_13__right2,
            Under_13__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_14 { get; } = new RoomData
    {
        Name = SceneNames.Under_14,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_16 { get; } = new RoomData
    {
        Name = SceneNames.Under_16,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_17 { get; } = new RoomData
    {
        Name = SceneNames.Under_17,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_17__bot1,
            Under_17__bot2,
            Under_17__door1,
            Under_17__left1,
            Under_17__right1,
            Under_17__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_18 { get; } = new RoomData
    {
        Name = SceneNames.Under_18,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_18__left1,
            Under_18__right1,
            Under_18__top1,
            Under_18__top2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_19 { get; } = new RoomData
    {
        Name = SceneNames.Under_19,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19__left1,
            Under_19__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_19b { get; } = new RoomData
    {
        Name = SceneNames.Under_19b,
        MapZone = MapZone.CITY_OF_SONG,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_19c { get; } = new RoomData
    {
        Name = SceneNames.Under_19c,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19c__bot1,
            Under_19c__left1,
            Under_19c__left2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_20 { get; } = new RoomData
    {
        Name = SceneNames.Under_20,
        MapZone = MapZone.NONE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_20__door_memoryEnd,
            Under_20__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_21 { get; } = new RoomData
    {
        Name = SceneNames.Under_21,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_21__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_22 { get; } = new RoomData
    {
        Name = SceneNames.Under_22,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_22__door_tubeEnter,
            Under_22__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_23 { get; } = new RoomData
    {
        Name = SceneNames.Under_23,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_23__bot1,
            Under_23__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Under_27 { get; } = new RoomData
    {
        Name = SceneNames.Under_27,
        MapZone = MapZone.SHELLWOOD_THICKET,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_27__left1,
            Under_27__right1,
            Under_27__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_01 { get; } = new RoomData
    {
        Name = SceneNames.Ward_01,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_01__left1,
            Ward_01__left2,
            Ward_01__left3,
            Ward_01__right1,
            Ward_01__right2,
            Ward_01__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_02 { get; } = new RoomData
    {
        Name = SceneNames.Ward_02,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_02__bot1,
            Ward_02__door_cinematicEnd,
            Ward_02__right1,
            Ward_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_02b { get; } = new RoomData
    {
        Name = SceneNames.Ward_02b,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_02b__bot1,
            Ward_02b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_03 { get; } = new RoomData
    {
        Name = SceneNames.Ward_03,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_03__bot1,
            Ward_03__door1,
            Ward_03__left1,
            Ward_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_04 { get; } = new RoomData
    {
        Name = SceneNames.Ward_04,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_04__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_05 { get; } = new RoomData
    {
        Name = SceneNames.Ward_05,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_06 { get; } = new RoomData
    {
        Name = SceneNames.Ward_06,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_06__bot1,
            Ward_06__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_07 { get; } = new RoomData
    {
        Name = SceneNames.Ward_07,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_07__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Ward_09 { get; } = new RoomData
    {
        Name = SceneNames.Ward_09,
        MapZone = MapZone.WARD,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_09__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_02 { get; } = new RoomData
    {
        Name = SceneNames.Weave_02,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_02__left2,
            Weave_02__left3,
            Weave_02__left4,
            Weave_02__right1,
            Weave_02__right2,
            Weave_02__right3,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_03 { get; } = new RoomData
    {
        Name = SceneNames.Weave_03,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_04 { get; } = new RoomData
    {
        Name = SceneNames.Weave_04,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_04__left1,
            Weave_04__right2,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_05b { get; } = new RoomData
    {
        Name = SceneNames.Weave_05b,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_05b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_07 { get; } = new RoomData
    {
        Name = SceneNames.Weave_07,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_07__left1,
            Weave_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_08 { get; } = new RoomData
    {
        Name = SceneNames.Weave_08,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_08__left1,
            Weave_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_10 { get; } = new RoomData
    {
        Name = SceneNames.Weave_10,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_10__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_11 { get; } = new RoomData
    {
        Name = SceneNames.Weave_11,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_11__right1,
            Weave_11__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_12 { get; } = new RoomData
    {
        Name = SceneNames.Weave_12,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_13 { get; } = new RoomData
    {
        Name = SceneNames.Weave_13,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_13__left1,
            Weave_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Weave_14 { get; } = new RoomData
    {
        Name = SceneNames.Weave_14,
        MapZone = MapZone.WEAVER_SHRINE,
        MapArea = MapAreaNames.Weavenest_Atla,
        TitledArea = TitledAreaNames.Weavenest_Atla,
        Gates = new([
            Weave_14__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_02 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_02,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_02__left1,
            Wisp_02__right1,
            Wisp_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_03 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_03,
        MapZone = MapZone.GREYMOOR,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_03__door1,
            Wisp_03__right1,
            Wisp_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_04 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_04,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_04__bot1,
            Wisp_04__left1,
            Wisp_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_05 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_05,
        MapZone = MapZone.UNDERSTORE,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_05__bot1,
            Wisp_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_06 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_06,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_06__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_07 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_07,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_07__left1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_08 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_08,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_08__left1,
            Wisp_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static RoomData Wisp_09 { get; } = new RoomData
    {
        Name = SceneNames.Wisp_09,
        MapZone = MapZone.WISP,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_09__right1,
            Wisp_09__top1,
        ]),
        ManuallyVerified = true,
    };
}
