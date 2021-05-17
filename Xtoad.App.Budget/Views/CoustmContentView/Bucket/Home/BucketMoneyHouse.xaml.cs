using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.ViewModels.Bucket.Home;

namespace Xtoad.App.Budget.Views.CoustmContentView.Bucket.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BucketMoneyHouse : ContentView
    {
        public BucketMoneyHouse()
        {
            InitializeComponent();
            BucketMoneyHouseViewModel _BucketMoneyHouseViewModel = new BucketMoneyHouseViewModel();
            _BucketMoneyHouseViewModel.LoadItemsCommand.Execute(null);
            BindingContext = _BucketMoneyHouseViewModel;
        }
    }
}