using Benchwarp.Benches;
using Benchwarp.Doors;
using Benchwarp.Events;
using Benchwarp.Util;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

public class GUIController : MonoBehaviour
{
    private GameObject menuCanvasParent = null!;
    private GameObject benchMenuCanvas = null!;
    private GameObject doorMenuCanvas = null!;
    private GameObject sceneNameCanvas = null!;

    private static GUIController _instance = null!;
    internal static FontManager FontManager = null!;
    private static Texture2D buttonRectImage = null!;

    public static readonly Vector2 TopLeftCorner = new Vector2(0, 1);

    public GameObject warpButton = null!;
    public GameObject setStartButton = null!;
    public GameObject cfgmgrBtn = null!;
    public GameObject nextPageBtn = null!;
    public List<GameObject> dropdowns = new([]);
    public GameObject sceneNamePanel = null!;

    public GameObject doorWarpButton = null!;
    public GameObject doorFlipButton = null!;
    public GameObject doorSelectPrevButton = null!;
    public GameObject doorAreaDropdown = null!;
    public GameObject doorRoomDropdown = null!;
    public GameObject doorDoorDropdown = null!;
    public GameObject doorConfigButton = null!;

    public int page = 1;
    public static int maxPages = 2;
    public static int maxDropdowns = 12;

    // see ResetBuildParameters()
    public static int btnWidth; //Controls Button Size Universally
    public static int btnHeight; //Controls Button Size Universally
    public static int btnOffsetX; //Initial X Offset
    public static int baseDropdownRowXOffset; //For Reset on Row Drop
    public static int btnOffsetY; //Y Offset for Dropdowns
    public static int baseDropdownYOffset; //Y Offset for Bench Buttons

    public bool IsDisplaying { get; private set; }
    public bool ScenePanelEnabled { get; private set; }

