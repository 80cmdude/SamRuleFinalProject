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

				SetUserSettings(newUser);
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

				SetUserSettings(signInUser);
				return true;
			}
			return false;
		}

		private void SetUserSettings(User user)
		{
			Settings.Token = user.Token;
			Settings.UserId = Convert.ToInt32(user.ID);
			Settings.FirstName = user.FirstName;
			Settings.LastName = user.LastName;
			Settings.EmployeeCardNumber = user.EmployeeCardNumber;
			Settings.PhoneNumber = user.PhoneNumber;
		}
	}
}
