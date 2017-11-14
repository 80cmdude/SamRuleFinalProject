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

		public static int UserId
		{
			get => AppSettings.GetValueOrDefault(nameof(UserId), 0);
			set => AppSettings.AddOrUpdateValue(nameof(UserId), value);
		}

		public static string Token
		{
			get => AppSettings.GetValueOrDefault(nameof(Token), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(Token), value);
		}

		public static decimal Balance
		{
			get => AppSettings.GetValueOrDefault(nameof(Balance), 0m);
			set => AppSettings.AddOrUpdateValue(nameof(Balance), value);
		}

		public static string FirstName
		{
			get => AppSettings.GetValueOrDefault(nameof(FirstName), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(FirstName), value);
		}

		public static string LastName
		{
			get => AppSettings.GetValueOrDefault(nameof(LastName), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(LastName), value);
		}

		public static float EmployeeCardNumber
		{
			get => AppSettings.GetValueOrDefault(nameof(EmployeeCardNumber), 0f);
			set => AppSettings.AddOrUpdateValue(nameof(EmployeeCardNumber), value);
		}

		public static string PhoneNumber
		{
			get => AppSettings.GetValueOrDefault(nameof(PhoneNumber), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(PhoneNumber), value);
		}

		public static void ClearSettings()
		{
			UserId = 0;
			Token = string.Empty;
			Balance = 0;
			FirstName = string.Empty;
			LastName = string.Empty;
			EmployeeCardNumber = 0f;
			PhoneNumber = string.Empty;
		}
	}
}
