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
    public class BucketBankHouseListViewModel : BaseViewModel
    {

        public IService<BucketBankHouse> DataStore => DependencyService.Get<IService<BucketBankHouse>>();

        private BucketBankHouse _selectedItem;

        public ObservableCollection<BucketBankHouse> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<BucketBankHouse> ItemTapped { get; }

        public BucketBankHouseListViewModel()
        {
            Title = "买房心愿";
            IsBusy = true;
            Items = new ObservableCollection<BucketBankHouse>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<BucketBankHouse>(OnItemSelected);

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
                    Debug.WriteLine(item.Percent);
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

        public BucketBankHouse SelectedItem
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

        async void OnItemSelected(BucketBankHouse item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(BucketBankDetailPage)}?{nameof(BucketBankDetailViewModel.ItemId)}={item.Id}");
        }
    }
}