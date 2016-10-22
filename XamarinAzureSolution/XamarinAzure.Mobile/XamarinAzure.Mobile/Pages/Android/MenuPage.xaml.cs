using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinAzure.Mobile.Pages.Android
{
    public partial class MenuPage : ContentPage
    {
        private readonly DroidRootPage _Root;

        public MenuPage(DroidRootPage pRoot)
        {
            this._Root = pRoot;

            this.InitializeComponent();

            this.BindingContext = new MenuViewModel(this.Navigation);

            this.NavView.NavigationItemSelected += async (sender, e) =>
            {
                this._Root.IsPresented = false;

                await Task.Delay(225);
                await this._Root.NavigateAsync(e.SelectedItem);
            };
        }

        private class MenuViewModel : ViewModels.XamarinAzureViewModelBase
        {
            public MenuViewModel(INavigation pNavigation) : base(pNavigation)
            {
                this.Title = "Menu";
            }
        }
    }
}
