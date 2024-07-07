using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Aki.Reflection.Patching;
using Comfort.Common;
using DG.Tweening;
using EFT;
using EFT.UI;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Networking;
using Random = System.Random;

//namespace Renegade.Core.Music
//{
//    public class RenegadeMusicPlayer_Patch : ModulePatch
//    {
//        internal static string CurrDir
//        {
//            get; set;
//        }
//        internal static List<AudioClip> musicClips = List<AudioClip>();
//        internal static string[] files;
//        internal RenegadeMusicPlayer_Patch()
//    }
//}