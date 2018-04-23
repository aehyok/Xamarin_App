using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace aehyok.App.Droid
{
    //app名称和图标的设置
    [Activity(Label = "缉私平台", Icon = "@drawable/F96", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var width = Resources.DisplayMetrics.WidthPixels;

            var height = Resources.DisplayMetrics.HeightPixels;

            var density = Resources.DisplayMetrics.Density; //屏幕密度



            var ScreenWidth = width / density; //屏幕宽度

            var ScreenHeight = height / density; //屏幕高度 含24个单位的标题栏高度 通过OnSizeAllocated获取的高度不含标题栏高度
            LoadApplication(new App());
        }
    }
}

