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
			var response = await GeneratePostRequest(user, ApiEndPoints.Register);
			if (response != null)
			{
				var jsonResponse = await response.Content.ReadAsStringAsync();

				var newUser = JsonConvert.DeserializeObject<User>(jsonResponse);

				Settings.Token = newUser.Token;
				Settings.UserId = Convert.ToInt32(newUser.ID);
				return true;
			}
			return false;
		}

		public async Task<bool> SignInRequest(User user)
		{
			var response = await GeneratePostRequest(user, ApiEndPoints.SignIn);
			if (response != null)
			{
				var jsonResponse = await response.Content.ReadAsStringAsync();
				User signInUser = JsonConvert.DeserializeObject<User>(jsonResponse);
				return true;
			}
			return false;
		}
	}
}
