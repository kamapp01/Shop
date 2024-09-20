using Shop.Domain;
using Shop.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.OrderOptions;
using Shop.Infrastructure;



namespace Shop.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________ #1 Show All Items _________________________________\n");
            
            // loading and printing all items
            LoadItemsUseCase loadItemsUseCase = new LoadItemsUseCase(new FileItemRepos());
            loadItemsUseCase.LoadAllItems();
            
            
            
            Console.WriteLine("\n\n\n__________________________________ #2 Pick Item ____________________________________\n");
            
            // creating a new base order with a random selected item
            // simulates a selected order
            Order order = loadItemsUseCase.selectedItem;

            Console.WriteLine("Selected item:");
            Console.WriteLine($"- {order.Description()}   price: {order.Cost()} kr");
            
            
            
            Console.WriteLine("\n\n\n____________________________ #3 Add/Ignore GiftWrapping ____________________________\n");

            // simulates that customer is adding gift wrapping to the order 
            Add_IgnoreGiftWrappingUseCase giftWrappingUseCase = new Add_IgnoreGiftWrappingUseCase(new FileGiftWrappingRepos());
            order = giftWrappingUseCase.GetGiftWrapping(order);
            
            Console.WriteLine($"Gift wrapping is added to your order");
            Console.WriteLine($"- {order.Description()}   price: {order.Cost()} kr ");
            
            
            
            Console.WriteLine("\n\n\n______________________________ #4 Add/Ignore Shipment ______________________________\n");
            
            // simulates that customer is adding shipment to the order
            Add_IgnoreShipmentUseCase shipmentUseCase = new Add_IgnoreShipmentUseCase(new FileShipmentRepos());
            order = shipmentUseCase.GetShipment(order);

            Console.WriteLine($"Shipment is added to your order");
            Console.WriteLine($"- {order.Description()}   price: {order.Cost()} kr ");
            
            
            
            Console.WriteLine("\n\n\n__________________________ #5 View Order with total price __________________________\n");

            // printing final order
            ViewOrderUseCase viewOrderUseCase = new ViewOrderUseCase();
            viewOrderUseCase.ViewOrder(order);
            
            
            Console.Read();
        }
    }
}
