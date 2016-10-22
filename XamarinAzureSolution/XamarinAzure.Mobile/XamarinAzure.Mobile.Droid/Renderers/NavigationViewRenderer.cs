using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinAzure.Mobile.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Support.Design.Widget;

[assembly: ExportRenderer(typeof(XamarinAzure.Mobile.Controls.NavigationView), typeof(NavigationViewRenderer))]

namespace XamarinAzure.Mobile.Droid.Renderers
{
    public class NavigationViewRenderer : ViewRenderer<Controls.NavigationView, NavigationView>
    {
        NavigationView navView;
        //ImageView profileImage;
        //TextView profileName;

        protected override void OnElementChanged(ElementChangedEventArgs<Controls.NavigationView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
                return;

            var view = Inflate(Forms.Context, Resource.Layout.nav_view, null);
            navView = view.JavaCast<NavigationView>();
            //navView.NavigationItemSelected += NavView_NavigationItemSelected;

            //Settings.Current.PropertyChanged += SettingsPropertyChanged;

            SetNativeControl(navView);

            var header = navView.GetHeaderView(0);
            //profileImage = header.FindViewById<ImageView>(Resource.Id.profile_image);
            //profileName = header.FindViewById<TextView>(Resource.Id.profile_name);

            //profileImage.Click += (sender, e2) => NavigateToLogin();
            //profileName.Click += (sender, e2) => NavigateToLogin();

            UpdateName();
            UpdateImage();

            navView.SetCheckedItem(Resource.Id.nav_home);
        }

        void NavigateToLogin()
        {
            //if (Settings.Current.IsLoggedIn)
            //    return;

            //MessagingService.Current.SendMessage(MessageKeys.NavigateLogin);
        }

        void SettingsPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(Settings.Current.Email))
            //{
            //    UpdateName();
            //    UpdateImage();
            //}
        }

        void UpdateName()
        {
            //profileName.Text = Settings.Current.UserDisplayName;
        }

        void UpdateImage()
        {
            //Koush.UrlImageViewHelper.SetUrlDrawable(profileImage, Settings.Current.UserAvatar, Resource.Drawable.profile_generic);
        }

        public override void OnViewRemoved(Android.Views.View child)
        {
            base.OnViewRemoved(child);
            //navView.NavigationItemSelected -= NavView_NavigationItemSelected;

            //Settings.Current.PropertyChanged -= SettingsPropertyChanged;
        }

        IMenuItem previousItem;

        void NavView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            if (previousItem != null)
                previousItem.SetChecked(false);

            navView.SetCheckedItem(e.MenuItem.ItemId);

            previousItem = e.MenuItem;

            Controls.NavigationItens _selectedItem = Controls.NavigationItens.Home;

            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.nav_home:
                    _selectedItem = Controls.NavigationItens.Home;
                    break;
                case Resource.Id.nav_login:
                    _selectedItem = Controls.NavigationItens.Login;
                    break;
            }

            this.Element.OnNavigationItemSelected(new Controls.NavigationItemSelectedEventArgs
            {
                SelectedItem = _selectedItem
            });
        }
    }
}