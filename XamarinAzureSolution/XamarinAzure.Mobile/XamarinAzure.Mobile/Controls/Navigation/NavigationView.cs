using Xamarin.Forms;

namespace XamarinAzure.Mobile.Controls
{
    public class NavigationView : ContentView
    {
        public void OnNavigationItemSelected(NavigationItemSelectedEventArgs e) { NavigationItemSelected?.Invoke(this, e); }

        public event NavigationItemSelectedEventHandler NavigationItemSelected;
    }
}