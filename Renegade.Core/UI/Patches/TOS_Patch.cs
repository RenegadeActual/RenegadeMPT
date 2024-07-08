using Aki.Reflection.Patching;
using Comfort.Common;
using EFT;
using EFT.UI;
using System;
using System.Reflection;
using System.Text;
using UnityEngine;
using Renegade.Core;

/*
namespace Renegade.Core.UI.Patches
{
    public class TOS_Patch : ModulePatch
    {
        protected const string str_1 = "V2VsY29tZSB0byBSZW5lZ2FkZVNQVCEKClJlbmVnYWRlU1BUIGlzIGEgdG90YWwgY29udmVyc2lvbiBtb2QgZm9yIFNQVCwgYnJpbmdpbmcgdGhlIHN0YWxrZXIgdW5pdmVyc2UgdG8gVGFya292LiBSZW5lZ2FkZU1QVCBpcyBhbmQgd2lsbCBhbHdheXMgYmUgZnJlZSwgaWYgeW91IHBhaWQgZm9yIGl0IHlvdSBnb3Qgc2NhbW1lZC4gVGhpcyBtb2QgaXMgaW4gQWxwaGEgYW5kIHRoZXJlIHdpbGwgYmUgYnVncy4gUmVwb3J0IGFueSBpc3N1ZXMgdG8gdGhlIEdpdGh1Yi4KCldhaXQgZm9yIHRoaXMgbWVzc2FnZSB0byBmYWRlIHRvIGFjY2VwdCBvdXIgVGVybXMgb2YgU2VydmljZS4KCllvdSBjYW4gZmluZCBvdXIgR2l0aHViIGhlcmU6IGh0dHBzOi8vZ2l0aHViLmNvbS9SZW5lZ2FkZUFjdHVhbC9SZW5lZ2FkZU1QVA==";
        protected const string str_2 = "";

        private static bool HasShown = false;

        protected override MethodBase GetTargetMethod() => typeof(TarkovApplication).GetMethod(nameof(TarkovApplication.method_23));

        [PatchPostfix]
        public static void PostFix()
        {
            if (HasShown)
            {
                return;
            }

            HasShown = true;

            if (!RenegadePlugin.AcceptedTOS.Value)
            {
                byte[] str_1_b = Convert.FromBase64String(str_1);
                string str_1_d = Encoding.UTF8.GetString(str_1_b);
                Singleton<PreloaderUI>.Instance.ShowRenegadeMessage("RenegadeMPT", str_1_d, ErrorScreen.EButtonType.QuitButton, 30f,
                    Application.Quit, AcceptTos);
            }
            else
            {
                byte[] str_2_b = Convert.FromBase64String(str_2);
                string str_2_d = Encoding.UTF8.GetString(str_2_b);
                Singleton<PreloaderUI>.Instance.ShowRenegadeMessage("RenegadeMPT", str_2_d, ErrorScreen.EButtonType.OkButton, 0f,
                    null,
                    null);
            }
        }

        private static void AcceptTos()
        {
            RenegadePlugin.AcceptedTOS.Value = true;
        }
    }
}
*/