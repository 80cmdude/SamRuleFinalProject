using FinalProjectApp.Data;
using FinalProjectApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Service
{
	public class TransactionApiRequest : ApiRequest
	{
		public async Task<bool> TransactionRequest(Transaction transaction)
		{
			var response = await GeneratePostRequest(transaction, ApiEndPoints.Transaction);
			if (response != null)
			{
				var jsonResponse = await response.Content.ReadAsStringAsync();
				User user = JsonConvert.DeserializeObject<User>(jsonResponse);
				Settings.Balance = user.Balance;
				return true;
			}
			return false;
		}
	}
}
