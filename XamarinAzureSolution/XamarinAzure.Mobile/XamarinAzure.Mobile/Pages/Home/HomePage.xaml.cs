using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAzure.Mobile.ViewModels.Home;

namespace XamarinAzure.Mobile.Pages.Home
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            this.BindingContext = new HomeViewModel(this.Navigation);
        }
    }
}
