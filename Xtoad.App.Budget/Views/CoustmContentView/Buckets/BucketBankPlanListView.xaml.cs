using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.ViewModels.Home;

namespace Xtoad.App.Budget.Views.CoustmContentView.Buckets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BucketBanPlankListView : ContentView
    {
        public BucketBanPlankListView()
        {
            InitializeComponent();
            BindingContext = new BucketBankPlanViewModel();
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}