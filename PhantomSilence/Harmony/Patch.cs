using System;
using HarmonyLib;

namespace PhantomSilence.Harmony
{
    [HarmonyPatch(typeof(AudioObject), nameof(AudioObject.Update))]
    public static class Patch
    {
        private static readonly ILogger Logger = new Logger();

        private static readonly string[] TargetNames =
        {
            "Night_Oneshots", // a_daybreak_oneshot[1-6]
            "Dusk_Stingers", // a_nightfall_oneshot
            "Dawn_Stingers" // a_daybreak_oneshot
        };

        public static bool Prefix(AudioObject __instance, float deltaTime)
        {
            if (!Array.Exists(TargetNames, name => name == __instance.name)) return true;

            Logger.Info($"Turning off {__instance.name}.");
            __instance.TurnOff(true);

            return true;
        }
    }
}