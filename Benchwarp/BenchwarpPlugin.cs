using BepInEx;
using BepInEx.Logging;
using System.Runtime.CompilerServices;

namespace Benchwarp;

[BepInDependency("org.silksong-modding.fsmutil")]
[BepInDependency("org.silksong-modding.assethelper")]
[BepInDependency("org.silksong-modding.prepatcher")]
[BepInDependency("org.silksong-modding.i18n")]
[BepInDependency("org.silksong-modding.modmenu")]
[BepInDependency("org.silksong-modding.datamanager")]
[BepInAutoPlugin(id: "io.github.benchwarp")]
public partial class BenchwarpPlugin : BaseUnityPlugin
{
    new public ManualLogSource Logger => base.Logger;
    public static BenchwarpPlugin Instance => _instance ?? throw new NullReferenceException("Benchwarp has not loaded yet!");
    private static BenchwarpPlugin? _instance;
    
    private void Awake()
    {
        try
        {
            _instance = this;
            Log($"Plugin {Name} ({Id}) has loaded!");
            gameObject.AddComponent<Components.RespawnChangeListener>();
            LoadAssets();
        }
        catch (Exception e)
        {
            LogError(GetErrorMsg(e));
        }
    }

    private void OnEnable()
    {
        if (!StartCalled) return;
        try
        {
            HarmonyLib.Harmony harmony = new(HarmonyID);
            harmony.PatchAll(GetType().Assembly);
            Patches.ShakraPDHook.Hook();
            Patches.DataManagerFix.Hook();
            Patches.RedeployPatch.Hook();
            Components.GUIController.Setup();
        }
        catch (Exception e)
        {
            LogError(GetErrorMsg(e));
        }
    }

    private void Start()
    {
        StartCalled = true;
        try
        {
            OnEnable();
            DefineConfig(); // Refer to BenchwarpPlugin.Settings.cs
            Components.GUIController.LateSetup();
        }
        catch (Exception e)
        {
            LogError(GetErrorMsg(e));
        }
    }

    private void OnDisable()
    {
        try
        {
            HarmonyLib.Harmony.UnpatchID(HarmonyID);
            Patches.ShakraPDHook.Unhook();
            Patches.DataManagerFix.Unhook();
            Patches.RedeployPatch.Unhook();
            Components.GUIController.Unload();
        }
        catch (Exception e)
        {
            LogError(GetErrorMsg(e));
        }
    }

    private bool StartCalled { get; set; } = false;
    private string HarmonyID { get; } = $"{Name} ({Id})";
    private string GetErrorMsg(Exception e, [CallerMemberName] string? caller = "") => $"Error during {GetType().Name}.{caller}:\n{e}";
}