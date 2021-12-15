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
    public class BucketBankAddViewModel : BaseViewModel
    {
        public IService<BucketBankHouse> DataStore => DependencyService.Get<IService<BucketBankHouse>>();

        public Dictionary<string, string> BucketType;

        private BucketBankHouse item;

        public BucketBankAddViewModel() {
            BucketType = EnumUtils.GetEnumDescription<BucketTypeEnum>();
        }

        public BucketBankHouse Item
        {
            get => item;
            set => SetProperty(ref item, value);
        }
    }
}
