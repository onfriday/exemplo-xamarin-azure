using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAzure.Mobile.Controls
{
    sealed class XamarinAzureNavigationPage : NavigationPage
    {
        public XamarinAzureNavigationPage(Page root) : base(root)
        {
            Initialize();

            Title = root.Title;
            Icon = root.Icon;
        }

        public XamarinAzureNavigationPage()
        {
            Initialize();
        }

        void Initialize()
        {
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    BarBackgroundColor = Color.FromHex("FAFAFA");
                    break;
                //case TargetPlatform.Other:
                //case TargetPlatform.Android:
                //case TargetPlatform.WinPhone:
                //case TargetPlatform.Windows:
                default:
                    BarBackgroundColor = Color.FromHex("2B65D6"); //(Color)Application.Current.Resources["Primary"];
                    BarTextColor = Color.FromHex("FFFFFF"); //(Color)Application.Current.Resources["NavigationText"];
                    break;
            }
        }
    }
}

