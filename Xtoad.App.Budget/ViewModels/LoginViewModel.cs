using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Views;

namespace Xtoad.App.Budget.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Login LoginForm { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            LoginForm = new Login("Test", "123456");
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            if (!"Test".Equals(LoginForm.LoginNo))
            {
                await App.Current.MainPage.DisplayAlert("xxx", "dddd", "OK");
                return;
            }
            await Shell.Current.GoToAsync($"//AboutPage");
        }
    }
}
