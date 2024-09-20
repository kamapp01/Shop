using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;

namespace Shop.InterfaceAdapter
{
    public interface IItemsRepos
    {
        List<Item> GetItems();
    }
}
