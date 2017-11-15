using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FinalProjectApp.ViewModels;

namespace FinalProjectApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeveloperPage : BaseContentPage
	{
		public DeveloperPage(DeveloperPageViewModel vm) : base(vm)
		{
			InitializeComponent();
		}
	}
}