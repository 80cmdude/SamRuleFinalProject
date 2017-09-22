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

		public static string Register = Constants.ApiUrl + "/Register";
		public static string SignIn = Constants.ApiUrl + "/SignIn";
	}
}
