using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAzure.Mobile.Controls;
using XamarinAzure.Mobile.Pages.Acesso;
using XamarinAzure.Mobile.Pages.Home;

namespace XamarinAzure.Mobile.Pages.Android
{
    public sealed class DroidRootPage : MasterDetailPage
    {
        Dictionary<NavigationItens, XamarinAzureNavigationPage> pages;

        bool isRunning = false;

        public DroidRootPage()
        {
            pages = new Dictionary<NavigationItens, XamarinAzureNavigationPage>();

            Master = new MenuPage(this);

            pages.Add(NavigationItens.Home, new XamarinAzureNavigationPage(new HomePage()));

            Detail = pages[NavigationItens.Home];
        }

        public async Task NavigateAsync(NavigationItens pSelectedItem)
        {
            XamarinAzureNavigationPage _new = null;

            if (!pages.ContainsKey(pSelectedItem))
            {

                switch (pSelectedItem)
                {
                    case NavigationItens.Home:
                        pages.Add(pSelectedItem, new XamarinAzureNavigationPage(new HomePage()));
                        break;
                    case NavigationItens.Login:
                        pages.Add(pSelectedItem, new XamarinAzureNavigationPage(new LoginPage()));
                        break;
                }
            }

            if (_new == null)
                _new = pages[pSelectedItem];

            if (_new == null)
                return;

            //if we are on the same tab and pressed it again.
            if (this.Detail == _new)
                await _new.Navigation.PopToRootAsync();

            this.Detail = _new;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //if (Settings.Current.FirstRun)
            //{
            //    MessagingService.Current.SendMessage(MessageKeys.NavigateLogin);
            //}

            isRunning = true;
        }
    }
}


