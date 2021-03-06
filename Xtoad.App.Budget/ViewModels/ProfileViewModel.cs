using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xtoad.App.Budget.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel()
        {
            Title = "我的";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            RegisterCommand = new Command(async () => await Shell.Current.GoToAsync("//LoginPage"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand RegisterCommand { get; }
    }
}