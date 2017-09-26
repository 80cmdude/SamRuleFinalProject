using FinalProjectApp.Models;
using FinalProjectApp.Service;
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
		public string EmployeeNumberEntryText { get; set; }
		public string PasswordEntryText { get; set; }
		public string ConfirmPasswordEntryText { get; set; }
		public string FirstNameEntryText { get; set; }
		public string LastNameEntryText { get; set; }

		private int _employeeNumber { get; set; }
		private string _password { get; set; }

		public SignInRegisterPageViewModel()
		{
			EmployeeNumberEntryText = "";
			PasswordEntryText = "";
			FirstNameEntryText = "";
			LastNameEntryText = "";
		}

		public ICommand RegisterCommand => new Command(async() =>
		{
			bool isEmployee = int.TryParse(EmployeeNumberEntryText, out int employeeNumber);

			_employeeNumber = employeeNumber;
			_password = PasswordEntryText;

			User newUser = new User()
			{
				EmployeeNumber = _employeeNumber,
				FirstName = FirstNameEntryText,
				LastName = LastNameEntryText,
				Password = _password,
			};

			UserApiRequest request = new UserApiRequest();

			if (await request.RegisterRequest(newUser))
			{
				//navigate to page
			};
		});
	}
}
