using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinStarter
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new XamarinStarter.MainPage();

            //Use this if hamburger menu is not required.
            //MainPage = new NavigationPage(new XamarinStarter.MainPage());

            //For hamburger menu.
            //var menuPage = new MenuPage();
            //NavigationPage = new NavigationPage(new MainPage());
            //var rootPage = new RootPage();
            //rootPage.Master = menuPage;
            //rootPage.Detail = NavigationPage;
            //MainPage = rootPage;

            MainPage = new NavigationPage(new XamarinStarter.RootPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
