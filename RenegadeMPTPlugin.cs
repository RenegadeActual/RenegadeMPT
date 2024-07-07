using BepInEx;
using BepInEx.Logging;
using Renegade.Core.UI;

/// <summary>
/// Renegade.Core Plugin.
/// Written by: William Whatley (Renegade_Actual/The_Apex_Legend) 
/// Server hosting support by: Anthony Valdez (MrGlockster)
/// </summary>

namespace Renegade.Core
{
    [BepInPlugin("com.renegade.core", "Renegade.Core", "1.0.1.4")]
    [BepInProcess("EscapeFromTarkov.exe")]
    public class RenegadePlugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;
        public static string EFTVersionMajor { get; internal set; }
        public string Locale { get; private set; } = "en";

        protected void Awake() //Main function
        {
            new RenegadeVersionLabel_Patch().Enable();
            string renegadeVersion = "1.0.1.4"; // This is already denoted in RenegadeVersionLabel_Patch.cs, I would like to have this file own it.
            LogSource = Logger;
            LogSource.LogInfo($"RenegadeMod loaded! Running version: " + renegadeVersion);
        }
    }
}
