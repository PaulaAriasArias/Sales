using SalesApp.Views;
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
