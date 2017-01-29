using System;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class OnBoardingPage : ContentPage
	{
		OnboardingPageVm _onBoardingVm;
		
		public OnBoardingPage()
		{
			Title = "Carousel View";
			_onBoardingVm = new OnboardingPageVm();
			BindingContext = _onBoardingVm;
			
			CarouselView carouselView = new CarouselView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
			};

			var onBoardingDataTemplate = new DataTemplate(CreateViewTemplate);
			carouselView.ItemTemplate = onBoardingDataTemplate;

			//Uncomment this in order to create the page Indicators.
			//CarouselIndicators indicators = new CarouselIndicators
			//{
			//	IndicatorHeight = 8,
			//	IndicatorWidth = 8,
			//	UnselectedIndicator = "unselected_circle.png",
			//	SelectedIndicator = "selected_circle.png",
			//	VerticalOptions = LayoutOptions.EndAndExpand
			//};

			Grid mainContainer = new Grid { };

			mainContainer.Children.Add(carouselView, 0, 0);
			//Uncomment this in order to add the page Indicators.
			//mainContainer.Children.Add(indicators, 0, 0);

			Content = mainContainer;

			#region Bindings

			carouselView.SetBinding(ItemsView.ItemsSourceProperty, nameof(_onBoardingVm.BoardingObjectsList));
			carouselView.SetBinding(CarouselView.PositionProperty, nameof(_onBoardingVm.Position), BindingMode.TwoWay);
			//Uncomment this in order to bind the page Indicators.
			//indicators.SetBinding(CarouselIndicators.PositionProperty, nameof(_onBoardingVm.Position), BindingMode.TwoWay);
			//indicators.SetBinding(CarouselIndicators.ItemsSourceProperty, nameof(_onBoardingVm.BoardingObjectsList));

			#endregion
		}

		/// <summary>
		/// Creates the view template for the OnBoarding Views.
		/// </summary>
		/// <returns>The custom Xamarin.Forms.StackLayout, OnboardingTemplateView.</returns>
		View CreateViewTemplate()
		{
			var view = new OnboardingTemplateView();
			view.BindingContext = _onBoardingVm.BoardingObjectsList;
			view.BackGroundProperty.SetBinding(BackgroundColorProperty, nameof(OnboardingModel.Color));
			return view;
		}
	}
}

