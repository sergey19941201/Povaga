using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using System.Timers;

namespace Povaga
{
    [Activity(Label = "Povaga", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait, Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Timer timer = new Timer(3000);
            timer.Elapsed += delegate
            {
                timer.Enabled = false;
            };
            timer.Enabled = true;
        }
    }
}

