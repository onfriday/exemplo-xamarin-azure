using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAzure.Mobile.Services
{
    public static class NavigationService
    {
        static bool _Navigating;

        public static async Task PushAsync(INavigation pNavigation, Page pPage, bool pAnimate = true)
        {
            if (_Navigating)
                return;

            _Navigating = true;
            await pNavigation.PushAsync(pPage, pAnimate);
            _Navigating = false;
        }

        public static async Task PushModalAsync(INavigation pNavigation, Page pPage, bool pAnimate = true)
        {
            if (_Navigating)
                return;

            _Navigating = true;
            await pNavigation.PushModalAsync(pPage, pAnimate);
            _Navigating = false;
        }
    }
}
