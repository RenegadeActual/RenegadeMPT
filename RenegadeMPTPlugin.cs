using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using EFT;
using EFT.UI;
using Aki.Reflection.Patching;
using Renegade.Core.UI;


namespace Renegade.Core
{
    /// <summary>
    /// Renegade.Base Plugin. <br/> <br/>
    /// Written by: William Whatley (Renegade_Actual/The_Apex_Legend) <br/>
    /// Supported by: Anthony Valdez (MrGlockster) <br/>
    /// </summary>

    [BepInPlugin("com.renegade.core", "Renegade.Core", "1.0.1.1")]
    [BepInProcess("EscapeFromTarkov.exe")]
    //[BepInDependency("com.SPT.core", BepInDependency.DependencyFlags.HardDependency)] // This is used so that we guarantee to load after spt-core, that way we can disable its patches
    //[BepInDependency("com.SPT.debugging", BepInDependency.DependencyFlags.HardDependency)]
    public class RenegadePlugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;
        // public static RenegadePlugin Instance;
        public static string EFTVersionMajor { get; internal set; }
        public string Locale { get; private set; } = "en";

        #region config values

        //Advanced
        public static ConfigEntry<bool> OfficialVersion { get; set; }

        #endregion

        protected void Awake()
        {
            // Instance = this;

            // GetClientConfig();

            new RenegadeVersionLabel_Patch().Enable();
            //new EndScreenLoadPatch().Enable();
            //new HideoutScreenLoadPatch().Enable();

            //Harmony.CreateAndPatchAll(typeof(CustomMusicComponent));

            //OfficialVersion.SettingChanged += OfficialVersion_SettingChanged;

            string renegadeVersion = "1.0.1.1";
            LogSource = Logger;
            LogSource.LogInfo($"RenegadeMod loaded! Running version: " + renegadeVersion);


        }

        //private void OfficialVersion_SettingChanged(object sender, EventArgs e)
        //{
        //    RenegadeVersionLabel_Patch.UpdateVersionLabel();
        //}
    }
}
