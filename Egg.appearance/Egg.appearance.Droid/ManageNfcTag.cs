using Android.App;
using Android.Content;
using Android.Nfc;
using Android.Widget;
using Java.Lang;
using Xamarin.Forms;
using Egg.appearance.Droid;
using Egg.appearance.views;
using Java.Math;
using Android.Util;

[assembly: Dependency(typeof(ManageNfcTag))]

namespace Egg.appearance.Droid
{
    public class ManageNfcTag : Object, INfcTag
    {
        public static bool InScanMode { get; set; }

        public ManageNfcTag() { }

        public void EnableScanMode()
        {
            InScanMode = true;

            // Create an intent filter for when an NFC tag is discovered.
            var tagDetected = new IntentFilter(NfcAdapter.ActionTagDiscovered);
            var filters = new[] { tagDetected };

            // When an NFC tag is detected, Android will use the PendingIntent to come back to this activity.
            // The OnNewIntent method will invoked by Android.
            var intent = new Intent(Forms.Context, GetType()).AddFlags(ActivityFlags.SingleTop);
            var pendingIntent = PendingIntent.GetActivity(Forms.Context, 0, intent, 0);

            var activity = Forms.Context as Activity;

            if (MainActivity.NfcAdapter == null)
            {
                //var alert = new AlertDialog.Builder(Forms.Context).Create();
                //alert.SetMessage("NFC is not supported on this device.");
                //alert.SetTitle("NFC Unavailable");
                //alert.SetButton("OK", delegate
                //{
                //    _registerButton.Enabled = false;
                //    _scanTextView.Text = "NFC is not supported on this device.";
                //});
                //alert.Show();
            }
            else
                try
                {
                    MainActivity.NfcAdapter.EnableForegroundDispatch(activity, pendingIntent, filters, null);
                }
                catch (System.Exception e)
                {
                    Log.Error("error", e.ToString());
                }
        }
    }
}