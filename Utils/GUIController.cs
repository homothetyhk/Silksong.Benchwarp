using System.Collections.Generic;
using System.IO;
using GlobalEnums;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

namespace BenchwarpSS.Utils
{
    public class GUIController : MonoBehaviour
    {
        public GameObject canvas;

        private static GUIController _instance;
        public static Font BenchwarpFont;
        public static Font Fallback = Font.CreateDynamicFontFromOSFont("Consolas", 16);
        public static Dictionary<string, Texture2D> images = new();

        public static readonly Vector2 TopLeftCorner = new Vector2(0, 1);

        public GameObject warpButton;
        public GameObject toggleAllBtn;
        public GameObject nextPageBtn;
        public GameObject forceUnlockButton;
        public List<GameObject> dropdowns = new([]);
        public GameObject benchDebugString;
        public int page = 1;
        public int maxPages = 2;

        public bool DebugUI = true;
        public bool ForceUnlock = false;

        public static int buttons = 0;
        public List<GameObject> benchButtons
        {
            get
            {
                List<GameObject> benchButtons = new([]);

                foreach (GameObject dropdownObj in dropdowns)
                {
                    Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                    benchButtons.AddRange(dropdown.buttons);
                }
                return benchButtons;
            }
        }
        public static string SavePath
        {
            get
            {
                if (GameManager.instance != null)
                {
                    DesktopPlatform platform = Platform.Current as DesktopPlatform;
                    string accId = "default";
                    if (platform != null)
                    {
                        if (platform.onlineSubsystem != null)
                        {
                            string userId = platform.onlineSubsystem.UserId;
                            if (!string.IsNullOrEmpty(userId))
                            {
                                accId = userId;
                            }
                        }
                    }
                    string benchwarpSavePath = Path.Combine(Application.persistentDataPath, accId, $"user{GameManager.instance.profileID}", $"BenchwarpSS.dat");
                    return benchwarpSavePath;
                }
                return "";
            }
        }
        public static Bench.BenchSaveData[] saveFile
        {
            get
            {
                if (File.Exists(SavePath) && SavePath != "")
                {
                    string json = File.ReadAllText(SavePath);
                    Bench.BenchSaveData[] data = JsonConvert.DeserializeObject<Bench.BenchSaveData[]>(json);
                    return data;
                }
                else
                {
                    return [];
                }
            }
        }
        public Bench.BenchSaveData[] dataToSave
        {
            get
            {
                List<Bench.BenchSaveData> data = new();
                
                foreach (GameObject benchButton in benchButtons)
                {
                    Bench bench = benchButton.GetComponent<Bench>();
                    data.Add(bench.saveData);
                }

                return data.ToArray();
            }
        }

        public bool toggleAllDir
        {
            get
            {
                bool toggleAll = false;
                foreach (GameObject dropdownObj in dropdowns)
                {
                    Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                    if (!dropdown.open)
                    {
                        toggleAll = true;
                    }
                }
                return toggleAll;
            }
        }

        public static int btnWidth = 110; //Controls Button Size Universally
        public static int btnHeight = 40; //Controls Button Size Universally
        public static int btnOffsetX = 10; //Initial X Offset
        public static int baseDropdownRowXOffset = btnOffsetX + btnWidth + 20; //For Reset on Row Drop
        public static int btnOffsetY = 10; //Y Offset for Dropdowns
        public static int baseDropdownYOffset = btnOffsetY; //Y Offset for Bench Buttons

        public static void Setup()
        {
            GameObject GUIObj = new("Benchwarp GUIController");
            _instance = GUIObj.AddComponent<GUIController>();
            DontDestroyOnLoad(GUIObj);
        }

        public static void Unload()
        {
            Destroy(_instance.canvas);
            Destroy(_instance.gameObject);
        }

        public void LoadResources()
        {
            images.Add("ButtonRect", ModHelper.LoadTexFromAssembly("BenchwarpSS.Resources.Images.ButtonRect.png"));
            SetBenchwarpFont();
        }

