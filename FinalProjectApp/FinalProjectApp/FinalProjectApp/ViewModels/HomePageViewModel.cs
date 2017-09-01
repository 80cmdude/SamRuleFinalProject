using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalProjectApp.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		public string HelloWorld { get; set; } = "Welcome To my Xamarin Forms template";

		public HomePageViewModel()
		{

		}
	}
}
