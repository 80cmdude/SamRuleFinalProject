using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProjectApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalProjectApp.ViewModels;

namespace FinalProjectApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new HomePage(new HomePageViewModel());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
