using Benchwarp.Data;
using Benchwarp.Util;
using GlobalEnums;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components
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
        public List<GameObject> dropdowns = new([]);
        public GameObject benchDebugString;
        public int page = 1;
        public int maxPages = 2;

        public bool DebugUI = true;

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

        public static int btnWidth = 115; //Controls Button Size Universally
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
            images.Add("ButtonRect", SpriteManager.LoadTexFromAssembly("Benchwarp.Resources.Images.ButtonRect.png"));
            SetBenchwarpFont();
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

                    if (DebugUI)
                    {
                        Text debugText = benchDebugString.GetComponent<Text>();
                        debugText.font = BenchwarpFont;
                    }

                    foreach (GameObject benchObj in benchButtons)
                    {
                        Text[] texts = benchObj.GetComponentsInChildren<Text>();
                        foreach (Text text in texts)
                        {
                            text.font = BenchwarpFont;
                        }
                    }

                    foreach (GameObject dropdownObj in dropdowns)
                    {
                        Text[] texts = dropdownObj.GetComponentsInChildren<Text>();
                        foreach (Text text in texts)
                        {
                            text.font = BenchwarpFont;
                        }
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
                BenchComponent bench = buttonObj.GetComponent<BenchComponent>();
                Text[] texts = buttonObj.GetComponentsInChildren<Text>();

                Color color = Color.white;

                if (bench.sceneName == PlayerData.instance.respawnScene && bench.objName == PlayerData.instance.respawnMarkerName)
                {
                    color = Color.yellow;
                }

                foreach (Text text in texts)
                {
                    if (!text.text.Any(char.IsDigit))
                    {
                        text.text = bench.benchName;
                    }
                    text.color = color;
                }
            }

            foreach (GameObject dropdownObj in dropdowns)
            {
                Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                if (dropdown.page == page)
                {
                    dropdownObj.SetActive(true);
                }
                else
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
            canvas_component.pixelPerfect = true;
            CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            canvas.AddComponent<GraphicRaycaster>();

            warpButton = BuildButton(canvas, "WARP", btnOffsetX, -btnOffsetY, TopLeftCorner); //Warp Button
            btnOffsetX += btnWidth + 20;
            warpButton.GetComponent<Button>().onClick.AddListener(SaveReload);

            toggleAllBtn = BuildButton(canvas, "Toggle All", -10, -10, new Vector2(1, 1));
            toggleAllBtn.GetComponent<Button>().onClick.AddListener(ToggleDropdowns);

            nextPageBtn = BuildButton(canvas, "Page ", -10, -(20 + btnHeight), new Vector2(1, 1));
            nextPageBtn.GetComponent<Button>().onClick.AddListener(NextPage);

            int pageToSet = 1;

            Dictionary<string, List<BenchData>> benchesByMenuArea = new()
            {
                { "Moss Grotto", new([
                        new("Ruined Chapel", "RestBench", "Tut_03", 1, MapZone.BONECHURCH),
                        new("Bone Bottom", "RestBench", "Bonetown", 1, MapZone.BONETOWN),
                        new("Moss Druid", "RestBench", "Mosstown_02c", 1, MapZone.MOSSTOWN),
                        new("Snail Shamans", "RestBench", "Tut_04", 1, MapZone.BONECHURCH)
                    ])
                },
                { "The Marrow", new([
                        new("Bell Bench", "RestBench", "Bone_01c", 1, MapZone.PATH_OF_BONE),
                        new("Beast Battle", "RestBench", "Bone_04", 1, MapZone.MOSSTOWN),
                        new("Bellshrine", "RestBench", "Bellshrine", 1, MapZone.PATH_OF_BONE),
                        new("Shooting Gallery", "RestBench", "Bone_12", 1, MapZone.PATH_OF_BONE,
                            Act3Data: new("Shooting Gallery?", "RestBench (1)", "Bone_12", 1, MapZone.PATH_OF_BONE)
                        ),
                        new("Flea Caravan", "RestBench", "Bone_10", 1, MapZone.PATH_OF_BONE,
                            Act3Data: new("Survivor Camp", "RestBench", "Bone_10", 1, MapZone.PATH_OF_BONE)
                        ),
                    ])
                },
                { "Hunter's March", new([
                        new("Trap Bench", "RestBench", "Ant_17", 1, MapZone.HUNTERS_NEST)
                    ])
                },
                { "Deep Docks", new([
                        new("Bell Bench", "RestBench", "Dock_01", 1, MapZone.DOCKS),
                        new("Forge", "RestBench", "Room_Forge", 1, MapZone.DOCKS),
                        new("Bellshrine", "RestBench", "Bellshrine_05", 1, MapZone.DOCKS),
                        new("Sauna", "RestBench", "Dock_10", 1, MapZone.DOCKS),
                        new("Diving Bell", "RestBench", "Room_Diving_Bell", 1, MapZone.DOCKS),
                        new("Abyss Exit", "RestBench (1)", "Dock_06_Church", 1, MapZone.DOCKS)
                    ])
                },
                { "Far Fields", new([
                        new("Bellway", "RestBench", "Bellway_03", 1, MapZone.WILDS),
                        new("Seamstress", "RestBench", "Bone_East_Umbrella", 1, MapZone.WILDS),
                        new("Pilgrim's Rest", "RestBench", "Bone_East_10_Room", 1, MapZone.PILGRIMS_REST),
                        new("Post-Claw", "RestBench", "Bone_East_15", 1, MapZone.WILDS),
                        new("Sprintmaster", "RestBench", "Sprintmaster_Cave", 1, MapZone.WILDS),
                        new("Karmelita", "RestBench", "Bone_East_27", 1, MapZone.WILDS)
                    ])
                },
                { "Greymoor", new([
                        new("Shakra", "RestBench", "Greymoor_02", 1, MapZone.GREYMOOR),
                        new("Halfway House", "RestBench", "Halfway_01", 1, MapZone.HALFWAY_HOUSE),
                        new("Bellshrine", "RestBench", "Bellshrine_02", 1, MapZone.GREYMOOR),
                        new("Flea Caravan", "RestBench", "Greymoor_08", 1, MapZone.GREYMOOR),
                        new("Wisp Thicket", "RestBench", "Wisp_04", 1, MapZone.WISP),
                        new("Verdania", "RestBench", "Clover_20", 1, MapZone.CLOVER),
                    ])
                },
                { "Bellheart", new([
                        new("Bellheart", "RestBench", "Belltown", 1, MapZone.BELLTOWN),
                        new("Widow", "RestBench", "Belltown_Shrine", 1, MapZone.BELLTOWN),
                        new("Bellhome", "RestBench", "Belltown_Room_Spare", 1, MapZone.BELLTOWN)
                    ])
                },
                { "Shellwood", new([
                        new("Bell Bench", "RestBench", "Shellwood_01b", 1, MapZone.SHELLWOOD_THICKET),
                        new("Bellshrine", "RestBench", "Bellshrine_03", 1, MapZone.SHELLWOOD_THICKET),
                        new("Overgrown Bench", "RestBench", "Shellwood_08c", 1, MapZone.SHELLWOOD_THICKET),
                        new("Witch Exit", "RestBench", "Mosstown_03", 1, MapZone.SHELLWOOD_THICKET)
                    ])
                },
                { "Blasted Steps", new([
                        new("Bell Bench", "RestBench", "Coral_02", 1, MapZone.JUDGE_STEPS),
                        new("Bellway", "RestBench", "Bellway_08", 1, MapZone.JUDGE_STEPS),
                        new("Flea Caravan", "RestBench", "Coral_Judge_Arena", 1, MapZone.JUDGE_STEPS),
                        new("Pinstress", "RestBench", "Room_Pinstress", 1, MapZone.JUDGE_STEPS),
                    ])
                },
                { "Wormways", new([
                        new("Lifeblood Lab", "RestBench", "Crawl_08", 1, MapZone.CRAWLSPACE)
                    ])
                },
                { "Sinner's Road", new([
                        new("Broken Bench", "RestBench", "Dust_10", 1, MapZone.DUSTPENS),
                        new("Styx", "RestBench", "Dust_11", 1, MapZone.DUSTPENS),
                    ])
                },
                { "Underworks", new([
                        new("Broken Elevator", "RestBench", "Under_01b", 1, MapZone.UNDERSTORE),
                        new("Confession Toll", "RestBench", "Under_08", 1, MapZone.UNDERSTORE),
                        new("Architect 12", "RestBench", "Under_17", 1, MapZone.UNDERSTORE),
                        new("Whiteward", "RestBench", "Ward_01", 1, MapZone.WARD)
                    ])
                },
                { "Citadel", new([
                        new("Underworks", "RestBench", "Under_07b", 1, MapZone.CITY_OF_SONG),
                        new("Below Dining", "RestBench", "Song_18", 1, MapZone.CITY_OF_SONG),
                        new("Spa", "RestBench", "Song_10", 1, MapZone.CITY_OF_SONG),
                        new("High Hall Entrance", "RestBench", "Hang_01", 1, MapZone.CITY_OF_SONG),
                        new("Songclave Bellshrine", "RestBench", "Bellshrine_Enclave", 1, MapZone.CITY_OF_SONG),
                        new("Songclave Outside", "RestBench", "Song_Enclave", 1, MapZone.CITY_OF_SONG),
                        new("Grand Bellway", "RestBench", "Bellway_City", 1, MapZone.CITY_OF_SONG),
                    ])
                },
                { "Citadel Other", new([
                        new("Cogwork Core", "RestBench", "Cog_Bench", 1, MapZone.COG_CORE),
                        new("High Halls Ventricle", "RestBench", "Hang_06b", 1, MapZone.HANG),
                        new("Memoriam", "RestBench", "Arborium_04", 1, MapZone.ARBORIUM),
                        new("Library", "RestBench", "Library_08", 1, MapZone.CITY_OF_SONG),
                        new("Cauldron Entrance", "RestBench", "Library_10", 1, MapZone.CITY_OF_SONG)
                    ])
                },
                { "Bilewater", new([
                        new("Bellway", "RestBench", "Bellway_Shadow", 1, MapZone.SWAMP),
                        new("Shortcut", "RestBench", "Shadow_08", 1, MapZone.SWAMP),
                        new("Bilehaven", "RestBench", "Shadow_18", 1, MapZone.SWAMP),
                        new("Exhaust Organ", "RestBench", "Organ_01", 1, MapZone.CITY_OF_SONG),
                    ])
                },
                { "Putrified Ducts", new([
                        new("Bellway", "RestBench", "Bellway_Aqueduct", 1, MapZone.AQUEDUCT),
                        new("Huntress", "RestBench", "Room_Huntress", 1, MapZone.AQUEDUCT),
                        new("Fleatopia", "RestBench", "Aqueduct_05", 1, MapZone.AQUEDUCT,
                            Act3Data: new("Festival", "RestBench Festival", "Aqueduct_05", 1, MapZone.AQUEDUCT)
                        )
                    ])
                },
                { "The Slab", new([
                        new("Bellway", "RestBench", "Slab_06", 1, MapZone.THE_SLAB),
                        new("Prison", "RestBench", "Slab_20", 1, MapZone.THE_SLAB),
                        new("Outside", "RestBench", "Slab_16", 1, MapZone.THE_SLAB),
                        new("After Arena", "RestBench (1)", "Slab_16", 1, MapZone.THE_SLAB),
                    ])
                },
                { "Mount Fay", new([
                        new("Shakra", "RestBench", "Peak_02", 1, MapZone.PEAK),
                        new("Half-Way", "RestBench", "Bellway_Peak", 1, MapZone.PEAK),
                        new("Final Climb", "RestBench", "Peak_07", 1, MapZone.PEAK),
                        new("Workbench", "RestBench (1)", "Peak_12", 1, MapZone.PEAK)
                    ])
                },
                { "Sands of Karak", new([
                        new("Sands of Karak", "RestBench", "Bellshrine_Coral", 1, MapZone.JUDGE_STEPS),
                        new("Coral Tower", "RestBench", "Coral_Tower_01", 1, MapZone.JUDGE_STEPS)
                    ])
                },
                { "The Cradle", new([
                        new("Terminus", "RestBench", "Tube_Hub", 1, MapZone.CITY_OF_SONG),
                        new("Mr. Mushroom", "RestBench", "Cradle_Destroyed_Challenge_Bench", 1, MapZone.CRADLE)
                    ])
                },
                { "Abyss", new([
                        new("Void Tendrils", "RestBench", "Abyss_12", 1, MapZone.ABYSS),
                        new("Top Abyss", "RestBench", "Abyss_09", 1, MapZone.ABYSS)
                    ])
                },
                { "Weavenest", new([
                        new("Atla", "RestBench", "Weave_07", 1, MapZone.WEAVER_SHRINE),
                        new("Cindril", "RestBench", "Bone_East_Weavehome", 1, MapZone.WILDS)
                    ])
                }
            };

            int i = 0;
            foreach ((string menuArea, List<BenchData> benches) in benchesByMenuArea)
            {
                i++;
                if (i == 14)
                {
                    btnOffsetX = baseDropdownRowXOffset;
                    pageToSet++;
                }

                GameObject dropdownObj = BuildButton(canvas, menuArea, btnOffsetX, -btnOffsetY, TopLeftCorner, hotkey: ((char)('A' + i - 1)).ToString());
                Dropdown dropdown = dropdownObj.AddComponent<Dropdown>();
                dropdown.page = pageToSet;
                dropdown.Init(dropdownObj, menuArea, benches);
                btnOffsetX += btnWidth + 10;
                dropdownObj.GetComponent<Button>().onClick.AddListener(dropdown.ToggleDropdown);

                dropdowns.Add(dropdownObj);
            }

            if (DebugUI)
            {
                benchDebugString = new("Benchwarp Debug", [typeof(RectTransform), typeof(Text)]);
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

        public static GameObject BuildButton(GameObject canvas, string name, int x, int y, Vector2 corner, bool bg = true, string hotkey = "")
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

            GameObject buttonHotkeyLabel = new("ButtonHotkey", typeof(RectTransform));
            buttonHotkeyLabel.transform.SetParent(button.transform, false);

            Text benchHotkeyText = buttonHotkeyLabel.AddComponent<Text>();
            benchHotkeyText.text = hotkey;
            benchHotkeyText.font = Fallback;
            benchHotkeyText.alignment = TextAnchor.UpperLeft;
            benchHotkeyText.color = Color.white;

            RectTransform hotkeyRT = benchHotkeyText.GetComponent<RectTransform>();
            hotkeyRT.anchorMin = Vector2.zero;
            hotkeyRT.anchorMax = Vector2.one;
            hotkeyRT.offsetMin = new(5, 0);
            hotkeyRT.offsetMax = new(0, -5);

            Text benchNameText = buttonTxt.AddComponent<Text>();
            benchNameText.text = name;
            benchNameText.font = Fallback;
            benchNameText.alignment = TextAnchor.MiddleCenter;
            benchNameText.color = Color.white;

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
                LogWarn("GM IS NULL HERE");
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
            foreach (GameObject dropdownObj in dropdowns)
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

                LogWarn("Couldn't find GUIController");

                GameObject GUIObj = new();
                _instance = GUIObj.AddComponent<GUIController>();
                DontDestroyOnLoad(GUIObj);

                return _instance;
            }
        }
    }
}
