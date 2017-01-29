using System;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class OnboardingTemplateView : StackLayout
	{
		public BoxView BackGroundProperty;

		public OnboardingTemplateView()
		{
			BackGroundProperty = new BoxView
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Children.Add(BackGroundProperty);
		}
	}
}
