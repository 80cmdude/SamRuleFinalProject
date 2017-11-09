using FinalProjectApp.Alert;
using FinalProjectApp.Data;
using FinalProjectApp.Helpers;
using FinalProjectApp.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Service
{
	public class ApiRequest
	{
		protected async Task<HttpResponseMessage> GeneratePostRequest<T>(T requestObject, string endPoint)
		{
			try
			{
				var httpClient = new HttpClient();
				var json = JsonConvert.SerializeObject(requestObject);

				var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
				httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Settings.Token}");
				httpClient.DefaultRequestHeaders.Add("Id", $"{Settings.UserId}");

				var response = await httpClient.PostAsync(endPoint, httpContent);
				if (ResponseHelper.HasHttpError(response))
				{
					return null;
				}
				return response;
			}
			catch (Exception e)
			{
				Alerts.ServiceUnavailable();
				return null;
			}
		}

		protected async Task<HttpResponseMessage> GenerateGetRequest(string endPoint)
		{
			try
			{
				var httpClient = new HttpClient();
				
				httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Settings.Token}");
				httpClient.DefaultRequestHeaders.Add("Id", $"{Settings.UserId}");

				var response = await httpClient.GetAsync(endPoint);
				if (ResponseHelper.HasHttpError(response))
				{
					return null;
				}
				return response;
			}
			catch (Exception e)
			{
				Alerts.ServiceUnavailable();
				return null;
			}
		}
	}
}
