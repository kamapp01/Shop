namespace Shop.Domain;

public abstract class OrderDecorator : Order
{
    protected string ID {get; set;}
    protected string description {get; set;}
    protected double price {get; set;}
    
    protected Order _order;

    protected OrderDecorator(Order order, string ID, string description, double price)
    {
        this.ID = ID;
        this.description = description;
        this.price = price;
        
        this._order = order;
    }
    
}