using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EventProject.Views
{	
	public partial class HomePage : ContentPage
	{	
		public HomePage (string username)
		{
            InitializeComponent();
			DisplayName(username);

        }

		private void DisplayName(string username)
		{
			userNameLbl.Text = $"Welcome {username}";

        }
	}
}

