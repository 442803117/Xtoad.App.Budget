using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.ViewModels.Home.Bucket;

namespace Xtoad.App.Budget.Views.CoustmContentView.Home.Bucket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BucketMoneyHouse : ContentView
    {
        public BucketMoneyHouse()
        {
            InitializeComponent();
            HouseItemsViewModel _BucketMoneyHouseListViewModel = new HouseItemsViewModel();
            _BucketMoneyHouseListViewModel.LoadItemsCommand.Execute(null);
            BindingContext = _BucketMoneyHouseListViewModel;
        }
    }
}