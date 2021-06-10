using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xtoad.App.Budget.Enum.Buckets;
using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Buckets;
using Xtoad.App.Budget.Services;
using Xtoad.App.Budget.Util;

namespace Xtoad.App.Budget.ViewModels.Buckets
{
    //[QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class BucketBankAddViewModel : BaseViewModel
    {
        public IService<BucketBankHouse> DataStore => DependencyService.Get<IService<BucketBankHouse>>();

        private BucketBankHouse item;

        private Dictionary<string, string> bucketType;

        public BucketBankAddViewModel() {
            bucketType = EnumUtils.GetEnumDescription<BucketTypeEnum>();
        }

        public Dictionary<string, string> BucketType {
            get => bucketType;
        }

        public BucketBankHouse Item
        {
            get => item;
            set => SetProperty<BucketBankHouse>(ref item, value);
        }

        //public async void LoadItemId(string itemId)
        //{
        //    try
        //    {
        //        var item = await DataStore.GetItemAsync(itemId);
        //        Id = item.Id;
        //        Text = item.Title;
        //        Description = item.Description;
        //    }
        //    catch (Exception)
        //    {
        //        Debug.WriteLine("Failed to Load Item");
        //    }
        //}
    }
}
