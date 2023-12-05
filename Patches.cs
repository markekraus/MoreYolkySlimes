using HarmonyLib;
using Il2Cpp;

namespace MoreYolkySlimes
{
    [HarmonyPatch(typeof(SpawnerTrigger), nameof(SpawnerTrigger.Awake))]
    internal class SpawnerTriggerAwakePatch : Entry
    {
        public static void Postfix(SpawnerTrigger __instance)
        {
            if (__instance.name != "YolkySpawner")
                return;
            __instance.chanceOfTrigger = _triggerChance.Value;
        }
    }
}