        public void SaveData()
        {
            string saveDataJson = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);

            Directory.CreateDirectory(Path.GetDirectoryName(SavePath));
            File.WriteAllText(SavePath, saveDataJson);
        }

        public void SetBenchwarpFont()
        {
            foreach (Font f in Resources.FindObjectsOfTypeAll(typeof(Font)))
            {
                if (f.name == "TrajanPro-Bold")
                {
                    BenchwarpFont = f;

                    Text warpText = warpButton.GetComponentInChildren<Text>();
                    warpText.font = BenchwarpFont;

                    Text toggleAll = toggleAllBtn.GetComponentInChildren<Text>();
                    toggleAll.font = BenchwarpFont;

                    Text nextPage = nextPageBtn.GetComponentInChildren<Text>();
                    nextPage.font = BenchwarpFont;

                    Text forceUnlockText = forceUnlockButton.GetComponentInChildren<Text>();
                    forceUnlockText.font = BenchwarpFont;

                    if (DebugUI)
                    {
                        Text debugText = benchDebugString.GetComponent<Text>();
                        debugText.font = BenchwarpFont;
                    }

                    foreach(GameObject benchObj in benchButtons)
                    {
                        Text text = benchObj.GetComponentInChildren<Text>();
                        text.font = BenchwarpFont;
                    }

                    foreach(GameObject dropdownObj in dropdowns)
                    {
                        Text text = dropdownObj.GetComponentInChildren<Text>();
                        text.font = BenchwarpFont;
                    }
                }
            }
        }


        public void NextPage()
        {
            page++;
            if (page > maxPages)
            {
                page = 1;
            }
        }

        public void GUIUpdate()
        {
            if (BenchwarpFont == null)
            {
                SetBenchwarpFont();
            }

            foreach (GameObject buttonObj in benchButtons)
            {
                Bench bench = buttonObj.GetComponent<Bench>();
                Text text = buttonObj.GetComponentInChildren<Text>();
                text.text = bench.benchName;
                if (bench.sceneName == PlayerData.instance.respawnScene && bench.objName == PlayerData.instance.respawnMarkerName)
                {
                    text.color = Color.yellow;
                } else if (!(bench.isUnlocked || ForceUnlock))
                {
                    text.color = new() { r = 0.25f, g = 0.15f, b = 0.38f, a = 1 };
                    text.text = "???";
                }
                else
                {
                    text.color = Color.white;
                }
            }

            foreach(GameObject dropdownObj in dropdowns)
            {
                Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                if (dropdown.page == page)
                {
                    dropdownObj.SetActive(true);
                } else
                {
                    dropdownObj.SetActive(false);
                }
            }

            Text toggleAll = toggleAllBtn.GetComponentInChildren<Text>();
            if (toggleAllDir)
            {
                toggleAll.text = "Open All";
            }
            else
            {
                toggleAll.text = "Close All";
            }

            Text nextPageText = nextPageBtn.GetComponentInChildren<Text>();
            nextPageText.text = $"Page {page}/{maxPages}";

            if (DebugUI)
            {
                if (PlayerData.instance != null)
                {
                    Text debugText = benchDebugString.GetComponent<Text>();
                    debugText.text = $"{PlayerData.instance.respawnMarkerName}, {PlayerData.instance.respawnScene}, {PlayerData.instance.respawnType}, {PlayerData.instance.mapZone}";
                }
            }
        }

