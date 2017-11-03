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

		public ICommand AddPoints => new Command(async() =>
		{
			Transaction transaction = new Transaction("Apple",100);
			TransactionApiRequest request = new TransactionApiRequest();
			await request.TransactionRequest(transaction);
			Balance = Settings.Balance;
		});
	}
}
