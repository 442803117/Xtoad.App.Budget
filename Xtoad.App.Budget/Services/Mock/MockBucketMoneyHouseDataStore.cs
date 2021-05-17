using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Bucket;

namespace Xtoad.App.Budget.Services.Mock
{
    public class MockBucketMoneyHouseDataStore : IDataStore<BucketMoneyHouse>
    {
        readonly List<BucketMoneyHouse> items;

        public MockBucketMoneyHouseDataStore()
        {
            items = new List<BucketMoneyHouse>()
            {
                new BucketMoneyHouse { Id = Guid.NewGuid().ToString(), Title = "我要买首套房", 
                    Description="This is an item description." ,Amount = 250000, Own=1000 },
                new BucketMoneyHouse { Id = Guid.NewGuid().ToString(), Title = "Second item", 
                    Description="This is an item description." ,Amount = 350000, Own=1000},
                new BucketMoneyHouse { Id = Guid.NewGuid().ToString(), Title = "Sixth item", 
                    Description="This is an item description." ,Amount = 50000 , Own=1000}
            };
        }

        public async Task<bool> AddItemAsync(BucketMoneyHouse item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(BucketMoneyHouse item)
        {
            var oldItem = items.Where((BucketMoneyHouse arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((BucketMoneyHouse arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<BucketMoneyHouse> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<BucketMoneyHouse>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}