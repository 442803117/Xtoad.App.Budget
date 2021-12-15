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
<<<<<<< HEAD
=======
    //[QueryProperty(nameof(ItemId), nameof(ItemId))]
>>>>>>> 6c71a5b98ee3034bbc2923f61775266a6e2eeb8a
    public class BucketBankAddViewModel : BaseViewModel
    {
        public IService<BucketBankHouse> DataStore => DependencyService.Get<IService<BucketBankHouse>>();

<<<<<<< HEAD
        public Dictionary<string, string> BucketType;

        private BucketBankHouse item;

        public BucketBankAddViewModel() {
            BucketType = EnumUtils.GetEnumDescription<BucketTypeEnum>();
        }

        public BucketBankHouse Item
        {
            get => item;
            set => SetProperty(ref item, value);
=======
        private BucketBankHouse item;

        private Dictionary<string, string> bucketType;


        public Command BucketTypeCommand { get; } 
       


        public BucketBankAddViewModel() {
            bucketType = EnumUtils.GetEnumDescription<BucketTypeEnum>();
            BucketTypeCommand = new Command(async () => await BucketTypeClickCommand());
        }

        public Dictionary<string, string> BucketType {
            get => bucketType;
        }

        public BucketBankHouse Item
        {
            get => item;
            set => SetProperty<BucketBankHouse>(ref item, value);
        }

        async Task BucketTypeClickCommand()
        {
            IsBusy = true;

            try
            {
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
>>>>>>> 6c71a5b98ee3034bbc2923f61775266a6e2eeb8a
        }
    }
}
