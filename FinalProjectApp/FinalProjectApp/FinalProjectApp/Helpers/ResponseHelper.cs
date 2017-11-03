using FinalProjectApp.Alert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Helpers
{
	public static class ResponseHelper
	{
		public static bool HasHttpError(HttpResponseMessage response)
		{
			if (!response.IsSuccessStatusCode)
			{
				response.Headers.TryGetValues("Error", out var errorReason);
				Alerts.PopAlertMessage("There was an issue", errorReason.FirstOrDefault());
				return true;
			}
			return false;
		}
	}
}
