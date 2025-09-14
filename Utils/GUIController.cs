using System.Collections.Generic;
using GlobalEnums;
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
        public GameObject warpButton;
        public List<GameObject> dropdowns = new([]);
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

        public void SetBenchwarpFont()
        {
            foreach (Font f in Resources.FindObjectsOfTypeAll(typeof(Font)))
            {
                if (f.name == "TrajanPro-Bold")
                {
                    BenchwarpFont = f;

                    Text warpText = warpButton.GetComponentInChildren<Text>();
                    warpText.font = BenchwarpFont;

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
                if (bench.sceneName == PlayerData.instance.respawnScene)
                {
                    text.color = Color.yellow;
                }
                else
                {
                    text.color = Color.white;
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

            warpButton = BuildButton(canvas, "WARP", btnOffsetX, -btnOffsetY); //Warp Button
            btnOffsetX += btnWidth + 20;
            warpButton.GetComponent<Button>().onClick.AddListener(SaveReload);

            for (int i = 0; i < Dropdown.dropdowns.Count; i++)
            {
                if (i == 13)
                {
                    btnOffsetX = baseDropdownRowXOffset;
                    btnOffsetY += (btnHeight + btnOffsetY) * 5;
                }

                Dropdown.DropdownData data = Dropdown.dropdowns[i];

                GameObject dropdownObj = BuildButton(canvas, data.name, btnOffsetX, -btnOffsetY);
                Dropdown dropdown = dropdownObj.AddComponent<Dropdown>();
                dropdown.Init(dropdownObj, data.name, data.benches);
                btnOffsetX += btnWidth + 10;
                dropdownObj.GetComponent<Button>().onClick.AddListener(dropdown.ToggleDropdown);

                dropdowns.Add(dropdownObj);
            }

            DontDestroyOnLoad(canvas);
        }

        public static GameObject BuildButton(GameObject canvas, string name, int x, int y, bool bg = true)
        {
            GameObject button = new($"{name} Button", [typeof(RectTransform)]);
            button.transform.SetParent(canvas.transform, false);
            Button button_component = button.AddComponent<Button>();

            RectTransform rt = button.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(btnWidth, btnHeight);
            rt.anchorMin = new Vector2(0, 1);
            rt.anchorMax = new Vector2(0, 1);
            rt.pivot = new Vector2(0, 1);
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
            ]),
            new("The Marrow", [
                new("Bell Bench", "RestBench", "Bone_01c", 1, MapZone.PATH_OF_BONE),
                new("Beast Battle", "RestBench", "Bone_04", 1, MapZone.MOSSTOWN),
                new("Bellshrine", "RestBench", "Bellshrine", 1, MapZone.PATH_OF_BONE),
                new("Ladybug", "RestBench", "Bone_12", 1, MapZone.PATH_OF_BONE)
            ]),
            new("Hunter's March", [
                new("Trap Bench", "RestBench", "Ant_17", 1, MapZone.HUNTERS_NEST)
            ]),
            new("Deep Docks", [
                new("Bell Bench", "RestBench", "Dock_01", 1, MapZone.DOCKS),
                new("Forge", "RestBench", "Room_Forge", 1, MapZone.DOCKS),
                new("Bellshrine", "RestBench", "Bellshrine_05", 1, MapZone.DOCKS)
            ]),
            new("Far Fields", [
                new("Bellway", "RestBench", "Bellway_03", 1, MapZone.PATH_OF_BONE),
                new("Seamstress", "RestBench", "Bone_East_Umbrella", 1, MapZone.WILDS),
                new("Pilgrim's Rest", "RestBench", "Bone_East_10_Room", 1, MapZone.PILGRIMS_REST),
                new("Post-Claw", "RestBench", "Bone_East_15", 1, MapZone.WILDS),
            ]),
            new("Greymoor", [
                new("Bellshrine", "RestBench", "Bellshrine_02", 1, MapZone.GREYMOOR),
                new("Halfway House", "RestBench", "Halfway_01", 1, MapZone.HALFWAY_HOUSE),
                new("Flea Caravan", "RestBench", "Greymoor_08", 1, MapZone.GREYMOOR)
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
                new("Pinstress", "RestBench", "Room_Pinstress", 1, MapZone.JUDGE_STEPS)
            ]),
            new("Wormways", [
                new("Lifeblood Lab", "RestBench", "Crawl_08", 1, MapZone.CRAWLSPACE)
            ]),
            new("Sinner's Road", [
                new("Broken Bench", "RestBench", "Dust_10", 1, MapZone.DUSTPENS),
                new("Styx", "RestBench", "Dust_11", 1, MapZone.DUSTPENS)
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
                new("Cogwork Core", "RestBench", "Cog_Bench", 1, MapZone.COG_CORE),
                new("High Hall Entrance", "RestBench", "Hang_01", 1, MapZone.CITY_OF_SONG),
                new("High Halls Ventricle", "RestBench", "Hang_06b", 1, MapZone.HANG),
                new("Songclave Bellshrine", "RestBench", "Bellshrine_Enclave", 1, MapZone.CITY_OF_SONG),
                new("Songclave Outside", "RestBench", "Song_Enclave", 1, MapZone.CITY_OF_SONG),
                new("Grand Bellway", "RestBench", "Bellway_City", 1, MapZone.CITY_OF_SONG),
                new("Memoriam", "RestBench", "Arborium_04", 1, MapZone.ARBORIUM),
            ]),
            new("Whispering Vaults", [
                new("Library", "RestBench", "Library_08", 1, MapZone.CITY_OF_SONG),
                new("Cauldron Entrance", "RestBench", "Library_10", 1, MapZone.CITY_OF_SONG),
            ]),
            new("The Slab", []),
            new("Mount Fay", []),
            new("Sands of Karak", [
                new("Bellshrine", "RestBench", "Bellshrine_Coral", 1, MapZone.JUDGE_STEPS)    
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
                buttons.Add(GUIController.BuildButton(canvas, benchData.benchName, 0, -(btnHeight + btnOffsetY + (btnOffsetY + btnHeight) * i), false));
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
