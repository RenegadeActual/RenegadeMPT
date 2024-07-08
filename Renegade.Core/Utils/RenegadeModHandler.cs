using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using Comfort.Common;
using EFT;
using EFT.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renegade.Core.Utils
{
    /// <summary>
    /// Mod Handler to ensure mods are loaded properly
    /// </summary>
    public class RenegadeModHandler
    {
        private readonly ManualLogSource logger = Logger.CreateLogSource("RenegadeModHandler");

        public void VerifyMods()
        {
            //PluginInfo[] pluginInfos = [.. Chainloader.PluginInfos.Values];
        }
    }
}
