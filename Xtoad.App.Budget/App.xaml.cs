using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.Services.Mock;
using Xtoad.App.Budget.Views;

namespace Xtoad.App.Budget
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockBucketMoneyHouseService>();
            DependencyService.Register<MockBucketBankPlanService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
