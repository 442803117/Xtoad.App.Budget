using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xtoad.App.Budget.ViewModels;
using Xtoad.App.Budget.ViewModels.Buckets;

namespace Xtoad.App.Budget.Views.Buckets
{
    public partial class BucketBankAddPage : ContentPage
    {
        public BucketBankAddPage()
        {
            InitializeComponent();
            BindingContext = new BucketBankAddViewModel();
        }
    }
}