using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.Services;
using Xtoad.App.Budget.Views;

namespace Xtoad.App.Budget
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
