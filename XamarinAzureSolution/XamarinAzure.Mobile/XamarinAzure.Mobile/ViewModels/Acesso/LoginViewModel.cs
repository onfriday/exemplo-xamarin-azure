using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAzure.Mobile.ViewModels.Acesso
{
    sealed class LoginViewModel : XamarinAzureViewModelBase
    {
        public LoginViewModel(INavigation pNavigation) : base(pNavigation)
        {

        }

        //<Entry Text="{Binding Usuario}" Placeholder="Usuário (Email)" />
        //<Entry Text="{Binding Senha}" Placeholder="Senha" IsPassword="True" />
        //<Button Text="Logar" Command="{Binding LogarCommand}" />
    }
}
