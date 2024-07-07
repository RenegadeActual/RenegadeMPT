using EFT.UI;
using System.Reflection;
using Aki.Reflection.Patching;
using HarmonyLib;
using Renegade.Core;
using Aki.Common.Http;
using Aki.Common.Utils;
using Comfort.Net.Dispatching;

namespace Renegade.Core.UI
{
    public class RenegadeVersionLabel_Patch : ModulePatch
    {
        /// <summary>
        /// Originally developed by the SPT and FIKA team; RENEVATED DRASTICALLY...
        /// </summary>
        private static string versionLabel = "RenegadeMPT";
        private static Traverse versionNumberTraverse;
        private static string renegadeVersion;
        private static string officialVersion;

        protected override MethodBase GetTargetMethod()
        {
            return typeof(VersionNumberClass).GetMethod(nameof(VersionNumberClass.Create),
                BindingFlags.Static | BindingFlags.Public);
        }

        [PatchPostfix]
        internal static void PatchPostfix(string major, object __result)
        {
            RenegadePlugin.EFTVersionMajor = major;

            if (string.IsNullOrEmpty(versionLabel))
            {
                versionLabel = "THIS IS THE VERSION LABEL";
            }

            renegadeVersion = "1.0.1.1-alpha";

            Traverse preloaderUiTraverse = Traverse.Create(MonoBehaviourSingleton<PreloaderUI>.Instance);

            preloaderUiTraverse.Field("_alphaVersionLabel").Property("LocalizationKey").SetValue("{0}");

            versionNumberTraverse = Traverse.Create(__result);

            Logger.LogInfo($"versionNumberTraverse:" + versionNumberTraverse.Field("Major"));

            officialVersion = versionNumberTraverse.Field<string>("Major").Value;

            UpdateVersionLabel();
        }

        public static void UpdateVersionLabel()
        {
            Traverse preloaderUiTraverse = Traverse.Create(MonoBehaviourSingleton<PreloaderUI>.Instance);
            
            preloaderUiTraverse.Field("string_2").SetValue($"RenegadeMPT BETA {renegadeVersion} | {versionLabel}");
            versionNumberTraverse.Field("Major").SetValue($"{versionLabel} {renegadeVersion}");
        }
    }
}