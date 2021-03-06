﻿using FinalProjectApp.Data;
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
			transaction.UserId = Settings.UserId;
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

		public async Task<List<Transaction>> GetTransactions()
		{
			var response = await GenerateGetRequest(ApiEndPoints.Transactions);
			if (response != null)
			{
				var jsonResponse = await response.Content.ReadAsStringAsync();
				List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(jsonResponse);
				return transactions;
			}
			return null;
		}

		public async Task<bool> GetBalanceRequest()
		{
			var response = await GenerateGetRequest(ApiEndPoints.Balance);
			if (response != null)
			{
				var jsonResponse = await response.Content.ReadAsStringAsync();
				decimal balance = JsonConvert.DeserializeObject<decimal>(jsonResponse);
				Settings.Balance = balance;
				return true;
			}
			return false;
		}
	}
}
