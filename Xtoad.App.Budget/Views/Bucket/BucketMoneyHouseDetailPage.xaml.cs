using System.ComponentModel;
using Xamarin.Forms;
using Xtoad.App.Budget.ViewModels;
using Xtoad.App.Budget.ViewModels.Bucket;

namespace Xtoad.App.Budget.Views.Bucket
{
    public partial class BucketMoneyHouseDetailPage : ContentPage
    {
        public BucketMoneyHouseDetailPage()
        {
            InitializeComponent();
            BindingContext = new MoneyHouseDetailViewModel();
        }
    }
}