        public void BuildMenus()
        {
            LoadResources();

            canvas = new("BenchwarpGUI");
            Canvas canvas_component = canvas.AddComponent<Canvas>();
            canvas_component.renderMode = RenderMode.ScreenSpaceOverlay;
            CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            canvas.AddComponent<GraphicRaycaster>();

            warpButton = BuildButton(canvas, "WARP", btnOffsetX, -btnOffsetY, TopLeftCorner); //Warp Button
            btnOffsetX += btnWidth + 20;
            warpButton.GetComponent<Button>().onClick.AddListener(SaveReload);

            toggleAllBtn = BuildButton(canvas, "Toggle All", -10, -10, new Vector2(1,1));
            toggleAllBtn.GetComponent<Button>().onClick.AddListener(ToggleDropdowns);

            nextPageBtn = BuildButton(canvas, "Page ", -10, -(20 + btnHeight), new Vector2(1, 1));
            nextPageBtn.GetComponent<Button>().onClick.AddListener(NextPage);

            forceUnlockButton = BuildButton(canvas, "Force Unlocked", -10, -(30 + btnHeight * 2), new Vector2(1, 1));
            forceUnlockButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                ForceUnlock = !ForceUnlock;
            });

            int pageToSet = 1;

            for (int i = 0; i < Dropdown.dropdowns.Count; i++)
            {
                if (i == 13)
                {
                    btnOffsetX = baseDropdownRowXOffset;
                    pageToSet++;
                }

                Dropdown.DropdownData data = Dropdown.dropdowns[i];

                GameObject dropdownObj = BuildButton(canvas, data.name, btnOffsetX, -btnOffsetY, TopLeftCorner);
                Dropdown dropdown = dropdownObj.AddComponent<Dropdown>();
                dropdown.page = pageToSet;
                dropdown.Init(dropdownObj, data.name, data.benches);
                btnOffsetX += btnWidth + 10;
                dropdownObj.GetComponent<Button>().onClick.AddListener(dropdown.ToggleDropdown);

                dropdowns.Add(dropdownObj);
            }

            if (DebugUI)
            {
                benchDebugString = new("Benchwarp Debug", [typeof(RectTransform),typeof(Text)]);
                RectTransform rt = benchDebugString.GetComponent<RectTransform>();
                Text text = benchDebugString.GetComponent<Text>();

                text.font = Fallback;
                text.color = Color.white;
                text.fontSize = 20;

                rt.sizeDelta = new Vector2(1000, 20);
                rt.anchorMin = new Vector2(0, 0);
                rt.anchorMax = new Vector2(0, 0);
                rt.pivot = new Vector2(0, 0);
                rt.anchoredPosition = new Vector2(10, 10);

                benchDebugString.transform.SetParent(canvas.transform, false);
            }

            DontDestroyOnLoad(canvas);
        }

        public static GameObject BuildButton(GameObject canvas, string name, int x, int y, Vector2 corner, bool bg = true)
        {
            GameObject button = new($"{name} Button", [typeof(RectTransform)]);
            button.transform.SetParent(canvas.transform, false);
            Button button_component = button.AddComponent<Button>();

            RectTransform rt = button.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(btnWidth, btnHeight);
            rt.anchorMin = corner;
            rt.anchorMax = corner;
            rt.pivot = corner;
            rt.anchoredPosition = new Vector2(x, y);

            if (bg)
            {
                Texture2D tex = images["ButtonRect"];
                Image image = button.AddComponent<Image>();
                image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
            }

            GameObject buttonTxt = new("ButtonText", typeof(RectTransform));
            buttonTxt.transform.SetParent(button.transform, false);

            Text text = buttonTxt.AddComponent<Text>();
            text.text = name;
            if (BenchwarpFont == null)
            {
                text.font = Fallback;
            } else
            {
                text.font = BenchwarpFont;
            }
            text.alignment = TextAnchor.MiddleCenter;
            text.color = Color.white;

            RectTransform textRT = buttonTxt.GetComponent<RectTransform>();
            textRT.anchorMin = Vector2.zero;
            textRT.anchorMax = Vector2.one;
            textRT.offsetMin = Vector2.zero;
            textRT.offsetMax = Vector2.zero;

            return button;
        }

        public static void SaveReload()
        {
            GameManager gm = GameManager.instance;
            if (gm == null)
            {
                ModHelper.Log("GM IS NULL HERE");
                return;
            }

            PlayerData.instance.atBench = false;

            gm.SaveGame((worked) =>
            {
                if (worked)
                {
                    gm.LoadGameFromUI(gm.profileID);
                }
            });

            gm.PauseGameToggle(false);
        }

        public void ToggleDropdowns()
        {
            bool TempToggleDir = toggleAllDir;
            foreach(GameObject dropdownObj in dropdowns)
            {
                Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                dropdown.open = TempToggleDir;
                dropdown.DropdownInteract(TempToggleDir);
            }
        }

        public static GUIController Instance
        {
            get
            {
                if (_instance != null) return _instance;

                _instance = FindFirstObjectByType<GUIController>();

                if (_instance != null) return _instance;

                ModHelper.Log("Couldn't find GUIController");

                GameObject GUIObj = new();
                _instance = GUIObj.AddComponent<GUIController>();
                DontDestroyOnLoad(GUIObj);

                return _instance;
            }
        }
    }

    public class Dropdown : MonoBehaviour
    {
        public string dropdownName = "";
        public List<Bench> benches = new([]);
        public List<GameObject> buttons = new([]);
        public bool open = false;
        public int page = 1;

        public class DropdownData(string name, List<Bench.BenchData> benches)
        {
            public string name = name;
            public List<Bench.BenchData> benches = benches;
        }

        public static List<DropdownData> dropdowns = new([
            new("Moss Grotto", [
                new("Ruined Chapel", "RestBench", "Tut_03", 1, MapZone.BONECHURCH),
                new("Bone Bottom", "RestBench", "Bonetown", 1, MapZone.BONETOWN),
                new("Moss Druid", "RestBench", "Mosstown_02c", 1, MapZone.MOSSTOWN),
                new("Snail Shamans", "RestBench", "Tut_04", 1, MapZone.BONECHURCH)
            ]),
            new("The Marrow", [
                new("Bell Bench", "RestBench", "Bone_01c", 1, MapZone.PATH_OF_BONE),
                new("Beast Battle", "RestBench", "Bone_04", 1, MapZone.MOSSTOWN),
                new("Bellshrine", "RestBench", "Bellshrine", 1, MapZone.PATH_OF_BONE),
                new("Shooting Gallery", "RestBench", "Bone_12", 1, MapZone.PATH_OF_BONE, 
                    new("Shooting Gallery?", "RestBench (1)", "Bone_12", 1, MapZone.PATH_OF_BONE)
                )
            ]),
            new("Hunter's March", [
                new("Trap Bench", "RestBench", "Ant_17", 1, MapZone.HUNTERS_NEST)
            ]),
            new("Deep Docks", [
                new("Bell Bench", "RestBench", "Dock_01", 1, MapZone.DOCKS),
                new("Forge", "RestBench", "Room_Forge", 1, MapZone.DOCKS),
                new("Bellshrine", "RestBench", "Bellshrine_05", 1, MapZone.DOCKS),
                new("Sauna", "RestBench", "Dock_10", 1, MapZone.DOCKS),
                new("Diving Bell", "RestBench", "Room_Diving_Bell", 1, MapZone.DOCKS),
                new("Abyss Exit", "RestBench (1)", "Dock_06_Church", 1, MapZone.DOCKS)
            ]),
            new("Far Fields", [
                new("Bellway", "RestBench", "Bellway_03", 1, MapZone.WILDS),
                new("Seamstress", "RestBench", "Bone_East_Umbrella", 1, MapZone.WILDS),
                new("Pilgrim's Rest", "RestBench", "Bone_East_10_Room", 1, MapZone.PILGRIMS_REST),
                new("Post-Claw", "RestBench", "Bone_East_15", 1, MapZone.WILDS),
                new("Sprintmaster", "RestBench", "Sprintmaster_Cave", 1, MapZone.WILDS)
            ]),
            new("Greymoor", [
                new("Bellshrine", "RestBench", "Bellshrine_02", 1, MapZone.GREYMOOR),
                new("Halfway House", "RestBench", "Halfway_01", 1, MapZone.HALFWAY_HOUSE),
                new("Flea Caravan", "RestBench", "Greymoor_08", 1, MapZone.GREYMOOR),
                new("Wisp Thicket", "RestBench", "Wisp_04", 1, MapZone.WISP)
            ]),
            new("Bellheart", [
                new("Bellheart", "RestBench", "Belltown", 1, MapZone.BELLTOWN),
                new("Widow", "RestBench", "Belltown_Shrine", 1, MapZone.BELLTOWN),
                new("Bellhome", "RestBench", "Belltown_Room_Spare", 1, MapZone.BELLTOWN)
            ]),
            new("Shellwood", [
                new("Bell Bench", "RestBench", "Shellwood_01b", 1, MapZone.SHELLWOOD_THICKET),
                new("Bellshrine", "RestBench", "Bellshrine_03", 1, MapZone.SHELLWOOD_THICKET),
                new("Overgrown Bench", "RestBench", "Shellwood_08c", 1, MapZone.SHELLWOOD_THICKET)
            ]),
            new("Blasted Steps", [
                new("Bell Bench", "RestBench", "Coral_02", 1, MapZone.JUDGE_STEPS),
                new("Bellway", "RestBench", "Bellway_08", 1, MapZone.JUDGE_STEPS),
                new("Flea Caravan", "RestBench", "Coral_Judge_Arena", 1, MapZone.JUDGE_STEPS),
                new("Pinstress", "RestBench", "Room_Pinstress", 1, MapZone.JUDGE_STEPS),
            ]),
            new("Wormways", [
                new("Lifeblood Lab", "RestBench", "Crawl_08", 1, MapZone.CRAWLSPACE)
            ]),
            new("Sinner's Road", [
                new("Broken Bench", "RestBench", "Dust_10", 1, MapZone.DUSTPENS),
                new("Styx", "RestBench", "Dust_11", 1, MapZone.DUSTPENS),
            ]),
            new("Underworks", [
                new("Broken Elevator", "RestBench", "Under_01b", 1, MapZone.UNDERSTORE),
                new("Confession Toll", "RestBench", "Under_08", 1, MapZone.UNDERSTORE),
                new("Architect 12", "RestBench", "Under_17", 1, MapZone.UNDERSTORE),
                new("Whiteward", "RestBench", "Ward_01", 1, MapZone.WARD)
            ]),
            new("Citadel", [
                new("Underworks", "RestBench", "Under_07b", 1, MapZone.CITY_OF_SONG),
                new("Below Dining", "RestBench", "Song_18", 1, MapZone.CITY_OF_SONG),
                new("Spa", "RestBench", "Song_10", 1, MapZone.CITY_OF_SONG),
                new("High Hall Entrance", "RestBench", "Hang_01", 1, MapZone.CITY_OF_SONG),
                new("Songclave Bellshrine", "RestBench", "Bellshrine_Enclave", 1, MapZone.CITY_OF_SONG),
                new("Songclave Outside", "RestBench", "Song_Enclave", 1, MapZone.CITY_OF_SONG),
                new("Grand Bellway", "RestBench", "Bellway_City", 1, MapZone.CITY_OF_SONG),
            ]),
            new("Citadel Other", [
                new("Cogwork Core", "RestBench", "Cog_Bench", 1, MapZone.COG_CORE),
                new("High Halls Ventricle", "RestBench", "Hang_06b", 1, MapZone.HANG),
                new("Memoriam", "RestBench", "Arborium_04", 1, MapZone.ARBORIUM),
                new("Library", "RestBench", "Library_08", 1, MapZone.CITY_OF_SONG),
                new("Cauldron Entrance", "RestBench", "Library_10", 1, MapZone.CITY_OF_SONG)
            ]),
            new("Bilewater", [
                new("Bellway", "RestBench", "Bellway_Shadow", 1, MapZone.SWAMP),
                new("Shortcut", "RestBench", "Shadow_08", 1, MapZone.SWAMP),
                new("Bilehaven", "RestBench", "Shadow_18", 1, MapZone.SWAMP),
                new("Exhaust Organ", "RestBench", "Organ_01", 1, MapZone.CITY_OF_SONG),
            ]),
            new("Putrified Ducts", [
                new("Bellway", "RestBench", "Bellway_Aqueduct", 1, MapZone.AQUEDUCT),
                new("Huntress", "RestBench", "Room_Huntress", 1, MapZone.AQUEDUCT),
                new("Fleatopia", "RestBench", "Aqueduct_05", 1, MapZone.AQUEDUCT,
                    new("Festival", "RestBench Festival", "Aqueduct_05", 1, MapZone.AQUEDUCT)
                )
            ]),
            new("The Slab", [
                new("Bellway", "RestBench", "Slab_06", 1, MapZone.THE_SLAB),
                new("Prison", "RestBench", "Slab_20", 1, MapZone.THE_SLAB),
                new("Outside", "RestBench", "Slab_16", 1, MapZone.THE_SLAB),
                new("After Arena", "RestBench (1)", "Slab_16", 1, MapZone.THE_SLAB),
            ]),
            new("Mount Fay", [
                new("Shakra", "RestBench", "Peak_02", 1, MapZone.PEAK),
                new("Half-Way", "RestBench", "Bellway_Peak", 1, MapZone.PEAK),
                new("Final Climb", "RestBench", "Peak_07", 1, MapZone.PEAK),
                new("Workbench", "RestBench (1)", "Peak_12", 1, MapZone.PEAK)
            ]),
            new("Sands of Karak", [
                new("Sands of Karak", "RestBench", "Bellshrine_Coral", 1, MapZone.JUDGE_STEPS),
                new("Coral Tower", "RestBench", "Coral_Tower_01", 1, MapZone.JUDGE_STEPS)
            ]),
            new("The Cradle", [
                new("Terminus", "RestBench", "Tube_Hub", 1, MapZone.CITY_OF_SONG)
            ]),
            new("Abyss", [
                new("Void Tendrils", "RestBench", "Abyss_12", 1, MapZone.ABYSS),
                new("Top Abyss", "RestBench", "Abyss_09", 1, MapZone.ABYSS)
            ]),
            new("Weavenest", [
                new("Atla", "RestBench", "Weave_07", 1, MapZone.WEAVER_SHRINE)
            ])
        ]);

        public void Init(GameObject canvas, string name, List<Bench.BenchData> benches)
        {
            dropdownName = name;

            int btnOffsetX = GUIController.btnOffsetX;
            int btnOffsetY = GUIController.baseDropdownYOffset;
            int btnHeight = GUIController.btnHeight;

            for (int i = 0; i < benches.Count; i++)
            {
                Bench.BenchData benchData = benches[i];
                buttons.Add(GUIController.BuildButton(canvas, benchData.benchName, 0, -(btnHeight + btnOffsetY + (btnOffsetY + btnHeight) * i), GUIController.TopLeftCorner, false));
                Bench bench = buttons[i].AddComponent<Bench>();
                bench.Init(benchData);
                buttons[i].GetComponent<Button>().onClick.AddListener(bench.SetBench);
            }

            DropdownInteract(open);
        }

        public void ToggleDropdown()
        {
            if (open)
            {
                open = false;
            }
            else
            {
                open = true;
            }
            DropdownInteract(open);
        }

        public void DropdownInteract(bool interact)
        {
            foreach (var button in buttons)
            {
                button.SetActive(interact);
            }
        }
    }
}
