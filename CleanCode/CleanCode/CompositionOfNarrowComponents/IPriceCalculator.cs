namespace CleanCode.CleanCode.CompositionOfNarrowComponents;

public interface IPriceCalculator
{
    decimal Calculate(ShoppingCart cart);
}