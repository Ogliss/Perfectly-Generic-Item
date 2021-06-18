using RimWorld;
using Verse;

namespace PerfectlyGenericItem
{
    [DefOf]
    public static class PGIThingDefOf
    {
        static PGIThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(PGIThingDefOf));
        }
        public static ThingDef PerfectlyGenericItem;
    }
}
