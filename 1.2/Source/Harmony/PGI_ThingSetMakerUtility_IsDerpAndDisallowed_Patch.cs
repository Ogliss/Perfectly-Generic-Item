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
    [HarmonyPatch(typeof(ThingSetMakerUtility), "IsDerpAndDisallowed")]
    public static class PGI_ThingSetMakerUtility_IsDerpAndDisallowed_Patch
    {
        [HarmonyPostfix, HarmonyPriority(Priority.Last)]
        public static void Postfix(ThingDef stuff, ref bool __result)
        {
            if (stuff == PGIThingDefOf.PerfectlyGenericItem)
            {
                __result = true;
            }
        }
    }

}
