namespace Benchwarp.Settings
{
    public class GlobalSettingsData
    {
        public bool ShowMenu = true;
        public MenuMode MenuMode = MenuMode.StandardBenchwarp;
        public bool ShowScene = false;
        //public int MaxSceneNames = 1;
        //public bool SwapNames = false;
        public bool AlwaysToggleAll = false;

        //public bool EnableDeploy = true;
        //public bool DeployInUnsafeRooms = false;
        //public bool ModifyVanillaBenchStyles = false;
        //public string nearStyle = "Right";
        //public string farStyle = "Right";
        //public bool DeployCooldown = true;
        //public bool Noninteractive = true;
        //public bool NoMidAirDeploy = true;

        //public bool NoPreload = false;
        public bool EnableHotkeys = false;
        public bool OverrideLocalization = false;

        public Dictionary<string, string> HotkeyOverrides = [];
    }
}
