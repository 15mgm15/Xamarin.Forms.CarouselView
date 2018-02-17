using System;
using CarouselViewTest.Views;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class App : Application
	{
		public App()
		{
            //Code Behind
			//MainPage = new NavigationPage(new OnBoardingPage());

            //Xaml
            MainPage = new NavigationPage(new OnBoardingPageXaml());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
