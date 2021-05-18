using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Buckets;

namespace Xtoad.App.Budget.Services.Mock
{
    public class MockBucketMoneyHouseDataStore : IDataStore<BucketBankHouse>
    {
        readonly List<BucketBankHouse> items;

        public MockBucketMoneyHouseDataStore()
        {
            items = new List<BucketBankHouse>()
            {
                new BucketBankHouse { Id = Guid.NewGuid().ToString(), Title = "我要买首套房", 
                    Description="This is an item description." ,Amount = 250000, Own=1000 },
                new BucketBankHouse { Id = Guid.NewGuid().ToString(), Title = "Second item", 
                    Description="This is an item description." ,Amount = 350000, Own=1000},
                new BucketBankHouse { Id = Guid.NewGuid().ToString(), Title = "Sixth item", 
                    Description="This is an item description." ,Amount = 50000 , Own=1000}
            };
        }

        public async Task<bool> AddItemAsync(BucketBankHouse item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(BucketBankHouse item)
        {
            var oldItem = items.Where((BucketBankHouse arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((BucketBankHouse arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<BucketBankHouse> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<BucketBankHouse>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}