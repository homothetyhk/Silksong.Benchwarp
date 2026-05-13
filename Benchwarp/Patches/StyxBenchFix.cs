using Benchwarp.Benches;
using Benchwarp.Data;
using Benchwarp.Util;
using HutongGames.PlayMaker.Actions;
using PrepatcherPlugin;
using Silksong.FsmUtil;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Benchwarp.Patches;

internal class StyxBenchFix
{
    internal static void Hook()
    {
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    internal static void Unhook()
    {
        SceneManager.activeSceneChanged -= OnActiveSceneChanged;
    }

    private static void OnActiveSceneChanged(Scene from, Scene to)
    {
        if (to.name == SceneNames.Dust_11 && PlayerDataAccess.permadeathMode == GlobalEnums.PermadeathModes.Off 
            && GameManager.instance.RespawningHero && BaseBenchList.Styx.RespawnInfo.IsCurrentRespawn())
        {
            bool battle = PlayerDataAccess.blackThreadWorld ? !PlayerDataAccess.silkFarmAbyssCoresCleared : !PlayerDataAccess.silkFarmBattle1_complete;
            if (battle)
            {
                GameObject? styx = to.FindGameObject("Steel Soul States/Regular/NPC Control/Grub Farmer NPC", warnIfNotFound: true);
                if (!styx) return;

                PlayMakerFSM fsm = styx!.LocateMyFSM("Control");
                foreach (string state in (string[])["Battle Active", "Abyss Battle Active"])
                {
                     fsm.MustGetState(state).RemoveFirstActionOfType<SetPosition>(); // sets bench y to -100f, reverted to 2.778f on battle end
                }
            }
        }
    }
}
