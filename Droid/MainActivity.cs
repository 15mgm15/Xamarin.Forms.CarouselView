using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using CarouselView.FormsPlugin.Android;

namespace CarouselViewTest.Droid
{
	[Activity(Label = "CarouselViewTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
            CarouselViewRenderer.Init();

			LoadApplication(new App());
		}
	}
}
