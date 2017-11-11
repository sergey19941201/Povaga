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
using Android.Views.Animations;

namespace Povaga.Activities
{
    [Activity(Label = "Activity4", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class Activity4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout4);

            Animation myAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.MyAnimation);
            ImageView myImage = FindViewById<ImageView>(Resource.Id.imageView1);

            myImage.StartAnimation(myAnimation);
        }
    }
}