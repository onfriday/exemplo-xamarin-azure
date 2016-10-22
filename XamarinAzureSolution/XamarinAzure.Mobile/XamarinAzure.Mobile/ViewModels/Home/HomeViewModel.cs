using Xamarin.Forms;

namespace XamarinAzure.Mobile.ViewModels.Home
{
    sealed class HomeViewModel : XamarinAzureViewModelBase
    {
        public HomeViewModel(INavigation pNavigation) : base(pNavigation)
        {
            this.Title = "Home";
        }
    }
}
