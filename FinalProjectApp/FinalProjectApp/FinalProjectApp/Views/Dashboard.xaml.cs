using FinalProjectApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dashboard : TabbedPage
	{
		public Dashboard()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent();
			Children.Add(new CardPage(new CardPageViewModel()));
			Children.Add(new CreditPage(new CreditPageViewModel()));
			Children.Add(new TransactionPage(new TransactionPageViewModel()));
		}

		protected override bool OnBackButtonPressed()
		{
			// Stops you going back to the registration screen
			return true;
		}
	}
}