    public List<GameObject> benchButtons
    {
        get
        {
            List<GameObject> benchButtons = new([]);

            foreach (GameObject dropdownObj in dropdowns)
            {
                BenchDropdown dropdown = dropdownObj.GetComponent<BenchDropdown>();
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
                BenchDropdown dropdown = dropdownObj.GetComponent<BenchDropdown>();
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
        FontManager = GUIObj.AddComponent<FontManager>();
        DontDestroyOnLoad(GUIObj);
        _instance.BuildMenus();
        _instance.ToggleDisplay(false);
    }

    public static void LateSetup()
    {
        if (BenchwarpPlugin.ConfigSettings.AlwaysToggleAll) Instance.ToggleDropdowns(true);
        Instance.ToggleScenePanel(BenchwarpPlugin.ConfigSettings.ShowScene);
        Instance.SelectMenu(BenchwarpPlugin.ConfigSettings.MenuMode);
        Settings.ConfigSettings.OnShowSceneChanged += () => Instance.ToggleScenePanel(BenchwarpPlugin.ConfigSettings.ShowScene);
        Settings.ConfigSettings.OnAlwaysToggleAllChanged += () => Instance.ToggleDropdowns(BenchwarpPlugin.ConfigSettings.AlwaysToggleAll);
        Settings.ConfigSettings.OnMenuModeChanged += () => Instance.SelectMenu(BenchwarpPlugin.ConfigSettings.MenuMode);
    }

    public static void Unload()
    {
        if (_instance.menuCanvasParent) Destroy(_instance.menuCanvasParent);
        if (_instance.sceneNameCanvas) Destroy(_instance.sceneNameCanvas);
        if (_instance) Destroy(_instance.gameObject);
    }

    public void LoadResources()
    {
        buttonRectImage = SpriteManager.LoadTexFromAssembly("Benchwarp.Resources.Images.ButtonRect.png");
    }

    public void ToggleDisplay(bool active)
    {
        menuCanvasParent.SetActive(active);
        IsDisplaying = active;
    }

    public void ToggleScenePanel(bool enabled)
    {
        sceneNamePanel.SetActive(enabled);
        ScenePanelEnabled = enabled;
    }

    public void SelectMenu(Settings.MenuMode mode)
    {
        if (mode == Settings.MenuMode.DoorWarp)
        {
            benchMenuCanvas.SetActive(false);
            doorMenuCanvas.SetActive(true);
        }
        else
        {
            benchMenuCanvas.SetActive(true);
            doorMenuCanvas.SetActive(false);
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
        try
        {
            if (ScenePanelEnabled)
            {
                if (GameManager.UnsafeInstance != null)
                {
                    string sceneText = TextModifiers.GetSceneName(GameManager.instance.sceneName);
                    if (HeroController.SilentInstance != null)
                    {
                        Vector2 heroPos = HeroController.instance.transform.position;
                        sceneText += $" {heroPos}";
                    }
                    sceneNamePanel.GetComponent<Text>().text = sceneText;
                }
            }

            if (GameManager.SilentInstance == null || !GameManager.instance.IsGamePaused() || GameManager.instance.IsNonGameplayScene())
            {
                if (IsDisplaying) ToggleDisplay(false);
                return;
            }
            else if (!IsDisplaying) ToggleDisplay(true);


            foreach (GameObject dropdownObj in dropdowns)
            {
                BenchDropdown dropdown = dropdownObj.GetComponent<BenchDropdown>();
                if (dropdown.page == page)
                {
                    dropdownObj.SetActive(true);
                }
                else
                {
                    dropdownObj.SetActive(false);
                }
            }

            Text nextPageText = nextPageBtn.GetComponentInChildren<Text>();
            nextPageText.text = $"Page {page}/{maxPages}";
        }
        catch (Exception e)
        {
            LogError($"Error during GUIController.Update:\n{e}");
        }

        
    }

    public void BuildMenus()
    {
        try
        {
            LoadResources();

            menuCanvasParent = new("BenchwarpGUI");
            BuildBenchMenu();
            BuildDoorMenu();
            BuildSceneNameCanvas();
            menuCanvasParent.AddComponent<HotkeyListener>();

            DontDestroyOnLoad(menuCanvasParent);
            DontDestroyOnLoad(sceneNameCanvas);
        }
        catch (Exception e)
        {
            LogError($"Error building menus:\n{e}");
        }
    }

    private void ResetBuildParameters()
    {
        btnWidth = 125; //Controls Button Size Universally
        btnHeight = 45; //Controls Button Size Universally
        btnOffsetX = 10; //Initial X Offset
        baseDropdownRowXOffset = btnOffsetX + btnWidth + 20; //For Reset on Row Drop
        btnOffsetY = 10; //Y Offset for Dropdowns
        baseDropdownYOffset = btnOffsetY; //Y Offset for Bench Buttons
    }

    private GameObject BuildCanvas(string name)
    {
        GameObject canvas = new(name);

        canvas.transform.SetParent(menuCanvasParent.transform);

        Canvas canvas_component = canvas.AddComponent<Canvas>();
        canvas_component.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas_component.pixelPerfect = true;
        CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        canvas.AddComponent<GraphicRaycaster>();

        return canvas;
    }

    private void BuildBenchMenu()
    {
        benchMenuCanvas = BuildCanvas("Bench Menu Canvas");

        ResetBuildParameters();

        warpButton = BuildButton(benchMenuCanvas, "Warp", btnOffsetX, -btnOffsetY, TopLeftCorner, true, BenchwarpPlugin.SharedSettings.GetHotkey("LB")); //Warp Button
        warpButton.GetComponent<Button>().onClick.AddListener(ChangeScene.WarpToRespawn);

        setStartButton = BuildButton(benchMenuCanvas, "Set Start", btnOffsetX, -btnOffsetY * 2 - btnHeight, TopLeftCorner, true, BenchwarpPlugin.SharedSettings.GetHotkey("SB")); //Set Start
        setStartButton.GetComponent<Button>().onClick.AddListener(BenchListModifiers.MenuSetToStart);
        setStartButton.AddComponent<AtStartListener>().buttonText = setStartButton.transform.Find("ButtonText").GetComponent<Text>();

        btnOffsetX += btnWidth + 20;


        cfgmgrBtn = BuildButton(benchMenuCanvas, "Config", -10, -10, new Vector2(1, 1));
        try
        {
            var cfgmgr = FindAnyObjectByType<ConfigurationManager.ConfigurationManager>();
            cfgmgrBtn.GetComponent<Button>().onClick.AddListener(() => cfgmgr.DisplayingWindow ^= true);
        }
        catch (Exception e)
        {
            LogError(e);
        }


        nextPageBtn = BuildButton(benchMenuCanvas, "Page ", -10, -(20 + btnHeight), new Vector2(1, 1), true, BenchwarpPlugin.SharedSettings.GetHotkey("NP"));
        nextPageBtn.GetComponent<Button>().onClick.AddListener(NextPage);


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

            GameObject dropdownObj = BuildButton(benchMenuCanvas, menuArea, btnOffsetX, -btnOffsetY, TopLeftCorner, hotkey: ((char)('A' + i - 1)).ToString());
            BenchDropdown dropdown = dropdownObj.AddComponent<BenchDropdown>();
            dropdown.page = pageToSet;
            dropdown.Init(dropdownObj, menuArea, benches);
            btnOffsetX += btnWidth + 10;
            dropdownObj.GetComponent<Button>().onClick.AddListener(dropdown.ToggleDropdown);

            dropdowns.Add(dropdownObj);
        }
    }

    private void BuildDoorMenu()
    {
        doorMenuCanvas = BuildCanvas("Door Menu Canvas");
        DoorSelectorComponent doorSelector = doorMenuCanvas.AddComponent<DoorSelectorComponent>();

        ResetBuildParameters();

        doorWarpButton = BuildButton(doorMenuCanvas, "Warp", btnOffsetX, -btnOffsetY, TopLeftCorner, true); // Warp Button
        doorWarpButton.GetComponent<Button>().onClick.AddListener(doorSelector.Warp);

        doorFlipButton = BuildButton(doorMenuCanvas, "Flip", btnOffsetX, -btnOffsetY * 2 - btnHeight, TopLeftCorner, true); // Flip Button
        doorFlipButton.GetComponent<Button>().onClick.AddListener(doorSelector.Flip);

        doorSelectPrevButton = BuildButton(doorMenuCanvas, "Last Entered", btnOffsetX, -btnOffsetY * 3 - btnHeight * 2, TopLeftCorner, true); // Prev Door Button
        doorSelectPrevButton.GetComponent<Button>().onClick.AddListener(doorSelector.LastEntered);

        cfgmgrBtn = BuildButton(doorMenuCanvas, "Config", -10, -10, new Vector2(1, 1));
        try
        {
            var cfgmgr = FindAnyObjectByType<ConfigurationManager.ConfigurationManager>();
            cfgmgrBtn.GetComponent<Button>().onClick.AddListener(() => cfgmgr.DisplayingWindow ^= true);
        }
        catch (Exception e)
        {
            LogError(e);
        }

        GameObject areaDropdown = BuildButton(doorMenuCanvas, "Areas", 11 * (btnOffsetX + btnWidth), -btnOffsetY, TopLeftCorner);
        DropdownRadioSwitch areaSwitch = areaDropdown.AddComponent<DropdownRadioSwitch>();
        areaSwitch.Init(areaDropdown, "Areas", 6, 9);
        areaSwitch.GetComponent<Button>().onClick.AddListener(areaSwitch.ToggleDropdown);
        areaSwitch.Populate(DoorList.RoomGroups.Select(g => g.MenuArea), false);

        GameObject roomDropdown = BuildButton(doorMenuCanvas, "Rooms", 5 * (btnOffsetX + btnWidth), -btnOffsetY, TopLeftCorner);
        DropdownRadioSwitch roomSwitch = roomDropdown.AddComponent<DropdownRadioSwitch>();
        roomSwitch.Init(roomDropdown, "Rooms", 6, 19);
        roomSwitch.GetComponent<Button>().onClick.AddListener(areaSwitch.ToggleDropdown);
        
        GameObject doorDropdown = BuildButton(doorMenuCanvas, "Doors", 3 * btnWidth / 2, -btnOffsetY, TopLeftCorner);
        DropdownRadioSwitch doorSwitch = doorDropdown.AddComponent<DropdownRadioSwitch>();
        doorSwitch.Init(doorDropdown, "Doors", 2, 10);
        roomSwitch.GetComponent<Button>().onClick.AddListener(areaSwitch.ToggleDropdown);

        doorSelector.Setup(areaSwitch, roomSwitch, doorSwitch, DoorList.RoomGroups);
    }

    private void BuildSceneNameCanvas()
    {
        sceneNameCanvas = BuildCanvas("Scene Name Canvas");
        sceneNameCanvas.transform.SetParent(null); // always display

        sceneNamePanel = new("Benchwarp Debug", [typeof(RectTransform), typeof(Text)]);
        RectTransform rt = sceneNamePanel.GetComponent<RectTransform>();
        Text text = sceneNamePanel.GetComponent<Text>();

        FontManager.SetTrajanFont(text);
        text.color = Color.white;
        text.fontSize = 20;

        rt.sizeDelta = new Vector2(1000, 20);
        rt.anchorMin = new Vector2(0, 0);
        rt.anchorMax = new Vector2(0, 0);
        rt.pivot = new Vector2(0, 0);
        rt.anchoredPosition = new Vector2(10, 10);
        sceneNamePanel.transform.SetParent(sceneNameCanvas.transform, false);
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
            Texture2D tex = buttonRectImage;
            Image image = button.AddComponent<Image>();
            image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }

        GameObject buttonTxt = new("ButtonText", typeof(RectTransform));
        buttonTxt.transform.SetParent(button.transform, false);

        GameObject buttonHotkeyLabel = new("ButtonHotkey", typeof(RectTransform));
        buttonHotkeyLabel.transform.SetParent(button.transform, false);

        Text benchHotkeyText = buttonHotkeyLabel.AddComponent<Text>();
        benchHotkeyText.text = hotkey;
        FontManager.SetMonoFont(benchHotkeyText);
        benchHotkeyText.alignment = TextAnchor.UpperLeft;
        benchHotkeyText.color = Color.white.AlphaMultiplied(0.5f);

        RectTransform hotkeyRT = benchHotkeyText.GetComponent<RectTransform>();
        hotkeyRT.anchorMin = Vector2.zero;
        hotkeyRT.anchorMax = Vector2.one;
        hotkeyRT.offsetMin = new(5, 0);
        hotkeyRT.offsetMax = new(0, -5);

        Text benchNameText = buttonTxt.AddComponent<Text>();
        benchNameText.text = name;
        FontManager.SetTrajanFont(benchNameText);
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
            BenchDropdown dropdown = dropdownObj.GetComponent<BenchDropdown>();
            dropdown.ToggleDropdown(expanded);
        }
    }

    public void ToggleDropdowns()
    {
        bool TempToggleDir = toggleAllDir;
        foreach(GameObject dropdownObj in dropdowns)
        {
            BenchDropdown dropdown = dropdownObj.GetComponent<BenchDropdown>();
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
