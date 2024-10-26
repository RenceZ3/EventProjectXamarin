using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string uname = username.Text;
            string pass = password.Text;

            try
            {

                if (uname.Equals("John") && pass.Equals("admin"))
                {
                    _ = DisplayAlert("Logged", "Hello " + uname, "Ok");
                    await Navigation.PushAsync(new Views.HomePage(uname));

                }
                else
                {
                    _ = DisplayAlert("Logged", "Invalid Credentials", "Ok");
                }

            }
            catch (NullReferenceException)
            {
                _ = DisplayAlert("Logged", "Username or Password Cannot be Empty", "Ok");
            }
        }

        private async void Register_User(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.RegisterPage());
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}

