using System.ComponentModel;
using Xamarin.Forms;
using Xtoad.App.Budget.ViewModels;

namespace Xtoad.App.Budget.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}