using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xtoad.App.Budget.ViewModels;

namespace Xtoad.App.Budget.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

    }
}