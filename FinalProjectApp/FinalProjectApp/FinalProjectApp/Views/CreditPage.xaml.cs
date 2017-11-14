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
	public partial class CreditPage : BaseContentPage
	{
		CreditPageViewModel viewModel;

		public CreditPage(CreditPageViewModel vm) : base(vm)
		{
			InitializeComponent();
			viewModel = vm;

			foreach (string creditType in Constants.CreditPickerItems.Keys)
			{
				CreditPicker.Items.Add(creditType);
			}

			CreditPicker.SelectedIndexChanged += CreditPicker_SelectedIndexChanged;
		}

		private void CreditPicker_SelectedIndexChanged(object sender, EventArgs e)
		{
			viewModel.CreditPickerUpdated(CreditPicker.SelectedIndex);
		}
	}
}