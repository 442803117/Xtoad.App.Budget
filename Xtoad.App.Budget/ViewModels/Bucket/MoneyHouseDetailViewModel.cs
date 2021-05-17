using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Bucket;
using Xtoad.App.Budget.Services;

namespace Xtoad.App.Budget.ViewModels.Bucket
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class MoneyHouseDetailViewModel : BaseViewModel
    {
        public IDataStore<BucketMoneyHouse> DataStore => DependencyService.Get<IDataStore<BucketMoneyHouse>>();

        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Title;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
