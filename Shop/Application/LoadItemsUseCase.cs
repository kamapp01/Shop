using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.InterfaceAdapter;

namespace Shop.Application
{
    class LoadItemsUseCase
    {
        private IItemsRepos _itemsRepos;
        public Item selectedItem { get; set; }
        
        
        public LoadItemsUseCase(IItemsRepos itemsRepos)
        {
            this._itemsRepos = itemsRepos;
        }

        
        public void LoadAllItems()
        {
            List<Item> items = _itemsRepos.GetItems();

            // selects a random item for later use
            selectRandomItem(items);
            
            Console.WriteLine("All items:");
            
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
            
        }

        private void selectRandomItem(List<Item> items)
        {
            Random random = new Random();
            
            Item rItem = items[random.Next(0,items.Count)];
            selectedItem = rItem;
        }
    }
}
