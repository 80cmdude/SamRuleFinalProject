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
				var response = await GeneratePostRequest(user, ApiEndPoints.Register);
				
				if (!response.IsSuccessStatusCode)
				{
					response.Headers.TryGetValues("Error", out var errorReason);
					Alerts.PopAlertMessage("There was an issue", errorReason.FirstOrDefault());
					return false;
				}

				var jsonResponse = await response.Content.ReadAsStringAsync();

				var newUser = JsonConvert.DeserializeObject<User>(jsonResponse);
				
				Settings.Token = newUser.Token;
				Settings.UserId = Convert.ToInt32(newUser.ID);
				return true;
			}
			catch (Exception e)
			{
				Alerts.ServiceUnavailable();
				return false;
			}
		}

		public async Task<bool> SignInRequest(User user)
		{
			try
			{
				var response = await GeneratePostRequest(user, ApiEndPoints.SignIn);

				if (!response.IsSuccessStatusCode)
				{
					response.Headers.TryGetValues("Error", out var errorReason);
					Alerts.PopAlertMessage("There was an issue", errorReason.FirstOrDefault());
					return false;
				}

				var jsonResponse = await response.Content.ReadAsStringAsync();
				User signInUser = JsonConvert.DeserializeObject<User>(jsonResponse);
				return true;
			}
			catch (Exception e)
			{
				Alerts.ServiceUnavailable();
				return false;
			}
		}
	}
}
