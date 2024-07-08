using BepInEx;
using BepInEx.Logging;
using Renegade.Core.UI;
using UnityEngine;
using System.Collections;
//using Renegade.Core.UI.Patches;
using BepInEx.Configuration;
//using Renegade.Core.Utils;

/// <summary>
/// Renegade.Core Plugin.
/// Written by: William Whatley (Renegade_Actual/The_Apex_Legend) 
/// Server hosting support by: Anthony Valdez (MrGlockster)
/// </summary>

namespace Renegade.Core
{
    [BepInPlugin("com.renegade.core", "Renegade.Core", "0.5.1.4")]
    [BepInProcess("EscapeFromTarkov.exe")]
    [BepInDependency("com.fika.core", BepInDependency.DependencyFlags.HardDependency)] //this is to ensure that FIKA loads first so that we can overwrite it
    public class RenegadePlugin : BaseUnityPlugin
    {
        public static RenegadePlugin Instance;
        public ManualLogSource RenegadeLogger { get => Logger; }
        public static string EFTVersionMajor { get; internal set; }
        public string Locale { get; private set; } = "en";
        //public static bool AcceptedTOS.Value = true;
        //public RenegadeModHandler ModHandler = new();

        #region config values

        // Hidden
        public static ConfigEntry<bool> AcceptedTOS { get; set; }

        #endregion

        protected void Awake() //Main function
        {
            Instance = this;

            //GetClientConfig();
            SetupConfig();
            new RenegadeVersionLabel_Patch().Enable();
            //new TOS_Patch().Enable();
            string renegadeVersion = "0.5.1.4"; // This is already denoted in RenegadeVersionLabel_Patch.cs, I would like to have this file own it.
            //LogSource = Logger;
            //LogSource.LogInfo($"RenegadeMod loaded! Running version: " + renegadeVersion);

            StartCoroutine(RunModHandler());

        }

        /// <summary>
        /// Coroutine to ensure all mods are loaded by waiting 5 seconds
        /// </summary>
        /// <returns></returns>
        private IEnumerator RunModHandler()
        {
            yield return new WaitForSeconds(5);
            //ModHandler.VerifyMods();
        }

        private void SetupConfig()
        {
            AcceptedTOS = Config.Bind("Hidden", "Accepted TOS", false, new ConfigDescription("Has accepted TOS", tags: new ConfigurationManagerAttributes() { Browsable = false }));
        }
    }
}
