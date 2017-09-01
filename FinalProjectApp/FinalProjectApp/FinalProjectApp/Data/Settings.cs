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

		public static string UserName
		{
			get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
		}
	}
}
