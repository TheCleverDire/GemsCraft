using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace GemsCraft_On_the_Go
{
    [Activity(Label = "GemsCraft: On the Go", Icon = "@drawable/icon", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        internal void Login(View v)
        {
            AlertDialog ad = new AlertDialog.Builder(this).Create();
            ad.SetTitle("hi! I'm testing something cooL!");
            ad.SetMessage("WEll hello there n00b!");
            ad.Show();
        }
    }
}

