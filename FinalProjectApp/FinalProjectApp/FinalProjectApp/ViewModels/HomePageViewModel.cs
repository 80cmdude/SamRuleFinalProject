using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FinalProjectApp.Resources.Resx;
using FinalProjectApp.Models;
using FinalProjectApp.Views;

namespace FinalProjectApp.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		public HomePageViewModel()
		{

		}

		public ICommand NavigateSignInCommand => new Command(async() =>
		{
			await Navigation.PushAsync(new SignInRegisterPage(new SignInRegisterPageViewModel()));
		});

		public ICommand NavigateRegisterCommand => new Command(async() =>
		{
			await Navigation.PushAsync(new SignInRegisterPage(new SignInRegisterPageViewModel()));
		});
	}
}
