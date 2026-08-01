using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace Bucksy.ExitToDesktop.Core
{
    /// <summary>
    /// Main entry point for the ExitToDesktop mod.
    /// </summary>
    public static class Plugin
    {
        private const string HarmonyId = "com.bucksy.exittodesktop";

        /// <summary>
        /// Called when the assembly is loaded.
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Initialize()
        {
            Debug.Log("[Bucksy.ExitToDesktop] Initializing...");

            var harmony = new Harmony(HarmonyId);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Debug.Log("[Bucksy.ExitToDesktop] Harmony patches applied.");
        }
    }
}