using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FinalProjectApp.Resources.Resx;
using FinalProjectApp.Models;

namespace FinalProjectApp.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		private int orderId = 1;
		private int userId = 1;
		public HomePageViewModel()
		{

		}

		public ICommand SaveData => new Command(() =>
		{
			Order order = new Order();
			order.Item = "cake";
			order.OrderId = orderId;
			order.UserId = userId;
			App.OrderDatabase.SaveItem(order);
			orderId++;
			userId++;
		});

		public ICommand GetData => new Command(() =>
		{
			var check = App.OrderDatabase.GetItems<Order>();
		});
	}
}
