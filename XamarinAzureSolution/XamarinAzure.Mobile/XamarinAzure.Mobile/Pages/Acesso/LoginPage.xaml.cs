using Xamarin.Forms;
using XamarinAzure.Mobile.ViewModels.Acesso;

namespace XamarinAzure.Mobile.Pages.Acesso
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            this.BindingContext = new LoginViewModel(this.Navigation);
        }
    }
}
