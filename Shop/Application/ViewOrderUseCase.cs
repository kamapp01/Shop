using Shop.Domain;

namespace Shop.Application;

public class ViewOrderUseCase
{
    
    public void ViewOrder(Order finalOrder)
    {
        // printing final order
        Console.WriteLine("Your order:\n");
        Console.WriteLine($"{finalOrder.Description()}");
        Console.WriteLine($"Total price: {finalOrder.Cost().ToString().PadLeft(6)} kr");
        
    }
}