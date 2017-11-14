using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalProjectApp.ViewModels
{
	public class CreditPageViewModel : BaseViewModel
	{
		public int CreditPickerIndex { get; set; }
		public bool CustomEntryVisible { get; set; } = false;

		public CreditPageViewModel()
		{

		}

		public void CreditPickerUpdated(int index)
		{
			CreditPickerIndex = index;
			switch (index)
			{
				case 3:
					CustomEntryVisible = true;
					break;
				default:
					CustomEntryVisible = false;
					break;
			}
			
		}
	}
}
