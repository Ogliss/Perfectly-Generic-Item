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
    [HarmonyPatch(typeof(BaseGenUtility), "IsCheapWallStuff")]
    public static class PGI_BaseGenUtility_IsCheapWallStuff_Patch
    {
        [HarmonyPostfix, HarmonyPriority(Priority.Last)]
        public static void Postfix(ThingDef d, ref bool __result)
        {
            if (d.defName == "PerfectlyGenericItem")
            {
                __result = false;
            }
        }
    }

}
