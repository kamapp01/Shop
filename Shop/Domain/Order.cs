namespace Shop.Domain;

public abstract class Order
{
    public abstract double Cost();
    public abstract string Description();
}