using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EventProject.Views
{	
	public partial class RegisterPage : ContentPage
	{	
		public RegisterPage ()
		{
			InitializeComponent ();
		}

		private async void Register_New(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());
		}
	}
}

