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

		public static string EmployeeNumber
		{
			get => AppSettings.GetValueOrDefault(nameof(EmployeeNumber), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(EmployeeNumber), value);
		}

		public static string Token
		{
			get => AppSettings.GetValueOrDefault(nameof(EmployeeNumber), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(EmployeeNumber), value);
		}
	}
}
