namespace CleanCode.CleanCode.CompositionOfNarrowComponents;

public class ShoppingCart
{
    public int CustomerId { get; set; }
    public List<CartItem> Items { get; set; } = new List<CartItem>();
}