using FinalProjectApp.Service;
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
	public partial class TransactionPage : BaseContentPage
	{
		TransactionPageViewModel viewModel;
		public TransactionPage (TransactionPageViewModel vm) : base(vm)
		{
			InitializeComponent ();
			viewModel = vm;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			viewModel.GetTransactions();
		}
	}
}