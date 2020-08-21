using HarmonyLib;
using RimWorld;
using RimWorld.BaseGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace PerfectlyGenericItem
{
    [HarmonyPatch(typeof(StuffProperties), "CanMake")]
    public static class PGI_GenStuff_CanMake_Patch
    {
        [HarmonyPostfix, HarmonyPriority(Priority.Last)]
        public static void Postfix(StuffProperties __instance, ref bool __result)
        {
            if (__instance.parent.defName == "PerfectlyGenericItem")
            {
                __result = false;
            }
        }
    }

}
