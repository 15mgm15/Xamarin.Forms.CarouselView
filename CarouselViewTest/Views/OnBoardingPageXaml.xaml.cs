using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselViewTest.Views
{
    public partial class OnBoardingPageXaml : ContentPage
    {
        public OnBoardingPageXaml()
        {
            InitializeComponent();
            BindingContext = new OnboardingPageVm();
        }
    }
}
