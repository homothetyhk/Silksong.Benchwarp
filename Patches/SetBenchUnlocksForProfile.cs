using System;
using System.Collections.Generic;
using System.Text;
using BenchwarpSS.Utils;
using HarmonyLib;
using UnityEngine;

namespace BenchwarpSS.Patches
{
    [HarmonyPatch(typeof(HeroController), nameof(HeroController.Awake))]
    internal class SetBenchUnlocksForProfile
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            foreach(GameObject benchButton in GUIController.Instance.benchButtons)
            {
                Bench bench = benchButton.GetComponent<Bench>();
                bench.SetUnlockStatus();
            }
        }
    }
}
