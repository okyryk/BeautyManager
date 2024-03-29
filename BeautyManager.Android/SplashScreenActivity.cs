﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;

namespace BeautyManager.Android
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, Icon = "@drawable/Icon")]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)((int)this.Window.DecorView.SystemUiVisibility ^ (int)SystemUiFlags.LayoutStable ^ (int)SystemUiFlags.LayoutFullscreen);
            this.Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            this.Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);
            base.OnCreate(bundle);
            this.StartActivity(typeof(MainActivity));
        }
    }
}
