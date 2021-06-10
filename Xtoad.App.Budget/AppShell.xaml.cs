using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xtoad.App.Budget.ViewModels;
using Xtoad.App.Budget.Views;
using Xtoad.App.Budget.Views.Buckets;

namespace Xtoad.App.Budget
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(BucketBankDetailPage), typeof(BucketBankDetailPage));
            Routing.RegisterRoute(nameof(BucketBankAddPage), typeof(BucketBankAddPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
