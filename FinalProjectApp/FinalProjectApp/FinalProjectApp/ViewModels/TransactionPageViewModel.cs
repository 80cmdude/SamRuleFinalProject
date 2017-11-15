using FinalProjectApp.Models;
using FinalProjectApp.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.ViewModels
{
	public class TransactionPageViewModel : BaseViewModel
	{
		public ObservableCollection<Transaction> Transactions { get; set; }
		
		public async void GetTransactions()
		{
			TransactionApiRequest request = new TransactionApiRequest();
			List<Transaction> transactions = await request.GetTransactions();
			if (transactions == null)
			{
				//This stops the app rendering the list view when there is no data in the collection
				Transactions = new ObservableCollection<Transaction>(new List<Transaction>());
				return;
			}
			Transactions = new ObservableCollection<Transaction>(transactions);
		}
	}
}
