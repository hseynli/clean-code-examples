namespace CleanCode.BadCode.InjectableVsNewableObjects;

public class Order
{
    public int Id { get; set; }
    public decimal TotalWeight { get; set; }
    public Address ShippingAddress { get; set; }
}