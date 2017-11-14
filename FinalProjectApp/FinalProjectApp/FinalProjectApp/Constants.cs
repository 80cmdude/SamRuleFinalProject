using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public static class Constants
	{
		public static string ApiUrl = "http://5bbd933e.ngrok.io";

		public static Dictionary<string, decimal> CreditPickerItems = new Dictionary<string, decimal>
		{
			{"£5", 5 },
			{"£10", 10 },
			{"20", 20 },
			{"Custom", 20 },
		};
	}
}
