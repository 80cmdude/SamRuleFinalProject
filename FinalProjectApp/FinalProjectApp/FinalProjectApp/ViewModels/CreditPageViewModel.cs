using FinalProjectApp.Alert;
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
	public class CreditPageViewModel : BaseViewModel
	{
		public int CreditPickerIndex { get; set; }
		public bool CustomEntryVisible { get; set; } = false;
		public string CustomPrice { get; set; }
		public string CreditCardNumber { get; set; }
		public DateTime ExpireyDate { get; set; }
		public string SecurityPin { get; set; }
		public bool SaveCard { get; set; }
		public IList<string> CreditPickerItems { get; set; }

		private float _creditCardNumber { get; set; }
		private int _securityPin { get; set; }
		private decimal _selectedPrice { get; set; }

		public CreditPageViewModel()
		{

		}

		public void CreditPickerUpdated(int index)
		{
			CreditPickerIndex = index;
			switch (index)
			{
				case 3:
					CustomEntryVisible = true;
					break;
				default:
					CustomEntryVisible = false;
					break;
			}
		}

		public ICommand PurchaseCreditCommand => new Command(async () =>
		{
			if (!ValidateData())
				return;
			_selectedPrice = GetPrice(CreditPickerIndex);

			Transaction transaction = new Transaction("Purchased Credits", _selectedPrice);

			TransactionApiRequest request = new TransactionApiRequest();
			await request.TransactionRequest(transaction);
		});

		private bool ValidateData()
		{
			decimal selectedPrice = 0;
			if (CreditPickerIndex == -1)
				return ValidationFailedAlert("Please choose an amount to buy");
			if (CreditPickerIndex == 3)
			{
				bool isValidPrice = decimal.TryParse(CustomPrice, out selectedPrice);
				if (!isValidPrice || string.IsNullOrEmpty(CustomPrice))
					return ValidationFailedAlert("Please enter a valid custom amount to buy");
			}	
			if (string.IsNullOrEmpty(CreditCardNumber) || !float.TryParse(CreditCardNumber, out float creditCardNumber))
				return ValidationFailedAlert("Please enter a valid credit card number");
			if (ExpireyDate == null)
				return ValidationFailedAlert("Please enter and expirey date");
			if (string.IsNullOrEmpty(SecurityPin) || !int.TryParse(SecurityPin, out int securityPin))
				return ValidationFailedAlert("Please enter a valid security pin");

			_creditCardNumber = creditCardNumber;
			_securityPin = securityPin;
			_selectedPrice = selectedPrice;
			return true;
		}

		private bool ValidationFailedAlert(string error)
		{
			Alerts.PopAlertMessage("Missing information", error);
			return false;
		}

		private decimal GetPrice(int index)
		{
			if (index == 3)
				return _selectedPrice;

			string priceText = CreditPickerItems[index];
			return Constants.CreditPickerItems[priceText];
		}
	}
}
