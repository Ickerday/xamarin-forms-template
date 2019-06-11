using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using DotNetException = System.Exception;
using FormsAppCompatActivity = Xamarin.Forms.Platform.Android.FormsAppCompatActivity;
using JavaException = Java.Lang.Exception;

namespace XF4.Template.Droid
{
    [Activity(Label = "XF4.Template",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Platform.Init(this, savedInstanceState);
            Forms.Init(this, savedInstanceState);

            try
            {
                LoadApplication(new App());
            }
            catch (JavaException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DotNetException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}