using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Bucket;
using Xtoad.App.Budget.Services;
using Xtoad.App.Budget.Views;

namespace Xtoad.App.Budget.ViewModels.Bucket.Home
{
    public class BucketMoneyHouseViewModel : BaseViewModel
    {

        public IDataStore<BucketMoneyHouse> DataStore => DependencyService.Get<IDataStore<BucketMoneyHouse>>();

        private BucketMoneyHouse _selectedItem;

        public ObservableCollection<BucketMoneyHouse> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<BucketMoneyHouse> ItemTapped { get; }

        public BucketMoneyHouseViewModel()
        {
            Title = "买房心愿";
            IsBusy = true;
            Items = new ObservableCollection<BucketMoneyHouse>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<BucketMoneyHouse>(OnItemSelected);

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

        public BucketMoneyHouse SelectedItem
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

        async void OnItemSelected(BucketMoneyHouse item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}