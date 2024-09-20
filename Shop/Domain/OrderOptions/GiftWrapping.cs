namespace Shop.Domain.OrderOptions;

public class GiftWrapping : OrderDecorator
{
    
    public GiftWrapping(Order order, string ID, string description, double price) : base(order, ID, description, price)
    {
    }

    
    public override double Cost()
    {
        return _order.Cost() + this.price;  
    }

    
    public override string Description()
    {
        return $"{_order.Description()} incl. {this.description}"; 
    }

    
}