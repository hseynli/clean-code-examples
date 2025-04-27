namespace CleanCode.Common;

public class Order
{
    public string Id { get; set; }
    public string CustomerId { get; set; }
    public OrderStatus Status { get; set; }
}