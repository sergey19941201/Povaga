using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace Povaga.Activities
{
    [Activity(Label = "Activity1", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout1);

            FindViewById<Button>(Resource.Id.button1).Click += delegate
            {
                StartActivity(typeof(Activity2));
            };
            FindViewById<Button>(Resource.Id.button2).Click += delegate
            {
                StartActivity(typeof(Activity3));
            };
            FindViewById<Button>(Resource.Id.button3).Click += delegate
            {
                StartActivity(typeof(Activity4));
            };
            FindViewById<Button>(Resource.Id.button4).Click += delegate
            {
                StartActivity(typeof(Activity5));
            };
            FindViewById<Button>(Resource.Id.button5).Click += delegate
            {
                StartActivity(typeof(Activity6));
            };
        }
    }
}