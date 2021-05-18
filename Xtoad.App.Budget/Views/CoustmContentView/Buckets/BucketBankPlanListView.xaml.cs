using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xtoad.App.Budget.Views.CoustmContentView.Buckets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BucketBanPlankListView : ContentView
    {
        public BucketBanPlankListView()
        {
            InitializeComponent();
            BindingContext = new BucketBanPlankListView();
        }
    }
}