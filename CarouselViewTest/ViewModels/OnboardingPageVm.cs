using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class OnboardingPageVm : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<OnboardingModel> BoardingObjectsList { get; set; }


		public OnboardingPageVm()
		{

			BoardingObjectsList = new ObservableCollection<OnboardingModel>
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
