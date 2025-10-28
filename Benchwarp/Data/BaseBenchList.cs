using System.Collections.ObjectModel;
using Benchwarp.Benches;
using GlobalEnums;

namespace Benchwarp.Data;

public static class BaseBenchList
{
    public static BenchData RuinedGrotto { get; } = new(BenchName: "Ruined Chapel", MenuArea: "Moss Grotto", 
        RespawnInfo: new RespawnInfo(SceneName: "Tut_03", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BONECHURCH));
    public static BenchData BoneBottom { get; } = new(BenchName: "Bone Bottom", MenuArea: "Moss Grotto", 
        RespawnInfo: new RespawnInfo(SceneName: "Bonetown", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BONETOWN));
    public static BenchData MossDruid { get; } = new(BenchName: "Moss Druid", MenuArea: "Moss Grotto",
        RespawnInfo: new RespawnInfo(SceneName: "Mosstown_02c", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.MOSSTOWN));
    public static BenchData SnailShamans { get; } = new(BenchName: "Snail Shamans", MenuArea: "Moss Grotto",
        RespawnInfo: new RespawnInfo(SceneName: "Tut_04", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BONECHURCH));
    public static BenchData BellBenchMarrow { get; } = new(BenchName: "Bell Bench", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: "Bone_01c", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData BellBeastBattle { get; } = new(BenchName: "Beast Battle", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: "Bone_04", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.MOSSTOWN));
    public static BenchData BellshrineMarrow { get; } = new(BenchName: "Bellshrine", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: "Bellshrine", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData ShootingGallery { get; } = new(BenchName: "Shooting Gallery", MenuArea: "The Marrow",
        RespawnInfo: new PDConditionalRespawnInfo(
            PlayerDataBoolName: nameof(PlayerData.act3_wokeUp),
            TrueRespawn: new RespawnInfo(SceneName: "Bone_12", RespawnMarkerName: "RestBench (1)", RespawnType: 1, MapZone: MapZone.PATH_OF_BONE),
            FalseRespawn: new RespawnInfo(SceneName: "Bone_12", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PATH_OF_BONE))); // TODO: survivor's camp?
    public static BenchData SurvivorCamp { get; } = new(BenchName: "Flea Caravan", MenuArea: "The Marrow",
        RespawnInfo: new RespawnInfo(SceneName: "Bone_10", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PATH_OF_BONE));
    public static BenchData TrapBenchMarch { get; } = new(BenchName: "Trap Bench", MenuArea: "Hunter's March",
        RespawnInfo: new PDConditionalRespawnInfo(
            PlayerDataBoolName: nameof(PlayerData.antBenchTrapDefused),
            TrueRespawn: new RespawnInfo(SceneName: "Ant_17", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.HUNTERS_NEST),
            FalseRespawn: new RespawnInfo(SceneName: "Ant_17", RespawnMarkerName: "RestBench", RespawnType: 0, MapZone: MapZone.HUNTERS_NEST)
            ));
    public static BenchData BellBenchDocks { get; } = new(BenchName: "Bell Bench", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Dock_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DOCKS));
    public static BenchData Forge { get; } = new(BenchName: "Forge", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Room_Forge", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DOCKS));
    public static BenchData BellshrineDocks { get; } = new(BenchName: "Bellshrine", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Bellshrine_05", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DOCKS));
    public static BenchData Sauna { get; } = new(BenchName: "Sauna", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Dock_10", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DOCKS)); // TODO
    public static BenchData DivingBell { get; } = new(BenchName: "Diving Bell", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Room_Diving_Bell", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DOCKS));
    public static BenchData AbyssExit { get; } = new(BenchName: "Abyss Exit", MenuArea: "Deep Docks",
                RespawnInfo: new RespawnInfo(SceneName: "Dock_06_Church", RespawnMarkerName: "RestBench (1)", RespawnType: 1, MapZone: MapZone.DOCKS));
    public static BenchData BellwayFields { get; } = new(BenchName: "Bellway", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_03", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS));
    public static BenchData Seamstress { get; } = new(BenchName: "Seamstress", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Bone_East_Umbrella", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS));
    public static BenchData PilgrimsRest { get; } = new(BenchName: "Pilgrim's Rest", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Bone_East_10_Room", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PILGRIMS_REST));
    public static BenchData PostClaw { get; } = new(BenchName: "Post-Claw", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Bone_East_15", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS)); // TODO
    public static BenchData Sprintmaster { get; } = new(BenchName: "Sprintmaster", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Sprintmaster_Cave", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS));
    public static BenchData Karmelita { get; } = new(BenchName: "Karmelita", MenuArea: "Far Fields",
                RespawnInfo: new RespawnInfo(SceneName: "Bone_East_27", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS));
    public static BenchData BellshrineGreymoor { get; } = new(BenchName: "Bellshrine", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: "Bellshrine_02", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.GREYMOOR)); // TODO: Shakra greymoor
    public static BenchData HalfwayHouse { get; } = new(BenchName: "Halfway House", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: "Halfway_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.HALFWAY_HOUSE));
    public static BenchData FleaCaravanGreymoor { get; } = new(BenchName: "Flea Caravan", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: "Greymoor_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.GREYMOOR));
    public static BenchData WispThicket { get; } = new(BenchName: "Wisp Thicket", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: "Wisp_04", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WISP));
    public static BenchData Verdania { get; } = new(BenchName: "Verdania", MenuArea: "Greymoor",
                RespawnInfo: new RespawnInfo(SceneName: "Clover_20", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CLOVER));
    public static BenchData Bellhart { get; } = new(BenchName: "Bellhart", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: "Belltown", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BELLTOWN));
    public static BenchData Widow { get; } = new(BenchName: "Widow", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: "Belltown_Shrine", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BELLTOWN));
    public static BenchData Bellhome { get; } = new(BenchName: "Bellhome", MenuArea: "Bellhart",
                RespawnInfo: new RespawnInfo(SceneName: "Belltown_Room_Spare", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.BELLTOWN));
    public static BenchData BellBenchShellwood { get; } = new(BenchName: "Bell Bench", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: "Shellwood_01b", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData BellshrineShellwood { get; } = new(BenchName: "Bellshrine", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: "Bellshrine_03", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData OvergrownBench { get; } = new(BenchName: "Overgrown Bench", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: "Shellwood_08c", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData WitchExit { get; } = new(BenchName: "Witch Exit", MenuArea: "Shellwood",
                RespawnInfo: new RespawnInfo(SceneName: "Mosstown_03", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SHELLWOOD_THICKET));
    public static BenchData BellBenchSteps { get; } = new(BenchName: "Bell Bench", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: "Coral_02", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData BellwaySteps { get; } = new(BenchName: "Bellway", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData FleaCaravanSteps { get; } = new(BenchName: "Flea Caravan", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: "Coral_Judge_Arena", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData Pinstress { get; } = new(BenchName: "Pinstress", MenuArea: "Blasted Steps",
                RespawnInfo: new RespawnInfo(SceneName: "Room_Pinstress", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData LifebloodLab { get; } = new(BenchName: "Lifeblood Lab", MenuArea: "Wormways",
                RespawnInfo: new RespawnInfo(SceneName: "Crawl_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CRAWLSPACE));
    public static BenchData BrokenBench { get; } = new(BenchName: "Broken Bench", MenuArea: "Sinner's Road",
                RespawnInfo: new RespawnInfo(SceneName: "Dust_10", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DUSTPENS));
    public static BenchData Styx { get; } = new(BenchName: "Styx", MenuArea: "Sinner's Road",
                RespawnInfo: new RespawnInfo(SceneName: "Dust_11", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.DUSTPENS));
    public static BenchData BrokenElevator { get; } = new(BenchName: "Broken Elevator", MenuArea: "Underworks",
                RespawnInfo: new RespawnInfo(SceneName: "Under_01b", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.UNDERSTORE));
    public static BenchData ConfessionToll { get; } = new(BenchName: "Confession Toll", MenuArea: "Underworks",
                RespawnInfo: new RespawnInfo(SceneName: "Under_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.UNDERSTORE));
    public static BenchData Architect12 { get; } = new(BenchName: "Architect 12", MenuArea: "Underworks",
                RespawnInfo: new RespawnInfo(SceneName: "Under_17", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.UNDERSTORE));
    public static BenchData Whiteward { get; } = new(BenchName: "Whiteward", MenuArea: "Underworks",
                RespawnInfo: new RespawnInfo(SceneName: "Ward_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WARD));
    public static BenchData UnderworksCitadel { get; } = new(BenchName: "Underworks", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Under_07b", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BelowDining { get; } = new(BenchName: "Below Dining", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Song_18", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG)); // TODO
    public static BenchData SpaCitadel { get; } = new(BenchName: "Spa", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Song_10", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData HighHallEntrance { get; } = new(BenchName: "High Hall Entrance", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Hang_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData SongclaveBellshrine { get; } = new(BenchName: "Songclave Bellshrine", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Bellshrine_Enclave", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData SongclaveOutside { get; } = new(BenchName: "Songclave Outside", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Song_Enclave", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData GrandBellway { get; } = new(BenchName: "Grand Bellway", MenuArea: "Citadel",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_City", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData CogworkCore { get; } = new(BenchName: "Cogwork Core", MenuArea: "Citadel Other",
                RespawnInfo: new RespawnInfo(SceneName: "Cog_Bench", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.COG_CORE));
    public static BenchData HighHallsVentricle { get; } = new(BenchName: "High Halls Ventricle", MenuArea: "Citadel Other",
                RespawnInfo: new RespawnInfo(SceneName: "Hang_06b", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.HANG));
    public static BenchData Memorium { get; } = new(BenchName: "Memoriam", MenuArea: "Citadel Other",
                RespawnInfo: new RespawnInfo(SceneName: "Arborium_04", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.ARBORIUM));
    public static BenchData Library { get; } = new(BenchName: "Library", MenuArea: "Citadel Other",
                RespawnInfo: new RespawnInfo(SceneName: "Library_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData CauldronEntrance { get; } = new(BenchName: "Cauldron Entrance", MenuArea: "Citadel Other",
                RespawnInfo: new RespawnInfo(SceneName: "Library_10", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BellwayBilewater { get; } = new(BenchName: "Bellway", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_Shadow", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SWAMP));
    public static BenchData ShortcutBilewater { get; } = new(BenchName: "Shortcut", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: "Shadow_08", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SWAMP));
    public static BenchData Bilehaven { get; } = new(BenchName: "Bilehaven", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: "Shadow_18", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.SWAMP));
    public static BenchData ExhaustOrgan { get; } = new(BenchName: "Exhaust Organ", MenuArea: "Bilewater",
                RespawnInfo: new RespawnInfo(SceneName: "Organ_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData BellwayDucts { get; } = new(BenchName: "Bellway", MenuArea: "Putrified Ducts",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_Aqueduct", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.AQUEDUCT));
    public static BenchData Huntress { get; } = new(BenchName: "Huntress", MenuArea: "Putrified Ducts",
                RespawnInfo: new RespawnInfo(SceneName: "Room_Huntress", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.AQUEDUCT));
    public static BenchData Fleatopia { get; } = new(BenchName: "Fleatopia", MenuArea: "Putrified Ducts",
                RespawnInfo: new PDConditionalRespawnInfo(
                    PlayerDataBoolName: nameof(PlayerData.act3_wokeUp),
                    TrueRespawn: new RespawnInfo(SceneName: "Aqueduct_05", RespawnMarkerName: "RestBench Festival", RespawnType: 1, MapZone: MapZone.AQUEDUCT),
                    FalseRespawn: new RespawnInfo(SceneName: "Aqueduct_05", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.AQUEDUCT)));
    public static BenchData BellwaySlab { get; } = new(BenchName: "Bellway", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: "Slab_06", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.THE_SLAB));
    public static BenchData PrisonSlab { get; } = new(BenchName: "Prison", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: "Slab_20", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.THE_SLAB));
    public static BenchData OutsideSlab { get; } = new(BenchName: "Outside", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: "Slab_16", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.THE_SLAB));
    public static BenchData AfterArenaSlab { get; } = new(BenchName: "After Arena", MenuArea: "The Slab",
                RespawnInfo: new RespawnInfo(SceneName: "Slab_16", RespawnMarkerName: "RestBench (1)", RespawnType: 1, MapZone: MapZone.THE_SLAB));
    public static BenchData ShakraMountFay { get; } = new(BenchName: "Shakra", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: "Peak_02", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PEAK));
    public static BenchData HalfwayMountFay { get; } = new(BenchName: "Half-Way", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: "Bellway_Peak", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PEAK));
    public static BenchData FinalClimbMountFay { get; } = new(BenchName: "Final Climb", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: "Peak_07", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.PEAK));
    public static BenchData WorkbenchMountFay { get; } = new(BenchName: "Workbench", MenuArea: "Mount Fay",
                RespawnInfo: new RespawnInfo(SceneName: "Peak_12", RespawnMarkerName: "RestBench (1)", RespawnType: 1, MapZone: MapZone.PEAK));
    public static BenchData SandsOfKarak { get; } = new(BenchName: "Sands of Karak", MenuArea: "Sands of Karak",
                RespawnInfo: new RespawnInfo(SceneName: "Bellshrine_Coral", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData CoralTower { get; } = new(BenchName: "Coral Tower", MenuArea: "Sands of Karak",
                RespawnInfo: new RespawnInfo(SceneName: "Coral_Tower_01", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.JUDGE_STEPS));
    public static BenchData Terminus { get; } = new(BenchName: "Terminus", MenuArea: "The Cradle",
                RespawnInfo: new RespawnInfo(SceneName: "Tube_Hub", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CITY_OF_SONG));
    public static BenchData MrMushroom { get; } = new(BenchName: "Mr. Mushroom", MenuArea: "The Cradle",
                RespawnInfo: new RespawnInfo(SceneName: "Cradle_Destroyed_Challenge_Bench", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.CRADLE)); // TODO
    public static BenchData VoidTendrils { get; } = new(BenchName: "Void Tendrils", MenuArea: "Abyss",
                RespawnInfo: new RespawnInfo(SceneName: "Abyss_12", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.ABYSS));
    public static BenchData TopAbyss { get; } = new(BenchName: "Top Abyss", MenuArea: "Abyss",
                RespawnInfo: new RespawnInfo(SceneName: "Abyss_09", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.ABYSS));
    public static BenchData WeavenestAtla { get; } = new(BenchName: "Atla", MenuArea: "Weavenest",
                RespawnInfo: new RespawnInfo(SceneName: "Weave_07", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WEAVER_SHRINE));
    public static BenchData WeavenestCindril { get; } = new(BenchName: "Cindril", MenuArea: "Weavenest",
                RespawnInfo: new RespawnInfo(SceneName: "Bone_East_Weavehome", RespawnMarkerName: "RestBench", RespawnType: 1, MapZone: MapZone.WILDS));
    
    public static ReadOnlyCollection<BenchData> BaseBenches { get; } = new([
        RuinedGrotto,
        BoneBottom,
        MossDruid,
        SnailShamans,
        BellBenchMarrow,
        BellBeastBattle,
        BellshrineMarrow,
        ShootingGallery,
        SurvivorCamp,
        TrapBenchMarch,
        BellBenchDocks,
        Forge,
        BellshrineDocks,
        Sauna,
        DivingBell,
        AbyssExit,
        BellwayFields,
        Seamstress,
        PilgrimsRest,
        PostClaw,
        Sprintmaster,
        Karmelita,
        BellshrineGreymoor,
        HalfwayHouse,
        FleaCaravanGreymoor,
        WispThicket,
        Verdania,
        Bellhart,
        Widow,
        Bellhome,
        BellBenchShellwood,
        BellshrineShellwood,
        OvergrownBench,
        WitchExit,
        BellBenchSteps,
        BellwaySteps,
        FleaCaravanSteps,
        Pinstress,
        LifebloodLab,
        BrokenBench,
        Styx,
        BrokenElevator,
        ConfessionToll,
        Architect12,
        Whiteward,
        UnderworksCitadel,
        BelowDining,
        SpaCitadel,
        HighHallEntrance,
        SongclaveBellshrine,
        SongclaveOutside,
        GrandBellway,
        CogworkCore,
        HighHallsVentricle,
        Memorium,
        Library,
        CauldronEntrance,
        BellwayBilewater,
        ShortcutBilewater,
        Bilehaven,
        ExhaustOrgan,
        BellwayDucts,
        Huntress,
        Fleatopia,
        BellwaySlab,
        PrisonSlab,
        OutsideSlab,
        AfterArenaSlab,
        ShakraMountFay,
        HalfwayMountFay,
        FinalClimbMountFay,
        WorkbenchMountFay,
        SandsOfKarak,
        CoralTower,
        Terminus,
        MrMushroom,
        VoidTendrils,
        TopAbyss,
        WeavenestAtla,
        WeavenestCindril,
        ]);
}
