using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Buckets;
using Xtoad.App.Budget.Services;
using Xtoad.App.Budget.ViewModels.Buckets;
using Xtoad.App.Budget.Views;
using Xtoad.App.Budget.Views.Buckets;

namespace Xtoad.App.Budget.ViewModels.Home
{
    public class BucketBankPlanViewModel : BaseViewModel
    {

        public IDataStore<BucketBankPlan> DataStore => DependencyService.Get<IDataStore<BucketBankPlan>>();

        private BucketBankPlan _selectedItem;

        public ObservableCollection<BucketBankPlan> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<BucketBankPlan> ItemTapped { get; }

        public BucketBankPlanViewModel()
        {
            Title = "买房心愿";
            IsBusy = true;
            Items = new ObservableCollection<BucketBankPlan>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<BucketBankPlan>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public BucketBankPlan SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(BucketBankPlan item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(BucketBankDetailPage)}?{nameof(BucketBankDetailViewModel.ItemId)}={item.Id}");
        }
    }
}