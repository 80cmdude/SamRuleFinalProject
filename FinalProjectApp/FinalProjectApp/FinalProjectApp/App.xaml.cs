using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProjectApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalProjectApp.ViewModels;
using FinalProjectApp.Data;
using FinalProjectApp.Models;

namespace FinalProjectApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		private static Database _orderDatabase;

		public App()
		{
			InitializeComponent();
			if (string.IsNullOrEmpty(Settings.Token))
			{
				MainPage = new NavigationPage(new HomePage(new HomePageViewModel()));
			}
			else
			{
				MainPage = new NavigationPage(new Dashboard());
			}
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

		public static Database OrderDatabase
		{
			get
			{
				if (_orderDatabase == null)
				{
					_orderDatabase = new Database("Orders");
					_orderDatabase.CreateTable<Order>();
					return _orderDatabase;
				}
				return _orderDatabase;
			}
		}
	}
}
