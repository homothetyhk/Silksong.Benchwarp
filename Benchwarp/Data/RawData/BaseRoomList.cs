using static Benchwarp.Data.RawData.BaseGateList;

namespace Benchwarp.Data.RawData;

public static class BaseRoomList
{
    public static Room Abandoned_town { get; } = new Room
    {
        Name = SceneNames.Abandoned_town,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Nameless_Town,
        Gates = new([
            Abandoned_town__bot1,
            Abandoned_town__door1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_01 { get; } = new Room
    {
        Name = SceneNames.Abyss_01,
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
    public static Room Abyss_02 { get; } = new Room
    {
        Name = SceneNames.Abyss_02,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_02__left1,
            Abyss_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_02b { get; } = new Room
    {
        Name = SceneNames.Abyss_02b,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_02b__left2,
            Abyss_02b__right1,
            Abyss_02b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_03 { get; } = new Room
    {
        Name = SceneNames.Abyss_03,
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
    public static Room Abyss_04 { get; } = new Room
    {
        Name = SceneNames.Abyss_04,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_04__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_05 { get; } = new Room
    {
        Name = SceneNames.Abyss_05,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_05__left2,
            Abyss_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_06 { get; } = new Room
    {
        Name = SceneNames.Abyss_06,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_06__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_07 { get; } = new Room
    {
        Name = SceneNames.Abyss_07,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_07__left1,
            Abyss_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_08 { get; } = new Room
    {
        Name = SceneNames.Abyss_08,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_08__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_09 { get; } = new Room
    {
        Name = SceneNames.Abyss_09,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_09__bot1,
            Abyss_09__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_11 { get; } = new Room
    {
        Name = SceneNames.Abyss_11,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_11__bot1,
            Abyss_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_12 { get; } = new Room
    {
        Name = SceneNames.Abyss_12,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_12__left1,
            Abyss_12__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_13 { get; } = new Room
    {
        Name = SceneNames.Abyss_13,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_13__left1,
            Abyss_13__right1,
            Abyss_13__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Abyss_Cocoon { get; } = new Room
    {
        Name = SceneNames.Abyss_Cocoon,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Abyss_Cocoon__door_entry,
            Abyss_Cocoon__door_test,
        ]),
        ManuallyVerified = true,
    };
    public static Room Ant_02 { get; } = new Room
    {
        Name = SceneNames.Ant_02,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_02__left1,
            Ant_02__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_03 { get; } = new Room
    {
        Name = SceneNames.Ant_03,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_03__left2,
            Ant_03__right3,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_04 { get; } = new Room
    {
        Name = SceneNames.Ant_04,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04__left1,
            Ant_04__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_04_left { get; } = new Room
    {
        Name = SceneNames.Ant_04_left,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04_left__left1,
            Ant_04_left__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_04_mid { get; } = new Room
    {
        Name = SceneNames.Ant_04_mid,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_04_mid__left1,
            Ant_04_mid__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_05b { get; } = new Room
    {
        Name = SceneNames.Ant_05b,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_05b__bot1,
            Ant_05b__bot2,
            Ant_05b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_05c { get; } = new Room
    {
        Name = SceneNames.Ant_05c,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_05c__left1,
            Ant_05c__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_08 { get; } = new Room
    {
        Name = SceneNames.Ant_08,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_08__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_09 { get; } = new Room
    {
        Name = SceneNames.Ant_09,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_09__left1,
            Ant_09__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_14 { get; } = new Room
    {
        Name = SceneNames.Ant_14,
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
        ManuallyVerified = false,
    };
    public static Room Ant_17 { get; } = new Room
    {
        Name = SceneNames.Ant_17,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_17__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_19 { get; } = new Room
    {
        Name = SceneNames.Ant_19,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_19__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_20 { get; } = new Room
    {
        Name = SceneNames.Ant_20,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_20__door1,
            Ant_20__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_21 { get; } = new Room
    {
        Name = SceneNames.Ant_21,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_21__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_Merchant { get; } = new Room
    {
        Name = SceneNames.Ant_Merchant,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_Merchant__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ant_Queen { get; } = new Room
    {
        Name = SceneNames.Ant_Queen,
        MapArea = MapAreaNames.Hunter_s_March,
        TitledArea = TitledAreaNames.Hunter_s_March,
        Gates = new([
            Ant_Queen__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Aqueduct_01 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_01,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_01__left1,
            Aqueduct_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_02 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_02,
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
    public static Room Aqueduct_03 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_03,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_03__left1,
            Aqueduct_03__right1,
            Aqueduct_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_04 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_04,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_04__bot1,
            Aqueduct_04__door1,
            Aqueduct_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_05 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_05,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_05__door2,
            Aqueduct_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_06 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_06,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_06__bot1,
            Aqueduct_06__left1,
            Aqueduct_06__left2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_07 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_07,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_07__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Aqueduct_08 { get; } = new Room
    {
        Name = SceneNames.Aqueduct_08,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Aqueduct_08__left1,
            Aqueduct_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Arborium_01 { get; } = new Room
    {
        Name = SceneNames.Arborium_01,
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
    public static Room Arborium_02 { get; } = new Room
    {
        Name = SceneNames.Arborium_02,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_02__left1,
            Arborium_02__right1,
        ]),
    };
    public static Room Arborium_03 { get; } = new Room
    {
        Name = SceneNames.Arborium_03,
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
    public static Room Arborium_04 { get; } = new Room
    {
        Name = SceneNames.Arborium_04,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_04__left1,
            Arborium_04__right1,
        ]),
    };
    public static Room Arborium_05 { get; } = new Room
    {
        Name = SceneNames.Arborium_05,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_05__right1,
            Arborium_05__top1,
        ]),
    };
    public static Room Arborium_06 { get; } = new Room
    {
        Name = SceneNames.Arborium_06,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_06__bot1,
            Arborium_06__left1,
            Arborium_06__right1,
        ]),
    };
    public static Room Arborium_07 { get; } = new Room
    {
        Name = SceneNames.Arborium_07,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_07__left1,
            Arborium_07__top1,
        ]),
    };
    public static Room Arborium_08 { get; } = new Room
    {
        Name = SceneNames.Arborium_08,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_08__bot1,
            Arborium_08__left1,
        ]),
    };
    public static Room Arborium_09 { get; } = new Room
    {
        Name = SceneNames.Arborium_09,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_09__right1,
            Arborium_09__right2,
        ]),
    };
    public static Room Arborium_10 { get; } = new Room
    {
        Name = SceneNames.Arborium_10,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_10__left1,
        ]),
    };
    public static Room Arborium_11 { get; } = new Room
    {
        Name = SceneNames.Arborium_11,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_11__left1,
            Arborium_11__right1,
        ]),
    };
    public static Room Arborium_Tube { get; } = new Room
    {
        Name = SceneNames.Arborium_Tube,
        MapArea = MapAreaNames.Memorium,
        TitledArea = TitledAreaNames.Memorium,
        Gates = new([
            Arborium_Tube__right1,
        ]),
    };
    public static Room Aspid_01 { get; } = new Room
    {
        Name = SceneNames.Aspid_01,
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
    public static Room Bellshrine { get; } = new Room
    {
        Name = SceneNames.Bellshrine,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bellshrine__left1,
            Bellshrine__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellshrine_02 { get; } = new Room
    {
        Name = SceneNames.Bellshrine_02,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Bellshrine_02__left1,
            Bellshrine_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellshrine_03 { get; } = new Room
    {
        Name = SceneNames.Bellshrine_03,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Bellshrine_03__left1,
            Bellshrine_03__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellshrine_05 { get; } = new Room
    {
        Name = SceneNames.Bellshrine_05,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bellshrine_05__left1,
            Bellshrine_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellshrine_Coral { get; } = new Room
    {
        Name = SceneNames.Bellshrine_Coral,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Bellshrine_Coral__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellshrine_Enclave { get; } = new Room
    {
        Name = SceneNames.Bellshrine_Enclave,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.First_Shrine,
        Gates = new([
            Bellshrine_Enclave__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Belltown { get; } = new Room
    {
        Name = SceneNames.Belltown,
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
        ManuallyVerified = false,
    };
    public static Room Belltown_04 { get; } = new Room
    {
        Name = SceneNames.Belltown_04,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_04__bot1,
            Belltown_04__left1,
            Belltown_04__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_06 { get; } = new Room
    {
        Name = SceneNames.Belltown_06,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_06__door1,
            Belltown_06__left1,
            Belltown_06__left3,
            Belltown_06__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_07 { get; } = new Room
    {
        Name = SceneNames.Belltown_07,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_07__left1,
            Belltown_07__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_08 { get; } = new Room
    {
        Name = SceneNames.Belltown_08,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_basement { get; } = new Room
    {
        Name = SceneNames.Belltown_basement,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_basement__bot1,
            Belltown_basement__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_basement_03 { get; } = new Room
    {
        Name = SceneNames.Belltown_basement_03,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_basement_03__left1,
            Belltown_basement_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_doctor { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_doctor,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_doctor__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_Fisher { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_Fisher,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Fisher__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_pinsmith { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_pinsmith,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_pinsmith__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_Relic { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_Relic,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Relic__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_shellwood { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_shellwood,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_shellwood__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Room_Spare { get; } = new Room
    {
        Name = SceneNames.Belltown_Room_Spare,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Room_Spare__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Belltown_Shrine { get; } = new Room
    {
        Name = SceneNames.Belltown_Shrine,
        MapArea = MapAreaNames.Bellhart,
        TitledArea = TitledAreaNames.Bellhart,
        Gates = new([
            Belltown_Shrine__right1,
            Belltown_Shrine__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellway_01 { get; } = new Room
    {
        Name = SceneNames.Bellway_01,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Bellway_01__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_02 { get; } = new Room
    {
        Name = SceneNames.Bellway_02,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Bellway_02__left1,
            Bellway_02__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_03 { get; } = new Room
    {
        Name = SceneNames.Bellway_03,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bellway_03__left1,
            Bellway_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_04 { get; } = new Room
    {
        Name = SceneNames.Bellway_04,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Bellway_04__bot1,
            Bellway_04__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_08 { get; } = new Room
    {
        Name = SceneNames.Bellway_08,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Bellway_08__left1,
            Bellway_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellway_Aqueduct { get; } = new Room
    {
        Name = SceneNames.Bellway_Aqueduct,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Bellway_Aqueduct__left1,
            Bellway_Aqueduct__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_City { get; } = new Room
    {
        Name = SceneNames.Bellway_City,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Bellway_City__left1,
            Bellway_City__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bellway_Peak { get; } = new Room
    {
        Name = SceneNames.Bellway_Peak,
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
    public static Room Bellway_Peak_02 { get; } = new Room
    {
        Name = SceneNames.Bellway_Peak_02,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Bellway_Peak_02__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bellway_Shadow { get; } = new Room
    {
        Name = SceneNames.Bellway_Shadow,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Bellway_Shadow__left1,
        ]),
    };
    public static Room Bone_01 { get; } = new Room
    {
        Name = SceneNames.Bone_01,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01__left2,
            Bone_01__right1,
            Bone_01__right2,
            Bone_01__top2,
            Bone_01__top2_extra,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_01b { get; } = new Room
    {
        Name = SceneNames.Bone_01b,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01b__left1,
            Bone_01b__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_01c { get; } = new Room
    {
        Name = SceneNames.Bone_01c,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_01c__left1,
            Bone_01c__left2,
            Bone_01c__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_02 { get; } = new Room
    {
        Name = SceneNames.Bone_02,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_02__left1,
            Bone_02__right1,
            Bone_02__top1,
            Bone_02__top2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_03 { get; } = new Room
    {
        Name = SceneNames.Bone_03,
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
        ManuallyVerified = false,
    };
    public static Room Bone_04 { get; } = new Room
    {
        Name = SceneNames.Bone_04,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_04__bot2,
            Bone_04__left1,
            Bone_04__left2,
            Bone_04__right1,
            Bone_04__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_05 { get; } = new Room
    {
        Name = SceneNames.Bone_05,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_05__bot1,
            Bone_05__left1,
            Bone_05__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_05b { get; } = new Room
    {
        Name = SceneNames.Bone_05b,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_05b__left1,
            Bone_05b__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_06 { get; } = new Room
    {
        Name = SceneNames.Bone_06,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_06__bot1,
            Bone_06__left1,
            Bone_06__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_07 { get; } = new Room
    {
        Name = SceneNames.Bone_07,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_07__left1,
            Bone_07__right1,
            Bone_07__right2,
            Bone_07__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_08 { get; } = new Room
    {
        Name = SceneNames.Bone_08,
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
        ManuallyVerified = false,
    };
    public static Room Bone_09 { get; } = new Room
    {
        Name = SceneNames.Bone_09,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_09__left1,
            Bone_09__right1,
            Bone_09__right2,
            Bone_09__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_10 { get; } = new Room
    {
        Name = SceneNames.Bone_10,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_10__bot1,
            Bone_10__door2,
            Bone_10__left1,
            Bone_10__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_11 { get; } = new Room
    {
        Name = SceneNames.Bone_11,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_11__bot1,
            Bone_11__left1,
            Bone_11__right1,
            Bone_11__right2,
            Bone_11__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_11b { get; } = new Room
    {
        Name = SceneNames.Bone_11b,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_11b__right1,
            Bone_11b__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_12 { get; } = new Room
    {
        Name = SceneNames.Bone_12,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_12__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_14 { get; } = new Room
    {
        Name = SceneNames.Bone_14,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_14__left1,
            Bone_14__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_15 { get; } = new Room
    {
        Name = SceneNames.Bone_15,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_15__bot1,
            Bone_15__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_16 { get; } = new Room
    {
        Name = SceneNames.Bone_16,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_16__left1,
            Bone_16__right1,
            Bone_16__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_17 { get; } = new Room
    {
        Name = SceneNames.Bone_17,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_17__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_18 { get; } = new Room
    {
        Name = SceneNames.Bone_18,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_18__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_19 { get; } = new Room
    {
        Name = SceneNames.Bone_19,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_19__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bone_East_01 { get; } = new Room
    {
        Name = SceneNames.Bone_East_01,
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
    public static Room Bone_East_02 { get; } = new Room
    {
        Name = SceneNames.Bone_East_02,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_02__left1,
            Bone_East_02__right1,
            Bone_East_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_02b { get; } = new Room
    {
        Name = SceneNames.Bone_East_02b,
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
    public static Room Bone_East_03 { get; } = new Room
    {
        Name = SceneNames.Bone_East_03,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_03__left1,
            Bone_East_03__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_04 { get; } = new Room
    {
        Name = SceneNames.Bone_East_04,
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
    public static Room Bone_East_04b { get; } = new Room
    {
        Name = SceneNames.Bone_East_04b,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_04b__left1,
            Bone_East_04b__right1,
            Bone_East_04b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_04c { get; } = new Room
    {
        Name = SceneNames.Bone_East_04c,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_04c__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_05 { get; } = new Room
    {
        Name = SceneNames.Bone_East_05,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_05__left1,
            Bone_East_05__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_07 { get; } = new Room
    {
        Name = SceneNames.Bone_East_07,
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
    public static Room Bone_East_08 { get; } = new Room
    {
        Name = SceneNames.Bone_East_08,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_08__left1,
            Bone_East_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_09 { get; } = new Room
    {
        Name = SceneNames.Bone_East_09,
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
    public static Room Bone_East_09b { get; } = new Room
    {
        Name = SceneNames.Bone_East_09b,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_09b__bot1,
            Bone_East_09b__left1,
            Bone_East_09b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_10 { get; } = new Room
    {
        Name = SceneNames.Bone_East_10,
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
    public static Room Bone_East_10_Church { get; } = new Room
    {
        Name = SceneNames.Bone_East_10_Church,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_10_Church__bot1,
            Bone_East_10_Church__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_10_Room { get; } = new Room
    {
        Name = SceneNames.Bone_East_10_Room,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_10_Room__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_11 { get; } = new Room
    {
        Name = SceneNames.Bone_East_11,
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
    public static Room Bone_East_12 { get; } = new Room
    {
        Name = SceneNames.Bone_East_12,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_12__bot1,
            Bone_East_12__left1,
            Bone_East_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_13 { get; } = new Room
    {
        Name = SceneNames.Bone_East_13,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_13__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_14 { get; } = new Room
    {
        Name = SceneNames.Bone_East_14,
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
    public static Room Bone_East_14b { get; } = new Room
    {
        Name = SceneNames.Bone_East_14b,
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
    public static Room Bone_East_15 { get; } = new Room
    {
        Name = SceneNames.Bone_East_15,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_15__bot1,
            Bone_East_15__left1,
            Bone_East_15__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_16 { get; } = new Room
    {
        Name = SceneNames.Bone_East_16,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_16__bot1,
            Bone_East_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_17 { get; } = new Room
    {
        Name = SceneNames.Bone_East_17,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_17__bot1,
            Bone_East_17__left1,
            Bone_East_17__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_17b { get; } = new Room
    {
        Name = SceneNames.Bone_East_17b,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_17b__left1,
            Bone_East_17b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_18 { get; } = new Room
    {
        Name = SceneNames.Bone_East_18,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18__left1,
            Bone_East_18__right1,
            Bone_East_18__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_18b { get; } = new Room
    {
        Name = SceneNames.Bone_East_18b,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18b__door1,
            Bone_East_18b__left1,
            Bone_East_18b__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_18c { get; } = new Room
    {
        Name = SceneNames.Bone_East_18c,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_18c__left1,
            Bone_East_18c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_20 { get; } = new Room
    {
        Name = SceneNames.Bone_East_20,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_20__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_21 { get; } = new Room
    {
        Name = SceneNames.Bone_East_21,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_21__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_22 { get; } = new Room
    {
        Name = SceneNames.Bone_East_22,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_22__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_24 { get; } = new Room
    {
        Name = SceneNames.Bone_East_24,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_24__bot1,
            Bone_East_24__left1,
            Bone_East_24__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_25 { get; } = new Room
    {
        Name = SceneNames.Bone_East_25,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_25__door1,
            Bone_East_25__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_26 { get; } = new Room
    {
        Name = SceneNames.Bone_East_26,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_26__bot1,
            Bone_East_26__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_27 { get; } = new Room
    {
        Name = SceneNames.Bone_East_27,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_27__bot1,
            Bone_East_27__left1,
            Bone_East_27__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_LavaChallenge { get; } = new Room
    {
        Name = SceneNames.Bone_East_LavaChallenge,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_LavaChallenge__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_Umbrella { get; } = new Room
    {
        Name = SceneNames.Bone_East_Umbrella,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_Umbrella__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_East_Weavehome { get; } = new Room
    {
        Name = SceneNames.Bone_East_Weavehome,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Bone_East_Weavehome__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Bone_Steel_Servant { get; } = new Room
    {
        Name = SceneNames.Bone_Steel_Servant,
        MapArea = MapAreaNames.The_Marrow,
        TitledArea = TitledAreaNames.The_Marrow,
        Gates = new([
            Bone_Steel_Servant__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Bonegrave { get; } = new Room
    {
        Name = SceneNames.Bonegrave,
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
    public static Room Bonetown { get; } = new Room
    {
        Name = SceneNames.Bonetown,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Bone_Bottom,
        Gates = new([
            Bonetown__bot1,
            Bonetown__bot1_firstEntry,
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
    public static Room Chapel_Wanderer { get; } = new Room
    {
        Name = SceneNames.Chapel_Wanderer,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Chapel_of_the_Wanderer,
        Gates = new([
            Chapel_Wanderer__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_01 { get; } = new Room
    {
        Name = SceneNames.Clover_01,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_01__left1,
            Clover_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_01b { get; } = new Room
    {
        Name = SceneNames.Clover_01b,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_02c { get; } = new Room
    {
        Name = SceneNames.Clover_02c,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_02c__left1,
            Clover_02c__left2,
            Clover_02c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_03 { get; } = new Room
    {
        Name = SceneNames.Clover_03,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_03__left1,
            Clover_03__left2,
            Clover_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_04b { get; } = new Room
    {
        Name = SceneNames.Clover_04b,
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
    public static Room Clover_05c { get; } = new Room
    {
        Name = SceneNames.Clover_05c,
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
    public static Room Clover_06 { get; } = new Room
    {
        Name = SceneNames.Clover_06,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_06__bot1,
            Clover_06__bot2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_10 { get; } = new Room
    {
        Name = SceneNames.Clover_10,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_10__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_10_web { get; } = new Room
    {
        Name = SceneNames.Clover_10_web,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_10_web__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_11 { get; } = new Room
    {
        Name = SceneNames.Clover_11,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_16 { get; } = new Room
    {
        Name = SceneNames.Clover_16,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_16__right1,
            Clover_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_18 { get; } = new Room
    {
        Name = SceneNames.Clover_18,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_18__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_19 { get; } = new Room
    {
        Name = SceneNames.Clover_19,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_19__left1,
            Clover_19__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_20 { get; } = new Room
    {
        Name = SceneNames.Clover_20,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_20__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Clover_21 { get; } = new Room
    {
        Name = SceneNames.Clover_21,
        MapArea = MapAreaNames.Verdania,
        TitledArea = TitledAreaNames.Lost_Verdania,
        Gates = new([
            Clover_21__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Cog_04 { get; } = new Room
    {
        Name = SceneNames.Cog_04,
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
        ManuallyVerified = false,
    };
    public static Room Cog_05 { get; } = new Room
    {
        Name = SceneNames.Cog_05,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_05__left1,
            Cog_05__right2,
            Cog_05__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_06 { get; } = new Room
    {
        Name = SceneNames.Cog_06,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_06__left2,
            Cog_06__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_07 { get; } = new Room
    {
        Name = SceneNames.Cog_07,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_07__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_08 { get; } = new Room
    {
        Name = SceneNames.Cog_08,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_08__bot1,
            Cog_08__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_09 { get; } = new Room
    {
        Name = SceneNames.Cog_09,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_09__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_09_Destroyed { get; } = new Room
    {
        Name = SceneNames.Cog_09_Destroyed,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_09_Destroyed__right1,
            Cog_09_Destroyed__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_10 { get; } = new Room
    {
        Name = SceneNames.Cog_10,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_10__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_10_Destroyed { get; } = new Room
    {
        Name = SceneNames.Cog_10_Destroyed,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_10_Destroyed__bot1,
            Cog_10_Destroyed__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_11_Destroyed { get; } = new Room
    {
        Name = SceneNames.Cog_11_Destroyed,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_11_Destroyed__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_Bench { get; } = new Room
    {
        Name = SceneNames.Cog_Bench,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Bench__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_Dancers { get; } = new Room
    {
        Name = SceneNames.Cog_Dancers,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Dancers__bot1,
            Cog_Dancers__bot2,
            Cog_Dancers__door1,
            Cog_Dancers__left1,
            Cog_Dancers__right1,
            Cog_Dancers__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cog_Pass { get; } = new Room
    {
        Name = SceneNames.Cog_Pass,
        MapArea = MapAreaNames.Cogwork_Core,
        TitledArea = TitledAreaNames.Cogwork_Core,
        Gates = new([
            Cog_Pass__left1,
            Cog_Pass__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_02 { get; } = new Room
    {
        Name = SceneNames.Coral_02,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_02__bot2,
            Coral_02__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_03 { get; } = new Room
    {
        Name = SceneNames.Coral_03,
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
        ManuallyVerified = false,
    };
    public static Room Coral_10 { get; } = new Room
    {
        Name = SceneNames.Coral_10,
        MapArea = MapAreaNames.Grand_Gate,
        TitledArea = TitledAreaNames.Grand_Gate,
        Gates = new([
            Coral_10__left1,
            Coral_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Coral_11 { get; } = new Room
    {
        Name = SceneNames.Coral_11,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_11__left1,
            Coral_11__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_11b { get; } = new Room
    {
        Name = SceneNames.Coral_11b,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_11b__left1,
            Coral_11b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_12 { get; } = new Room
    {
        Name = SceneNames.Coral_12,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_12__left2,
            Coral_12__left3,
            Coral_12__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_19 { get; } = new Room
    {
        Name = SceneNames.Coral_19,
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
        ManuallyVerified = false,
    };
    public static Room Coral_19b { get; } = new Room
    {
        Name = SceneNames.Coral_19b,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_19b__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_23 { get; } = new Room
    {
        Name = SceneNames.Coral_23,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_23__left1,
            Coral_23__left2,
            Coral_23__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_24 { get; } = new Room
    {
        Name = SceneNames.Coral_24,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_24__left1,
            Coral_24__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_25 { get; } = new Room
    {
        Name = SceneNames.Coral_25,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_25__bot1,
            Coral_25__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_26 { get; } = new Room
    {
        Name = SceneNames.Coral_26,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_26__left1,
            Coral_26__left2,
            Coral_26__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_27 { get; } = new Room
    {
        Name = SceneNames.Coral_27,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_27__left1,
            Coral_27__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_28 { get; } = new Room
    {
        Name = SceneNames.Coral_28,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_28__door1,
            Coral_28__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_29 { get; } = new Room
    {
        Name = SceneNames.Coral_29,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Voltnest,
        Gates = new([
            Coral_29__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Coral_32 { get; } = new Room
    {
        Name = SceneNames.Coral_32,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_32__left1,
            Coral_32__right1,
            Coral_32__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_33 { get; } = new Room
    {
        Name = SceneNames.Coral_33,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_33__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_34 { get; } = new Room
    {
        Name = SceneNames.Coral_34,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_34__door1,
            Coral_34__right1,
            Coral_34__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_35 { get; } = new Room
    {
        Name = SceneNames.Coral_35,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_35__left1,
            Coral_35__left2,
            Coral_35__right1,
            Coral_35__right2,
            Coral_35__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_35b { get; } = new Room
    {
        Name = SceneNames.Coral_35b,
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
        ManuallyVerified = false,
    };
    public static Room Coral_36 { get; } = new Room
    {
        Name = SceneNames.Coral_36,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_36__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_37 { get; } = new Room
    {
        Name = SceneNames.Coral_37,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_37__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_38 { get; } = new Room
    {
        Name = SceneNames.Coral_38,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_38__bot1,
            Coral_38__left1,
            Coral_38__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_39 { get; } = new Room
    {
        Name = SceneNames.Coral_39,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_39__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_40 { get; } = new Room
    {
        Name = SceneNames.Coral_40,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_40__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_41 { get; } = new Room
    {
        Name = SceneNames.Coral_41,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_41__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_42 { get; } = new Room
    {
        Name = SceneNames.Coral_42,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_42__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_43 { get; } = new Room
    {
        Name = SceneNames.Coral_43,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_43__left1,
            Coral_43__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_44 { get; } = new Room
    {
        Name = SceneNames.Coral_44,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Sands_of_Karak,
        Gates = new([
            Coral_44__left1,
            Coral_44__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_Judge_Arena { get; } = new Room
    {
        Name = SceneNames.Coral_Judge_Arena,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Coral_Judge_Arena__door2,
            Coral_Judge_Arena__left1,
            Coral_Judge_Arena__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Coral_Tower_01 { get; } = new Room
    {
        Name = SceneNames.Coral_Tower_01,
        MapArea = MapAreaNames.Sands_of_Karak,
        TitledArea = TitledAreaNames.Coral_Tower,
        Gates = new([
            Coral_Tower_01__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Cradle_01 { get; } = new Room
    {
        Name = SceneNames.Cradle_01,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_01__left1,
            Cradle_01__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_01_Destroyed { get; } = new Room
    {
        Name = SceneNames.Cradle_01_Destroyed,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_01_Destroyed__bot1,
            Cradle_01_Destroyed__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_02 { get; } = new Room
    {
        Name = SceneNames.Cradle_02,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_02__left2,
            Cradle_02__right1,
            Cradle_02__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_02b { get; } = new Room
    {
        Name = SceneNames.Cradle_02b,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_02b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_03 { get; } = new Room
    {
        Name = SceneNames.Cradle_03,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_03__left2,
            Cradle_03__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_03_Destroyed { get; } = new Room
    {
        Name = SceneNames.Cradle_03_Destroyed,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_03_Destroyed__bot1,
            Cradle_03_Destroyed__door1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_Destroyed_Challenge_01 { get; } = new Room
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_01,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_01__left1,
            Cradle_Destroyed_Challenge_01__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_Destroyed_Challenge_02 { get; } = new Room
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_02,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_02__left1,
            Cradle_Destroyed_Challenge_02__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Cradle_Destroyed_Challenge_Bench { get; } = new Room
    {
        Name = SceneNames.Cradle_Destroyed_Challenge_Bench,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Cradle_Destroyed_Challenge_Bench__bot1,
            Cradle_Destroyed_Challenge_Bench__door1,
            Cradle_Destroyed_Challenge_Bench__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Crawl_01 { get; } = new Room
    {
        Name = SceneNames.Crawl_01,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_01__left1,
            Crawl_01__right1,
        ]),
    };
    public static Room Crawl_02 { get; } = new Room
    {
        Name = SceneNames.Crawl_02,
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
    public static Room Crawl_03 { get; } = new Room
    {
        Name = SceneNames.Crawl_03,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_03__bot1,
            Crawl_03__left1,
            Crawl_03__right1,
            Crawl_03__top1,
        ]),
    };
    public static Room Crawl_03b { get; } = new Room
    {
        Name = SceneNames.Crawl_03b,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_03b__bot1,
            Crawl_03b__right1,
            Crawl_03b__top1,
        ]),
    };
    public static Room Crawl_04 { get; } = new Room
    {
        Name = SceneNames.Crawl_04,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_04__left1,
            Crawl_04__right1,
        ]),
    };
    public static Room Crawl_05 { get; } = new Room
    {
        Name = SceneNames.Crawl_05,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Weavenest_Karn,
        Gates = new([
            Crawl_05__right1,
        ]),
    };
    public static Room Crawl_06 { get; } = new Room
    {
        Name = SceneNames.Crawl_06,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_06__left1,
        ]),
    };
    public static Room Crawl_07 { get; } = new Room
    {
        Name = SceneNames.Crawl_07,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_07__bot1,
            Crawl_07__left1,
            Crawl_07__top1,
        ]),
    };
    public static Room Crawl_08 { get; } = new Room
    {
        Name = SceneNames.Crawl_08,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_08__bot1,
        ]),
    };
    public static Room Crawl_09 { get; } = new Room
    {
        Name = SceneNames.Crawl_09,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_09__left1,
            Crawl_09__right1,
        ]),
    };
    public static Room Crawl_10 { get; } = new Room
    {
        Name = SceneNames.Crawl_10,
        MapArea = MapAreaNames.Wormways,
        TitledArea = TitledAreaNames.Wormways,
        Gates = new([
            Crawl_10__right1,
        ]),
    };
    public static Room Dock_01 { get; } = new Room
    {
        Name = SceneNames.Dock_01,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_01__left1,
            Dock_01__right1,
            Dock_01__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_02 { get; } = new Room
    {
        Name = SceneNames.Dock_02,
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
    public static Room Dock_02b { get; } = new Room
    {
        Name = SceneNames.Dock_02b,
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
    public static Room Dock_03 { get; } = new Room
    {
        Name = SceneNames.Dock_03,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03__bot1,
            Dock_03__left1,
            Dock_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_03b { get; } = new Room
    {
        Name = SceneNames.Dock_03b,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03b__left1,
            Dock_03b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_03c { get; } = new Room
    {
        Name = SceneNames.Dock_03c,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03c__left2,
            Dock_03c__top1,
            Dock_03c__top2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_03d { get; } = new Room
    {
        Name = SceneNames.Dock_03d,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_03d__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_04 { get; } = new Room
    {
        Name = SceneNames.Dock_04,
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
    public static Room Dock_05 { get; } = new Room
    {
        Name = SceneNames.Dock_05,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_06_Church { get; } = new Room
    {
        Name = SceneNames.Dock_06_Church,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_06_Church__bot1,
            Dock_06_Church__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_08 { get; } = new Room
    {
        Name = SceneNames.Dock_08,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_08__left1,
            Dock_08__left2,
            Dock_08__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_09 { get; } = new Room
    {
        Name = SceneNames.Dock_09,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_09__left1,
            Dock_09__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_10 { get; } = new Room
    {
        Name = SceneNames.Dock_10,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_10__left1,
            Dock_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_11 { get; } = new Room
    {
        Name = SceneNames.Dock_11,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_11__left1,
            Dock_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_12 { get; } = new Room
    {
        Name = SceneNames.Dock_12,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_12__door1,
            Dock_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_13 { get; } = new Room
    {
        Name = SceneNames.Dock_13,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_14 { get; } = new Room
    {
        Name = SceneNames.Dock_14,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dock_15 { get; } = new Room
    {
        Name = SceneNames.Dock_15,
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
    public static Room Dock_16 { get; } = new Room
    {
        Name = SceneNames.Dock_16,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Dock_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dust_01 { get; } = new Room
    {
        Name = SceneNames.Dust_01,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_01__left1,
            Dust_01__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_02 { get; } = new Room
    {
        Name = SceneNames.Dust_02,
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
        ManuallyVerified = false,
    };
    public static Room Dust_03 { get; } = new Room
    {
        Name = SceneNames.Dust_03,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_03__bot1,
            Dust_03__left1,
            Dust_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_04 { get; } = new Room
    {
        Name = SceneNames.Dust_04,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_04__door1,
            Dust_04__left1,
            Dust_04__left2,
            Dust_04__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_05 { get; } = new Room
    {
        Name = SceneNames.Dust_05,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_05__bot1,
            Dust_05__left1,
            Dust_05__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_06 { get; } = new Room
    {
        Name = SceneNames.Dust_06,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_06__left1,
            Dust_06__right1,
            Dust_06__right2,
            Dust_06__right3,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_09 { get; } = new Room
    {
        Name = SceneNames.Dust_09,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_09__door1,
            Dust_09__door2,
            Dust_09__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_10 { get; } = new Room
    {
        Name = SceneNames.Dust_10,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_10__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_11 { get; } = new Room
    {
        Name = SceneNames.Dust_11,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_11__bot1,
            Dust_11__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_12 { get; } = new Room
    {
        Name = SceneNames.Dust_12,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_12__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_Barb { get; } = new Room
    {
        Name = SceneNames.Dust_Barb,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Barb__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_Chef { get; } = new Room
    {
        Name = SceneNames.Dust_Chef,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Chef__bot1,
            Dust_Chef__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Dust_Maze_08_completed { get; } = new Room
    {
        Name = SceneNames.Dust_Maze_08_completed,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.The_Mist,
        Gates = new([
            Dust_Maze_08_completed__right1,
            Dust_Maze_08_completed__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Dust_Shack { get; } = new Room
    {
        Name = SceneNames.Dust_Shack,
        MapArea = MapAreaNames.Sinner_s_Road,
        TitledArea = TitledAreaNames.Sinner_s_Road,
        Gates = new([
            Dust_Shack__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Greymoor_01 { get; } = new Room
    {
        Name = SceneNames.Greymoor_01,
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
    public static Room Greymoor_02 { get; } = new Room
    {
        Name = SceneNames.Greymoor_02,
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
    public static Room Greymoor_03 { get; } = new Room
    {
        Name = SceneNames.Greymoor_03,
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
    public static Room Greymoor_04 { get; } = new Room
    {
        Name = SceneNames.Greymoor_04,
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
    public static Room Greymoor_05 { get; } = new Room
    {
        Name = SceneNames.Greymoor_05,
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
    public static Room Greymoor_06 { get; } = new Room
    {
        Name = SceneNames.Greymoor_06,
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
    public static Room Greymoor_07 { get; } = new Room
    {
        Name = SceneNames.Greymoor_07,
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
    public static Room Greymoor_08 { get; } = new Room
    {
        Name = SceneNames.Greymoor_08,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_08__door1,
            Greymoor_08__door2,
            Greymoor_08__left2,
            Greymoor_08__right1,
            Greymoor_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_10 { get; } = new Room
    {
        Name = SceneNames.Greymoor_10,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_10__left1,
            Greymoor_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_11 { get; } = new Room
    {
        Name = SceneNames.Greymoor_11,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_11__left1,
            Greymoor_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_12 { get; } = new Room
    {
        Name = SceneNames.Greymoor_12,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_12__left1,
            Greymoor_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_13 { get; } = new Room
    {
        Name = SceneNames.Greymoor_13,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_13__bot1,
            Greymoor_13__left1,
            Greymoor_13__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_15 { get; } = new Room
    {
        Name = SceneNames.Greymoor_15,
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
    public static Room Greymoor_15b { get; } = new Room
    {
        Name = SceneNames.Greymoor_15b,
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
    public static Room Greymoor_16 { get; } = new Room
    {
        Name = SceneNames.Greymoor_16,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_16__left1,
            Greymoor_16__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_17 { get; } = new Room
    {
        Name = SceneNames.Greymoor_17,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_17__left1,
            Greymoor_17__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_20b { get; } = new Room
    {
        Name = SceneNames.Greymoor_20b,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_20b__door1,
            Greymoor_20b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_20c { get; } = new Room
    {
        Name = SceneNames.Greymoor_20c,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_20c__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_21 { get; } = new Room
    {
        Name = SceneNames.Greymoor_21,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_21__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_22 { get; } = new Room
    {
        Name = SceneNames.Greymoor_22,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_22__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Greymoor_24 { get; } = new Room
    {
        Name = SceneNames.Greymoor_24,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Greymoor_24__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Halfway_01 { get; } = new Room
    {
        Name = SceneNames.Halfway_01,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Halfway_Home,
        Gates = new([
            Halfway_01__bot1,
            Halfway_01__left1,
            Halfway_01__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Hang_01 { get; } = new Room
    {
        Name = SceneNames.Hang_01,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_01__right1,
            Hang_01__right2,
        ]),
    };
    public static Room Hang_02 { get; } = new Room
    {
        Name = SceneNames.Hang_02,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_02__left1,
            Hang_02__right1,
        ]),
    };
    public static Room Hang_03 { get; } = new Room
    {
        Name = SceneNames.Hang_03,
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
    public static Room Hang_03_top { get; } = new Room
    {
        Name = SceneNames.Hang_03_top,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_03_top__bot1,
        ]),
    };
    public static Room Hang_04 { get; } = new Room
    {
        Name = SceneNames.Hang_04,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_04__left1,
            Hang_04__right1,
        ]),
    };
    public static Room Hang_06 { get; } = new Room
    {
        Name = SceneNames.Hang_06,
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
    public static Room Hang_06_bank { get; } = new Room
    {
        Name = SceneNames.Hang_06_bank,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_06_bank__left1,
        ]),
    };
    public static Room Hang_06b { get; } = new Room
    {
        Name = SceneNames.Hang_06b,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_06b__left1,
        ]),
    };
    public static Room Hang_07 { get; } = new Room
    {
        Name = SceneNames.Hang_07,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_07__bot1,
            Hang_07__left1,
            Hang_07__right1,
            Hang_07__top1,
        ]),
    };
    public static Room Hang_08 { get; } = new Room
    {
        Name = SceneNames.Hang_08,
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
    public static Room Hang_09 { get; } = new Room
    {
        Name = SceneNames.Hang_09,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_09__right1,
        ]),
    };
    public static Room Hang_10 { get; } = new Room
    {
        Name = SceneNames.Hang_10,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_10__left1,
            Hang_10__right1,
        ]),
    };
    public static Room Hang_12 { get; } = new Room
    {
        Name = SceneNames.Hang_12,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_12__right1,
        ]),
    };
    public static Room Hang_13 { get; } = new Room
    {
        Name = SceneNames.Hang_13,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_13__left1,
            Hang_13__right1,
        ]),
    };
    public static Room Hang_14 { get; } = new Room
    {
        Name = SceneNames.Hang_14,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_14__left1,
        ]),
    };
    public static Room Hang_15 { get; } = new Room
    {
        Name = SceneNames.Hang_15,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_15__right1,
        ]),
    };
    public static Room Hang_16 { get; } = new Room
    {
        Name = SceneNames.Hang_16,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_16__door1,
            Hang_16__right1,
        ]),
    };
    public static Room Hang_17b { get; } = new Room
    {
        Name = SceneNames.Hang_17b,
        MapArea = MapAreaNames.High_Halls,
        TitledArea = TitledAreaNames.High_Halls,
        Gates = new([
            Hang_17b__left1,
        ]),
    };
    public static Room Library_01 { get; } = new Room
    {
        Name = SceneNames.Library_01,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_01__left1,
            Library_01__left2,
            Library_01__left3,
            Library_01__right1,
            Library_01__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_02 { get; } = new Room
    {
        Name = SceneNames.Library_02,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_02__left1,
            Library_02__left2,
            Library_02__right1,
            Library_02__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_03 { get; } = new Room
    {
        Name = SceneNames.Library_03,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_03__left1,
            Library_03__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_04 { get; } = new Room
    {
        Name = SceneNames.Library_04,
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
        ManuallyVerified = false,
    };
    public static Room Library_05 { get; } = new Room
    {
        Name = SceneNames.Library_05,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_05__left1,
            Library_05__left2,
            Library_05__right1,
            Library_05__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_06 { get; } = new Room
    {
        Name = SceneNames.Library_06,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_06__left1,
            Library_06__left2,
            Library_06__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_07 { get; } = new Room
    {
        Name = SceneNames.Library_07,
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
        ManuallyVerified = false,
    };
    public static Room Library_08 { get; } = new Room
    {
        Name = SceneNames.Library_08,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_08__left1,
            Library_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_09 { get; } = new Room
    {
        Name = SceneNames.Library_09,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_09__bot1,
            Library_09__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_10 { get; } = new Room
    {
        Name = SceneNames.Library_10,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_10__bot1,
            Library_10__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_11 { get; } = new Room
    {
        Name = SceneNames.Library_11,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_11__left1,
            Library_11__left2,
            Library_11__left3,
            Library_11__right1,
            Library_11__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_11b { get; } = new Room
    {
        Name = SceneNames.Library_11b,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_11b__left3,
            Library_11b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_12 { get; } = new Room
    {
        Name = SceneNames.Library_12,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_12__door1,
            Library_12__left1,
            Library_12__left2,
            Library_12__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_12b { get; } = new Room
    {
        Name = SceneNames.Library_12b,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_12b__left1,
            Library_12b__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_13 { get; } = new Room
    {
        Name = SceneNames.Library_13,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_13__left1,
            Library_13__right1,
            Library_13__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_13b { get; } = new Room
    {
        Name = SceneNames.Library_13b,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_13b__left1,
            Library_13b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_14 { get; } = new Room
    {
        Name = SceneNames.Library_14,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_14__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_15 { get; } = new Room
    {
        Name = SceneNames.Library_15,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_15__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Library_16 { get; } = new Room
    {
        Name = SceneNames.Library_16,
        MapArea = MapAreaNames.Whispering_Vaults,
        TitledArea = TitledAreaNames.Whispering_Vaults,
        Gates = new([
            Library_16__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Memory_Needolin { get; } = new Room
    {
        Name = SceneNames.Memory_Needolin,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Memory_Needolin__left1,
            Memory_Needolin__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Memory_Red { get; } = new Room
    {
        Name = SceneNames.Memory_Red,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Memory_Red__door_enterRedMemory_Beast,
            Memory_Red__door_enterRedMemory_Hive,
            Memory_Red__door_enterRedMemory_Weaver,
            Memory_Red__door_wakeInRedMemory_Beast,
            Memory_Red__door_wakeInRedMemory_Hive,
            Memory_Red__door_wakeInRedMemory_Weaver,
        ]),
        ManuallyVerified = true,
    };
    public static Room Mosstown_01 { get; } = new Room
    {
        Name = SceneNames.Mosstown_01,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_01__bot1,
            Mosstown_01__right1,
            Mosstown_01__right2,
            Mosstown_01__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Mosstown_02 { get; } = new Room
    {
        Name = SceneNames.Mosstown_02,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_02__bot1,
            Mosstown_02__bot2,
            Mosstown_02__left1,
            Mosstown_02__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Mosstown_02c { get; } = new Room
    {
        Name = SceneNames.Mosstown_02c,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_02c__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Mosstown_03 { get; } = new Room
    {
        Name = SceneNames.Mosstown_03,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Mosshome,
        Gates = new([
            Mosstown_03__right1,
            Mosstown_03__right2,
            Mosstown_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Organ_01 { get; } = new Room
    {
        Name = SceneNames.Organ_01,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Exhaust_Organ,
        Gates = new([
            Organ_01__left1,
            Organ_01__left2,
            Organ_01__left3,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_01 { get; } = new Room
    {
        Name = SceneNames.Peak_01,
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
    public static Room Peak_02 { get; } = new Room
    {
        Name = SceneNames.Peak_02,
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
    public static Room Peak_04 { get; } = new Room
    {
        Name = SceneNames.Peak_04,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04__left1,
            Peak_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_04c { get; } = new Room
    {
        Name = SceneNames.Peak_04c,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04c__right1,
            Peak_04c__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_04d { get; } = new Room
    {
        Name = SceneNames.Peak_04d,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_04d__left1,
            Peak_04d__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_05 { get; } = new Room
    {
        Name = SceneNames.Peak_05,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05__bot1,
            Peak_05__right3,
            Peak_05__top2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_05c { get; } = new Room
    {
        Name = SceneNames.Peak_05c,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05c__left2,
            Peak_05c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_05d { get; } = new Room
    {
        Name = SceneNames.Peak_05d,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05d__bot1,
            Peak_05d__door1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_05e { get; } = new Room
    {
        Name = SceneNames.Peak_05e,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_05e__left1,
            Peak_05e__right1,
            Peak_05e__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_06 { get; } = new Room
    {
        Name = SceneNames.Peak_06,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_06__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_06b { get; } = new Room
    {
        Name = SceneNames.Peak_06b,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_06b__door1,
            Peak_06b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_07 { get; } = new Room
    {
        Name = SceneNames.Peak_07,
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
    public static Room Peak_08 { get; } = new Room
    {
        Name = SceneNames.Peak_08,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_08__bot1,
            Peak_08__right1,
            Peak_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_08b { get; } = new Room
    {
        Name = SceneNames.Peak_08b,
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
    public static Room Peak_10 { get; } = new Room
    {
        Name = SceneNames.Peak_10,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_12 { get; } = new Room
    {
        Name = SceneNames.Peak_12,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_12__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Peak_Mask_Maker { get; } = new Room
    {
        Name = SceneNames.Peak_Mask_Maker,
        MapArea = MapAreaNames.Mount_Fay,
        TitledArea = TitledAreaNames.Mount_Fay,
        Gates = new([
            Peak_Mask_Maker__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Caravan_Interior { get; } = new Room
    {
        Name = SceneNames.Room_Caravan_Interior,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Room_Caravan_Interior__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Caravan_Spa { get; } = new Room
    {
        Name = SceneNames.Room_Caravan_Spa,
        MapArea = MapAreaNames.Unknown,
        TitledArea = TitledAreaNames.Unknown,
        Gates = new([
            Room_Caravan_Spa__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_CrowCourt { get; } = new Room
    {
        Name = SceneNames.Room_CrowCourt,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Room_CrowCourt__bot1,
            Room_CrowCourt__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_CrowCourt_02 { get; } = new Room
    {
        Name = SceneNames.Room_CrowCourt_02,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Greymoor,
        Gates = new([
            Room_CrowCourt_02__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Diving_Bell { get; } = new Room
    {
        Name = SceneNames.Room_Diving_Bell,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Room_Diving_Bell__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Diving_Bell_Abyss { get; } = new Room
    {
        Name = SceneNames.Room_Diving_Bell_Abyss,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Room_Diving_Bell_Abyss__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Diving_Bell_Abyss_Fixed { get; } = new Room
    {
        Name = SceneNames.Room_Diving_Bell_Abyss_Fixed,
        MapArea = MapAreaNames.The_Abyss,
        TitledArea = TitledAreaNames.The_Abyss,
        Gates = new([
            Room_Diving_Bell_Abyss_Fixed__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Forge { get; } = new Room
    {
        Name = SceneNames.Room_Forge,
        MapArea = MapAreaNames.Deep_Docks,
        TitledArea = TitledAreaNames.Deep_Docks,
        Gates = new([
            Room_Forge__left1,
            Room_Forge__right1,
            Room_Forge__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Huntress { get; } = new Room
    {
        Name = SceneNames.Room_Huntress,
        MapArea = MapAreaNames.Putrified_Ducts,
        TitledArea = TitledAreaNames.Putrified_Ducts,
        Gates = new([
            Room_Huntress__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Room_Pinstress { get; } = new Room
    {
        Name = SceneNames.Room_Pinstress,
        MapArea = MapAreaNames.Blasted_Steps,
        TitledArea = TitledAreaNames.Blasted_Steps,
        Gates = new([
            Room_Pinstress__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Room_Witch { get; } = new Room
    {
        Name = SceneNames.Room_Witch,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Room_Witch__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shadow_01 { get; } = new Room
    {
        Name = SceneNames.Shadow_01,
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
    public static Room Shadow_02 { get; } = new Room
    {
        Name = SceneNames.Shadow_02,
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
    public static Room Shadow_03 { get; } = new Room
    {
        Name = SceneNames.Shadow_03,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_03__left1,
            Shadow_03__right1,
            Shadow_03__top1,
        ]),
    };
    public static Room Shadow_04 { get; } = new Room
    {
        Name = SceneNames.Shadow_04,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_04__right1,
            Shadow_04__right2,
            Shadow_04__top1,
        ]),
    };
    public static Room Shadow_04b { get; } = new Room
    {
        Name = SceneNames.Shadow_04b,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_04b__left1,
            Shadow_04b__right1,
        ]),
    };
    public static Room Shadow_05 { get; } = new Room
    {
        Name = SceneNames.Shadow_05,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_05__left1,
            Shadow_05__right1,
        ]),
    };
    public static Room Shadow_08 { get; } = new Room
    {
        Name = SceneNames.Shadow_08,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_08__left1,
            Shadow_08__top1,
        ]),
    };
    public static Room Shadow_09 { get; } = new Room
    {
        Name = SceneNames.Shadow_09,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_09__left1,
            Shadow_09__left2,
            Shadow_09__left3,
            Shadow_09__right1,
        ]),
    };
    public static Room Shadow_10 { get; } = new Room
    {
        Name = SceneNames.Shadow_10,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_10__bot1,
            Shadow_10__left1,
            Shadow_10__right1,
        ]),
    };
    public static Room Shadow_11 { get; } = new Room
    {
        Name = SceneNames.Shadow_11,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_11__left1,
            Shadow_11__right1,
        ]),
    };
    public static Room Shadow_12 { get; } = new Room
    {
        Name = SceneNames.Shadow_12,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_12__left1,
            Shadow_12__right1,
        ]),
    };
    public static Room Shadow_13 { get; } = new Room
    {
        Name = SceneNames.Shadow_13,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_13__left1,
        ]),
    };
    public static Room Shadow_14 { get; } = new Room
    {
        Name = SceneNames.Shadow_14,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_14__right1,
            Shadow_14__right2,
        ]),
    };
    public static Room Shadow_15 { get; } = new Room
    {
        Name = SceneNames.Shadow_15,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_15__right1,
            Shadow_15__right2,
        ]),
    };
    public static Room Shadow_16 { get; } = new Room
    {
        Name = SceneNames.Shadow_16,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_16__left1,
            Shadow_16__right1,
        ]),
    };
    public static Room Shadow_18 { get; } = new Room
    {
        Name = SceneNames.Shadow_18,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_18__door1,
            Shadow_18__left1,
            Shadow_18__right1,
        ]),
    };
    public static Room Shadow_19 { get; } = new Room
    {
        Name = SceneNames.Shadow_19,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_19__left1,
            Shadow_19__left2,
            Shadow_19__right1,
            Shadow_19__right2,
        ]),
    };
    public static Room Shadow_20 { get; } = new Room
    {
        Name = SceneNames.Shadow_20,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_20__bot1,
            Shadow_20__top1,
        ]),
    };
    public static Room Shadow_21 { get; } = new Room
    {
        Name = SceneNames.Shadow_21,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_21__bot1,
        ]),
    };
    public static Room Shadow_22 { get; } = new Room
    {
        Name = SceneNames.Shadow_22,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_22__bot1,
            Shadow_22__top1,
            Shadow_22__top2,
            Shadow_22__top3,
        ]),
    };
    public static Room Shadow_23 { get; } = new Room
    {
        Name = SceneNames.Shadow_23,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_23__left1,
        ]),
    };
    public static Room Shadow_24 { get; } = new Room
    {
        Name = SceneNames.Shadow_24,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_24__left1,
        ]),
    };
    public static Room Shadow_25 { get; } = new Room
    {
        Name = SceneNames.Shadow_25,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_25__left1,
        ]),
    };
    public static Room Shadow_26 { get; } = new Room
    {
        Name = SceneNames.Shadow_26,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_26__left1,
            Shadow_26__left2,
            Shadow_26__right1,
            Shadow_26__right2,
        ]),
    };
    public static Room Shadow_27 { get; } = new Room
    {
        Name = SceneNames.Shadow_27,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_27__left1,
            Shadow_27__right1,
        ]),
    };
    public static Room Shadow_28 { get; } = new Room
    {
        Name = SceneNames.Shadow_28,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_28__right1,
        ]),
    };
    public static Room Shadow_Bilehaven_Room { get; } = new Room
    {
        Name = SceneNames.Shadow_Bilehaven_Room,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_Bilehaven_Room__left1,
        ]),
    };
    public static Room Shadow_Weavehome { get; } = new Room
    {
        Name = SceneNames.Shadow_Weavehome,
        MapArea = MapAreaNames.Bilewater,
        TitledArea = TitledAreaNames.Bilewater,
        Gates = new([
            Shadow_Weavehome__left1,
        ]),
    };
    public static Room Shellgrave { get; } = new Room
    {
        Name = SceneNames.Shellgrave,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellgrave__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_01 { get; } = new Room
    {
        Name = SceneNames.Shellwood_01,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_01__left1,
            Shellwood_01__left2,
            Shellwood_01__right1,
            Shellwood_01__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_01b { get; } = new Room
    {
        Name = SceneNames.Shellwood_01b,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_01b__left1,
            Shellwood_01b__left2,
            Shellwood_01b__right1,
            Shellwood_01b__right2,
            Shellwood_01b__right3,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_02 { get; } = new Room
    {
        Name = SceneNames.Shellwood_02,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_02__left2,
            Shellwood_02__left3,
            Shellwood_02__right1,
            Shellwood_02__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_03 { get; } = new Room
    {
        Name = SceneNames.Shellwood_03,
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
        ManuallyVerified = false,
    };
    public static Room Shellwood_04b { get; } = new Room
    {
        Name = SceneNames.Shellwood_04b,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_04b__left1,
            Shellwood_04b__right1,
            Shellwood_04b__top1,
            Shellwood_04b__top2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_04c { get; } = new Room
    {
        Name = SceneNames.Shellwood_04c,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_04c__bot1,
            Shellwood_04c__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_08 { get; } = new Room
    {
        Name = SceneNames.Shellwood_08,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_08__bot1,
            Shellwood_08__left1,
            Shellwood_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_08c { get; } = new Room
    {
        Name = SceneNames.Shellwood_08c,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_08c__left1,
            Shellwood_08c__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_10 { get; } = new Room
    {
        Name = SceneNames.Shellwood_10,
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
        ManuallyVerified = false,
    };
    public static Room Shellwood_11 { get; } = new Room
    {
        Name = SceneNames.Shellwood_11,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_11__right1,
            Shellwood_11__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_11b { get; } = new Room
    {
        Name = SceneNames.Shellwood_11b,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_11b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_13 { get; } = new Room
    {
        Name = SceneNames.Shellwood_13,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_13__left1,
            Shellwood_13__left2,
            Shellwood_13__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_14 { get; } = new Room
    {
        Name = SceneNames.Shellwood_14,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_14__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_15 { get; } = new Room
    {
        Name = SceneNames.Shellwood_15,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_15__left1,
            Shellwood_15__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_16 { get; } = new Room
    {
        Name = SceneNames.Shellwood_16,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_16__left1,
            Shellwood_16__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_18 { get; } = new Room
    {
        Name = SceneNames.Shellwood_18,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_18__left1,
            Shellwood_18__right1,
            Shellwood_18__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_19 { get; } = new Room
    {
        Name = SceneNames.Shellwood_19,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_19__left1,
            Shellwood_19__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_20 { get; } = new Room
    {
        Name = SceneNames.Shellwood_20,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_20__left1,
            Shellwood_20__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_22 { get; } = new Room
    {
        Name = SceneNames.Shellwood_22,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_22__door1,
            Shellwood_22__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_25 { get; } = new Room
    {
        Name = SceneNames.Shellwood_25,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_25__door1,
            Shellwood_25__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_25b { get; } = new Room
    {
        Name = SceneNames.Shellwood_25b,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_25b__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_26 { get; } = new Room
    {
        Name = SceneNames.Shellwood_26,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_26__bot1,
            Shellwood_26__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Shellwood_Witch { get; } = new Room
    {
        Name = SceneNames.Shellwood_Witch,
        MapArea = MapAreaNames.Shellwood,
        TitledArea = TitledAreaNames.Shellwood,
        Gates = new([
            Shellwood_Witch__door1,
            Shellwood_Witch__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_01 { get; } = new Room
    {
        Name = SceneNames.Slab_01,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_01__left1,
            Slab_01__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_02 { get; } = new Room
    {
        Name = SceneNames.Slab_02,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_02__left1,
            Slab_02__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_03 { get; } = new Room
    {
        Name = SceneNames.Slab_03,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
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
        ManuallyVerified = false,
    };
    public static Room Slab_04 { get; } = new Room
    {
        Name = SceneNames.Slab_04,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_04__bot1,
            Slab_04__door1,
            Slab_04__right1,
            Slab_04__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_05 { get; } = new Room
    {
        Name = SceneNames.Slab_05,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_05__bot1,
            Slab_05__right1,
            Slab_05__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_06 { get; } = new Room
    {
        Name = SceneNames.Slab_06,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_06__door1,
            Slab_06__left1,
            Slab_06__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_07 { get; } = new Room
    {
        Name = SceneNames.Slab_07,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_07__right1,
            Slab_07__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_08 { get; } = new Room
    {
        Name = SceneNames.Slab_08,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_08__door1,
            Slab_08__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_10b { get; } = new Room
    {
        Name = SceneNames.Slab_10b,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_10b__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_10c { get; } = new Room
    {
        Name = SceneNames.Slab_10c,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_10c__door1,
            Slab_10c__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_12 { get; } = new Room
    {
        Name = SceneNames.Slab_12,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_12__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_13 { get; } = new Room
    {
        Name = SceneNames.Slab_13,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_13__bot1,
            Slab_13__door1,
            Slab_13__left1,
            Slab_13__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_14 { get; } = new Room
    {
        Name = SceneNames.Slab_14,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_14__right1,
            Slab_14__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_15 { get; } = new Room
    {
        Name = SceneNames.Slab_15,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_15__bot1,
            Slab_15__left1,
            Slab_15__right1,
            Slab_15__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_16 { get; } = new Room
    {
        Name = SceneNames.Slab_16,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_16__bot1,
            Slab_16__door1,
            Slab_16__left1,
            Slab_16__right1,
            Slab_16__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_16b { get; } = new Room
    {
        Name = SceneNames.Slab_16b,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_16b__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_17 { get; } = new Room
    {
        Name = SceneNames.Slab_17,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_17__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_18 { get; } = new Room
    {
        Name = SceneNames.Slab_18,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_18__left1,
            Slab_18__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_19b { get; } = new Room
    {
        Name = SceneNames.Slab_19b,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_19b__left1,
            Slab_19b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_20 { get; } = new Room
    {
        Name = SceneNames.Slab_20,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_20__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_21 { get; } = new Room
    {
        Name = SceneNames.Slab_21,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_21__left1,
            Slab_21__left3,
            Slab_21__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_22 { get; } = new Room
    {
        Name = SceneNames.Slab_22,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_22__bot1,
            Slab_22__bot2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_23 { get; } = new Room
    {
        Name = SceneNames.Slab_23,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_23__door1,
            Slab_23__door2,
            Slab_23__left1,
            Slab_23__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_Cell { get; } = new Room
    {
        Name = SceneNames.Slab_Cell,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_Cell_Creature { get; } = new Room
    {
        Name = SceneNames.Slab_Cell_Creature,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell_Creature__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Slab_Cell_Quiet { get; } = new Room
    {
        Name = SceneNames.Slab_Cell_Quiet,
        MapArea = MapAreaNames.The_Slab,
        TitledArea = TitledAreaNames.The_Slab,
        Gates = new([
            Slab_Cell_Quiet__left1,
            Slab_Cell_Quiet__left2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_01 { get; } = new Room
    {
        Name = SceneNames.Song_01,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01__bot1,
            Song_01__right2,
            Song_01__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_01b { get; } = new Room
    {
        Name = SceneNames.Song_01b,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01b__bot1,
            Song_01b__right1,
            Song_01b__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_01c { get; } = new Room
    {
        Name = SceneNames.Song_01c,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_01c__left1,
            Song_01c__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_02 { get; } = new Room
    {
        Name = SceneNames.Song_02,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_02__left2,
            Song_02__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_03 { get; } = new Room
    {
        Name = SceneNames.Song_03,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_03__bot1,
            Song_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_04 { get; } = new Room
    {
        Name = SceneNames.Song_04,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_04__bot1,
            Song_04__left1,
            Song_04__right1,
            Song_04__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_05 { get; } = new Room
    {
        Name = SceneNames.Song_05,
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
        ManuallyVerified = false,
    };
    public static Room Song_07 { get; } = new Room
    {
        Name = SceneNames.Song_07,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_07__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_08 { get; } = new Room
    {
        Name = SceneNames.Song_08,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_09 { get; } = new Room
    {
        Name = SceneNames.Song_09,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_09__bot1,
            Song_09__right1,
            Song_09__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_09b { get; } = new Room
    {
        Name = SceneNames.Song_09b,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_09b__left1,
            Song_09b__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_10 { get; } = new Room
    {
        Name = SceneNames.Song_10,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_10__left1,
            Song_10__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_11 { get; } = new Room
    {
        Name = SceneNames.Song_11,
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
        ManuallyVerified = false,
    };
    public static Room Song_12 { get; } = new Room
    {
        Name = SceneNames.Song_12,
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
        ManuallyVerified = false,
    };
    public static Room Song_13 { get; } = new Room
    {
        Name = SceneNames.Song_13,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_13__left1,
            Song_13__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_14 { get; } = new Room
    {
        Name = SceneNames.Song_14,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_14__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_15 { get; } = new Room
    {
        Name = SceneNames.Song_15,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_15__left1,
            Song_15__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_17 { get; } = new Room
    {
        Name = SceneNames.Song_17,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_17__left1,
            Song_17__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_18 { get; } = new Room
    {
        Name = SceneNames.Song_18,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_18__bot1,
            Song_18__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_19_entrance { get; } = new Room
    {
        Name = SceneNames.Song_19_entrance,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_19_entrance__left1,
            Song_19_entrance__right1,
            Song_19_entrance__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_20 { get; } = new Room
    {
        Name = SceneNames.Song_20,
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
        ManuallyVerified = false,
    };
    public static Room Song_20b { get; } = new Room
    {
        Name = SceneNames.Song_20b,
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
        ManuallyVerified = false,
    };
    public static Room Song_24 { get; } = new Room
    {
        Name = SceneNames.Song_24,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_24__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_25 { get; } = new Room
    {
        Name = SceneNames.Song_25,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_25__bot1,
            Song_25__left1,
            Song_25__right1,
            Song_25__top1,
            Song_25__top2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_26 { get; } = new Room
    {
        Name = SceneNames.Song_26,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_26__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_27 { get; } = new Room
    {
        Name = SceneNames.Song_27,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_27__left1,
            Song_27__right1,
            Song_27__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_28 { get; } = new Room
    {
        Name = SceneNames.Song_28,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_28__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_29 { get; } = new Room
    {
        Name = SceneNames.Song_29,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_29__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_Enclave { get; } = new Room
    {
        Name = SceneNames.Song_Enclave,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Enclave__bot1,
            Song_Enclave__door1,
            Song_Enclave__left1,
            Song_Enclave__left2,
            Song_Enclave__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_Enclave_Tube { get; } = new Room
    {
        Name = SceneNames.Song_Enclave_Tube,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Enclave_Tube__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_Tower_01 { get; } = new Room
    {
        Name = SceneNames.Song_Tower_01,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Tower_01__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Song_Tower_Destroyed { get; } = new Room
    {
        Name = SceneNames.Song_Tower_Destroyed,
        MapArea = MapAreaNames.Choral_Chambers,
        TitledArea = TitledAreaNames.Choral_Chambers,
        Gates = new([
            Song_Tower_Destroyed__bot1,
            Song_Tower_Destroyed__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Sprintmaster_Cave { get; } = new Room
    {
        Name = SceneNames.Sprintmaster_Cave,
        MapArea = MapAreaNames.Far_Fields,
        TitledArea = TitledAreaNames.Far_Fields,
        Gates = new([
            Sprintmaster_Cave__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Tube_Hub { get; } = new Room
    {
        Name = SceneNames.Tube_Hub,
        MapArea = MapAreaNames.Cradle,
        TitledArea = TitledAreaNames.Cradle,
        Gates = new([
            Tube_Hub__left1,
            Tube_Hub__left3,
            Tube_Hub__left4,
        ]),
        ManuallyVerified = false,
    };
    public static Room Tut_01 { get; } = new Room
    {
        Name = SceneNames.Tut_01,
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
    public static Room Tut_01b { get; } = new Room
    {
        Name = SceneNames.Tut_01b,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_01b__left1,
            Tut_01b__left2,
            Tut_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Tut_02 { get; } = new Room
    {
        Name = SceneNames.Tut_02,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_02__right1,
            Tut_02__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Tut_03 { get; } = new Room
    {
        Name = SceneNames.Tut_03,
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
    public static Room Tut_04 { get; } = new Room
    {
        Name = SceneNames.Tut_04,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_04__left1,
            Tut_04__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Tut_05 { get; } = new Room
    {
        Name = SceneNames.Tut_05,
        MapArea = MapAreaNames.Mosslands,
        TitledArea = TitledAreaNames.Moss_Grotto,
        Gates = new([
            Tut_05__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_01 { get; } = new Room
    {
        Name = SceneNames.Under_01,
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
    public static Room Under_01b { get; } = new Room
    {
        Name = SceneNames.Under_01b,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_01b__left1,
            Under_01b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_02 { get; } = new Room
    {
        Name = SceneNames.Under_02,
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
    public static Room Under_03 { get; } = new Room
    {
        Name = SceneNames.Under_03,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_03b { get; } = new Room
    {
        Name = SceneNames.Under_03b,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03b__left1,
            Under_03b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_03c { get; } = new Room
    {
        Name = SceneNames.Under_03c,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03c__left1,
            Under_03c__left2,
            Under_03c__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_03d { get; } = new Room
    {
        Name = SceneNames.Under_03d,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_03d__bot1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_04 { get; } = new Room
    {
        Name = SceneNames.Under_04,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_04__left1,
            Under_04__right1,
            Under_04__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_05 { get; } = new Room
    {
        Name = SceneNames.Under_05,
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
    public static Room Under_06 { get; } = new Room
    {
        Name = SceneNames.Under_06,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_06__left1,
            Under_06__right1,
            Under_06__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_07 { get; } = new Room
    {
        Name = SceneNames.Under_07,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07__left3,
            Under_07__right2,
            Under_07__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_07b { get; } = new Room
    {
        Name = SceneNames.Under_07b,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07b__bot1,
            Under_07b__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_07c { get; } = new Room
    {
        Name = SceneNames.Under_07c,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_07c__bot1,
            Under_07c__left2,
            Under_07c__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_08 { get; } = new Room
    {
        Name = SceneNames.Under_08,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_08__bot1,
            Under_08__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_10 { get; } = new Room
    {
        Name = SceneNames.Under_10,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_10__left1,
            Under_10__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_11 { get; } = new Room
    {
        Name = SceneNames.Under_11,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_11__left1,
            Under_11__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_12 { get; } = new Room
    {
        Name = SceneNames.Under_12,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_12__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_13 { get; } = new Room
    {
        Name = SceneNames.Under_13,
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
    public static Room Under_14 { get; } = new Room
    {
        Name = SceneNames.Under_14,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_14__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_16 { get; } = new Room
    {
        Name = SceneNames.Under_16,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_16__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_17 { get; } = new Room
    {
        Name = SceneNames.Under_17,
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
    public static Room Under_18 { get; } = new Room
    {
        Name = SceneNames.Under_18,
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
    public static Room Under_19 { get; } = new Room
    {
        Name = SceneNames.Under_19,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19__left1,
            Under_19__top1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_19b { get; } = new Room
    {
        Name = SceneNames.Under_19b,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19b__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_19c { get; } = new Room
    {
        Name = SceneNames.Under_19c,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_19c__bot1,
            Under_19c__left1,
            Under_19c__left2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_20 { get; } = new Room
    {
        Name = SceneNames.Under_20,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_20__left1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_21 { get; } = new Room
    {
        Name = SceneNames.Under_21,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_21__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_22 { get; } = new Room
    {
        Name = SceneNames.Under_22,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_22__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_23 { get; } = new Room
    {
        Name = SceneNames.Under_23,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_23__bot1,
            Under_23__right1,
        ]),
        ManuallyVerified = true,
    };
    public static Room Under_27 { get; } = new Room
    {
        Name = SceneNames.Under_27,
        MapArea = MapAreaNames.Underworks,
        TitledArea = TitledAreaNames.Underworks,
        Gates = new([
            Under_27__left1,
            Under_27__right1,
            Under_27__right2,
        ]),
        ManuallyVerified = true,
    };
    public static Room Ward_01 { get; } = new Room
    {
        Name = SceneNames.Ward_01,
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
        ManuallyVerified = false,
    };
    public static Room Ward_02 { get; } = new Room
    {
        Name = SceneNames.Ward_02,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_02__bot1,
            Ward_02__right1,
            Ward_02__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_02b { get; } = new Room
    {
        Name = SceneNames.Ward_02b,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_02b__bot1,
            Ward_02b__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_03 { get; } = new Room
    {
        Name = SceneNames.Ward_03,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_03__bot1,
            Ward_03__door1,
            Ward_03__left1,
            Ward_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_04 { get; } = new Room
    {
        Name = SceneNames.Ward_04,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_04__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_05 { get; } = new Room
    {
        Name = SceneNames.Ward_05,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_05__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_06 { get; } = new Room
    {
        Name = SceneNames.Ward_06,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_06__bot1,
            Ward_06__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_07 { get; } = new Room
    {
        Name = SceneNames.Ward_07,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_07__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Ward_09 { get; } = new Room
    {
        Name = SceneNames.Ward_09,
        MapArea = MapAreaNames.Whiteward,
        TitledArea = TitledAreaNames.Whiteward,
        Gates = new([
            Ward_09__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_02 { get; } = new Room
    {
        Name = SceneNames.Weave_02,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_02__left2,
            Weave_02__left3,
            Weave_02__left4,
            Weave_02__right1,
            Weave_02__right2,
            Weave_02__right3,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_03 { get; } = new Room
    {
        Name = SceneNames.Weave_03,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_03__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_04 { get; } = new Room
    {
        Name = SceneNames.Weave_04,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_04__left1,
            Weave_04__right2,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_05b { get; } = new Room
    {
        Name = SceneNames.Weave_05b,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_05b__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_07 { get; } = new Room
    {
        Name = SceneNames.Weave_07,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_07__left1,
            Weave_07__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_08 { get; } = new Room
    {
        Name = SceneNames.Weave_08,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_08__left1,
            Weave_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_10 { get; } = new Room
    {
        Name = SceneNames.Weave_10,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_10__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_11 { get; } = new Room
    {
        Name = SceneNames.Weave_11,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_11__right1,
            Weave_11__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_12 { get; } = new Room
    {
        Name = SceneNames.Weave_12,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_12__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_13 { get; } = new Room
    {
        Name = SceneNames.Weave_13,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_13__left1,
            Weave_13__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Weave_14 { get; } = new Room
    {
        Name = SceneNames.Weave_14,
        MapArea = MapAreaNames.Weavenest_Alta,
        TitledArea = TitledAreaNames.Weavenest_Alta,
        Gates = new([
            Weave_14__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_02 { get; } = new Room
    {
        Name = SceneNames.Wisp_02,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_02__left1,
            Wisp_02__right1,
            Wisp_02__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_03 { get; } = new Room
    {
        Name = SceneNames.Wisp_03,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_03__door1,
            Wisp_03__right1,
            Wisp_03__top1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_04 { get; } = new Room
    {
        Name = SceneNames.Wisp_04,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_04__bot1,
            Wisp_04__left1,
            Wisp_04__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_05 { get; } = new Room
    {
        Name = SceneNames.Wisp_05,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_05__bot1,
            Wisp_05__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_06 { get; } = new Room
    {
        Name = SceneNames.Wisp_06,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_06__bot1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_07 { get; } = new Room
    {
        Name = SceneNames.Wisp_07,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_07__left1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_08 { get; } = new Room
    {
        Name = SceneNames.Wisp_08,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_08__left1,
            Wisp_08__right1,
        ]),
        ManuallyVerified = false,
    };
    public static Room Wisp_09 { get; } = new Room
    {
        Name = SceneNames.Wisp_09,
        MapArea = MapAreaNames.Greymoor,
        TitledArea = TitledAreaNames.Wisp_Thicket,
        Gates = new([
            Wisp_09__right1,
            Wisp_09__top1,
        ]),
        ManuallyVerified = false,
    };
}
