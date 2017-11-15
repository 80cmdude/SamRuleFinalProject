using FinalProjectApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.ViewModels
{
	public class TransactionPageViewModel : BaseViewModel
	{
		public async void GetTransactions()
		{
			TransactionApiRequest request = new TransactionApiRequest();
			var check = await request.GetTransactions();
		}
	}
}
