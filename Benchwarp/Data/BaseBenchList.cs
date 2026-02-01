using System.Collections.ObjectModel;
using Benchwarp.Benches;
using GlobalEnums;

namespace Benchwarp.Data;

public static class BaseBenchList
{
    public static BenchData RuinedChapel { get; } = new(BenchName: "Ruined Chapel", MenuArea: "Moss Grotto", 
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Tut_03, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.BONECHURCH));
    public static BenchData BoneBottom { get; } = new(BenchName: "Bone Bottom", MenuArea: "Moss Grotto", 
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bonetown, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.BONETOWN));
    public static BenchData MossDruid { get; } = new(BenchName: "Moss Druid", MenuArea: "Moss Grotto",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Mosstown_02c, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.MOSSTOWN));
    public static BenchData SnailShamans { get; } = new(BenchName: "Snail Shamans", MenuArea: "Moss Grotto",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Tut_04, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.BONECHURCH));
    public static BenchData TollBenchMarrow { get; } = new(BenchName: "Toll Bench", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_01c, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData MosshomeGate { get; } = new(BenchName: "Mosshome Gate", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_04, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.MOSSTOWN));
    public static BenchData BellshrineMarrow { get; } = new(BenchName: "Bellshrine", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData ShootingGallery { get; } = new(BenchName: "Shooting Gallery", MenuArea: "The Marrow",
        RespawnInfo: new PDConditionalRespawnInfo(
            PlayerDataBoolName: nameof(PlayerData.act3_wokeUp),
            TrueRespawn: new RespawnInfo(SceneName: SceneNames.Bone_12, RespawnMarkerName: RespawnMarkerNames.RestBench__1_,
                RespawnType: RespawnTypes.Bench, MapZone: MapZone.PATH_OF_BONE),
            FalseRespawn: new RespawnInfo(SceneName: SceneNames.Bone_12, RespawnMarkerName: RespawnMarkerNames.RestBench,
                RespawnType: RespawnTypes.Bench, MapZone: MapZone.PATH_OF_BONE)));
    public static BenchData FleaCaravanMarrow { get; } = new(BenchName: "Flea Caravan", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_10, RespawnMarkerName: RespawnMarkerNames.RestBench,
            RespawnType: RespawnTypes.Bench, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData TrapBenchMarch { get; } = new(BenchName: "Trap Bench", MenuArea: "Hunter's March",
        RespawnInfo: new PDConditionalRespawnInfo(
            PlayerDataBoolName: nameof(PlayerData.antBenchTrapDefused),
            TrueRespawn: new RespawnInfo(SceneName: SceneNames.Ant_17, RespawnMarkerName: RespawnMarkerNames.RestBench,
                RespawnType: RespawnTypes.Bench, MapZone: MapZone.HUNTERS_NEST),
            FalseRespawn: new RespawnInfo(SceneName: SceneNames.Ant_17, RespawnMarkerName: RespawnMarkerNames.RestBench,
                RespawnType: RespawnTypes.Floor, MapZone: MapZone.HUNTERS_NEST)
            ));
    public static BenchData TollBenchDocks { get; } = new(BenchName: "Toll Bench", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Dock_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData Forge { get; } = new(BenchName: "Forge", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Room_Forge, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData BellshrineDocks { get; } = new(BenchName: "Bellshrine", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine_05, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData Sauna { get; } = new(BenchName: "Sauna", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Dock_10, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData DivingBell { get; } = new(BenchName: "Diving Bell", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Room_Diving_Bell, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData AbyssExit { get; } = new(BenchName: "Abyss Exit", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Dock_06_Church, RespawnMarkerName: RespawnMarkerNames.RestBench__1_,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DOCKS));
    public static BenchData BellwayFields { get; } = new(BenchName: "Bellway", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_03, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    public static BenchData Seamstress { get; } = new(BenchName: "Seamstress", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_East_Umbrella, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    public static BenchData PilgrimsRest { get; } = new(BenchName: "Pilgrim's Rest", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_East_10_Room, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.PILGRIMS_REST));
    public static BenchData GatedToll { get; } = new(BenchName: "Gated Toll", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_East_15, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    public static BenchData Sprintmaster { get; } = new(BenchName: "Sprintmaster", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Sprintmaster_Cave, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    public static BenchData Karmelita { get; } = new(BenchName: "Karmelita", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_East_27, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    public static BenchData ShakraGreymoor { get; } = new(BenchName: "Shakra", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Greymoor_02, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.GREYMOOR));
    public static BenchData BellshrineGreymoor { get; } = new(BenchName: "Bellshrine", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine_02, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.GREYMOOR));
    public static BenchData HalfwayHouse { get; } = new(BenchName: "Halfway House", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Halfway_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.HALFWAY_HOUSE));
    public static BenchData FleaCaravanGreymoor { get; } = new(BenchName: "Flea Caravan", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Greymoor_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.GREYMOOR));
    public static BenchData WispThicket { get; } = new(BenchName: "Wisp Thicket", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Wisp_04, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WISP));
    public static BenchData Verdania { get; } = new(BenchName: "Verdania", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Clover_20, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CLOVER));
    public static BenchData Bellhart { get; } = new(BenchName: "Bellhart", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Belltown, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.BELLTOWN));
    public static BenchData Widow { get; } = new(BenchName: "Widow", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Belltown_Shrine, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.BELLTOWN));
    public static BenchData Bellhome { get; } = new(BenchName: "Bellhome", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Belltown_Room_Spare, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.BELLTOWN));
    public static BenchData CentralTollShellwood { get; } = new(BenchName: "Central Toll", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Shellwood_01b, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData BellshrineShellwood { get; } = new(BenchName: "Bellshrine", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine_03, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData OvergrownWest { get; } = new(BenchName: "Overgrown West", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Shellwood_08c, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData ChapelExit { get; } = new(BenchName: "Chapel Exit", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Mosstown_03, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData TollBenchSteps { get; } = new(BenchName: "Toll Bench", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Coral_02, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData BellwaySteps { get; } = new(BenchName: "Bellway", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData FleaCaravanSteps { get; } = new(BenchName: "Flea Caravan", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Coral_Judge_Arena, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData Pinstress { get; } = new(BenchName: "Pinstress", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Room_Pinstress, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData PlasmiumLab { get; } = new(BenchName: "Plasmium Lab", MenuArea: "Wormways",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Crawl_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CRAWLSPACE));
    public static BenchData BrokenToll { get; } = new(BenchName: "Broken Toll", MenuArea: "Sinner's Road",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Dust_10, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DUSTPENS));
    public static BenchData Styx { get; } = new(BenchName: "Styx", MenuArea: "Sinner's Road",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Dust_11, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.DUSTPENS));
    public static BenchData BrokenElevator { get; } = new(BenchName: "Broken Elevator", MenuArea: "Underworks & Whiteward",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Under_01b, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.UNDERSTORE));
    public static BenchData ConfessionToll { get; } = new(BenchName: "Confession Toll", MenuArea: "Underworks & Whiteward",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Under_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.UNDERSTORE));
    public static BenchData TwelfthArchitect { get; } = new(BenchName: "Twelfth Architect", MenuArea: "Underworks & Whiteward",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Under_17, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.UNDERSTORE));
    public static BenchData Whiteward { get; } = new(BenchName: "Whiteward", MenuArea: "Underworks & Whiteward",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Ward_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WARD));
    public static BenchData OutsideUnderworks { get; } = new(BenchName: "Outside Underworks", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Under_07b, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BelowDining { get; } = new(BenchName: "Below Dining", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Song_18, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData SpaCitadel { get; } = new(BenchName: "Spa", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Song_10, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData HighHallsEntrance { get; } = new(BenchName: "High Halls Entrance", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Hang_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData FirstShrine { get; } = new(BenchName: "First Shrine", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine_Enclave, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData Songclave { get; } = new(BenchName: "Songclave", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Song_Enclave, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData GrandBellway { get; } = new(BenchName: "Grand Bellway", MenuArea: "Choral Chambers",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_City, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData CogworkCore { get; } = new(BenchName: "Cogwork Core", MenuArea: "Outlying Citadel",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Cog_Bench, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.COG_CORE));
    public static BenchData HighHallsVentrica { get; } = new(BenchName: "High Halls Ventrica", MenuArea: "Outlying Citadel",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Hang_06b, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.HANG));
    public static BenchData Memorium { get; } = new(BenchName: "Memorium", MenuArea: "Outlying Citadel",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Arborium_04, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.ARBORIUM));
    public static BenchData Library { get; } = new(BenchName: "Library", MenuArea: "Outlying Citadel",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Library_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData SacredVault { get; } = new(BenchName: "Sacred Vault", MenuArea: "Outlying Citadel",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Library_10, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BellwayBilewater { get; } = new(BenchName: "Bellway", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_Shadow, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SWAMP));
    public static BenchData CorpseSackChamber { get; } = new(BenchName: "Corpse Sack Chamber", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Shadow_08, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SWAMP));
    public static BenchData Bilehaven { get; } = new(BenchName: "Bilehaven", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Shadow_18, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.SWAMP));
    public static BenchData ExhaustOrgan { get; } = new(BenchName: "Exhaust Organ", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Organ_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BellwayDucts { get; } = new(BenchName: "Bellway", MenuArea: "Putrified Ducts",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_Aqueduct, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.AQUEDUCT));
    public static BenchData Huntress { get; } = new(BenchName: "Huntress", MenuArea: "Putrified Ducts",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Room_Huntress, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.AQUEDUCT));
    public static BenchData Fleatopia { get; } = new(BenchName: "Fleatopia", MenuArea: "Putrified Ducts",
                RespawnInfo: new PDConditionalRespawnInfo(
                    PlayerDataBoolName: nameof(PlayerData.act3_wokeUp),
                    TrueRespawn: new RespawnInfo(SceneName: SceneNames.Aqueduct_05, RespawnMarkerName: "RestBench Festival", 
                        RespawnType: RespawnTypes.Bench, MapZone: MapZone.AQUEDUCT),
                    FalseRespawn: new RespawnInfo(SceneName: SceneNames.Aqueduct_05, RespawnMarkerName: RespawnMarkerNames.RestBench,
                        RespawnType: RespawnTypes.Bench, MapZone: MapZone.AQUEDUCT)));
    public static BenchData BellwaySlab { get; } = new(BenchName: "Bellway", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Slab_06, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.THE_SLAB));
    public static BenchData MappersTunnel { get; } = new(BenchName: "Mapper's Tunnel", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Slab_20, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.THE_SLAB));
    public static BenchData WindowSlab { get; } = new(BenchName: "Window", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Slab_16, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.THE_SLAB));
    public static BenchData HereticKeyArena { get; } = new(BenchName: "Heretic Key Arena", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Slab_16, RespawnMarkerName: RespawnMarkerNames.RestBench__1_,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.THE_SLAB));
    public static BenchData ShakraMountFay { get; } = new(BenchName: "Shakra", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Peak_02, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.PEAK));
    public static BenchData TollBenchMountFay { get; } = new(BenchName: "Toll Bench", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellway_Peak, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.PEAK));
    public static BenchData FinalClimbMountFay { get; } = new(BenchName: "Final Climb", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Peak_07, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.PEAK));
    public static BenchData WorkbenchMountFay { get; } = new(BenchName: "Workbench", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Peak_12, RespawnMarkerName: RespawnMarkerNames.RestBench__1_,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.PEAK));
    public static BenchData SandsOfKarak { get; } = new(BenchName: "Sands of Karak", MenuArea: "Sands of Karak",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bellshrine_Coral, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData CoralTower { get; } = new(BenchName: "Coral Tower", MenuArea: "Sands of Karak",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Coral_Tower_01, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData Terminus { get; } = new(BenchName: "Terminus", MenuArea: "The Cradle",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Tube_Hub, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData SurfaceAscent { get; } = new(BenchName: "Surface Ascent", MenuArea: "The Cradle",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Cradle_Destroyed_Challenge_Bench, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.CRADLE));
    public static BenchData VoidTendrils { get; } = new(BenchName: "Void Tendrils", MenuArea: "Abyss",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Abyss_12, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.ABYSS));
    public static BenchData UpperAbyss { get; } = new(BenchName: "Upper Abyss", MenuArea: "Abyss",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Abyss_09, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.ABYSS));
    public static BenchData WeavenestAtla { get; } = new(BenchName: "Atla", MenuArea: "Weavenest",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Weave_07, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WEAVER_SHRINE));
    public static BenchData WeavenestCindril { get; } = new(BenchName: "Cindril", MenuArea: "Weavenest",
                RespawnInfo: new RespawnInfo(SceneName: SceneNames.Bone_East_Weavehome, RespawnMarkerName: RespawnMarkerNames.RestBench,
                    RespawnType: RespawnTypes.Bench, MapZone: MapZone.WILDS));
    
    public static ReadOnlyCollection<BenchData> BaseBenches { get; } = new([
        RuinedChapel,
        BoneBottom,
        MossDruid,
        SnailShamans,
        TollBenchMarrow,
        MosshomeGate,
        BellshrineMarrow,
        ShootingGallery,
        FleaCaravanMarrow,
        TrapBenchMarch,
        TollBenchDocks,
        Forge,
        BellshrineDocks,
        Sauna,
        DivingBell,
        AbyssExit,
        BellwayFields,
        Seamstress,
        PilgrimsRest,
        GatedToll,
        Sprintmaster,
        Karmelita,
        ShakraGreymoor,
        BellshrineGreymoor,
        HalfwayHouse,
        FleaCaravanGreymoor,
        WispThicket,
        Verdania,
        Bellhart,
        Widow,
        Bellhome,
        CentralTollShellwood,
        BellshrineShellwood,
        OvergrownWest,
        ChapelExit,
        TollBenchSteps,
        BellwaySteps,
        FleaCaravanSteps,
        Pinstress,
        PlasmiumLab,
        BrokenToll,
        Styx,
        BrokenElevator,
        ConfessionToll,
        TwelfthArchitect,
        Whiteward,
        OutsideUnderworks,
        BelowDining,
        SpaCitadel,
        HighHallsEntrance,
        FirstShrine,
        Songclave,
        GrandBellway,
        CogworkCore,
        HighHallsVentrica,
        Memorium,
        Library,
        SacredVault,
        BellwayBilewater,
        CorpseSackChamber,
        Bilehaven,
        ExhaustOrgan,
        BellwayDucts,
        Huntress,
        Fleatopia,
        BellwaySlab,
        MappersTunnel,
        WindowSlab,
        HereticKeyArena,
        ShakraMountFay,
        TollBenchMountFay,
        FinalClimbMountFay,
        WorkbenchMountFay,
        SandsOfKarak,
        CoralTower,
        Terminus,
        SurfaceAscent,
        VoidTendrils,
        UpperAbyss,
        WeavenestAtla,
        WeavenestCindril,
        ]);
}
