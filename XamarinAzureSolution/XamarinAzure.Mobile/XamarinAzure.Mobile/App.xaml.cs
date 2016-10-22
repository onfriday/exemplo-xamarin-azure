using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinAzure.Mobile.Pages.Android;

namespace XamarinAzure.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            switch (Device.OS)
            {
                case TargetPlatform.Other:
                    break;
                case TargetPlatform.iOS:
                    break;
                case TargetPlatform.Android:
                    MainPage = new DroidRootPage();
                    break;
                case TargetPlatform.WinPhone:
                    break;
                case TargetPlatform.Windows:
                    break;
                default:
                    break;
            }
        }

        protected override void OnStart()
        {
            OnResume();
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
