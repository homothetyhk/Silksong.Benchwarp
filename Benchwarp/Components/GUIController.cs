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
        public GameObject toggleAllBtn;
        public GameObject nextPageBtn;
        public List<GameObject> dropdowns = new([]);
        public GameObject benchDebugString;
        public int page = 1;
        public int maxPages = 2;

        public bool DebugUI = true;

        public bool IsDisplaying { get; private set; }

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
        public static int btnHeight = 45; //Controls Button Size Universally
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

        public void ToggleDisplay(bool active)
        {
            canvas.SetActive(active);
            IsDisplaying = active;
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

                    foreach(GameObject benchObj in benchButtons)
                    {
                        Text[] texts = benchObj.GetComponentsInChildren<Text>();
                        foreach(Text text in texts)
                        {
                            text.font = BenchwarpFont;
                        }
                    }

                    foreach(GameObject dropdownObj in dropdowns)
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
            canvas_component.pixelPerfect = true;
            CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            canvas.AddComponent<GraphicRaycaster>();

            canvas.AddComponent<HotkeyListener>();

            warpButton = BuildButton(canvas, "WARP", btnOffsetX, -btnOffsetY, TopLeftCorner); //Warp Button
            btnOffsetX += btnWidth + 20;
            warpButton.GetComponent<Button>().onClick.AddListener(ChangeScene.WarpToRespawn);

            toggleAllBtn = BuildButton(canvas, "Toggle All", -10, -10, new Vector2(1,1));
            toggleAllBtn.GetComponent<Button>().onClick.AddListener(ToggleDropdowns);

            nextPageBtn = BuildButton(canvas, "Page ", -10, -(20 + btnHeight), new Vector2(1, 1));
            nextPageBtn.GetComponent<Button>().onClick.AddListener(NextPage);

            int pageToSet = 1;

            int i = 0;
            foreach ((string menuArea, ReadOnlyCollection<BenchData> benches) in BenchList.BenchGroups)
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
