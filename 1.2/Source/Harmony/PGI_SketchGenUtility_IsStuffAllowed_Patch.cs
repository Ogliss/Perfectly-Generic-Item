using HarmonyLib;
using RimWorld;
using RimWorld.SketchGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace PerfectlyGenericItem// SketchGenUtility.IsStuffAllowed
{
    [HarmonyPatch(typeof(SketchGenUtility), "IsStuffAllowed")]
    public static class PGI_SketchGenUtility_IsStuffAllowed_Patch
    {
        [HarmonyPostfix, HarmonyPriority(Priority.Last)]
        public static void Postfix(ThingDef stuff, ref bool __result)
        {
            if (stuff == PGIThingDefOf.PerfectlyGenericItem)
            {
                __result = false;
            }
        }
    }

}
