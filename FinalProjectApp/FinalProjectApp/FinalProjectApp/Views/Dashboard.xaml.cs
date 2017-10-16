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
			InitializeComponent();
			Children.Add(new CardPage(new CardPageViewModel()));
		}
	}
}