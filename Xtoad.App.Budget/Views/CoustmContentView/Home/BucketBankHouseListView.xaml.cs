using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.ViewModels.Home;

namespace Xtoad.App.Budget.Views.CoustmContentView.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BucketBankHouseListView : ContentView
    {
        public BucketBankHouseListView()
        {
            InitializeComponent();
            BucketBankHouseListViewModel _BucketMoneyHouseListViewModel = new BucketBankHouseListViewModel();
            _BucketMoneyHouseListViewModel.LoadItemsCommand.Execute(null);
            BindingContext = _BucketMoneyHouseListViewModel;
        }
    }
}