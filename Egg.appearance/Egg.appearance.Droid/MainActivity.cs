using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Nfc;
using Android.OS;
using Android.Widget;
using Java.Math;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System;
using Android.Util;

namespace Egg.appearance.Droid
{
    [Activity(Label = "Egg.appearance", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        public static NfcAdapter NfcAdapter { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            NfcAdapter = NfcAdapter.GetDefaultAdapter(this);
            Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        protected override void OnNewIntent(Intent intent)
        {
            Log.Info("we", "are");
            if (ManageNfcTag.InScanMode)
            {
                ManageNfcTag.InScanMode = false;
                var tag = intent.GetParcelableExtra(NfcAdapter.ExtraTag) as Tag;

                if (tag == null)
                {
                    return;
                }
                var tagId = String.Format("{0}" + (tag.GetId().Length * 2) + "X", new BigInteger(1, tag.GetId()));
                Log.Info(tagId, "Tag Id");
                //_scanTextView.Text = tagId;
                //DisplayMessage("Tag id retrieved");
                Toast.MakeText(this, "You have registered", ToastLength.Long).Show();

                // Register the tag
                //var tagRegisterCompleted = await RegisterTagIdAsync(tagId);
                //if (tagRegisterCompleted.IsSuccessStatusCode)
                //{
                //    Toast.MakeText(this, "You have registered", ToastLength.Long).Show();
                //}
            }
        }
    }
}

