using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAzure.Mobile.ViewModels
{
    abstract class XamarinAzureViewModelBase : BaseViewModel
    {
        protected INavigation Navigation { get; private set; }

        public XamarinAzureViewModelBase(INavigation pNavigation = null) : base()
        {
            this.Navigation = pNavigation;
        }
    }
}
