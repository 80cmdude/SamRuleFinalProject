using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Service
{
	public static class ApiEndPoints
	{
		private static string _api = "/api";

		public static string Register = Constants.ApiUrl + _api + "/Register";
		public static string SignIn = Constants.ApiUrl + _api + "/SignIn";
		public static string Transaction = Constants.ApiUrl + _api + "/Transaction";
		public static string Transactions = Constants.ApiUrl + _api + "/Transactions";
		public static string Balance = Constants.ApiUrl + _api + "/Balance";
	}
}
