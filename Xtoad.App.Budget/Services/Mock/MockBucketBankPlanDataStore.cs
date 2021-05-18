using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xtoad.App.Budget.Models;
using Xtoad.App.Budget.Models.Buckets;

namespace Xtoad.App.Budget.Services.Mock
{
    public class MockBucketBankPlanDataStore : IDataStore<BucketBankPlan>
    {
        readonly List<BucketBankPlan> items;

        public MockBucketBankPlanDataStore()
        {
            items = new List<BucketBankPlan>()
            {
                new BucketBankPlan { Id = Guid.NewGuid().ToString(), MainId = "1", Amount = 2000, BankTime= new DateTime(2021, 4,2) },
                new BucketBankPlan { Id = Guid.NewGuid().ToString(), MainId = "1", Amount = 2100, BankTime= new DateTime(2021, 4,28) },
                new BucketBankPlan { Id = Guid.NewGuid().ToString(), MainId = "1", Amount = 2200, BankTime= new DateTime(2021, 5,2) },
            };
        }

        public async Task<bool> AddItemAsync(BucketBankPlan item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(BucketBankPlan item)
        {
            var oldItem = items.Where((BucketBankPlan arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((BucketBankPlan arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<BucketBankPlan> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<BucketBankPlan>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}