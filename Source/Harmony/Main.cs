using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace PerfectlyGenericItem
{
    [StaticConstructorOnStartup]
    class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.ogliss.rimworld.mod.PerfectlyGenericItem");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            string modname = "Perfectly Generic Item: ";
            // Fluffys Stuff Floors compatability
            string tname = "StuffedFloors.Controller";
            string nspace = "StuffedFloors";
            string mname = "GetStuffDefsFor";
            MethodInfo target = AccessTools.Method(GenTypes.GetTypeInAnyAssembly(tname, nspace), mname, new Type[] { typeof(StuffCategoryDef) }, null);
            if (target != null)
            {
                Type t = typeof(Main);
                string pmname = "StuffedFloors_GetStuffDefsFor_Postfix";
                MethodInfo patch = t.GetMethod(pmname);
                if (patch == null)
                {
                    Log.Warning("Patch is null " + t.Name.ToString() + "." + pmname);
                }
                else
                {
                    if (harmony.Patch(target, new HarmonyMethod(patch)) == null)
                    {
                        Log.Warning(modname + tname + " Patch Failed to apply");
                    }
                }
            }
        }
        public static void StuffedFloors_GetStuffDefsFor_Postfix(ref List<ThingDef> __result)
        {
            __result.RemoveAll(x => x == PGIThingDefOf.PerfectlyGenericItem);
        }
    }

}
