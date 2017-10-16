using FinalProjectApp.Data;
using FinalProjectApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectApp.Alert;

namespace FinalProjectApp.Service
{
	public class UserApiRequest : ApiRequest
	{
		public async Task<bool> RegisterRequest(User user)
		{
			try
			{
				var json = await GeneratePostRequest(user);
				Dictionary<string, string> newUser = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

				if (newUser["success"] == "true")
				{
					Settings.Token = newUser["token"];
					Settings.UserId = Convert.ToInt32(newUser["id"]);
					return true;
				}
				Alerts.PopAlertMessage("User already exists", "Sorry the user entered already exists, please sign in instead");
				return false;
			}
			catch (Exception e)
			{
				Alerts.ServiceUnavailable();
				return false;
			}
		}
	}
}
