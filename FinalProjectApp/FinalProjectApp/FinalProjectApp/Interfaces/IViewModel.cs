using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectApp.Interfaces
{
	public interface IViewModel
	{
		INavigation Navigation { get; set; }
		void OnAppearing();
		void OnDisappearing();
	}
}
