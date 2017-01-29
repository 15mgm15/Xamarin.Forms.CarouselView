using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Foundation;
using UIKit;

namespace CarouselViewTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			var cv = typeof(Xamarin.Forms.CarouselView);
			Assembly.Load(cv.FullName);

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
