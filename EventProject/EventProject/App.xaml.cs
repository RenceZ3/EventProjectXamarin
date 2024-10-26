using System;
using EventProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventProject
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            

        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

