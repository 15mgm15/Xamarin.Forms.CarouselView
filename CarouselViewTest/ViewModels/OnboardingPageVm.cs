using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarouselViewTest
{
	public class OnboardingPageVm : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<OnboardingModel> BoardingObjectsList { get; set; }

		//This is only needed if we need page Indicators
		int _position = 0;
		public int Position
		{
			get
			{
				return _position;
			}
			set
			{
				_position = value;
				OnPropertyChanged(nameof(Position));
			}
		}

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
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
