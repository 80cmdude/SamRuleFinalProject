using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Data
{
	public class Settings
	{
		private static ISettings AppSettings => CrossSettings.Current;

		public static string UserId
		{
			get => AppSettings.GetValueOrDefault(nameof(UserId), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(UserId), value);
		}

		public static string Token
		{
			get => AppSettings.GetValueOrDefault(nameof(Token), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(Token), value);
		}
	}
}
