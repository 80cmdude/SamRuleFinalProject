using FinalProjectApp.Interfaces;
using FinalProjectApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectApp.Views
{
	public partial class SignInRegisterPage : BaseContentPage
	{
		public SignInRegisterPage(IViewModel vm) : base(vm)
		{
			InitializeComponent();
		}
	}
}