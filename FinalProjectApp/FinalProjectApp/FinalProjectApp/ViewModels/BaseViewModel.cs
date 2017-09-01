using FinalProjectApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectApp.ViewModels
{
	public abstract class BaseViewModel : IViewModel, INotifyPropertyChanged
	{
		public BaseViewModel()
		{

		}

		public INavigation Navigation { get; set; }

		public virtual void OnAppearing()
		{

		}

		public virtual void OnDisappearing()
		{

		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
