using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HICHEM
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
        new Item { Id = Guid.NewGuid().ToString(), Text = "VỀ CHÚNG TÔI", Icon = "about.png", GoToDetail = "listArrow.png", DetailUrl="vechungtoi.html"},
        new Item { Id = Guid.NewGuid().ToString(), Text = "THÀNH TỰU", Icon = "Achievement-512.png", GoToDetail = "listArrow.png", DetailUrl="thanhtuu.html" },
        new Item { Id = Guid.NewGuid().ToString(), Text = "LIÊN HỆ", Icon = "grey_new_seo2-41-512.png", GoToDetail = "listArrow.png", DetailUrl="lienhe.html" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
