using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.InterfaceAdapter;
using Shop.Infrastructure.Service;

namespace Shop.Infrastructure
{
    internal class FileItemRepos : IItemsRepos
    {
        // path to the "ItemFiles" folder where the item text files are stored
        private readonly string _directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\TxtFileFolder\ItemFiles");


        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            FileReadingService readItemFiles = new FileReadingService();
            
            string[,] fileData = readItemFiles.ReadFiles(_directoryPath);

            for (int i = 0; i < fileData.GetLength(0); i++)
            {
                string ID = fileData[i, 0];
                string description = fileData[i, 1];
                double price = double.Parse(fileData[i, 2]);
                    
                Item item = new Item(ID, description, price);
                items.Add(item);
                
            }

            return items;
        }
    }
    
}
