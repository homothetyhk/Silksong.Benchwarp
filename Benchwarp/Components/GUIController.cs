using Benchwarp.Data;
using Benchwarp.Util;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components
{
    public class GUIController : MonoBehaviour
    {
        private GameObject canvas;

        private static GUIController _instance;
        public static Font BenchwarpFont;
        public static Font Fallback = Font.CreateDynamicFontFromOSFont("Consolas", 16);
        public static Dictionary<string, Texture2D> images = new();

        public static readonly Vector2 TopLeftCorner = new Vector2(0, 1);

        public GameObject warpButton;
        public GameObject setStartButton;
        public GameObject cfgmgrBtn;
        public GameObject nextPageBtn;
        public List<GameObject> dropdowns = new([]);
        public GameObject sceneNamePanel;
        public int page = 1;
        public static int maxPages = 2;
        public static int maxDropdowns = 12;

        public static int btnWidth = 125; //Controls Button Size Universally
        public static int btnHeight = 45; //Controls Button Size Universally
        public static int btnOffsetX = 10; //Initial X Offset
        public static int baseDropdownRowXOffset = btnOffsetX + btnWidth + 20; //For Reset on Row Drop
        public static int btnOffsetY = 10; //Y Offset for Dropdowns
        public static int baseDropdownYOffset = btnOffsetY; //Y Offset for Bench Buttons

        public bool IsDisplaying { get; private set; }
        public bool ScenePanelEnabled { get; private set; }

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

        public static void Setup()
        {
            GameObject GUIObj = new("Benchwarp GUIController");
            _instance = GUIObj.AddComponent<GUIController>();
            DontDestroyOnLoad(GUIObj);
            _instance.BuildMenus();
            _instance.ToggleDisplay(false);
        }

        public static void LateSetup()
        {
            if (BenchwarpPlugin.GS.AlwaysToggleAll) Instance.ToggleDropdowns(true);
            Instance.ToggleScenePanel(BenchwarpPlugin.GS.ShowScene);
            Settings.GlobalSettings.OnShowSceneChanged += () => Instance.ToggleScenePanel(BenchwarpPlugin.GS.ShowScene);
            Settings.GlobalSettings.OnAlwaysToggleAllChanged += () => Instance.ToggleDropdowns(BenchwarpPlugin.GS.AlwaysToggleAll);
        }

        public static void Unload()
        {
            if (_instance.canvas) Destroy(_instance.canvas);
            if (_instance) Destroy(_instance);
        }

        public void LoadResources()
        {
            images.Add("ButtonRect", SpriteManager.LoadTexFromAssembly("Benchwarp.Resources.Images.ButtonRect.png"));
            SetBenchwarpFont();
        }

        public void ToggleDisplay(bool active)
        {
            canvas.SetActive(active);
            IsDisplaying = active;
        }

        public void ToggleScenePanel(bool enabled)
        {
            sceneNamePanel.SetActive(enabled);
            ScenePanelEnabled = enabled;
        }

        public void SetBenchwarpFont()
        {
            foreach (Font f in Resources.FindObjectsOfTypeAll(typeof(Font)))
            {
                if (f.name == "TrajanPro-Bold")
                {
                    BenchwarpFont = f;

                    Text warpText = warpButton.transform.Find("ButtonText").GetComponent<Text>();
                    warpText.font = BenchwarpFont;

                    Text setStartText = setStartButton.transform.Find("ButtonText").GetComponent<Text>();
                    setStartText.font = BenchwarpFont;

                    /*
                    Text toggleAll = toggleAllBtn.GetComponentInChildren<Text>();
                    toggleAll.font = BenchwarpFont;
                    */

                    Text cfgmgrText = cfgmgrBtn.transform.Find("ButtonText").GetComponent<Text>();
                    cfgmgrText.font = BenchwarpFont;

                    Text nextPage = nextPageBtn.transform.Find("ButtonText").GetComponent<Text>();
                    nextPage.font = BenchwarpFont;

                    Text debugText = sceneNamePanel.GetComponent<Text>();
                    debugText.font = BenchwarpFont;

                    foreach (GameObject benchObj in benchButtons)
                    {
                        benchObj.GetComponent<BenchComponent>().buttonText.font = BenchwarpFont;
                    }

                    foreach(GameObject dropdownObj in dropdowns)
                    {
                        dropdownObj.transform.Find("ButtonText").GetComponent<Text>().font = BenchwarpFont;
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

        public void Update()
        {
            if (BenchwarpFont == null)
            {
                SetBenchwarpFont();
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

            /*
            Text toggleAll = toggleAllBtn.GetComponentInChildren<Text>();
            if (toggleAllDir)
            {
                toggleAll.text = "Open All";
            }
            else
            {
                toggleAll.text = "Close All";
            }
            */

            Text nextPageText = nextPageBtn.GetComponentInChildren<Text>();
            nextPageText.text = $"Page {page}/{maxPages}";

            if (ScenePanelEnabled)
            {
                if (PlayerData.instance != null)
                {
                    Text debugText = sceneNamePanel.GetComponent<Text>();
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

            canvas.AddComponent<HotkeyListener>();

            warpButton = BuildButton(canvas, "Warp", btnOffsetX, -btnOffsetY, TopLeftCorner, true, BenchwarpPlugin.GS.GetHotkey("LB")); //Warp Button
            warpButton.GetComponent<Button>().onClick.AddListener(ChangeScene.WarpToRespawn);

            setStartButton = BuildButton(canvas, "Set Start", btnOffsetX, -btnOffsetY * 2 - btnHeight, TopLeftCorner, true, BenchwarpPlugin.GS.GetHotkey("SB")); //Set Start
            setStartButton.GetComponent<Button>().onClick.AddListener(Events.BenchListModifiers.SetToStart);
            setStartButton.AddComponent<AtStartListener>().buttonText = setStartButton.transform.Find("ButtonText").GetComponent<Text>();

            btnOffsetX += btnWidth + 20;

            /*
            toggleAllBtn = BuildButton(canvas, "Toggle All", -10, -10, new Vector2(1,1));
            toggleAllBtn.GetComponent<Button>().onClick.AddListener(ToggleDropdowns);
            */

            cfgmgrBtn = BuildButton(canvas, "Config", -10, -10, new Vector2(1, 1));

            nextPageBtn = BuildButton(canvas, "Page ", -10, -(20 + btnHeight), new Vector2(1, 1), true, BenchwarpPlugin.GS.GetHotkey("NP"));
            nextPageBtn.GetComponent<Button>().onClick.AddListener(NextPage);

            try
            {
                var cfgmgr = FindAnyObjectByType<ConfigurationManager.ConfigurationManager>();
                cfgmgrBtn.GetComponent<Button>().onClick.AddListener(() => cfgmgr.DisplayingWindow ^= true);
            }
            catch (Exception e)
            {
                LogError(e);
            }
            

            int pageToSet = 0;

            int i = 0;
            foreach ((string menuArea, ReadOnlyCollection<BenchData> benches) in BenchList.BenchGroups)
            {
                i++;
                if (i % maxDropdowns == 1)
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

            sceneNamePanel = new("Benchwarp Debug", [typeof(RectTransform), typeof(Text)]);
            RectTransform rt = sceneNamePanel.GetComponent<RectTransform>();
            Text text = sceneNamePanel.GetComponent<Text>();

            text.font = Fallback;
            text.color = Color.white;
            text.fontSize = 20;

            rt.sizeDelta = new Vector2(1000, 20);
            rt.anchorMin = new Vector2(0, 0);
            rt.anchorMax = new Vector2(0, 0);
            rt.pivot = new Vector2(0, 0);
            rt.anchoredPosition = new Vector2(10, 10);

            sceneNamePanel.transform.SetParent(canvas.transform, false);

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
            benchHotkeyText.color = Color.white.AlphaMultiplied(0.5f);

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
            textRT.anchorMin = new(0.05f, 0);
            textRT.anchorMax = new(0.95f, 1);
            textRT.offsetMin = Vector2.zero;
            textRT.offsetMax = Vector2.zero;

            return button;
        }

        public void ToggleDropdowns(bool expanded)
        {
            foreach (GameObject dropdownObj in dropdowns)
            {
                Dropdown dropdown = dropdownObj.GetComponent<Dropdown>();
                dropdown.ToggleDropdown(expanded);
            }
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

                LogWarn("Couldn't find GUIController");

                GameObject GUIObj = new();
                _instance = GUIObj.AddComponent<GUIController>();
                DontDestroyOnLoad(GUIObj);

                return _instance;
            }
        }
    }
}
