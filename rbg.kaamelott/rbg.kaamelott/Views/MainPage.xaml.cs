﻿using rbg.kaamelott.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rbg.kaamelott.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
		}
    }
}
