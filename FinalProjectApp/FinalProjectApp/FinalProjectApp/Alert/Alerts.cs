using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Alert
{
	public static class Alerts
	{
		public async static void ServiceUnavailable()
		{
			await App.Current.MainPage.DisplayAlert("Service Unavailable","Please speak to a memeber of the tech team to restore the service", "Okay");
		}

		public async static void PopAlertMessage(string title, string message)
		{
			await App.Current.MainPage.DisplayAlert(title, message, "Okay");
		}
	}
}
