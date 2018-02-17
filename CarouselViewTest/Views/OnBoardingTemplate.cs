using System;
using Xamarin.Forms;

namespace CarouselViewTest
{
    /// <summary>
    /// If you want to use a custom view on your DataTemplate
    /// </summary>
	public class OnboardingTemplateView : StackLayout
	{
		public BoxView BackGroundBoxView;

		public OnboardingTemplateView()
		{
			BackGroundBoxView = new BoxView
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Children.Add(BackGroundBoxView);
		}
	}
}
