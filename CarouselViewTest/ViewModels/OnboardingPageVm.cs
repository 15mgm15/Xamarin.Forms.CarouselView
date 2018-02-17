using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class OnboardingPageVm : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public List<OnboardingModel> BoardingObjectsList { get; set; }

		public OnboardingPageVm()
		{
			BoardingObjectsList = new List<OnboardingModel>
			{
				new OnboardingModel
				{
					Color = Color.Red
				},
				new OnboardingModel
				{
					Color = Color.Blue
				},
				new OnboardingModel
				{
					Color = Color.Green
				},
				new OnboardingModel
				{
					Color = Color.Yellow
				}
			};
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
	}
}
