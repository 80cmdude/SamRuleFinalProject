﻿using FinalProjectApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardPage : BaseContentPage
	{
		public CardPage(CardPageViewModel vm) : base(vm)
		{
			InitializeComponent();
		}
	}
}