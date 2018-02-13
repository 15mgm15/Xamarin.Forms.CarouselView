using System;
using CarouselView.FormsPlugin.Abstractions;
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
			
            CarouselViewControl carouselView = new CarouselViewControl
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
                ShowIndicators = true
			};

			var onBoardingDataTemplate = new DataTemplate(CreateViewTemplate);
			carouselView.ItemTemplate = onBoardingDataTemplate;

			Grid mainContainer = new Grid { };

			mainContainer.Children.Add(carouselView, 0, 0);
			
			Content = mainContainer;

			#region Bindings

            carouselView.SetBinding(CarouselViewControl.ItemsSourceProperty, nameof(_onBoardingVm.BoardingObjectsList));
			
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

