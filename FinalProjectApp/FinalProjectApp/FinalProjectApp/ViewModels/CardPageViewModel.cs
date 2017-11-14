using FinalProjectApp.Models;
using FinalProjectApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FinalProjectApp.Data;

namespace FinalProjectApp.ViewModels
{
	public class CardPageViewModel : BaseViewModel
	{
		public decimal Balance { get; set; }
		public string Name { get; set; }
		public string CardNumber { get; set; }

		public CardPageViewModel()
		{
			Name = $"{Settings.FirstName} {Settings.LastName}";
			CardNumber = $"Card Number: \n {Settings.EmployeeCardNumber}";
		}

		public ICommand AddPoints => new Command(async() =>
		{
			Transaction transaction = new Transaction("Apple",100);
			TransactionApiRequest request = new TransactionApiRequest();
			await request.TransactionRequest(transaction);
			Balance = Settings.Balance;
		});

		public ICommand SignOutCommand => new Command(async() =>
		{
			await SignOut();
		});

		public async void GetBalance()
		{
			TransactionApiRequest request = new TransactionApiRequest();
			await request.GetBalanceRequest();
			Balance = Settings.Balance;
		}
	}
}
