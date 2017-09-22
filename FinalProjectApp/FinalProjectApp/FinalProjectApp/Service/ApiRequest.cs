using FinalProjectApp.Data;
using FinalProjectApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Service
{
	public class ApiRequest
	{
		private async Task<string> GeneratePostRequest<T>(T requestObject)
		{
			try
			{
				var httpClient = new HttpClient();

				var json = JsonConvert.SerializeObject(requestObject);

				var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
				//httpContent.Headers.Add("Authorization", $"Basic {Settings.Token}");

				var response = await httpClient.PostAsync(ApiEndPoints.Register, httpContent);

				var jsonResponse = await response.Content.ReadAsStringAsync();

				return jsonResponse;
			}
			catch (Exception e)
			{
				return null;
			}
		}

		public async Task<User> RegisterRequest(User user)
		{
			var json = await GeneratePostRequest(user);

			//var newUser = JsonConvert.DeserializeObject<>(json);

			return user;
		}
	}
}
