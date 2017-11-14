using FinalProjectApp.Alert;
using FinalProjectApp.Models;
using FinalProjectApp.Service;
using FinalProjectApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalProjectApp.ViewModels
{
	public class SignInRegisterPageViewModel : BaseViewModel
	{
		public bool IsSignInPage { get; set; }
		public string PasswordEntryText { get; set; }
		public string FirstNameEntryText { get; set; }
		public string LastNameEntryText { get; set; }
		public string EmployeeCardNumberEntryText { get; set; }
		public string EmailEntryText { get; set; }
		public string PhoneNumberEntryText { get; set; }
		public string SignInRegButtonText => IsSignInPage ? "Sign In" : "Register";

		private int _employeeNumber { get; set; }
		private string _password { get; set; }

		public SignInRegisterPageViewModel(bool isSignInPage)
		{
			IsSignInPage = isSignInPage;
			EmployeeCardNumberEntryText = "";
			PasswordEntryText = "";
			FirstNameEntryText = "";
			LastNameEntryText = "";
			EmailEntryText = "";
			PhoneNumberEntryText = "";
		}

		public ICommand SignInRegisterCommand => new Command(async () =>
		{
			if (IsSignInPage)
			{
				if (await SignIn())
				{
					await Navigation.PushAsync(new Dashboard());
				}
			}
			else
			{
				if (await Register())
				{
					await Navigation.PushAsync(new Dashboard());
				};
			}
		});

		private async Task<bool> Register()
		{
			if (string.IsNullOrEmpty(EmployeeCardNumberEntryText) || string.IsNullOrEmpty(PasswordEntryText) || string.IsNullOrEmpty(FirstNameEntryText) || string.IsNullOrEmpty(LastNameEntryText) || string.IsNullOrEmpty(EmailEntryText) || string.IsNullOrEmpty(PhoneNumberEntryText))
			{
				Alerts.PopAlertMessage("Invalid Field", "Please fill in all the fields");
				return false;
			}

			bool isEmployee = int.TryParse(EmployeeCardNumberEntryText, out int employeeNumber);

			_employeeNumber = employeeNumber;
			_password = PasswordEntryText;

			User newUser = new User()
			{
				EmployeeCardNumber = _employeeNumber,
				FirstName = FirstNameEntryText,
				LastName = LastNameEntryText,
				Password = _password,
				Email = EmailEntryText,
				PhoneNumber = PhoneNumberEntryText
			};

			UserApiRequest request = new UserApiRequest();

			return await request.RegisterRequest(newUser);
		}

		private async Task<bool> SignIn()
		{
			if (string.IsNullOrEmpty(EmployeeCardNumberEntryText) || string.IsNullOrEmpty(PasswordEntryText))
			{
				Alerts.PopAlertMessage("Invalid Fields", "Please fill in all the fields");
				return false;
			}

			bool isEmployee = int.TryParse(EmployeeCardNumberEntryText, out int employeeNumber);
			_employeeNumber = employeeNumber;
			_password = PasswordEntryText;

			User newUser = new User()
			{
				EmployeeCardNumber = _employeeNumber,
				Password = _password,
			};

			UserApiRequest request = new UserApiRequest();

			return await request.SignInRequest(newUser);
		}
	}
}
