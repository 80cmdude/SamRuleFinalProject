using FinalProjectApp.Alert;
using FinalProjectApp.Data;
using FinalProjectApp.Models;
using FinalProjectApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalProjectApp.ViewModels
{
	public class DeveloperPageViewModel : BaseViewModel
	{
		public string ProductNameText { get; set; }
		public string PriceText { get; set; }

		private decimal _price { get; set; }

		public ICommand MakePaymentCommand => new Command(async () =>
		{
			bool canSendPrice = decimal.TryParse(PriceText, out decimal price);

			if (canSendPrice)
			{
				price = -price;
				TransactionApiRequest request = new TransactionApiRequest();
				Transaction transaction = new Transaction(ProductNameText, price);
				if (await request.TransactionRequest(transaction))
				{
					Alerts.PopAlertMessage("Sent", "Request was sent successfully");
				}
			}
		});

		public ICommand InvalidateTokenCommand => new Command(() =>
		{
			Settings.Token = "Cake";
		});
	}
}
