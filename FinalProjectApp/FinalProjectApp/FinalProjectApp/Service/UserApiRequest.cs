using FinalProjectApp.Data;
using FinalProjectApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Service
{
	public class UserApiRequest : ApiRequest
	{
		public async Task<bool> RegisterRequest(User user)
		{
			var json = await GeneratePostRequest(user);

			Dictionary<string, string> newUser = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

			if (newUser["success"] == "true")
			{
				Settings.Token = newUser["token"];
				Settings.UserId = newUser["id"];
				return true;
			}
			return false;
		}
	}
}
